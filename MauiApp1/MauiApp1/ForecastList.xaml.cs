namespace MauiApp1;

public partial class ForecastList : ContentPage
{
	WeatherData forecastData;
	public ForecastList(WeatherData forecastData)
	{
		InitializeComponent();
		this.forecastData = forecastData;
            	forecastList.ItemsSource = forecastData.Daily;
	}

	async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
	{
        	await Navigation.PushAsync(new Forecast(forecastData, args.SelectedItemIndex)); 
    	}

}