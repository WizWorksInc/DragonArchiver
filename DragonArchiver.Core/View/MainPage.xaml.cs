using DragonArchiver.Core.ViewModel;

namespace DragonArchiver.Core.View;

public partial class MainPage : ContentPage
{
    public MainPage(ItemsViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

