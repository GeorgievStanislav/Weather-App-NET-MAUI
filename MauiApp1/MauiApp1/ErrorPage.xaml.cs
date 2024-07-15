namespace MauiApp1;

public partial class ErrorPage : ContentPage
{
	private string error_message;
	public ErrorPage(string error_message)
	{
		InitializeComponent();
		this.error_message = error_message;
		//error_message = "An error has occured!";
		BindingContext = error_message;
	}

}