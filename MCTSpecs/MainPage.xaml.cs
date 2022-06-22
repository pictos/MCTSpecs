namespace MCTSpecs;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void OnCounterClicked(object sender, EventArgs e)
	{
		string size = string.Empty,
			density = string.Empty;
#if ANDROID
		var ctx = this.Handler.MauiContext.Context;
		size = MainActivity.GetSizeName(ctx);
		density = MainActivity.GetDeviceDensity(ctx);
#endif
		var result = $"Size: {size}, DPI: {density}";
		await DisplayAlert("Values", result, "Ok");
		lbl.Text = result;
		lbl.WidthRequest = 2000;
		lbl.TextColor = Colors.White;
	}
}
