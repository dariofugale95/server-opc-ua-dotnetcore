using Newtonsoft.Json;
using Opc.Ua;
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

        public OpenWeatherMapDataClass GetWeatherDataByCity(string city)
        {
            var client = new RestClient("https://community-open-weather-map.p.rapidapi.com/weather?q=" + "" + city);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", Properties.Resources.apiKey1);
            IRestResponse response = client.Execute(request);
            Console.WriteLine("Response of ApiRequest to OpenWeatherMapData: "+response.StatusCode);
            if (response.StatusCode != System.Net.HttpStatusCode.OK) {
                Console.WriteLine("Api Request to OpenWeatherMapData is failed");
                return null;
            }
            OpenWeatherMapDataClass openWeatherMapData = JsonConvert.DeserializeObject<OpenWeatherMapDataClass>(response.Content);
            return openWeatherMapData;
        }
    }
}