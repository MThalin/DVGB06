using System;
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

        public void SetEmails(string f1, string f2, string s1, string s2, string b1, string b2)
        {
            textBox1.Text = f1;
            textBox2.Text = s1;
            textBox3.Text = b1;
            textBox4.Text = f2;
            textBox5.Text = s2;
            textBox6.Text = b2;
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            bForm.openLoginForm();
        }
    }
}
