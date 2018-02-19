using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SplitFile
{
    public partial class Spliter : Form
    {
        #region Variables

        string[] FileLocationArr;
        long[] FileSizeArr;
        long[] StartByteArr;
        long[] EndByteArr;

        byte[] SourceByte;

        public static string ProjectLocation = "";

        FileStream Reader;
        FileStream Writer;

        bool Canceled = false;
        bool StartedSpliting = false;

        //Source File Name
        String Sfilename;

        // Total size of file in bytes
        long TotalSize;

        // Total Size Used while adding.
        long RemainingSize;

        // Size of the buffer selected by user
        long BufferSize;

        // Total no of files to be splited
        int TotalFile;

        // Index Number of current file in progress
        int CurrentFileIndex;

        long LastEstimation = 0;

        // Buffer for transferring data
        byte[] Data;

        //Directory Location of the spliting
        String ProjectDirectory;
        #endregion

        #region Menu Methods

        public Spliter()
        {
            InitializeComponent();
            GC.KeepAlive(Progressor);
            //Progressor.Start();
        }

        void ProgressChanged(object sender, EventArgs e)
        {
            try
            {
                txtFileProcessing.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

                progressCurrentFile.Value = Convert.ToInt32((Writer.Length * 100) / FileSizeArr[CurrentFileIndex]);
                txtCurrentFileByte.Text = Writer.Length + " Bytes";
                txtCurrentFilePrec.Text = progressCurrentFile.Value.ToString() + "% Completed";

                progressOverallStatus.Value = Convert.ToInt32((Reader.Position * 100) / TotalSize);
                txtOverallFileByte.Text = Reader.Position.ToString() + " Bytes";
                txtOverallPerc.Text = progressOverallStatus.Value.ToString() + "% Completed";
            }
            catch { }
        }

        void NewProject(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.AddExtension = true;
            SFD.CheckPathExists = true;
            SFD.DefaultExt = ".sp";
            SFD.Filter = "SplitFile Project (*.sp)|*.sp";
            if (SFD.ShowDialog() == DialogResult.Cancel) return;

            ProjectLocation = SFD.FileName;
            if (!ProjectLocation.ToLower().EndsWith(".sp")) ProjectLocation += ".sp";
            ClearAll();
        }

        void OpenProject(object sender, EventArgs e)
        {
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); return; }
            ClearAll();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.DefaultExt = ".sp";
            OFD.Filter = "SplitFile Project (*.sp)|*.sp";
            OFD.CheckFileExists = true;
            if (OFD.ShowDialog() == DialogResult.Cancel) return;
            ProjectLocation = OFD.FileName;
            if (!OpenProject())
            {
                ClearAll();
                MessageBox.Show("The project cannot be loaded.");
            }
        }

        void RestartSpliting(object sender, EventArgs e)
        {
            if (Splitter.IsBusy) { MessageBox.Show("This action cannot be performed at this time. First stop the running process and then retry.", "Invalid Operation"); return; }
            if (ProjectLocation == "") { MessageBox.Show("Open the project and then try again.", "Invalid Operation"); return; }
            DialogResult DR = MessageBox.Show("Are you sure to restart the current project?", "Confirm Restart", MessageBoxButtons.YesNo);
            if (DR == DialogResult.No) return;
            CurrentFileIndex = 0;
            SaveProject();
            if (MessageBox.Show("Do you want to remove the previous parts?\n\nYes - If you want to delete all the parts created in previous attempt.\nNo  - Continue with old files.\n\nClick No only if you are sure that previous parts are not damaged.", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (ListViewItem Item in lstParts.Items)
                {
                    try
                    {
                        File.Delete(Item.SubItems[0].Text);
                    }
                    catch (Exception Ex) { MessageBox.Show("The part named \"" + Item.SubItems[0].Text + "\" could not be deleted.\n\nReason:\n\n" + Ex.Message); }
                }
        }

        void Hide(object sender, EventArgs e)
        {
            Hide(); if (itmCurrentStatus.Checked)
            {
                TimeEstimater.Enabled = false;
                Progressor.Enabled = false;
                txtTimeRemaining.Text = "Estimating...Please Wait";
            }
        }

        void Exit(object sender, EventArgs e)
        {
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); return; }
            DialogResult DR = MessageBox.Show("Are you sure to Exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (DR == DialogResult.No) return;
            this.FormClosing -= new FormClosingEventHandler(HideForm);
            this.Close();
        }

        void ViewCurrentStatus(object sender, EventArgs e)
        {
            if (!Splitter.IsBusy) { itmCurrentStatus.Checked = true; panelStatus.Visible = false; return; }
            itmCurrentStatus.Checked = !itmCurrentStatus.Checked;

            if (itmCurrentStatus.Checked)
            {
                Progressor.Enabled = true;
                LastEstimation = Reader.Position;
                TimeEstimater.Enabled = true;                
            }
            else
            {
                Progressor.Enabled = false;
                TimeEstimater.Enabled = false;
                txtTimeRemaining.Text = "Estimating... Please Wait";
            }

            panelStatus.Visible = itmCurrentStatus.Checked;
        }

        void Show(object sender, EventArgs e)
        {
            Show();
            if (itmCurrentStatus.Checked && Splitter.IsBusy) { Progressor.Enabled = true; LastEstimation = Reader.Position; TimeEstimater.Enabled = true; }
        }

        void ForceShutdownWhenDone(object sender, EventArgs e)
        {
            itmForceShutdownWhenDone.Checked = !itmForceShutdownWhenDone.Checked;
            if (itmForceShutdownWhenDone.Checked)
            {
                if (MessageBox.Show("Activating this functionality will force the computer to shutdown within 30 Seconds as soon as the spliting process had been over, even if other appliaction are in progress.\n\nNote:  Any unsaved datas may be lost due to this action. Are you sure to use this functionality?", "Force Shutdown when Done", MessageBoxButtons.YesNo) == DialogResult.No)
                    itmForceShutdownWhenDone.Checked = false;
            }
        }

        void ShutdownWhenDone(object sender, EventArgs e)
        {
            itmShutdownWhenDone.Checked = !itmForceShutdownWhenDone.Checked;
            if (itmShutdownWhenDone.Checked)
            {
                if (MessageBox.Show("Activating this functionality will shutdown the computer within 30 Seconds as soon as the spliting process had been over. Are you sure to use this functionality?", "Shutdown when Done",MessageBoxButtons.YesNo) == DialogResult.No)
                    itmShutdownWhenDone.Checked = false;
            }
        }

        void ExitWhenDone(object sender, EventArgs e)
        {
            itmExitWhenDone.Checked = !itmExitWhenDone.Checked;
        }

        void About(object sender, EventArgs e)
        {
            About AboutSplitFile = new About();
            AboutSplitFile.ShowDialog();
        }

        #endregion

        #region Button Methods

        void BrowseSource(object sender, EventArgs e)
        {
            //if (ProjectLocation == "") { MessageBox.Show("First start a new project and then try again."); return; }
            if (StartedSpliting) { MessageBox.Show("You cannot perform this action after started to split the file. Stop the process if running and then Click Restart Spliting option from the file menu to do this action."); return; }
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then try again."); }
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.CheckFileExists = true;
            if (OFD.ShowDialog() == DialogResult.Cancel) return;
            ClearAll();
            ProjectLocation = Path.GetDirectoryName(OFD.FileName) + @"\"+Path.GetFileNameWithoutExtension(OFD.FileName)+ @"\"+Path.GetFileNameWithoutExtension(OFD.FileName)+@".sp";
            ProjectDirectory = Path.GetDirectoryName(OFD.FileName) + @"\" + Path.GetFileNameWithoutExtension(OFD.FileName);
            try
            {
                Directory.CreateDirectory(ProjectDirectory);
                FileStream fs = new FileStream(ProjectLocation, FileMode.CreateNew);
                fs.Close();
            }
            catch { }
            Sfilename = OFD.FileName;
            AssignSourceFile(OFD.FileName);
           
            
        }

        void BrowsePart(object sender, EventArgs e)
        {
            if (ProjectLocation == "") { MessageBox.Show("First start a new project and then try again."); return; }
            if (Splitter.IsBusy) { MessageBox.Show("First stop the current process and then proceed."); return; }
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.CheckPathExists = true;
            if (SFD.ShowDialog() == DialogResult.Cancel) return;
            txtPartName.Text = SFD.FileName;
        }

        void AddParts(object sender, EventArgs e)
        {
            if (RemainingSize == 0) return;
            //if (txtPartName.Text.Length == 0 || txtPartSize.Text.Length == 0)
            //{
            //    MessageBox.Show("Enter the filename and the size of the part to be added and then try again.");
            //    return;
            //}


            long temppsize= TotalSize/8, rmsize=TotalSize%8,tempx = 0;
            for (int i = 0; i < 8; i++)
            {
                if(i==7)
                {
                    tempx = rmsize;
                }
                long tempInt = temppsize+ tempx;
                //try
                //{
                //   // tempInt = Convert.ToInt64(txtPartSize.Text.Trim());
                //}
                //catch { MessageBox.Show("Only numbers can be entered in the size column provided. No alphabets or special characters can be entered."); return; }

                //foreach (ListViewItem Itm in lstParts.Items)
                //{
                //    if (Itm.SubItems[0].Text.ToLower() == txtPartName.Text.ToLower())
                //    {
                //        MessageBox.Show("The specified filename already exists in the list. Please specify a different filename.", "Duplicate Filename");
                //        return;
                //    }
                //}

                if (RemainingSize < tempInt) { MessageBox.Show("Size mentioned is greater than the size remaining Remaining size."); return; }

                RemainingSize = RemainingSize - tempInt;
                txtRemainingSize.Text = RemainingSize.ToString();

                string StartByte = "1", EndByte = tempInt+"";

                if (lstParts.Items.Count != 0)
                {
                    long tmpStart = Convert.ToInt64(lstParts.Items[lstParts.Items.Count - 1].SubItems[3].Text);
                    long tmpEnd = tmpStart + Convert.ToInt64(tempInt);
                    tmpStart++;
                    StartByte = tmpStart.ToString();
                    EndByte = tmpEnd.ToString();
                }
                MessageBox.Show(ProjectDirectory + @"\" + Path.GetFileNameWithoutExtension(Sfilename) + i);
                try
                {
                    FileStream fs = new FileStream(ProjectDirectory + @"\" + Path.GetFileNameWithoutExtension(Sfilename) + i, FileMode.CreateNew);
                    fs.Close();
                }
                catch { }
                lstParts.Items.Add(new ListViewItem(new string[] { ProjectDirectory + @"\" + Path.GetFileNameWithoutExtension(Sfilename) + i, tempInt + "", StartByte, EndByte }));
                txtPartSize.MaxLength = txtRemainingSize.Text.Length;
            }
        }

        void RemoveSelected(object sender, EventArgs e)
        {
            try
            {
                if (StartedSpliting) { MessageBox.Show("You cannot perform this action after started to split the file. Stop the process if running and then Click Restart Spliting option from the file menu to do this action."); return; }
                if (lstParts.SelectedItems.Count == 0) return;
                int Index = lstParts.SelectedItems[0].Index;
                if (Index == -1) { MessageBox.Show("First select the part to be removed.", "Action Canceled"); return; }

                if (MessageBox.Show("Are you sure to remove selected part from the list.", "SplitFile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                RemainingSize += Convert.ToInt64(lstParts.Items[lstParts.SelectedItems[0].Index].SubItems[1].Text);
                txtRemainingSize.Text = RemainingSize.ToString();
                int i = lstParts.SelectedItems[0].Index;
                lstParts.Items.RemoveAt(i);
                if (i == 0)
                {
                    lstParts.Items[0].SubItems[2].Text = "1";
                    lstParts.Items[0].SubItems[3].Text = lstParts.Items[0].SubItems[1].Text;
                    i++;
                }
                while (i < lstParts.Items.Count)
                {
                    long SB = Convert.ToInt64(lstParts.Items[i - 1].SubItems[3].Text);
                    long CurSize = Convert.ToInt64(lstParts.Items[i].SubItems[1].Text);

                    lstParts.Items[i].SubItems[2].Text = Convert.ToString(SB + 1);
                    lstParts.Items[i].SubItems[3].Text = Convert.ToString(SB + CurSize);
                    i++;
                }

                txtPartSize.MaxLength = txtRemainingSize.Text.Length;
            }
            catch { }
        }
        
        void Start(object sender, EventArgs e)
        {
            if (ProjectLocation == "") { MessageBox.Show("First start a new project and then proceed."); return; }
            if (lstParts.Items.Count == 0) { MessageBox.Show("Add the name and size of each part to split.", "No Parts Found"); return; }
            if (lstParts.Items.Count == 1) { MessageBox.Show("The file must be atleast splited into two parts.", "Requirement Failed"); return; }
            if (RemainingSize != 0) { MessageBox.Show("The file has to be entirely splited before starting to split. Their are " + txtRemainingSize.Text + " Bytes remaining to be splited.", "Split File"); return; }
            try
            {
                if (Reader == null) Reader = new FileStream(txtSourceFile.Text, FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (FileNotFoundException) { MessageBox.Show("The specified source file to split was not found. Please select an existing file.", "File Not Found"); return; }
            catch { MessageBox.Show("The selected source file could not be accessed. It might be either blocked by some other process. Stop all the process using the file and then try again.", "Error"); return; }

            TotalFile = lstParts.Items.Count;
            FileLocationArr = new string[TotalFile];
            FileSizeArr = new long[TotalFile];
            StartByteArr = new long[TotalFile];
            EndByteArr = new long[TotalFile];
            BufferSize = Convert.ToInt64(txtBufferSize.Value);
            for (int i = 0; i < TotalFile; i++)
            {
                FileLocationArr[i] = lstParts.Items[i].SubItems[0].Text;
                FileSizeArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[1].Text);
                StartByteArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[2].Text);
                EndByteArr[i] = Convert.ToInt64(lstParts.Items[i].SubItems[3].Text);
            }

            SaveProject();
            Splitter.RunWorkerAsync();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            
            if (txtCreateMergeFile.Checked) CreateMergeFile(ProjectLocation + "_Merger.bat");

            if (itmCurrentStatus.Checked)
            {
                panelStatus.Visible = true;
                Progressor.Enabled = true;
                LastEstimation = Reader.Position;
                TimeEstimater.Enabled = true;
            }
            else panelStatus.Visible = false;

            txtTimeRemaining.Text = "Started, Processing...";
        }

        void Stop(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to end the process?", "Confirm End Process", MessageBoxButtons.YesNo) == DialogResult.No) return;
            btnStop.Enabled = false;
            Canceled = true;
        }

        void BufferSizeChanged(object sender, EventArgs e)
        {
            BufferSize = Convert.ToInt64(txtBufferSize.Value);
        }
        #endregion

        #region Spliting

        void SplitFile(object sender, System.ComponentModel.DoWorkEventArgs e)
        {            
            long tmpEndByte;

            while (CurrentFileIndex < TotalFile)
            {
                Data = null;
                try
                {
                    Data = new byte[Convert.ToInt32(BufferSize)];
                }
                catch
                {
                    BufferSize -= 50000;
                    continue;
                }
                Directory.CreateDirectory(FileLocationArr[CurrentFileIndex].Substring(0, FileLocationArr[CurrentFileIndex].LastIndexOf("\\")));
                Writer = new FileStream(FileLocationArr[CurrentFileIndex], FileMode.Append, FileAccess.Write, FileShare.None);

                // Set the position of the reader.
                Reader.Position = StartByteArr[CurrentFileIndex] - 1 + Writer.Length;

                // Get the end position of Current file.
                tmpEndByte = EndByteArr[CurrentFileIndex];

                while (Reader.Position < tmpEndByte)
                {
                    // Assign no of bytes to read
                    if (Reader.Position + BufferSize > tmpEndByte)
                    {
                        Data = null;
                        try
                        {
                            Data = new byte[Convert.ToInt32(tmpEndByte - Reader.Position)];
                        }
                        catch { BufferSize -= 50000; continue; }
                    }

                    // Read and write the data
                    Reader.Read(Data, 0, Data.Length);
                    Writer.Write(Data, 0, Data.Length);
                    if (Canceled) return;
                }

                // Add completed file when completed.
                CurrentFileIndex++;
                Writer.Flush(); Writer.Close();
            }
        }

        void SplitingCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (Canceled) MessageBox.Show("The process had been canceled by the user. Click Start button to resume it again.", "Process Canceled");
            else
            {
                txtFileProcessing.Text = "File " + Convert.ToString(CurrentFileIndex + 1) + " / " + TotalFile.ToString();

                progressCurrentFile.Value = 100;
                txtCurrentFileByte.Text = lstParts.Items[lstParts.Items.Count - 1].SubItems[3].Text + " Bytes";
                txtCurrentFilePrec.Text = "100% Completed";

                progressOverallStatus.Value = 100;
                txtOverallFileByte.Text = txtTotalSize.Text + " Bytes";
                txtOverallPerc.Text = "100% Completed";
            }
            SaveProject();
            Progressor.Enabled = false;
            TimeEstimater.Enabled = false;
            txtTimeRemaining.Text = "Estimating... Please Wait";

            try { Writer.Close(); Writer = null; }
            catch { }

            Reader.Close(); Reader = null;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            panelStatus.Visible = false;
            itmCurrentStatus.Checked = true;

            if (!Canceled)
            {
                if (itmForceShutdownWhenDone.Checked)
                {
                    ShutDown StartShut = new ShutDown(true, 30);
                    StartShut.Show();
                    this.FormClosing -= new FormClosingEventHandler(HideForm);
                }
                else if (itmShutdownWhenDone.Checked)
                {
                    ShutDown StartShut = new ShutDown(false, 30);
                    StartShut.Show();
                    this.FormClosing -= new FormClosingEventHandler(HideForm);
                }
                else if (itmExitWhenDone.Checked)
                { this.FormClosing -= new FormClosingEventHandler(HideForm); Application.Exit(); }
                else MessageBox.Show("The process had been successfully completed.", "Process Completed");
            }
            Canceled = false;
        }
        #endregion

        #region Miscellaneous

        void ClearAll()
        {
            lstParts.Items.Clear();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            panelStatus.Visible = false;
        }

        void CreateMergeFile(string Path)
        {
            StreamWriter SW = new StreamWriter(Path);
            SW.WriteLine("@echo off");
            SW.WriteLine("title .NET Spliter v2.0\ncls\n");
            SW.WriteLine("echo =======================================================================");
            SW.WriteLine("echo                           .NET Spliter v2.0");
            SW.WriteLine("echo =======================================================================");
            SW.WriteLine("echo.");
            SW.WriteLine("echo  This file helps you to join the files splited by .NET Spliter v2.0.");
            SW.WriteLine("echo _______________________________________________________________________");
            SW.WriteLine("echo.");
            SW.WriteLine("echo  File List --- Size in Bytes");
            // Write the list of files.
            for (int i = 1; i != lstParts.Items.Count + 1; i++)
                SW.WriteLine("echo       " + i.ToString() + ". " + lstParts.Items[i - 1].SubItems[0].Text.Substring(lstParts.Items[i - 1].SubItems[0].Text.LastIndexOf("\\") + 1) + " --- " + lstParts.Items[i - 1].SubItems[1].Text + " Bytes");
            SW.WriteLine("echo.");
            SW.WriteLine("echo.");
            SW.WriteLine("echo Checking for files listed above.\necho.");

            // Che for existance of files.
            for (int i = 0; i != lstParts.Items.Count; i++)
            {
                string flNm = lstParts.Items[i].SubItems[0].Text.Substring(lstParts.Items[i].SubItems[0].Text.LastIndexOf("\\") + 1);
                SW.WriteLine("if exist \"" + flNm + "\" (\necho " + flNm + " exists.");
                SW.WriteLine(") else (");
                SW.WriteLine("echo.\necho File not Found :- \"" + flNm + "\"\n");
                SW.WriteLine("echo.\necho Note:- All the above listed files must exist in the same directory.");
                SW.WriteLine("echo.\necho.\necho.");
                SW.WriteLine("echo Copy the missing file in the same directory and then try again.\necho.\npause\nexit");
                SW.WriteLine(")\n");
            }
            SW.WriteLine("if exist \"" + txtSourceFile.Text.Substring(txtSourceFile.Text.LastIndexOf("\\") + 1) + "\" (");
            SW.WriteLine("echo.\necho.\necho The file named \"" + txtSourceFile.Text.Substring(txtSourceFile.Text.LastIndexOf("\\") + 1) + "\" already exists in this folder.");
            SW.WriteLine("echo Move the file to any other directory and then try again.");
            SW.WriteLine("pause\nexit\n)\necho.");
            SW.WriteLine("echo Checking for files completed successfully.");
            SW.WriteLine("pause");
            SW.WriteLine("echo.");
            SW.WriteLine("echo Started to join the files above mentioned. Please Wait ...");
            string ActualFileName = "\"" + txtSourceFile.Text.Substring(txtSourceFile.Text.LastIndexOf("\\") + 1) + "\"";
            SW.WriteLine("echo Actual File Name: " + ActualFileName + "");
            SW.WriteLine("echo.");
            string tmpFileName = "";
            foreach (ListViewItem Itm in lstParts.Items)
                tmpFileName += " \"" + Itm.SubItems[0].Text.Substring(Itm.SubItems[0].Text.LastIndexOf("\\") + 1) + "\" +";
            tmpFileName = tmpFileName.Substring(0, tmpFileName.Length - 1) + " ";
            SW.WriteLine("copy /b" + tmpFileName + ActualFileName);
            SW.WriteLine("echo.");
            SW.WriteLine("echo The new file named " + ActualFileName + " has been created.");
            SW.WriteLine("echo.\necho. Process Completed successfully. Exiting ...");
            SW.Write("echo.\npause");
            SW.Close(); SW = null;
        }

        void SaveProject()
        {
            FileStream FS = new FileStream(ProjectLocation, FileMode.Create, FileAccess.Write);
            BinaryWriter BW = new BinaryWriter(FS);

            BW.Write(Convert.ToInt16(111));// Specify it as spliter Project
            BW.Write(txtSourceFile.Text.Length);
            BW.Write(txtSourceFile.Text.ToCharArray());
            BW.Write(TotalSize); // Total size of the current file

            BW.Write(SourceByte); // Write the bytes of the source file.            
            BW.Write(BufferSize); // Size of the buffer
            BW.Write(CurrentFileIndex); // Index of current file processing.
            BW.Write(TotalFile); // Total no of parts to be splited.

            foreach (ListViewItem Item in lstParts.Items)
            {
                BW.Write(Item.SubItems[0].Text.Length);
                BW.Write(Item.SubItems[0].Text.ToCharArray());
                BW.Write(Convert.ToInt64(Item.SubItems[1].Text));
                BW.Write(Convert.ToInt64(Item.SubItems[2].Text));
                BW.Write(Convert.ToInt64(Item.SubItems[3].Text));
            }
            BW.Flush(); BW.Close(); BW = null; FS.Close(); FS = null;
        }

        void AssignSourceFile(string Path)
        {
            try
            {
                Reader = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None);
                SourceByte = new byte[30];
                Reader.Read(SourceByte, 0, 10);
                Reader.Position = (Reader.Length / 2) - 5;
                Reader.Read(SourceByte, 10, 10);
                Reader.Position = Reader.Length - 10;
                Reader.Read(SourceByte, 20, 10);
                Reader.Position = 0;
                txtSourceFile.Text = Path;
                txtTotalSize.Text = txtRemainingSize.Text = Reader.Length.ToString();
                TotalSize = RemainingSize = Reader.Length;
                panelButtons.Visible = true;
                txtPartSize.MaxLength = txtRemainingSize.Text.Length;
            }
            catch (FileNotFoundException) { MessageBox.Show("The specified source file to split was not found. Please select an existing file.", "File Not Found"); }
            catch { MessageBox.Show("The selected source file could not be accessed. It might be either blocked by some other process. Stop all the process using the file and then try again.", "Error"); }
        }

        bool OpenProject()
        {
            ClearAll();
            FileStream FS = new FileStream(ProjectLocation, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FS);

            if (BR.ReadInt16() != 111) { MessageBox.Show("The selected file is not a valid Splitter Project file.", "Invalid Project File"); return false; }// Specify it as spliter Project

            int tmpChrs = BR.ReadInt32(); // specify the length of the source file.

            // get the location of source file.
            string srclocation = new string(BR.ReadChars(tmpChrs));
            TotalSize = BR.ReadInt64(); // Total size of the current file

            // Get start and end bytes of old source file.
            SourceByte = BR.ReadBytes(30);

            FileStream SrcStr;
        CheckForFile:
            try
            {
                SrcStr = new FileStream(srclocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            }
            catch (FileNotFoundException)
            {
                if (MessageBox.Show("The source file \"" + srclocation + "\" could not be found.  Do you want to select the source file manually?", "File Not Found", MessageBoxButtons.YesNo) == DialogResult.No) return false;
                srclocation = GetOpenSource();
                if (srclocation == "") return false; goto CheckForFile;
            }
            catch
            {
                if (MessageBox.Show("The source file \"" + srclocation + "\" cannot be accessed. It may be used by some other process. Close all the other applications using the file and then click Ok", "Access Denied", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return false;
                goto CheckForFile;
            }

            if (SrcStr.Length != TotalSize)
            {
                if (MessageBox.Show("The source file \"" + srclocation + "\" is not a valid source file related to this project. The size of the file difer. Do you want to select the source file related to the project manualy?", "Invalid Source File", MessageBoxButtons.YesNo) == DialogResult.No) return false;
                SrcStr.Close(); SrcStr = null;
                srclocation = GetOpenSource();
                if (srclocation == "") return false;
                goto CheckForFile;
            }

            byte[] tmpSourceBytes = new byte[30];

            // Get start and end bytes of selected file.
            SrcStr.Read(tmpSourceBytes, 0, 10);

            SrcStr.Position = (SrcStr.Length / 2) - 5;
            SrcStr.Read(tmpSourceBytes, 10, 10);

            SrcStr.Position = SrcStr.Length - 10;
            SrcStr.Read(tmpSourceBytes, 20, 10);

            // Check for start and end bytes
            for (int a = 0; a < 30; a++)
            {
                if (tmpSourceBytes[a] == SourceByte[a]) continue;
                DialogResult DR = MessageBox.Show("The source file \"" + srclocation + "\" is not a valid source file related to this project. Do you want to select the source file related to the project manualy?", "Invalid Source File", MessageBoxButtons.YesNo);
                if (DR == DialogResult.No) return false;
                SrcStr.Close(); SrcStr = null;
                srclocation = GetOpenSource();
                if (srclocation == "") return false;
                goto CheckForFile;
            }

            SrcStr.Close(); SrcStr = null; // Close the source stream in use.

            BufferSize = BR.ReadInt64(); // Size of the buffer
            CurrentFileIndex = BR.ReadInt32(); // Index of current file processing.

            TotalFile = BR.ReadInt32(); // Total no of parts to be splited.

            for (int i = 0; i < TotalFile; i++)
            {
                lstParts.Items.Add(new ListViewItem(new string[] { new String(BR.ReadChars(BR.ReadInt32())), BR.ReadInt64().ToString(), BR.ReadInt64().ToString(), BR.ReadInt64().ToString() }));
            }

            BR.Close(); BR = null;
            FS.Close(); FS = null;
            AssignSourceFile(srclocation);
            txtRemainingSize.Text = "0";
            RemainingSize = 0;
            return true;
        }

        string GetOpenSource()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.DefaultExt = "*";
            OFD.CheckFileExists = true;
            OFD.Filter = "All Files (*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.Cancel) return "";
            return OFD.FileName;
        }

        void LoadingCompleted(object sender, EventArgs e)
        {
            if (ProjectLocation == "") return;
            if (!OpenProject())
            {
                ClearAll(); MessageBox.Show("The project cannot be loaded.");
                this.FormClosing -= new FormClosingEventHandler(HideForm);
                this.Close();
            }
        }

        // When the form started to close.
        void HideForm(object sender, FormClosingEventArgs e)
        {
            if (Splitter.IsBusy)
            {
                Hide();
                Progressor.Enabled = false;
                TimeEstimater.Enabled = false;
                txtTimeRemaining.Text = "Estimating... Please Wait";
                e.Cancel = true;
                TrayIcon.ShowBalloonTip(3000, "Split File", "The application had been minimised.\nRight click the icon for options.", ToolTipIcon.Info);
            }
            else
            {
                if (MessageBox.Show("Are you sure to exit this application?", "Confirm Exit...", MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
            }
        }

        void EstimateTime(object sender, EventArgs e)
        {
            long tmpVar = Reader.Position - LastEstimation;
            LastEstimation = Reader.Position;
            tmpVar = (((TotalSize - Reader.Position) / tmpVar) * 5);
            if (tmpVar < 20) tmpVar += 6;
            txtTimeRemaining.Text = GetHours(ref tmpVar) + "  (approximately)";
        }

        string GetHours(ref long Sec)
        {
            long Count = 0;
            while (Sec > 3599)
            {
                Count++;
                Sec -= 3600;
            }
            if (Count == 0)
            {
                if (Sec != 0) return GetMin(ref Sec);
                else return "";
            }
            else
            {
                if (Sec != 0) return Count.ToString() + " Hours  " + GetMin(ref Sec);
                else return Count.ToString() + " Hours";
            }
        }

        string GetMin(ref long Sec)
        {            
            long Count = 0;
            while (Sec > 59)
            {
                Count++;
                Sec -= 60;
            }
            if (Count == 0)
            {
                if (Sec != 0) return Sec.ToString() + " Seconds";
                else return "";
            }
            else
            {
                if (Sec != 0) return Count.ToString() + " Minutes  " + Sec.ToString() + " Seconds";
                else return Count.ToString() + " Minutes";
            }
        }

        #endregion
    }
}