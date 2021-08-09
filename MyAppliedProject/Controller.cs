
namespace MyAppliedProject
{
    class Controller
    {
        BaseForm bForm;
        Weather we;
        Market ma;
        Mail ml;
        FileHandler fh;
        Performance pe;

        public Controller(BaseForm bFormIn)
        {
            bForm = bFormIn;
            we = new Weather(this);
            ma = new Market(this);
            ml = new Mail(this);
            fh = new FileHandler(this);
            pe = new Performance(this);
        }

        public void PopUp(string msg)
        {
            bForm.PopMsg(msg);
        }

        //WEATHER.------------------------------------------------------------------------------

        public void WeatherAction(string city)
        {
            we.GetWeather(city);
        }

        public void WeatherReAction(string weather, string condition)
        {
            bForm.SetWeather(weather, condition);
        }

        //MARKET.------------------------------------------------------------------------------

        public void MarketAction(string stock)
        {
            ma.GetMarket(stock);
        }

        public void MarketReAction(string change)
        {
            bForm.SetChange(change);
        }

        //PERFORMANCE.------------------------------------------------------------------------------

        public void PerformanceAction()
        {
            pe.GetPerformance();
        }

        public void PerformanceReAction(int cpu, int ram)
        {
            bForm.SetPerformance(cpu, ram);
        }

        //EMAIL.------------------------------------------------------------------------------

        public void MailLogin(string mail, string user, string pass)
        {
            ml.Login(mail, user, pass);
        }

        public void MailLogout()
        {
            ml.Logout();
        }

        public void MailAction()
        {
            ml.GetEmails();
        }

        public void MailReAction(string f1, string f2, string s1, string s2, string b1, string b2)
        {
            bForm.UpdateMail(f1, f2, s1, s2, b1, b2);
        }

        //FILE.------------------------------------------------------------------------------

        public void FileAction(string element, string content)
        {
            fh.EditXML(element, content);
        }

        public void FileReAction(string rgb, string height, string width, string passCheck, string mail, string gUser, string gPass, string oUser, string oPass, string wCheck, string wCity, string mCheck, string mStock, string pCheck)
        {
            bForm.SetCookieData(rgb, height, width, passCheck, mail, gUser, gPass, oUser, oPass, wCheck, wCity, mCheck, mStock, pCheck);
        }
    }
}
