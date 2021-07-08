

namespace MyAppliedProject
{
    class Controller
    {
        Form1 f1;
        Form2 f2;
        Weather we;
        Gmail gm;
        FileHandler fh;

        public Controller(Form1 formIn)
        {
            f1 = formIn;
            f2 = new Form2(this);
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
            f1.SetWeather(weather);
        }

        public void GmailAction(string user, string pass)
        {
            gm.SetEmails(user, pass);
        }

        public void GmailReAction(string f1, string f2, string f3, string s1, string s2, string s3, string b1, string b2, string b3)
        {
            f1.SetEmails(f1, f2, f3, s1, s2, s3, b1, b2, b3);
        }

        public void FileAction(string element, string content)
        {
            fh.EditXML(element, content);
        }

        public void FileReAction(string gUser, string gPass, string wCity)
        {
            f1.SetCookieData(gUser, gPass, wCity);
        }

    }
}
