using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livestreamer_shell
{
    public partial class homeScreen : Form
    {
        private static string streamIndex;
        private static string checkedButton;
        private static int currentIndex = 0;
        private static List<Process> livestreamerArray = new List<Process>();

        public homeScreen()
        {
            InitializeComponent();
            serviceName.SelectedIndex = 0;
            serviceName.Focus();
            this.streamText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(streamText_KeyPress);
            this.streamText.Enter += new EventHandler(streamText_Enter);
            this.streamText.LostFocus += new EventHandler(streamText_LostFocus);
        }

        private void streamText_LostFocus(object sender, EventArgs e)
        {
            streamText.Text = "Enter Stream Name Here";
            streamText.ForeColor = Color.DarkGray;
        }

        private void streamText_Enter(object sender, EventArgs e)
        {
            streamText.Text = "";
            streamText.ForeColor = Color.Black;
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            streamText.Text = "";
            sourceButton.Checked = true;
            highButton.Checked = false;
            mediumButton.Checked = false;
            lowButton.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("vlc"))
                {
                    process.CloseMainWindow();
                }

                livestreamer_shell.homeScreen.ActiveForm.Close();
            }
            catch (InvalidOperationException excep)
            {
                livestreamer_shell.homeScreen.ActiveForm.Close();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            livestreamerArray.Add(new System.Diagnostics.Process());
            streamIndex = serviceName.SelectedIndex.ToString();
            checkedButton = checkRadioButtons();
            livestreamerArray[currentIndex].StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            livestreamerArray[currentIndex].StartInfo.FileName = "cmd.exe";

            if(!checkedButton.Equals("null"))
            {
                if (streamIndex.Equals("0"))
                {
                    livestreamerArray[currentIndex].StartInfo.Arguments = "/C livestreamer twitch.tv/" + streamText.Text + " " + checkedButton;
                }
                else if (streamIndex.Equals("1"))
                {
                    livestreamerArray[currentIndex].StartInfo.Arguments = "/C livestreamer youtube.com/" + streamText.Text + " " + checkedButton;
                }
                this.WindowState = FormWindowState.Minimized;
                livestreamerArray[currentIndex].Start();
                currentIndex++;
                Thread.Sleep(3000);
                checkForMediaPlayer();
            }
            else
            {
                MessageBox.Show("Please Select a Quality.");
            }
            
        }

        private void checkForMediaPlayer()
        {
            var check = true;
            
            while (check)
            {
                var processes = Process.GetProcessesByName("vlc");
                if (processes.Length == 0)
                {
                    check = false;
                }
            }
            this.WindowState = FormWindowState.Normal;
        }

        private string checkRadioButtons()
        {
            if (sourceButton.Checked == true)
            {                
                return "best";
            }
            else if(highButton.Checked == true)
            {
                return "high";
            }
            else if (mediumButton.Checked == true)
            {
                return "medium";
            }
            else if (lowButton.Checked == true)
            {
                return "worst";
            }
            else
            {
                return "null";
            } 
        }

        private void livestreamer_shell_FormClosed(object sender, FormClosedEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void streamText_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                acceptButton_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
