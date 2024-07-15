using System;

namespace MauiApp1;

public partial class SearchByCityName : ContentPage
{

    RestService _restService;
    WeatherData weatherData;
    
    public SearchByCityName(WeatherData weatherData)
	{
		InitializeComponent();
        	this.weatherData = weatherData;
        	_restService = new RestService();
    	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (weatherData != null || weatherData.Base != null)
        {
            BindingContext = weatherData;
        }
          
    }


    async void DailyForecast(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForecastList(weatherData));
    }

    async void OnGetWeatherButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_cityEntry.Text))
        {
            weatherData = await
                _restService.
                GetWeatherData(GenerateRequestURL(Constants.OpenWeatherMapEndpoint));
            
            if (weatherData == null)
            {
                await DisplayAlert("Warning!", "City does not exist", "OK");
                _cityEntry.Text = null;
            }
            else
            {
                BindingContext = weatherData;
            }
        }
    }

    string GenerateStartURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += "&units=metric";
        requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
        return requestUri;
    }
    string GenerateRequestURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"?q={_cityEntry.Text}";
        requestUri += "&units=metric";
        requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
        return requestUri;
    }


}