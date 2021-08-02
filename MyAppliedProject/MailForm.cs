using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAppliedProject
{ 
    public partial class MailForm : Form
    {
        BaseForm bForm;

        public MailForm(BaseForm bFormIn)
        {
            InitializeComponent();
            bForm = bFormIn;
        }

        public void SetColor(Color c, Color c2)
        {
            signOutBtn.ForeColor = c;
            FromIcon1.BackColor = c;
            FromIcon2.BackColor = c;
            SubjectIcon1.BackColor = c;
            SubjectIcon2.BackColor = c;
            MessageIcon1.BackColor = c;
            MessageIcon2.BackColor = c;
        }

        public void SetEmails(string f1, string f2, string s1, string s2, string b1, string b2)
        {
            FromBox1.Text = f1;
            SubjectBox1.Text = s1;
            MessageBox1.Text = b1;
            FromBox2.Text = f2;
            SubjectBox2.Text = s2;
            MessageBox2.Text = b2;
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            bForm.openLoginForm();
        }
    }
}
