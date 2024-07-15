//using Java.Lang;
//using Android.Telephony;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    RestService _restService;
    WeatherData weatherData;
    private string starturl;
    NetworkAccess accessType;
    private long change;
    LocationService _locationService;

    public MainPage()
    {
        InitializeComponent();
        _restService = new RestService();
        weatherData = new WeatherData();
        starturl = null;
        change = 0;
        accessType = Connectivity.Current.NetworkAccess;
        _locationService = new LocationService();

    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        if (accessType != NetworkAccess.Internet)
        {
            await Navigation.PushAsync(new ErrorPage("No internet connection!\nRestart the app and try again."));
        }

        starturl = await _locationService.GetCurrentLocation();
        if (!_locationService.hasLocation)
        {
            await Navigation.PushAsync(new ErrorPage(_locationService.errorMessage));
        }
        
        if (weatherData == null || weatherData.Base == null)
        {
            weatherData = await _restService.GetWeatherData(GenerateStartURL(Constants.OpenWeatherMapOneCall));
            weatherData.Current.Dt += weatherData.Timezone_offset;
            if (weatherData.Alerts != null)
            {
                FrameAlerts.IsVisible = true;
            }
            HourlyChange(0);
            BindingContext = weatherData;
        }       
    }

    async void OnGetWeatherButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_cityEntry.Text))
        {
            weatherData = await
                _restService.
                GetWeatherData(GenerateRequestURL(Constants.OpenWeatherMapEndpoint));

            if (weatherData != null)
            {
                await Navigation.PushAsync(new SearchByCityName(weatherData));
            }
            else
            {
                await DisplayAlert("Warning!", "City does not exist", "OK");
                _cityEntry.Text = null;
            }
        }
    }

    async void OnShowForecast(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_cityEntry.Text))
        {
            await Navigation.PushAsync(new ForecastList(weatherData));
        }
        else
        {
            await Navigation.PushAsync(new ForecastList(weatherData));
        }

    }

    void HourlyChange(int i)
    {
        change = weatherData.Hourly[0].Weather[0].Id;
        foreach (var c in weatherData.Hourly)
        {
            if (c.Weather[0].Id != change)
            {
                _expectLabel.IsVisible = true;
                _expectLabel.Text = $"Expected {c.Weather[0].Description} in {i} hours!";
                break;
            }
            i++;
        }
    }    

    string GenerateRequestURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"?q={_cityEntry.Text}";
        requestUri += "&units=metric";
        requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
        return requestUri;
    }

    string GenerateStartURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += starturl;
        requestUri += "&units=metric";
        requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
        return requestUri;
    }

    string GenerateForecastURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"?lat={weatherData.Coord.Lat}&lon={weatherData.Coord.Lon}";
        requestUri += "&units=metric&lang=bg";
        requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
        return requestUri;
    }


}

