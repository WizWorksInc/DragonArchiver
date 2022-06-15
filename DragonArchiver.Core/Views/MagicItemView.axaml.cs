using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DragonArchiver.Core.Views;

public partial class MagicItemView : UserControl
{
    public MagicItemView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}