

namespace MyAppliedProject
{
    class Controller
    {
        BaseForm bForm;
        MailForm mForm;
        LoginForm lForm;
        SettingForm sForm;
        Weather we;
        Market ma;
        Gmail gm;
        Hotmail hm;
        FileHandler fh;
        Performance pe;

        public Controller(BaseForm bFormIn, MailForm mFormIn, LoginForm lFormIn, SettingForm sFormIn)
        {
            bForm = bFormIn;
            mForm = mFormIn;
            lForm = lFormIn;
            sForm = sFormIn;
            we = new Weather(this);
            ma = new Market(this);
            gm = new Gmail(this);
            hm = new Hotmail(this);
            fh = new FileHandler(this);
            pe = new Performance(this);
        }

        public void WeatherAction(string city)
        {
            we.GetWeather(city);
        }

        public void WeatherReAction(string weather, string condition)
        {
            bForm.SetWeather(weather, condition);
        }

        public void MarketAction(string stock)
        {
            ma.GetMarket(stock);
        }

        public void MarketReAction(string change)
        {
            bForm.SetChange(change);
        }

        public void GmailAction(string user, string pass)
        {
            gm.SetEmails(user, pass);
        }

        public void OutlookAction(string user, string pass)
        {
            hm.SetEmails(user, pass);
        }

        public void GmailReAction(string f1, string f2, string s1, string s2, string b1, string b2)
        {
            mForm.SetEmails(f1, f2, s1, s2, b1, b2);
            bForm.openMailForm();
        }

        public void MailFail()
        {
            lForm.PopMsg();
        }

        public void FileAction(string element, string content)
        {
            fh.EditXML(element, content);
        }

        public void FileReAction(string mail, string gUser, string gPass, string oUser, string oPass, string wCity, string mStock)
        {
            bForm.SetCookieData(wCity, mStock);
            lForm.SetCookieData(mail, gUser, gPass, oUser, oPass);
        }

        public void PerformanceAction()
        {
            pe.GetPerformance();
        }

        public void PerformanceReAction(int cpu, int ram)
        {
            bForm.SetPerformance(cpu, ram);
        }

    }
}
