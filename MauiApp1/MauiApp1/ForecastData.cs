﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MauiApp1
{
    public class ForecastData
    {
        [JsonProperty("cod")]
        public string Cod { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }

        [JsonProperty("cnt")]
        public int Cnt { get; set; }

        [JsonProperty("list")]
        public List<List> List { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }
    }
        //public class City//new
        //{
        //    [JsonProperty("id")]
        //    public int Id { get; set; }

        //    [JsonProperty("name")]
        //    public string Name { get; set; }

        //    [JsonProperty("coord")]
        //    public Coord Coord { get; set; }

        //    [JsonProperty("country")]
        //    public string Country { get; set; }

        //    [JsonProperty("population")]
        //    public int Population { get; set; }

        //    [JsonProperty("timezone")]
        //    public int Timezone { get; set; }

        //    [JsonProperty("sunrise")]
        //    public int Sunrise { get; set; }

        //    [JsonProperty("sunset")]
        //    public int Sunset { get; set; }
        //}

        //public class Clouds//same
        //{
        //    [JsonProperty("all")]
        //    public int All { get; set; }
        //}

        //public class Coord//same
        //{
        //    [JsonProperty("lat")]
        //    public double Lat { get; set; }

        //    [JsonProperty("lon")]
        //    public double Lon { get; set; }
        //}

        //public class List//new
        //{
        //    [JsonProperty("dt")]
        //    public int Dt { get; set; }

        //    [JsonProperty("main")]
        //    public Main Main { get; set; }

        //    [JsonProperty("weather")]
        //    public List<Weather> Weather { get; set; }

        //    [JsonProperty("clouds")]
        //    public Clouds Clouds { get; set; }

        //    [JsonProperty("wind")]
        //    public Wind Wind { get; set; }

        //    [JsonProperty("visibility")]
        //    public int Visibility { get; set; }

        //    [JsonProperty("pop")]
        //    public double Pop { get; set; }

        //    [JsonProperty("sys")]
        //    public Sys Sys { get; set; }

        //    [JsonProperty("dt_txt")]
        //    public string Dt_txt { get; set; }

        //    [JsonProperty("rain")]
        //    public Rain Rain { get; set; }
        //}

        //public class Main//diff
        //{
        //    [JsonProperty("temp")]
        //    public double Temp { get; set; }

        //    [JsonProperty("feels_like")]
        //    public double Feels_like { get; set; }

        //    [JsonProperty("temp_min")]
        //    public double Temp_min { get; set; }

        //    [JsonProperty("temp_max")]
        //    public double Temp_max { get; set; }

        //    [JsonProperty("pressure")]
        //    public int Pressure { get; set; }

        //    [JsonProperty("sea_level")]
        //    public int Sea_level { get; set; }

        //    [JsonProperty("grnd_level")]
        //    public int Grnd_level { get; set; }

        //    [JsonProperty("humidity")]
        //    public int Humidity { get; set; }

        //    [JsonProperty("temp_kf")]
        //    public double Temp_kf { get; set; }
        //}

        //public class Rain//new
        //{
        //    [JsonProperty("3h")]
        //    public double _3h { get; set; }
        //}

        //public class Root // fake class test
        //{
        //    [JsonProperty("6h")]
        //    public double _6h { get; set; }
        //}

        //public class Sys//diff
        //{
        //    [JsonProperty("pod")]
        //    public string Pod { get; set; }
        //}

        //public class Weather//same
        //{
        //    [JsonProperty("id")]
        //    public int Id { get; set; }

        //    [JsonProperty("main")]
        //    public string Main { get; set; }

        //    [JsonProperty("description")]
        //    public string Description { get; set; }

        //    [JsonProperty("icon")]
        //    public string Icon { get; set; }
        //}

        //public class Wind//diff
        //{
        //    [JsonProperty("speed")]
        //    public double Speed { get; set; }

        //    [JsonProperty("deg")]
        //    public int Deg { get; set; }

        //    [JsonProperty("gust")]
        //    public double Gust { get; set; }
        //}


    
}
