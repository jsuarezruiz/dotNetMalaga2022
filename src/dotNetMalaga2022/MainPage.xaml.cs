using dotNetMalaga2022.Views;

namespace dotNetMalaga2022;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnBorderClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BorderView());
	}

    async void OnShadowsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShadowsView());
    }

    async void OnDesktopClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DesktopView());
    }
}

