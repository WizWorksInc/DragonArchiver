using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DragonArchiver.Core.Services;
using DragonArchiver.Core.ViewModels;
using DragonArchiver.Core.Views;

namespace DragonArchiver.Core
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new ItemsViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}