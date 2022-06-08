using Microsoft.Toolkit.Mvvm.ComponentModel ;

namespace DragonArchiver.Core.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotBusy))]
    private bool _isBusy;

    [ObservableProperty]
    private string _title;

    public bool IsNotBusy => !IsBusy;
}