using System.Reactive.Disposables;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace DragonArchiver.Core.Samples;

public partial class DirectAuthView : ReactiveUserControl<DirectAuthViewModel>
{
    //private ProgressBar LoginProgress => this.FindControl<ProgressBar>("LoginProgress");
    public DirectAuthView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        this.WhenActivated(disposables =>
        {
            this.WhenAnyObservable(x => x.ViewModel!.Login.IsExecuting)
                .BindTo(this, x => x.LoginProgress.IsVisible)
                .DisposeWith(disposables);
        });
    }
}