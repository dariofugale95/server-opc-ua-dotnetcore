using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OPCWeatherMap.Models;
using RestSharp;

namespace OPCWeatherMap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("HomeController/SendRequest")]
        public async Task<IActionResult> SendRequest()
        {
            var client = new RestClient("https://community-open-weather-map.p.rapidapi.com/weather?q=Catania");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "community-open-weather-map.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f4d458d83cmshf1ccd0cc1563d40p12950djsn0c85cecdac60");
            IRestResponse response = await Task.Run(() => client.Execute(request));
            OpenWeatherMapDataClass openWeatherMapData = JsonConvert.DeserializeObject<OpenWeatherMapDataClass>(response.Content);
            return View(openWeatherMapData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
