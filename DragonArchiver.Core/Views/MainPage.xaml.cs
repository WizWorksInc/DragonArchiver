namespace DragonArchiver.Core.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


	private void NpcDesignerRedirect_Clicked(object sender, EventArgs e)
	{
        // switch the current page to the NpcDesigner page
        Navigation.PushAsync(new NpcDesigner());
    }

    //private void NpcDesignerRedirect_Clicked(object sender, EventArgs e) => Application.Current.MainPage = new NavigationPage(new NpcDesigner());
}

