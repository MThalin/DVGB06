using System;
using System.Windows.Forms;

namespace MyAppliedProject
{
    public partial class SettingForm : Form
    {
        BaseForm bForm;

        bool height, width;
        bool weather, stock, performance;
        int movX, movY;
        bool isGrabbing;

        public SettingForm(BaseForm bFormIn)
        {
            InitializeComponent();
            bForm = bFormIn;

            titlePanel.MouseMove += new MouseEventHandler(this.onMouseMove);
            titlePanel.MouseDown += new MouseEventHandler(this.onMouseDown);
            titlePanel.MouseUp += new MouseEventHandler(this.onMouseUp);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            height = false;
            bForm.HeightMinus();
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            height = true;
            bForm.HeightPlus();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            width = true;
            bForm.WidthPlus();
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            width = false;
            bForm.WidthMinus();
        }

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
    }
}
