using Microsoft.Maui.Animations;
using Newtonsoft.Json;

namespace MauiApp1
{
    public class WeatherData
    {
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("cod")]
        public long Cod { get; set; }
        //forecastdata
        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }

        [JsonProperty("cnt")]
        public int Cnt { get; set; }

        [JsonProperty("list")]
        public List<List> List { get; set; }
        //onecall
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public int Timezone_offset { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }

        [JsonProperty("minutely")]
        public List<Minutely> Minutely { get; set; }

        [JsonProperty("hourly")]
        public List<Hourly> Hourly { get; set; }

        [JsonProperty("daily")]
        public List<Daily> Daily { get; set; }

        [JsonProperty("alerts")]
        public List<Alert> Alerts { get; set; }
    }


    public class Clouds
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }

    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class Main//diff
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
        //forecastdata
        [JsonProperty("feels_like")]
        public double Feels_like { get; set; }

        [JsonProperty("sea_level")]
        public int Sea_level { get; set; }

        [JsonProperty("grnd_level")]
        public int Grnd_level { get; set; }

        [JsonProperty("temp_kf")]
        public double Temp_kf { get; set; }
    }

    public class Sys//diff
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("message")]
        public double Message { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        [JsonProperty("sunset")]
        public long Sunset { get; set; }
        //forecastdata
        [JsonProperty("pod")]
        public string Pod { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("main")]
        public string Visibility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Wind//diff
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public long Deg { get; set; }
        //forecastdata
        [JsonProperty("gust")]
        public double Gust { get; set; }
    }
    //forecastdata
    public class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }

    public class List
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("pop")]
        public double Pop { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("dt_txt")]
        public string Dt_txt { get; set; }

        [JsonProperty("rain")]
        public Rain Rain { get; set; }
    }

    public class Rain
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }
    //onecall
    public class Minutely
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("precipitation")]
        public double Precipitation { get; set; }
    }
    public class Hourly
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        public double Feels_like { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("dew_point")]
        public double Dew_point { get; set; }

        [JsonProperty("uvi")]
        public double Uvi { get; set; }

        [JsonProperty("clouds")]
        public int Clouds { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind_speed")]
        public double Wind_speed { get; set; }

        [JsonProperty("wind_deg")]
        public int Wind_deg { get; set; }

        [JsonProperty("wind_gust")]
        public double Wind_gust { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("pop")]
        public double Pop { get; set; }
    }
    public class Daily
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty("sunset")]
        public int Sunset { get; set; }

        [JsonProperty("moonrise")]
        public int Moonrise { get; set; }

        [JsonProperty("moonset")]
        public int Moonset { get; set; }

        [JsonProperty("moon_phase")]
        public double Moon_phase { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("temp")]
        public Temp Temp { get; set; }

        [JsonProperty("feels_like")]
        public FeelsLike Feels_like { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("dew_point")]
        public double Dew_point { get; set; }

        [JsonProperty("wind_speed")]
        public double Wind_speed { get; set; }

        [JsonProperty("wind_deg")]
        public long Wind_deg { get; set; }

        [JsonProperty("wind_gust")]
        public double Wind_gust { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("clouds")]
        public int Clouds { get; set; }

        [JsonProperty("pop")]
        public double Pop { get; set; }

        [JsonProperty("rain")]
        public double Rain { get; set; }

        [JsonProperty("uvi")]
        public double Uvi { get; set; }
    }
    public class Current
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty("sunset")]
        public int Sunset { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        public double Feels_like { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("dew_point")]
        public double Dew_point { get; set; }

        [JsonProperty("uvi")]
        public double Uvi { get; set; }

        [JsonProperty("clouds")]
        public int Clouds { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind_speed")]
        public double Wind_speed { get; set; }

        [JsonProperty("wind_deg")]
        public long Wind_deg { get; set; }

        [JsonProperty("wind_gust")]
        public double Wind_gust { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
    }
    public class Alert
    {
        [JsonProperty("sender_name")]
        public string Sender_name { get; set; }

        [JsonProperty("event")]
        public string @Event { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
    public class Temp
    {
        [JsonProperty("day")]
        public double Day { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("night")]
        public double Night { get; set; }

        [JsonProperty("eve")]
        public double Eve { get; set; }

        [JsonProperty("morn")]
        public double Morn { get; set; }
    }
    public class FeelsLike
    {
        [JsonProperty("day")]
        public double Day { get; set; }

        [JsonProperty("night")]
        public double Night { get; set; }

        [JsonProperty("eve")]
        public double Eve { get; set; }

        [JsonProperty("morn")]
        public double Morn { get; set; }
    }
}
