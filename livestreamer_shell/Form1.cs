using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            streamText.Text = "";
            sourceButton.Checked = false;
            highButton.Checked = false;
            mediumButton.Checked = false;
            lowButton.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < livestreamerArray.Count; i++)
                {
                    livestreamerArray[i].StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    livestreamerArray[i].CloseMainWindow();
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
            }
            else
            {
                MessageBox.Show("Please Select a Quality.");
            }
            
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
    }
}
