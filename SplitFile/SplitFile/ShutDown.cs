using System;
using System.Windows.Forms;

namespace SplitFile
{
    public partial class ShutDown : Form
    {
        System.Timers.Timer ShutdownTimer;
        string Command;
        System.Diagnostics.Process StartProcess;

        public ShutDown(bool ForceShutdown, double ShutdownTime)
        {
            StartProcess = new System.Diagnostics.Process();
            StartProcess.StartInfo.FileName = Environment.GetEnvironmentVariable("windir") + "\\system32\\shutdown.exe";
            StartProcess.StartInfo.CreateNoWindow = true;
            StartProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            
            InitializeComponent();
            if (ForceShutdown)
            {
                StartProcess.StartInfo.Arguments = " -s -f -c \"SplitFile has been scheduled to shutdown the system forcefully when the work prescribed to it had been completed.\" -t 20";
                Text = "Split File :: Scheduler :: Force Windows Shutdown :: " + ShutdownTime.ToString() + " Seconds";
            }
            else
            {
                StartProcess.StartInfo.Arguments = " -s -c \"SplitFile has been scheduled to shutdown the system when the work prescribed to it had been completed.\" -t 20";
                Text = "Split File :: Scheduler :: Windows Shutdown :: " + ShutdownTime.ToString() + " Seconds";
            }
            ShutdownTimer = new System.Timers.Timer(ShutdownTime * 1000);
            ShutdownTimer.Elapsed += new System.Timers.ElapsedEventHandler(StartShutdown);
            ShutdownTimer.Enabled = true;
        }

        void StartShutdown(object sender, System.Timers.ElapsedEventArgs e)
        {
            StartProcess.Start();
            Application.Exit();
        }

        void CancelShutdown(object sender, EventArgs e)
        {
            ShutdownTimer.Enabled = false;
            Application.Exit();
        }
    }
}