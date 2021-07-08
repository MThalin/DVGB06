using System;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class Form1 : Form
    {
        Controller co;
        int movX, movY;
        bool isGrabbing;

        public Form1()
        {
            InitializeComponent();
            co = new Controller(this);

            titlePanel.MouseMove += new MouseEventHandler(this.onMouseMove);
            titlePanel.MouseDown += new MouseEventHandler(this.onMouseDown);
            titlePanel.MouseUp += new MouseEventHandler(this.onMouseUp);
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (isGrabbing) { this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY); }
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            isGrabbing = true;
            movX = e.X;
            movY = e.Y;
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            isGrabbing = false;
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void SetCookieData(string gUser, string gPass, string wCity)
        {
            UserLoginBox.Text = gUser;
            PassLoginBox.Text = gPass;
            WeatherBox.Text = wCity;
        }
    }
}
