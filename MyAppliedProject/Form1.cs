using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class Form1 : Form
    {
        Form1 fo1;
        Form2 fo2;
        Form3 fo3;
        Controller co;
        int movX, movY;
        bool isGrabbing;

        public Form1()
        {
            InitializeComponent();
            fo1 = this;
            fo2 = new Form2(this);
            fo3 = new Form3(this);
            co = new Controller(this, fo2, fo3);

            titlePanel.MouseMove += new MouseEventHandler(this.onMouseMove);
            titlePanel.MouseDown += new MouseEventHandler(this.onMouseDown);
            titlePanel.MouseUp += new MouseEventHandler(this.onMouseUp);

            openLoginForm();
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
            WeatherLabel.Text = weather;
        }

        public void SetChange(string change)
        {
            MarketLabel.Text = change;
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

        public void SignIn(string userIn, string passIn)
        {
            string user = userIn;
            string pass = passIn;
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

        public void SetCookieData(string wCity, string mStock)
        {
            WeatherBox.Text = wCity;
            MarketBox.Text = mStock;
        }

        public void openLoginForm ()
        {
            fo3.TopLevel = false;
            fo3.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(fo3);
            fo3.BringToFront();
            fo3.Show();
        }

        private void weatherCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (weatherCheck.Checked) { rightPanelFlow.Controls.Add(weatherPanel); }
            else { rightPanelFlow.Controls.Remove(weatherPanel); }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { rightPanelFlow.Controls.Add(tableLayoutPanel2); }
            else { rightPanelFlow.Controls.Remove(tableLayoutPanel2); }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { rightPanelFlow.Controls.Add(tableLayoutPanel3); }
            else { rightPanelFlow.Controls.Remove(tableLayoutPanel3); }
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Enabled = true;
            this.Size = new Size(400,this.Height);
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Enabled = false;
            this.Size = new Size(250, this.Height);
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, 400);
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, 800);
        }

        private void MarketButton_Click(object sender, EventArgs e)
        {
            string stock = MarketBox.Text;
            co.MarketAction(stock);
            co.FileAction("marketstock", stock);
        }

        public void openMailForm()
        {
            fo2.TopLevel = false;
            fo2.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(fo2);
            fo2.BringToFront();
            fo2.Show();
        }
    }
}
