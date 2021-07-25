using System;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class LoginForm : Form
    {
        BaseForm bForm;
        string email;
        string gmailUser;
        string gmailPass;
        string outlookUser;
        string outlookPass;
        bool savePass;

        public LoginForm(BaseForm bFormIn)
        {
            InitializeComponent();
            bForm = bFormIn;
            savePass = SaveCheck.Checked;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            bForm.SignIn(UserLoginBox.Text, PassLoginBox.Text, email, savePass);
        }

        public void SetCookieData(string mail, string gUser, string gPass, string oUser, string oPass)
        {
            email = mail;
            gmailUser = gUser;
            gmailPass = gPass;
            outlookUser = oUser;
            outlookPass = oPass;

            switch (email)
            {
                case "gmail":
                    GmailButton.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
                    UserLoginBox.Text = gmailUser;
                    PassLoginBox.Text = gmailPass;
                    break;
                case "outlook":
                    OutlookButton.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
                    UserLoginBox.Text = outlookUser;
                    PassLoginBox.Text = outlookPass;
                    break;
                default:
                    break;
            }
        }

        public void PopMsg()
        {
            MessageBox.Show("Something went wrong!\nMake sure you entered the correct username & password.");
        }

        private void GmailButton_Click(object sender, EventArgs e)
        {
            email = "gmail";
            GmailButton.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            OutlookButton.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            UserLoginBox.Text = gmailUser;
            PassLoginBox.Text = gmailPass;
        }

        private void OutlookButton_Click(object sender, EventArgs e)
        {
            email = "outlook";
            OutlookButton.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
            GmailButton.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            UserLoginBox.Text = outlookUser;
            PassLoginBox.Text = outlookPass;
        }

        private void SaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveCheck.Checked) { savePass = true; }
            else { savePass = false; }
        }
    }
}
