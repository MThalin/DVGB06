

namespace MyAppliedProject
{
    class Controller
    {
        Form1 fo1;
        Form2 fo2;
        Form3 fo3;
        Weather we;
        Gmail gm;
        FileHandler fh;

        public Controller(Form1 fo1In, Form2 fo2In, Form3 fo3In)
        {
            fo1 = fo1In;
            fo2 = fo2In;
            fo3 = fo3In;
            we = new Weather(this);
            gm = new Gmail(this);
            fh = new FileHandler(this);
        }

        public void WeatherAction(string city)
        {
            we.GetWeather(city);
        }

        public void WeatherReAction(string weather)
        {
            fo1.SetWeather(weather);
        }

        public void GmailAction(string user, string pass)
        {
            gm.SetEmails(user, pass);
        }

        public void GmailReAction(string f1, string f2, string s1, string s2, string b1, string b2)
        {
            fo2.SetEmails(f1, f2, s1, s2, b1, b2);
        }

        public void FileAction(string element, string content)
        {
            fh.EditXML(element, content);
        }

        public void FileReAction(string gUser, string gPass, string wCity)
        {
            fo1.SetCookieData(wCity);
            fo3.SetCookieData(gUser, gPass);
        }

    }
}
