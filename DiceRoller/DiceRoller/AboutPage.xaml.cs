namespace DiceRoller;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void Navegar_Github(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://github.com/MatheusC-jpg");
    }

    private async void Navegar_Github2(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://github.com/Enzin-png");
    }
}