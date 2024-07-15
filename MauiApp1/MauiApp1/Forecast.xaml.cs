namespace MauiApp1;

public partial class Forecast : ContentPage
{
    RestService _restService;
    WeatherData forecastData;
    private int list_index;
    public Forecast(WeatherData forecastData, int list_index)
    {
        InitializeComponent();
        _restService = new RestService();
        this.forecastData = forecastData;
        this.list_index = list_index;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if(list_index != -1)
        {
            BindingContext = forecastData.Daily[list_index];//works
        }
        
    }

}