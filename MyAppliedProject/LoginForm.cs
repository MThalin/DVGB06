using System;
using System.Drawing;
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

        //SETTINGS.-------------------------------------------------------------------------------

        public void SetColor (Color c, Color c2)
        {          
            signInBtn.ForeColor = c;
            OutlookButton.ForeColor = c;
            GmailButton.ForeColor = c;
        }

        public void SetCookieData(string mail, string passCheck, string gUser, string gPass, string oUser, string oPass)
        {
            email = mail;
            gmailUser = gUser;
            gmailPass = gPass;
            outlookUser = oUser;
            outlookPass = oPass;

            if (passCheck == "True") { SaveCheck.Checked = true; }
            else { SaveCheck.Checked = false; }

            switch (email)
            {
                case "gmail":
                    GmailButton.FlatAppearance.BorderSize = 1;
                    OutlookButton.FlatAppearance.BorderSize = 0;
                    UserLoginBox.Text = gmailUser;
                    PassLoginBox.Text = gmailPass;
                    break;
                case "outlook":
                    OutlookButton.FlatAppearance.BorderSize = 1;
                    GmailButton.FlatAppearance.BorderSize = 0;
                    UserLoginBox.Text = outlookUser;
                    PassLoginBox.Text = outlookPass;
                    break;
                default:
                    break;
            }
        }

        //BUTTONS/CHECKBOX.--------------------------------------------------------------------------

        private void signInBtn_Click(object sender, EventArgs e)
        {
            bForm.SignIn(UserLoginBox.Text, PassLoginBox.Text, email, savePass);
        }

        private void GmailButton_Click(object sender, EventArgs e)
        {
            email = "gmail";
            GmailButton.FlatAppearance.BorderSize = 1;
            OutlookButton.FlatAppearance.BorderSize = 0;
            UserLoginBox.Text = gmailUser;
            PassLoginBox.Text = gmailPass;
        }

        private void OutlookButton_Click(object sender, EventArgs e)
        {
            email = "outlook";
            OutlookButton.FlatAppearance.BorderSize = 1;
            GmailButton.FlatAppearance.BorderSize = 0;
            UserLoginBox.Text = outlookUser;
            PassLoginBox.Text = outlookPass;
        }

        //--------------------------

        private void SaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveCheck.Checked) { savePass = true; }
            else { savePass = false; }
        }
    }
}
