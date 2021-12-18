using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Text;

namespace Assistant
{
    public partial class mainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        Thread threadForAssistant;
        int inProgress = 0;
        Random random = new Random();       

        public mainForm()
        {
            InitializeComponent();
            pictureBox_warning.Image = SystemIcons.Warning.ToBitmap();
        }

        private void StartClick(object sender, EventArgs e)
        {
            inProgress = 1;
            threadForAssistant = new Thread(new ThreadStart(ThreadCode));
            threadForAssistant.Start();

            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            label_status.Text = "Status: Running";
            AppendText(DateTime.Now.ToString("HH:mm:ss") + " - Thread started.\n", richTextBox_console.ForeColor);
        }

        private void StopClick(object sender, EventArgs e)
        {
            inProgress = 0;
            AppendText(Environment.NewLine + " -----------" + Environment.NewLine, richTextBox_console.ForeColor);
            AppendText(DateTime.Now.ToString("HH:mm:ss") + " - Stopping...", richTextBox_console.ForeColor);
            AppendText(Environment.NewLine, richTextBox_console.ForeColor);

            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            label_status.Text = "Status: Stopping";
            Console.WriteLine(Mouse.LeftButton.ToString());
            Console.WriteLine(Mouse.RightButton.ToString());
            
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)System.Windows.Forms.Cursor.Position.X, (uint)System.Windows.Forms.Cursor.Position.Y, 0, 0);
            AppendText(DateTime.Now.ToString("HH:mm:ss") + " - Fired LM_U.", Color.Blue);
            AppendText(Environment.NewLine, richTextBox_console.ForeColor);
            mouse_event(MOUSEEVENTF_RIGHTUP, (uint)System.Windows.Forms.Cursor.Position.X, (uint)System.Windows.Forms.Cursor.Position.Y, 0, 0);
            AppendText(DateTime.Now.ToString("HH:mm:ss") + " - Fired RM_U.", Color.Red);
            AppendText(Environment.NewLine, richTextBox_console.ForeColor);

            threadForAssistant.Abort();
            label_status.Text = "Status: Stopped";
            label_timeLeft.Visible = false;
            AppendText(DateTime.Now.ToString("HH:mm:ss") + " - Thread stopped.", richTextBox_console.ForeColor);
            AppendText(Environment.NewLine, richTextBox_console.ForeColor);
        }

        private void ThreadCode()
        {
            Thread.Sleep(5000); //(5 second wait at the start)

            while (inProgress == 1)
            {
               
                AppendText(DateTime.Now.ToString("HH:mm:ss") + " - ", richTextBox_console.ForeColor);
                uint X = (uint)System.Windows.Forms.Cursor.Position.X;
                uint Y = (uint)System.Windows.Forms.Cursor.Position.Y;

                //Start with a left click
                mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);

                AppendText("LM_D ", Color.Blue); 
                //Follow up with a right click after a semi random interval
                Thread.Sleep(random.Next(40, 800));
                mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
                AppendText("RM_D ", Color.Red);
                AppendText("|| ", richTextBox_console.ForeColor);

                //call the mouse event up
                FinalizeMouseClicks(X, Y);

                //Waits a semi random amount of time for the next execution
                int msToWait = random.Next(440000, 1440000);
                string nextTime = DateTime.Now.AddMilliseconds(msToWait).ToString("HH:mm:ss");
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate {
                        label_timeLeft.Invoke(new MethodInvoker(delegate 
                        {
                            label_timeLeft.Text = "Next time: " + nextTime;
                            label_timeLeft.Visible = true;
                        }));
                        //label_timeLeft.Text = "Next time: " + DateTime.Now.AddMilliseconds(3000).ToString("HH:mm:ss");
                    }));
                    /*return*/;
                }
                
                //label_timeLeft.Visible = true;
                Thread.Sleep(msToWait);
                //Thread.Sleep(2000);
            }
        }

        // This method will randomize the order at which the left and right mouse clicks are executed
        private void FinalizeMouseClicks(uint X, uint Y)
        {
            //1 = Raises left mouse first; 0 = Raises right mouse first
            if (random.Next(2) == 1) // Random 0 or 1
            {
                //Sleep until raising the left mouse button
                Thread.Sleep(random.Next(40, 1000));
                if (inProgress == 1)
                {
                    mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    AppendText("LM_U ", Color.Blue);
                }


                //Sleep until raising the right mouse button
                Thread.Sleep(random.Next(40, 1000));
                if (inProgress == 1)
                {
                    mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    AppendText("RM_D", Color.Red);
                    AppendText(Environment.NewLine, richTextBox_console.ForeColor);
                }
            }
            else
            {
                //Sleep until raising the right mouse button
                Thread.Sleep(random.Next(40, 1000));
                if (inProgress == 1)
                {
                    mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    AppendText("RM_U ", Color.Red);
                }

                //Sleep until raising the left mouse button
                Thread.Sleep(random.Next(40, 1000));
                if (inProgress == 1)
                {
                    mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    AppendText("LM_U", Color.Blue);
                    AppendText(Environment.NewLine, richTextBox_console.ForeColor);
                }
            }
            
        }

        //AppendText was created due to a thread conflict error but it's used basically everywhere else for the sake of coherence - also allows adding color to the text
        private void AppendText(string value, Color color)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, Color>(AppendText), new object[] { value, color }); //Using Invoke instead of BeginInvoke as we can just wait for a synchronous completion in this use case
                return;
            }

            richTextBox_console.SelectionStart = richTextBox_console.TextLength;
            richTextBox_console.SelectionLength = 0;
            richTextBox_console.SelectionColor = color;
            richTextBox_console.AppendText(value);
            richTextBox_console.SelectionColor = richTextBox_console.ForeColor;
        }

        private void btn_kofi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/gandini");
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inProgress = 0;
            try
            {
                //Just in case. Saw a left-over process once and this is just a quick and dirty solution.
                threadForAssistant.Abort();
            }
            catch (Exception)
            {
                //
            }
            
        }
    }
}
