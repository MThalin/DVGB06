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

        public void SetWeather(string weather)
        {
            co.WeatherReAction(weather);
        }

        private async void GetWeatherData()
        {
            url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=" + id;

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
                        double kelvin = data.main.temp;
                        double celcius = kelvin - 273.15;
                        double temp = Math.Round(celcius, 1);
                        string weather = temp.ToString();

                        SetWeather(weather);
                    }
                    else
                    {
                        SetWeather("N/A");
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
