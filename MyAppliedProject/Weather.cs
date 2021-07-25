using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;


namespace MyAppliedProject
{
    class Weather
    {
        Controller co;

        private string url;
        private string id;
        private string city;

        public Weather(Controller coIn)
        {
            co = coIn;
            id = "6fa49b63cc06c4714a8268fda07fa8e1";
        }

        public void GetWeather(string cityIn)
        {
            city = cityIn;
            GetWeatherData();
        }

        private async void GetWeatherData()
        {
            url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + id;

            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(url);

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string strResult = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(strResult);
                        string condition = data["weather"][0]["main"];
                        double celsius = data.main.temp;
                        double tmp = Math.Round(celsius, 1);
                        string weather = tmp.ToString() + " C";

                        Console.WriteLine(condition);

                        co.WeatherReAction(weather, condition);
                    }
                    else
                    {
                        co.WeatherReAction("N/A", "");
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    co.WeatherReAction("N/A", "");
                }
            }
        }
    }
}
