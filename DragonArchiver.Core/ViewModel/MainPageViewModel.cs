using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Serilog;

namespace DragonArchiver.Core.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private string _name;
    [ObservableProperty] private string _type;

    public MainPageViewModel(string name, string type)
    {
	    _name = name;
	    _type = type;
    }

    [ICommand]
    private void Populate()
    {
        try
        {

        }
        catch (Exception e)
        {
            Log.Error("[ERROR]: {e}", e);
            throw;
        }
    }
}