using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPCServerNETCore.Application
{

    public class Example
    {        
        public void funziona()
        {
            var client = new RestClient("https://community-open-weather-map.p.rapidapi.com/weather?callback=test&id=2172797&units=%2522metric%2522%20or%20%2522imperial%2522&mode=xml%252C%20html&q=Catania%252Cit");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f4d458d83cmshf1ccd0cc1563d40p12950djsn0c85cecdac60");
            IRestResponse response = client.Execute(request);
        }
    }
}
