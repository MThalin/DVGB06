using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class SettingForm : Form
    {
        BaseForm bForm;

        bool weather, stock, performance;
        int movX, movY;
        bool isGrabbing;
        bool isDragging;
        Bitmap bmp;
        Color c;
        Color c2;

        public SettingForm(BaseForm bFormIn)
        {
            InitializeComponent();
            bForm = bFormIn;
            bmp = new Bitmap(ColorBox.BackgroundImage);
        }

        //CUSTOM TITLE BAR.-------------------------------------------------------------------------------

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        //SETTINGS.-------------------------------------------------------------------------------

        public void SetColor(Color c, Color c2)
        {
            ClearBtn.ForeColor = c;
            SaveBtn.ForeColor = c;
            upBtn.ForeColor = c;
            downBtn.ForeColor = c;
            leftBtn.ForeColor = c;
            rightBtn.ForeColor = c;
            WeatherCheck.ForeColor = c;
            MarketCheck.ForeColor = c;
            PerformanceCheck.ForeColor = c;
            closeBtn.ForeColor = c;
            upBtn.BackColor = c;
            downBtn.BackColor = c;
            leftBtn.BackColor = c;
            rightBtn.BackColor = c;

            titlePanel.BackColor = c2;
            closeBtn.BackColor = c2;
        }

        public void SetCookieData(Color col, Color col2, string wCheck, string mCheck, string pCheck)
        {
            c = col;
            c2 = col2;

            if (wCheck == "True") { WeatherCheck.Checked = true; }
            else { WeatherCheck.Checked = false; }

            if (mCheck == "True") { MarketCheck.Checked = true; }
            else { MarketCheck.Checked = false; }

            if (pCheck == "True") { PerformanceCheck.Checked = true; }
            else { PerformanceCheck.Checked = false; }
        }

        //BUTTONS.-------------------------------------------------------------------------------

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bForm.SetColor(c, c2);
            string col = c.R + "," + c.G + "," + c.B;
            bForm.SaveSettings(col, WeatherCheck.Checked, MarketCheck.Checked, PerformanceCheck.Checked);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?\n\nThis will reset all settings to default and delete all saved data, such as email credentials and recent search terms etc..", "Clearing settings and data", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) { bForm.ClearSettings(); }
        }

        //---------------------------

        private void upBtn_Click(object sender, EventArgs e) { bForm.HeightMinus(); }

        private void downBtn_Click(object sender, EventArgs e) { bForm.HeightPlus(); }

        private void rightBtn_Click(object sender, EventArgs e) { bForm.WidthPlus(); }

        private void leftBtn_Click(object sender, EventArgs e) { bForm.WidthMinus(); }

        //CHECKBOXES.-------------------------------------------------------------------------------

        private void WeatherCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WeatherCheck.Checked) { weather = true; }
            else { weather = false; }
            bForm.showWeather(weather);
        }

        private void MarketCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MarketCheck.Checked) { stock = true; }
            else { stock = false; }
            bForm.showMarket(stock);
        }

        private void PerformanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PerformanceCheck.Checked) { performance = true; }
            else { performance = false; }
            bForm.showPerformance(performance);
        }

        //CUSTOM COLOR PICKER.-------------------------------------------------------------------------------

        private void ColorBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;

            c = bmp.GetPixel(e.X, e.Y);
            c2 = Color.FromArgb((int)(c.R * 0.25), (int)(c.G * 0.25), (int)(c.B * 0.25));

            ClearBtn.ForeColor = c;
            SaveBtn.ForeColor = c;
            upBtn.ForeColor = c;
            downBtn.ForeColor = c;
            leftBtn.ForeColor = c;
            rightBtn.ForeColor = c;
            WeatherCheck.ForeColor = c;
            MarketCheck.ForeColor = c;
            PerformanceCheck.ForeColor = c;
            closeBtn.ForeColor = c;
            upBtn.BackColor = c;
            downBtn.BackColor = c;
            leftBtn.BackColor = c;
            rightBtn.BackColor = c;

            titlePanel.BackColor = c2;
            closeBtn.BackColor = c2;
        }

        private void ColorBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                try
                {
                    c = bmp.GetPixel(e.X, e.Y);
                    c2 = Color.FromArgb((int)(c.R * 0.25), (int)(c.G * 0.25), (int)(c.B * 0.25));

                    ClearBtn.ForeColor = c;
                    SaveBtn.ForeColor = c;
                    upBtn.ForeColor = c;
                    downBtn.ForeColor = c;
                    leftBtn.ForeColor = c;
                    rightBtn.ForeColor = c;
                    WeatherCheck.ForeColor = c;
                    MarketCheck.ForeColor = c;
                    PerformanceCheck.ForeColor = c;
                    closeBtn.ForeColor = c;
                    upBtn.BackColor = c;
                    downBtn.BackColor = c;
                    leftBtn.BackColor = c;
                    rightBtn.BackColor = c;

                    titlePanel.BackColor = c2;
                    closeBtn.BackColor = c2;
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        private void ColorBox_MouseUp(object sender, MouseEventArgs e) 
        { 
            isDragging = false; 
        }
    }
}
