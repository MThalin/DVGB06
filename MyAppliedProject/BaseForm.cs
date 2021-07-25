using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class BaseForm : Form
    {
        MailForm mForm;
        LoginForm lForm;
        SettingForm sForm;
        Controller co;
        int movX, movY;
        bool isGrabbing;

        public BaseForm()
        {
            InitializeComponent();
            mForm = new MailForm(this);
            lForm = new LoginForm(this);
            sForm = new SettingForm(this);
            co = new Controller(this, mForm, lForm, sForm);

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

        public void SetWeather(string weather, string condition)
        {
            if (condition == "") { WeatherIcon.Image = null; }
            else if (condition == "Thunderstorm") { WeatherIcon.Image = Properties.Resources.thunder; }
            else if (condition == "Drizzle" || condition == "Rain") { WeatherIcon.Image = Properties.Resources.rain; }
            else if (condition == "Snow") { WeatherIcon.Image = Properties.Resources.snow; }
            else if (condition == "Clear") { WeatherIcon.Image = Properties.Resources.clear; }
            else if (condition == "Clouds") { WeatherIcon.Image = Properties.Resources.clouds; }
            else { WeatherIcon.Image = Properties.Resources.mist; }
            Console.WriteLine(condition);
            WeatherLabel.Text = weather;
        }

        public void SetChange(string change)
        {
            if (change.Contains("-")) { MarketIcon.Image = Properties.Resources.decrease; }
            else { MarketIcon.Image = Properties.Resources.increase; }

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

        public void SignIn(string userIn, string passIn, string mail, bool save)
        {
            switch (mail)
            {
                case "gmail":
                    co.GmailAction(userIn, passIn);
                    co.FileAction("gmailuser", userIn);
                    if (save) { co.FileAction("gmailpass", passIn); }
                    else { co.FileAction("gmailpass", ""); }
                    break;
                case "outlook":
                    co.OutlookAction(userIn, passIn);
                    co.FileAction("outlookuser", userIn);
                    if (save) { co.FileAction("outlookpass", passIn); }
                    else { co.FileAction("outlookpass", ""); }
                    break;
                default:
                    break;
            }

            co.FileAction("chosenmail", mail);
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
            lForm.TopLevel = false;
            lForm.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(lForm);
            lForm.BringToFront();
            lForm.Show();
        }

        public void showWeather(bool weather)
        {
            if (weather) { rightPanelFlow.Controls.Add(weatherPanel); }
            else { rightPanelFlow.Controls.Remove(weatherPanel); }
        }

        public void showMarket(bool stock)
        {
            if (stock) { rightPanelFlow.Controls.Add(tableLayoutPanel2); }
            else { rightPanelFlow.Controls.Remove(tableLayoutPanel2); }
        }

        public void showPerformance(bool performance)
        {
            if (performance) { rightPanelFlow.Controls.Add(tableLayoutPanel3); }
            else { rightPanelFlow.Controls.Remove(tableLayoutPanel3); }
        }

        public void HeightPlus() { this.Size = new Size(this.Width, 800); }

        public void HeightMinus()  { this.Size = new Size(this.Width, 400); }

        public void WidthPlus()
        {
            rightPanel.Enabled = true;
            this.Size = new Size(400, this.Height);
        }

        public void WidthMinus()
        {
            rightPanel.Enabled = false;
            this.Size = new Size(250, this.Height);
        }

        private void MarketButton_Click(object sender, EventArgs e)
        {
            string stock = MarketBox.Text;
            co.MarketAction(stock);
            co.FileAction("marketstock", stock);
        }

        private void PerformanceButton_Click(object sender, EventArgs e)
        {
            co.PerformanceAction();
        }

        public void SetPerformance(int cpu, int ram)
        {
            cpuBar.Value = cpu;
            cpuLabel.Text = "CPU:\n" + cpu.ToString() + "%";

            ramBar.Value = ram;
            ramLabel.Text = "RAM:\n" + ram.ToString() + "%";
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            sForm.BringToFront();
            sForm.Show();
        }

        public void openMailForm()
        {
            mForm.TopLevel = false;
            mForm.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(mForm);
            mForm.BringToFront();
            mForm.Show();
        }
    }
}
