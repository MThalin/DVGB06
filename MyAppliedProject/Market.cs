using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyAppliedProject
{
    class Market
    {
        Controller co;

        private string url;
        private string id;
        private string stock;

        public Market(Controller coIn)
        {
            co = coIn;
            id = "9c7ddef97dmshd96741f13a5fd7bp16da3djsn25cf8f5c6079";
        }

        public async void GetMarket(string stockIn)
        {
            stock = stockIn;
            await GetMarketData();
        }

        private async Task GetMarketData()
        {
               url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + stock + "&apikey=" + id;

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
                        string valueChange = data["Global Quote"]["09. change"];
                        string percentChange = data["Global Quote"]["10. change percent"];
                        string change = valueChange + " USD (" + percentChange + ")";

                        if (!change.Contains("-")) { change = "+" + change; }

                        co.MarketReAction(change);
                    }
                    else
                    {
                        co.MarketReAction("N/A");
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    co.MarketReAction("N/A");
                }
            }
        }
    }
}
