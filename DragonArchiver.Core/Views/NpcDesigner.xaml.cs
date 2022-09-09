namespace DragonArchiver.Core.Views;

public partial class NpcDesigner : ContentPage
{
	public NpcDesigner()
	{
		InitializeComponent();
        Editor editor = new Editor { Placeholder = "Enter text", HeightRequest = 250 };
        editor.TextChanged += OnTextChanged;
        editor.Completed += OnTextCompleted;
    }

    public void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = editor.Text;
    }

    public void OnTextCompleted(object sender, EventArgs e)
    {
        string text = ((Editor)sender).Text;
    }
}