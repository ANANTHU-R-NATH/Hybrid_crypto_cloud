using System;
using System.Windows.Forms;

namespace SplitFile
{
    static class Program
    {
        [STAThread]
        static void Main(string[] Args)
        {
            Application.EnableVisualStyles();
            System.IO.FileStream Reader;

            if (Args != null)
                if (Args.Length > 0)
                    if (Args[0] != "")
                    {
                        try
                        {
                            Reader = new System.IO.FileStream(Args[0], System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        }
                        catch (System.IO.FileNotFoundException) { MessageBox.Show("The file \"" + Args[0] + "\" could not be found."); return; }
                        catch (Exception Ex) { MessageBox.Show("The file \"" + Args[0] + "\" could not be loaded.\n\nError Message:\n" + Ex.Message); return; }

                        System.IO.BinaryReader BR = new System.IO.BinaryReader(Reader);
                        short Data = BR.ReadInt16();
                        BR.Close(); BR = null; Reader.Close();

                        if (Data != 111)
                        { MessageBox.Show("The file \"" + Args[0] + "\" is not a valid project file."); return; }

                        Spliter.ProjectLocation = Args[0];
                    }
            Application.Run(new Spliter());
        }
    }
}