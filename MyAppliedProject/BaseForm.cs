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
        string time;

        public BaseForm()
        {
            InitializeComponent();
            mForm = new MailForm(this);
            lForm = new LoginForm(this);
            sForm = new SettingForm(this);
            co = new Controller(this);

            time = DateTime.Now.ToString("HH:mm");
            TimeLabel.Text = time;

            openLoginForm();
            WeatherIcon.Hide();
            MarketIcon.Hide();
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            isGrabbing = true;
            movX = e.X;
            movY = e.Y;
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isGrabbing) { this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY); }
        }

        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isGrabbing = false;
        }

        public void SaveSettings(string c, bool wc, bool mc, bool pc)
        {
            co.FileAction("rgb", c);
            co.FileAction("weathercheck", wc.ToString());
            co.FileAction("marketcheck", mc.ToString());
            co.FileAction("performancecheck", pc.ToString());
            co.FileAction("height", this.Height.ToString());
            co.FileAction("width", this.Width.ToString());
        }

        public void ClearSettings()
        {
            co.FileAction("reset", "");
        }

        public void SetColor (Color c, Color c2)
        {
            TimeLabel.ForeColor = c;
            WeatherButton.BackColor = c;
            WeatherIcon.BackColor = c;
            WeatherLabel.ForeColor = c;
            MarketButton.BackColor = c;
            MarketIcon.BackColor = c;
            MarketLabel.ForeColor = c;
            cpuLabel.ForeColor = c;
            ramLabel.ForeColor = c;
            SettingsBtn.ForeColor = c;
            closeBtn.ForeColor = c;
            minBtn.ForeColor = c;

            titlePanel.BackColor = c2;
            SettingsBtn.BackColor = c2;
            closeBtn.BackColor = c2;
            minBtn.BackColor = c2;
            cpuBar.ForeColor = c2;
            ramBar.ForeColor = c2;

            lForm.SetColor(c, c2);
            mForm.SetColor(c, c2);
            sForm.SetColor(c, c2);
        }

        public void SetWeather(string weather, string condition)
        {
            WeatherIcon.Show();

            if (condition == "") { WeatherIcon.Image = null; WeatherIcon.Hide(); }
            else if (condition == "Thunderstorm") { WeatherIcon.Image = Properties.Resources.thunder; }
            else if (condition == "Drizzle" || condition == "Rain") { WeatherIcon.Image = Properties.Resources.rain; }
            else if (condition == "Snow") { WeatherIcon.Image = Properties.Resources.snow; }
            else if (condition == "Clear") { WeatherIcon.Image = Properties.Resources.clear; }
            else if (condition == "Clouds") { WeatherIcon.Image = Properties.Resources.clouds; }
            else { WeatherIcon.Image = Properties.Resources.mist; }

            WeatherLabel.Text = weather;
        }

        public void SetChange(string change)
        {
            MarketIcon.Show();

            if (change == "N/A") { MarketIcon.Image = null; MarketIcon.Hide(); }
            else if (change.Contains("-")) { MarketIcon.Image = Properties.Resources.decrease; }
            else { MarketIcon.Image = Properties.Resources.increase; }

            MarketLabel.Text = change;
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            string city = WeatherBox.Text;
            co.WeatherAction(city);
            co.FileAction("weathercity", city);
            weatherTimer.Start();
        }

        public void SignIn(string userIn, string passIn, string mail, bool save)
        {
            try {

                co.MailLogin(mail, userIn, passIn);

                switch (mail)
                {
                    case "gmail":
                        co.FileAction("gmailuser", userIn);
                        if (save) { co.FileAction("gmailpass", passIn); }
                        else { co.FileAction("gmailpass", ""); }
                        break;

                    case "outlook":
                        co.FileAction("outlookuser", userIn);
                        if (save) { co.FileAction("outlookpass", passIn); }
                        else { co.FileAction("outlookpass", ""); }
                        break;

                    default:
                        break;
                }

                co.MailAction();
                openMailForm();
                co.FileAction("chosenmail", mail);
                co.FileAction("passcheck", save.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                PopMsg("Something went wrong!\nMake sure you entered the correct username & password.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void SetCookieData(string rgb, string height, string width, string passCheck, string mail, string gUser, string gPass, string oUser, string oPass, string wCheck, string wCity, string mCheck, string mStock, string pCheck)
        {
            Color col = Color.FromArgb(Convert.ToInt32(rgb.Split(',')[0]), Convert.ToInt32(rgb.Split(',')[1]), Convert.ToInt32(rgb.Split(',')[2]));
            Color col2 = Color.FromArgb((int)(col.R * 0.25), (int)(col.G * 0.25), (int)(col.B * 0.25));
            SetColor(col, col2);

            if (width == "400") { rightPanel.Enabled = true; }
            else { rightPanel.Enabled = false; }
            this.Size = new Size(Convert.ToInt32(width), Convert.ToInt32(height));
            WeatherBox.Text = wCity;
            MarketBox.Text = mStock;
            if (wCheck == "True") { showWeather(true); }
            else { showWeather(false); }
            if (mCheck == "True") { showMarket(true); }
            else { showMarket(false); }
            if (pCheck == "True") { showPerformance(true); }
            else { showPerformance(false); }

            lForm.SetCookieData(mail, passCheck, gUser, gPass, oUser, oPass);
            sForm.SetCookieData(col, col2, wCheck, mCheck, pCheck);
        }

        public void openLoginForm ()
        {
            lForm.TopLevel = false;
            lForm.Dock = DockStyle.Fill;
            leftPanel.Controls.Add(lForm);
            lForm.BringToFront();
            lForm.Show();
            mailTimer.Stop();
        }

        public void showWeather(bool weather)
        {
            if (weather) 
            { 
                rightPanelFlow.Controls.Add(weatherPanel);
            }
            else 
            { 
                rightPanelFlow.Controls.Remove(weatherPanel);
                weatherTimer.Stop();
            }
        }

        public void showMarket(bool stock)
        {
            if (stock) { rightPanelFlow.Controls.Add(tableLayoutPanel2); }
            else { rightPanelFlow.Controls.Remove(tableLayoutPanel2); }
        }

        public void showPerformance(bool performance)
        {
            if (performance) 
            { 
                rightPanelFlow.Controls.Add(tableLayoutPanel3);
                performanceTimer.Start();
            }
            else 
            { 
                rightPanelFlow.Controls.Remove(tableLayoutPanel3);
                performanceTimer.Stop();
            }
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
            mailTimer.Start();
        }

        public void UpdateMail(string f1, string f2, string s1, string s2, string b1, string b2)
        {
            mForm.SetEmails(f1, f2, s1, s2, b1, b2);
        }

        private void watchTimer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("HH:mm");
            TimeLabel.Text = time;
        }

        private void weatherTimer_Tick(object sender, EventArgs e)
        {
            co.WeatherAction("update");
        }

        private void performanceTimer_Tick(object sender, EventArgs e)
        {
            co.PerformanceAction();
        }

        private void mailTimer_Tick(object sender, EventArgs e)
        {
            co.MailAction();
        }

        public void PopMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
