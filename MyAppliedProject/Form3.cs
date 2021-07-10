using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class Form3 : Form
    {
        Form1 fo1;

        public Form3(Form1 fo1In)
        {
            InitializeComponent();
            fo1 = fo1In;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            fo1.SignIn(UserLoginBox.Text, PassLoginBox.Text);
        }

        public void SetCookieData(string gUser, string gPass)
        {
            UserLoginBox.Text = gUser;
            PassLoginBox.Text = gPass;
        }
    }
}
