using System;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class Form1 : Form
    {
        Controller co;

        public Form1()
        {
            InitializeComponent();
            co = new Controller(this);
        }

        public void SetWeather(string weather)
        {
            WeatherLabel.Text = weather + " C";
        }

        private void TempButton_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm");
            TimeLabel.Text = time;
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            string city = WeatherBox.Text;
            co.WeatherAction(city);
            co.FileAction("weathercity", city);
        }

        public void SetEmails(string f1, string f2, string f3, string s1, string s2, string s3, string b1, string b2, string b3)
        {
            textBox1.Text = f1;
            textBox2.Text = s1;
            textBox3.Text = b1;
            textBox4.Text = f2;
            textBox5.Text = s2;
            textBox6.Text = b2;
            textBox7.Text = f3;
            textBox8.Text = s3;
            textBox9.Text = b3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = UserLoginBox.Text;
            string pass = PassLoginBox.Text;
            co.GmailAction(user, pass);
            co.FileAction("gmailuser", user);
            co.FileAction("gmailpass", pass);
        }

        public void SetCookieData(string gUser, string gPass, string wCity)
        {
            UserLoginBox.Text = gUser;
            PassLoginBox.Text = gPass;
            WeatherBox.Text = wCity;
        }
    }
}
