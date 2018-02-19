namespace SplitFile
{
    partial class Spliter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spliter));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNewPoject = new System.Windows.Forms.ToolStripMenuItem();
            this.itmOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itmRestartSpliting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itmHide = new System.Windows.Forms.ToolStripMenuItem();
            this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCurrentStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmForceShutdownWhenDone = new System.Windows.Forms.ToolStripMenuItem();
            this.itmShutdownWhenDone = new System.Windows.Forms.ToolStripMenuItem();
            this.itmExitWhenDone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectHelper = new System.Windows.Forms.HelpProvider();
            this.lstParts = new System.Windows.Forms.ListView();
            this.itmFileName = new System.Windows.Forms.ColumnHeader();
            this.itmPartSize = new System.Windows.Forms.ColumnHeader();
            this.itmStartByte = new System.Windows.Forms.ColumnHeader();
            this.itmEndByte = new System.Windows.Forms.ColumnHeader();
            this.btnBrowsePart = new System.Windows.Forms.Button();
            this.txtCreateMergeFile = new System.Windows.Forms.CheckBox();
            this.txtTotalSize = new System.Windows.Forms.TextBox();
            this.txtRemainingSize = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPartSize = new System.Windows.Forms.TextBox();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.txtBufferSize = new System.Windows.Forms.NumericUpDown();
            this.txtOverallFileByte = new System.Windows.Forms.Label();
            this.txtCurrentFileByte = new System.Windows.Forms.Label();
            this.txtFileProcessing = new System.Windows.Forms.Label();
            this.progressOverallStatus = new System.Windows.Forms.ProgressBar();
            this.progressCurrentFile = new System.Windows.Forms.ProgressBar();
            this.txtOverallPerc = new System.Windows.Forms.Label();
            this.txtCurrentFilePrec = new System.Windows.Forms.Label();
            this.txtTimeRemaining = new System.Windows.Forms.Label();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblBlank = new System.Windows.Forms.Label();
            this.lblPieces = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.lblRemainingSize = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartSize = new System.Windows.Forms.Label();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblProcessingOL = new System.Windows.Forms.Label();
            this.lblProcessingCF = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.lblOverallStatus = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblBottomHeader = new System.Windows.Forms.Label();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.Splitter = new System.ComponentModel.BackgroundWorker();
            this.Progressor = new System.Windows.Forms.Timer(this.components);
            this.TimeEstimater = new System.Windows.Forms.Timer(this.components);
            this.MainMenuStrip.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBufferSize)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.optionsToolStripMenuItem,
            this.mnuHelp});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(665, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmNewPoject,
            this.itmOpenProject,
            this.toolStripSeparator1,
            this.itmRestartSpliting,
            this.toolStripSeparator2,
            this.itmHide,
            this.itmExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // itmNewPoject
            // 
            this.itmNewPoject.Name = "itmNewPoject";
            this.itmNewPoject.Size = new System.Drawing.Size(158, 22);
            this.itmNewPoject.Text = "New Project";
            this.itmNewPoject.ToolTipText = "Create a new Split File project.";
            this.itmNewPoject.Click += new System.EventHandler(this.NewProject);
            // 
            // itmOpenProject
            // 
            this.itmOpenProject.Name = "itmOpenProject";
            this.itmOpenProject.Size = new System.Drawing.Size(158, 22);
            this.itmOpenProject.Text = "Open Project";
            this.itmOpenProject.ToolTipText = "Open old project and resume splitting.";
            this.itmOpenProject.Click += new System.EventHandler(this.OpenProject);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // itmRestartSpliting
            // 
            this.itmRestartSpliting.Name = "itmRestartSpliting";
            this.itmRestartSpliting.Size = new System.Drawing.Size(158, 22);
            this.itmRestartSpliting.Text = "Restart Spliting";
            this.itmRestartSpliting.ToolTipText = "Restart spliting process from the first.";
            this.itmRestartSpliting.Click += new System.EventHandler(this.RestartSpliting);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // itmHide
            // 
            this.itmHide.Name = "itmHide";
            this.itmHide.Size = new System.Drawing.Size(158, 22);
            this.itmHide.Text = "Hide";
            this.itmHide.ToolTipText = "Hide this form.";
            this.itmHide.Click += new System.EventHandler(this.Hide);
            // 
            // itmExit
            // 
            this.itmExit.Name = "itmExit";
            this.itmExit.Size = new System.Drawing.Size(158, 22);
            this.itmExit.Text = "Exit";
            this.itmExit.ToolTipText = "Exit the application.";
            this.itmExit.Click += new System.EventHandler(this.Exit);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCurrentStatus});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(41, 20);
            this.mnuView.Text = "View";
            // 
            // itmCurrentStatus
            // 
            this.itmCurrentStatus.Checked = true;
            this.itmCurrentStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itmCurrentStatus.Name = "itmCurrentStatus";
            this.itmCurrentStatus.Size = new System.Drawing.Size(156, 22);
            this.itmCurrentStatus.Text = "Current Status";
            this.itmCurrentStatus.ToolTipText = "Specify weathe status is visible while splitting.";
            this.itmCurrentStatus.Click += new System.EventHandler(this.ViewCurrentStatus);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmForceShutdownWhenDone,
            this.itmShutdownWhenDone,
            this.itmExitWhenDone,
            this.toolStripSeparator4});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // itmForceShutdownWhenDone
            // 
            this.itmForceShutdownWhenDone.Name = "itmForceShutdownWhenDone";
            this.itmForceShutdownWhenDone.Size = new System.Drawing.Size(239, 22);
            this.itmForceShutdownWhenDone.Text = "Force Shutdown when done";
            this.itmForceShutdownWhenDone.ToolTipText = "Shutdown the computer even if other process were running.";
            this.itmForceShutdownWhenDone.Click += new System.EventHandler(this.ForceShutdownWhenDone);
            // 
            // itmShutdownWhenDone
            // 
            this.itmShutdownWhenDone.Name = "itmShutdownWhenDone";
            this.itmShutdownWhenDone.Size = new System.Drawing.Size(239, 22);
            this.itmShutdownWhenDone.Text = "Shutdown Computer when done";
            this.itmShutdownWhenDone.ToolTipText = "Automatically Shutdown the computer when the splitting process had been completed" +
                ".";
            this.itmShutdownWhenDone.Click += new System.EventHandler(this.ShutdownWhenDone);
            // 
            // itmExitWhenDone
            // 
            this.itmExitWhenDone.Name = "itmExitWhenDone";
            this.itmExitWhenDone.Size = new System.Drawing.Size(239, 22);
            this.itmExitWhenDone.Text = "Exit when done";
            this.itmExitWhenDone.ToolTipText = "Exit the application when the process had been completed.";
            this.itmExitWhenDone.Click += new System.EventHandler(this.ExitWhenDone);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(48, 20);
            this.mnuHelp.Text = "About";
            this.mnuHelp.Click += new System.EventHandler(this.About);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(115, 98);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.Show);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.Hide);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About);
            // 
            // lstParts
            // 
            this.lstParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itmFileName,
            this.itmPartSize,
            this.itmStartByte,
            this.itmEndByte});
            this.lstParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstParts.FullRowSelect = true;
            this.ObjectHelper.SetHelpString(this.lstParts, "Displays the Name and size of each part of the file added by user.");
            this.lstParts.Location = new System.Drawing.Point(0, 87);
            this.lstParts.Name = "lstParts";
            this.ObjectHelper.SetShowHelp(this.lstParts, true);
            this.lstParts.Size = new System.Drawing.Size(665, 87);
            this.lstParts.TabIndex = 1;
            this.lstParts.UseCompatibleStateImageBehavior = false;
            this.lstParts.View = System.Windows.Forms.View.Details;
            // 
            // itmFileName
            // 
            this.itmFileName.Text = "File Name";
            this.itmFileName.Width = 211;
            // 
            // itmPartSize
            // 
            this.itmPartSize.Text = "Part Size";
            this.itmPartSize.Width = 150;
            // 
            // itmStartByte
            // 
            this.itmStartByte.Text = "Start Byte";
            this.itmStartByte.Width = 150;
            // 
            // itmEndByte
            // 
            this.itmEndByte.Text = "End Byte";
            this.itmEndByte.Width = 150;
            // 
            // btnBrowsePart
            // 
            this.ObjectHelper.SetHelpString(this.btnBrowsePart, "Browses thelocal folder and select where the splited files has to be saved.");
            this.btnBrowsePart.Location = new System.Drawing.Point(481, 37);
            this.btnBrowsePart.Name = "btnBrowsePart";
            this.ObjectHelper.SetShowHelp(this.btnBrowsePart, true);
            this.btnBrowsePart.Size = new System.Drawing.Size(56, 23);
            this.btnBrowsePart.TabIndex = 4;
            this.btnBrowsePart.Text = "&Browse";
            this.btnBrowsePart.UseVisualStyleBackColor = true;
            this.btnBrowsePart.Click += new System.EventHandler(this.BrowsePart);
            // 
            // txtCreateMergeFile
            // 
            this.txtCreateMergeFile.AutoSize = true;
            this.txtCreateMergeFile.Checked = true;
            this.txtCreateMergeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ObjectHelper.SetHelpString(this.txtCreateMergeFile, "Specifies weather a batch file would be created to merge the file without the hel" +
                    "p of this tool.");
            this.txtCreateMergeFile.Location = new System.Drawing.Point(7, 96);
            this.txtCreateMergeFile.Name = "txtCreateMergeFile";
            this.ObjectHelper.SetShowHelp(this.txtCreateMergeFile, true);
            this.txtCreateMergeFile.Size = new System.Drawing.Size(223, 17);
            this.txtCreateMergeFile.TabIndex = 3;
            this.txtCreateMergeFile.Text = "Create &Merge file to Join parts (Merge.bat)";
            this.txtCreateMergeFile.UseVisualStyleBackColor = true;
            // 
            // txtTotalSize
            // 
            this.txtTotalSize.BackColor = System.Drawing.SystemColors.Window;
            this.ObjectHelper.SetHelpString(this.txtTotalSize, "Displays the total size of the source file in bytes. (readonly)");
            this.txtTotalSize.Location = new System.Drawing.Point(70, 10);
            this.txtTotalSize.Name = "txtTotalSize";
            this.txtTotalSize.ReadOnly = true;
            this.ObjectHelper.SetShowHelp(this.txtTotalSize, true);
            this.txtTotalSize.Size = new System.Drawing.Size(165, 20);
            this.txtTotalSize.TabIndex = 0;
            this.txtTotalSize.TabStop = false;
            // 
            // txtRemainingSize
            // 
            this.txtRemainingSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemainingSize.Location = new System.Drawing.Point(322, 10);
            this.txtRemainingSize.Name = "txtRemainingSize";
            this.txtRemainingSize.ReadOnly = true;
            this.ObjectHelper.SetShowHelp(this.txtRemainingSize, true);
            this.txtRemainingSize.Size = new System.Drawing.Size(215, 20);
            this.txtRemainingSize.TabIndex = 0;
            this.txtRemainingSize.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ObjectHelper.SetHelpString(this.btnStop, "Stops spliting of files completly. (Can be restarted later with the project file." +
                    ")");
            this.btnStop.Location = new System.Drawing.Point(561, 92);
            this.btnStop.Name = "btnStop";
            this.ObjectHelper.SetShowHelp(this.btnStop, true);
            this.btnStop.Size = new System.Drawing.Size(87, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.Stop);
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.SystemColors.Window;
            this.ObjectHelper.SetHelpString(this.txtPartName, "Specifies the name of the part to be created. (Adds to the list when Add Part bur" +
                    "ron is clicked.)");
            this.txtPartName.Location = new System.Drawing.Point(70, 39);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ReadOnly = true;
            this.ObjectHelper.SetShowHelp(this.txtPartName, true);
            this.txtPartName.Size = new System.Drawing.Size(405, 20);
            this.txtPartName.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Blue;
            this.ObjectHelper.SetHelpString(this.btnStart, "Starts spliting the source file into many parts as spefied in the list.");
            this.btnStart.Location = new System.Drawing.Point(561, 10);
            this.btnStart.Name = "btnStart";
            this.ObjectHelper.SetShowHelp(this.btnStart, true);
            this.btnStart.Size = new System.Drawing.Size(87, 49);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.Start);
            // 
            // txtPartSize
            // 
            this.ObjectHelper.SetHelpString(this.txtPartSize, "Specifies the size of the part to be created. (Adds to the list when Add Part bur" +
                    "ron is clicked)");
            this.txtPartSize.Location = new System.Drawing.Point(322, 66);
            this.txtPartSize.Name = "txtPartSize";
            this.ObjectHelper.SetShowHelp(this.txtPartSize, true);
            this.txtPartSize.Size = new System.Drawing.Size(215, 20);
            this.txtPartSize.TabIndex = 5;
            // 
            // btnAddParts
            // 
            this.ObjectHelper.SetHelpString(this.btnAddParts, "Adds new part to the list with specified name and size in bytes. (As specified ab" +
                    "ove)");
            this.btnAddParts.Location = new System.Drawing.Point(322, 92);
            this.btnAddParts.Name = "btnAddParts";
            this.ObjectHelper.SetShowHelp(this.btnAddParts, true);
            this.btnAddParts.Size = new System.Drawing.Size(82, 23);
            this.btnAddParts.TabIndex = 6;
            this.btnAddParts.Text = "&Add Part";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.AddParts);
            // 
            // btnRemoveSelected
            // 
            this.ObjectHelper.SetHelpString(this.btnRemoveSelected, "Removes the selected part from the list.");
            this.btnRemoveSelected.Location = new System.Drawing.Point(432, 92);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.ObjectHelper.SetShowHelp(this.btnRemoveSelected, true);
            this.btnRemoveSelected.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveSelected.TabIndex = 7;
            this.btnRemoveSelected.Text = "&Remove Part";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.RemoveSelected);
            // 
            // txtBufferSize
            // 
            this.ObjectHelper.SetHelpString(this.txtBufferSize, "Select the size of the buffer in bytes. (The number of bytes which would be proce" +
                    "ssed at time. Higher selection dose the work soon.)");
            this.txtBufferSize.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtBufferSize.Location = new System.Drawing.Point(70, 67);
            this.txtBufferSize.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.txtBufferSize.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.txtBufferSize.Name = "txtBufferSize";
            this.ObjectHelper.SetShowHelp(this.txtBufferSize, true);
            this.txtBufferSize.Size = new System.Drawing.Size(165, 20);
            this.txtBufferSize.TabIndex = 2;
            this.txtBufferSize.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtBufferSize.ValueChanged += new System.EventHandler(this.BufferSizeChanged);
            // 
            // txtOverallFileByte
            // 
            this.txtOverallFileByte.AutoSize = true;
            this.ObjectHelper.SetHelpString(this.txtOverallFileByte, "Displays the total number of bytes processed in the source file.");
            this.txtOverallFileByte.Location = new System.Drawing.Point(485, 92);
            this.txtOverallFileByte.Name = "txtOverallFileByte";
            this.ObjectHelper.SetShowHelp(this.txtOverallFileByte, true);
            this.txtOverallFileByte.Size = new System.Drawing.Size(42, 13);
            this.txtOverallFileByte.TabIndex = 0;
            this.txtOverallFileByte.Text = "0 Bytes";
            // 
            // txtCurrentFileByte
            // 
            this.txtCurrentFileByte.AutoSize = true;
            this.ObjectHelper.SetHelpString(this.txtCurrentFileByte, "Displays the number of bytes transferred to the current file.");
            this.txtCurrentFileByte.Location = new System.Drawing.Point(485, 59);
            this.txtCurrentFileByte.Name = "txtCurrentFileByte";
            this.ObjectHelper.SetShowHelp(this.txtCurrentFileByte, true);
            this.txtCurrentFileByte.Size = new System.Drawing.Size(42, 13);
            this.txtCurrentFileByte.TabIndex = 0;
            this.txtCurrentFileByte.Text = "0 Bytes";
            // 
            // txtFileProcessing
            // 
            this.txtFileProcessing.AutoSize = true;
            this.ObjectHelper.SetHelpString(this.txtFileProcessing, "Displays the current part which is in progress.");
            this.txtFileProcessing.Location = new System.Drawing.Point(485, 31);
            this.txtFileProcessing.Name = "txtFileProcessing";
            this.ObjectHelper.SetShowHelp(this.txtFileProcessing, true);
            this.txtFileProcessing.Size = new System.Drawing.Size(49, 13);
            this.txtFileProcessing.TabIndex = 0;
            this.txtFileProcessing.Text = "File 0 / 0";
            // 
            // progressOverallStatus
            // 
            this.ObjectHelper.SetHelpString(this.progressOverallStatus, "Displayes the overall status of the process.");
            this.progressOverallStatus.Location = new System.Drawing.Point(90, 87);
            this.progressOverallStatus.Name = "progressOverallStatus";
            this.ObjectHelper.SetShowHelp(this.progressOverallStatus, true);
            this.progressOverallStatus.Size = new System.Drawing.Size(200, 23);
            this.progressOverallStatus.Step = 1;
            this.progressOverallStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressOverallStatus.TabIndex = 0;
            // 
            // progressCurrentFile
            // 
            this.ObjectHelper.SetHelpString(this.progressCurrentFile, "Displays the status of current part of the file.");
            this.progressCurrentFile.Location = new System.Drawing.Point(90, 54);
            this.progressCurrentFile.Name = "progressCurrentFile";
            this.ObjectHelper.SetShowHelp(this.progressCurrentFile, true);
            this.progressCurrentFile.Size = new System.Drawing.Size(200, 23);
            this.progressCurrentFile.Step = 1;
            this.progressCurrentFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressCurrentFile.TabIndex = 0;
            // 
            // txtOverallPerc
            // 
            this.txtOverallPerc.AutoSize = true;
            this.ObjectHelper.SetHelpString(this.txtOverallPerc, "Displayes the overall status of the process in percent.");
            this.txtOverallPerc.Location = new System.Drawing.Point(296, 92);
            this.txtOverallPerc.Name = "txtOverallPerc";
            this.ObjectHelper.SetShowHelp(this.txtOverallPerc, true);
            this.txtOverallPerc.Size = new System.Drawing.Size(74, 13);
            this.txtOverallPerc.TabIndex = 0;
            this.txtOverallPerc.Text = "0% Completed";
            // 
            // txtCurrentFilePrec
            // 
            this.txtCurrentFilePrec.AutoSize = true;
            this.ObjectHelper.SetHelpString(this.txtCurrentFilePrec, "Displays the status of current part of the file in percent.");
            this.txtCurrentFilePrec.Location = new System.Drawing.Point(296, 59);
            this.txtCurrentFilePrec.Name = "txtCurrentFilePrec";
            this.ObjectHelper.SetShowHelp(this.txtCurrentFilePrec, true);
            this.txtCurrentFilePrec.Size = new System.Drawing.Size(74, 13);
            this.txtCurrentFilePrec.TabIndex = 0;
            this.txtCurrentFilePrec.Text = "0% Completed";
            // 
            // txtTimeRemaining
            // 
            this.txtTimeRemaining.AutoSize = true;
            this.ObjectHelper.SetHelpString(this.txtTimeRemaining, "Displays the current sataus.");
            this.txtTimeRemaining.Location = new System.Drawing.Point(90, 31);
            this.txtTimeRemaining.Name = "txtTimeRemaining";
            this.ObjectHelper.SetShowHelp(this.txtTimeRemaining, true);
            this.txtTimeRemaining.Size = new System.Drawing.Size(124, 13);
            this.txtTimeRemaining.TabIndex = 0;
            this.txtTimeRemaining.Text = "Estimating... Please Wait";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.BackColor = System.Drawing.SystemColors.Window;
            this.ObjectHelper.SetHelpString(this.txtSourceFile, "Displays the source file which has to be splited into small parts.");
            this.txtSourceFile.Location = new System.Drawing.Point(70, 35);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.ReadOnly = true;
            this.ObjectHelper.SetShowHelp(this.txtSourceFile, true);
            this.txtSourceFile.Size = new System.Drawing.Size(513, 20);
            this.txtSourceFile.TabIndex = 0;
            this.txtSourceFile.TabStop = false;
            // 
            // btnBrowseSource
            // 
            this.ObjectHelper.SetHelpString(this.btnBrowseSource, "Browses the file to be splited.");
            this.btnBrowseSource.Location = new System.Drawing.Point(592, 33);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.ObjectHelper.SetShowHelp(this.btnBrowseSource, true);
            this.btnBrowseSource.Size = new System.Drawing.Size(56, 23);
            this.btnBrowseSource.TabIndex = 0;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.BrowseSource);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "TrayIcon";
            this.TrayIcon.Visible = true;
            this.TrayIcon.Click += new System.EventHandler(this.Show);
            // 
            // lblBlank
            // 
            this.lblBlank.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBlank.Location = new System.Drawing.Point(0, 24);
            this.lblBlank.Name = "lblBlank";
            this.lblBlank.Size = new System.Drawing.Size(665, 40);
            this.lblBlank.TabIndex = 0;
            // 
            // lblPieces
            // 
            this.lblPieces.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPieces.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieces.Location = new System.Drawing.Point(0, 64);
            this.lblPieces.Name = "lblPieces";
            this.lblPieces.Size = new System.Drawing.Size(665, 23);
            this.lblPieces.TabIndex = 0;
            this.lblPieces.Text = "Add Parts";
            this.lblPieces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.lblTotalSize);
            this.panelButtons.Controls.Add(this.btnBrowsePart);
            this.panelButtons.Controls.Add(this.txtCreateMergeFile);
            this.panelButtons.Controls.Add(this.txtTotalSize);
            this.panelButtons.Controls.Add(this.lblRemainingSize);
            this.panelButtons.Controls.Add(this.txtRemainingSize);
            this.panelButtons.Controls.Add(this.lblPartName);
            this.panelButtons.Controls.Add(this.btnStop);
            this.panelButtons.Controls.Add(this.txtPartName);
            this.panelButtons.Controls.Add(this.lblPartSize);
            this.panelButtons.Controls.Add(this.btnStart);
            this.panelButtons.Controls.Add(this.txtPartSize);
            this.panelButtons.Controls.Add(this.btnAddParts);
            this.panelButtons.Controls.Add(this.btnRemoveSelected);
            this.panelButtons.Controls.Add(this.txtBufferSize);
            this.panelButtons.Controls.Add(this.lblBufferSize);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 174);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(665, 121);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.Visible = false;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(4, 13);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(54, 13);
            this.lblTotalSize.TabIndex = 0;
            this.lblTotalSize.Text = "Total Size";
            // 
            // lblRemainingSize
            // 
            this.lblRemainingSize.AutoSize = true;
            this.lblRemainingSize.Location = new System.Drawing.Point(262, 13);
            this.lblRemainingSize.Name = "lblRemainingSize";
            this.lblRemainingSize.Size = new System.Drawing.Size(57, 13);
            this.lblRemainingSize.TabIndex = 0;
            this.lblRemainingSize.Text = "Remaining";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(4, 42);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(57, 13);
            this.lblPartName.TabIndex = 0;
            this.lblPartName.Text = "Part Name";
            // 
            // lblPartSize
            // 
            this.lblPartSize.AutoSize = true;
            this.lblPartSize.Location = new System.Drawing.Point(262, 69);
            this.lblPartSize.Name = "lblPartSize";
            this.lblPartSize.Size = new System.Drawing.Size(49, 13);
            this.lblPartSize.TabIndex = 0;
            this.lblPartSize.Text = "Part Size";
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.Location = new System.Drawing.Point(4, 69);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(58, 13);
            this.lblBufferSize.TabIndex = 0;
            this.lblBufferSize.Text = "Buffer Size";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.txtOverallFileByte);
            this.panelStatus.Controls.Add(this.lblProcessingOL);
            this.panelStatus.Controls.Add(this.txtCurrentFileByte);
            this.panelStatus.Controls.Add(this.lblProcessingCF);
            this.panelStatus.Controls.Add(this.txtFileProcessing);
            this.panelStatus.Controls.Add(this.lblProcessing);
            this.panelStatus.Controls.Add(this.progressOverallStatus);
            this.panelStatus.Controls.Add(this.progressCurrentFile);
            this.panelStatus.Controls.Add(this.txtOverallPerc);
            this.panelStatus.Controls.Add(this.txtCurrentFilePrec);
            this.panelStatus.Controls.Add(this.txtTimeRemaining);
            this.panelStatus.Controls.Add(this.lblOverallStatus);
            this.panelStatus.Controls.Add(this.lblCurrentFile);
            this.panelStatus.Controls.Add(this.lblRemainingTime);
            this.panelStatus.Controls.Add(this.lblBottomHeader);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 295);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(665, 119);
            this.panelStatus.TabIndex = 3;
            this.panelStatus.Visible = false;
            // 
            // lblProcessingOL
            // 
            this.lblProcessingOL.AutoSize = true;
            this.lblProcessingOL.Location = new System.Drawing.Point(420, 92);
            this.lblProcessingOL.Name = "lblProcessingOL";
            this.lblProcessingOL.Size = new System.Drawing.Size(57, 13);
            this.lblProcessingOL.TabIndex = 0;
            this.lblProcessingOL.Text = "Processed";
            // 
            // lblProcessingCF
            // 
            this.lblProcessingCF.AutoSize = true;
            this.lblProcessingCF.Location = new System.Drawing.Point(420, 59);
            this.lblProcessingCF.Name = "lblProcessingCF";
            this.lblProcessingCF.Size = new System.Drawing.Size(57, 13);
            this.lblProcessingCF.TabIndex = 0;
            this.lblProcessingCF.Text = "Processed";
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(420, 31);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(59, 13);
            this.lblProcessing.TabIndex = 0;
            this.lblProcessing.Text = "Processing";
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.AutoSize = true;
            this.lblOverallStatus.Location = new System.Drawing.Point(10, 92);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(73, 13);
            this.lblOverallStatus.TabIndex = 0;
            this.lblOverallStatus.Text = "Overall Status";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(10, 59);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(60, 13);
            this.lblCurrentFile.TabIndex = 0;
            this.lblCurrentFile.Text = "Current File";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(10, 31);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(57, 13);
            this.lblRemainingTime.TabIndex = 0;
            this.lblRemainingTime.Text = "Remaining";
            // 
            // lblBottomHeader
            // 
            this.lblBottomHeader.BackColor = System.Drawing.SystemColors.Info;
            this.lblBottomHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBottomHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomHeader.Location = new System.Drawing.Point(0, 0);
            this.lblBottomHeader.Name = "lblBottomHeader";
            this.lblBottomHeader.Size = new System.Drawing.Size(665, 23);
            this.lblBottomHeader.TabIndex = 0;
            this.lblBottomHeader.Text = "Spliting Status";
            this.lblBottomHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(7, 38);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(60, 13);
            this.lblSourceFile.TabIndex = 0;
            this.lblSourceFile.Text = "Source File";
            // 
            // Splitter
            // 
            this.Splitter.WorkerSupportsCancellation = true;
            this.Splitter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SplitFile);
            this.Splitter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SplitingCompleted);
            // 
            // Progressor
            // 
            this.Progressor.Interval = 1000;
            this.Progressor.Tick += new System.EventHandler(this.ProgressChanged);
            // 
            // TimeEstimater
            // 
            this.TimeEstimater.Interval = 5000;
            this.TimeEstimater.Tick += new System.EventHandler(this.EstimateTime);
            // 
            // Spliter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 414);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.lblSourceFile);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.lblPieces);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.lblBlank);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Spliter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideForm);
            this.Load += new System.EventHandler(this.LoadingCompleted);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBufferSize)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.HelpProvider ObjectHelper;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem itmNewPoject;
        private System.Windows.Forms.ToolStripMenuItem itmOpenProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itmRestartSpliting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itmHide;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem itmCurrentStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Label lblBlank;
        private System.Windows.Forms.ListView lstParts;
        private System.Windows.Forms.ColumnHeader itmFileName;
        private System.Windows.Forms.ColumnHeader itmPartSize;
        private System.Windows.Forms.ColumnHeader itmStartByte;
        private System.Windows.Forms.ColumnHeader itmEndByte;
        private System.Windows.Forms.Label lblPieces;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Button btnBrowsePart;
        private System.Windows.Forms.CheckBox txtCreateMergeFile;
        private System.Windows.Forms.TextBox txtTotalSize;
        private System.Windows.Forms.Label lblRemainingSize;
        private System.Windows.Forms.TextBox txtRemainingSize;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPartSize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPartSize;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.NumericUpDown txtBufferSize;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label txtOverallFileByte;
        private System.Windows.Forms.Label lblProcessingOL;
        private System.Windows.Forms.Label txtCurrentFileByte;
        private System.Windows.Forms.Label lblProcessingCF;
        private System.Windows.Forms.Label txtFileProcessing;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.ProgressBar progressOverallStatus;
        private System.Windows.Forms.ProgressBar progressCurrentFile;
        private System.Windows.Forms.Label txtOverallPerc;
        private System.Windows.Forms.Label txtCurrentFilePrec;
        private System.Windows.Forms.Label txtTimeRemaining;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblBottomHeader;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.ComponentModel.BackgroundWorker Splitter;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer Progressor;
        private System.Windows.Forms.Timer TimeEstimater;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmShutdownWhenDone;
        private System.Windows.Forms.ToolStripMenuItem itmExitWhenDone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itmForceShutdownWhenDone;
    }
}

