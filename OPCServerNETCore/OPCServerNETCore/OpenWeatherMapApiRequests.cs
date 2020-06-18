using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Quickstarts.MyOPCServer
{
    public class OpenWeatherMapApiRequests
    {
        public OpenWeatherMapApiRequests()
        {
        }

        public async Task<OpenWeatherMapDataClass> GetWeatherDataByCity()
        {
            var client = new RestClient("https://community-open-weather-map.p.rapidapi.com/weather?q=Catania");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f4d458d83cmshf1ccd0cc1563d40p12950djsn0c85cecdac60");
            IRestResponse response = await Task.Run(() => client.Execute(request));
            OpenWeatherMapDataClass openWeatherMapData = JsonConvert.DeserializeObject<OpenWeatherMapDataClass>(response.Content);
            return openWeatherMapData;
        }
    }
}
