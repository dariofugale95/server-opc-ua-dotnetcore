using Newtonsoft.Json;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPCWeatherMap.Models
{
    public class OpenWeatherMapDataClass
    {
        [JsonProperty("coord")]
        public Coordinates Coord { get; set; }
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
        [JsonProperty("base")]
        public String Base { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("dt")]
        public long Dt { get; set; }
        [JsonProperty("sys")]
        public Sys Sys { get; set; }
        [JsonProperty("timezone")]
        public int Timezone { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("cod")]
        public int Cod { get; set; }
    }

    [JsonObject]
    public class Coordinates
    {
        [JsonProperty("lon")]
        public float Longitude { get; set; }
        [JsonProperty("lat")]
        public float Latitude { get; set; }
    }

    [JsonObject]
    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("main")]
        public String Main { get; set; }
        [JsonProperty("description")]
        public String Description { get; set; }
        [JsonProperty("icon")]
        public String Icon { get; set; }
    }

    [JsonObject]
    public class Main
    {
        [JsonProperty("temp")]
        public float Temp { get; set; }
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("temp_min")]
        public float TempMin { get; set; }
        [JsonProperty("temp_max")]
        public float TempMax { get; set; }
    }

    [JsonObject]
    public class Wind
    {
        [JsonProperty("speed")]
        public float Speed { get; set; }
    }

    [JsonObject]
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

    [JsonObject]
    public class Sys
    {
        [JsonProperty("type")]
        public short Type { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("message")]
        public float Message { get; set; }
        [JsonProperty("country")]
        public String Country { get; set; }
        [JsonProperty("sunrise")]
        public String Sunrise { get; set; }
        [JsonProperty("sunset")]
        public String Sunset { get; set; }
    }
}
