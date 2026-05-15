namespace WheresButtons;

public partial class CustomControl : ContentView
{
    public static readonly BindableProperty AccessibleNameProperty =
        BindableProperty.Create(nameof(AccessibleName), typeof(string), typeof(CustomControl), string.Empty);

    public string AccessibleName
    {
        get { return (string)GetValue(CustomControl.AccessibleNameProperty); }
        set { SetValue(AccessibleNameProperty, value); }
    }

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomControl), string.Empty);

    public string Text
    {
        get { return (string)GetValue(CustomControl.TextProperty); }
        set { SetValue(TextProperty, value); }
    }

    public CustomControl()
	{
		InitializeComponent();
	}

	// This gets called in response to both a tap and a mouse click on the control.
    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var page = App.Current?.Windows[0]?.Page;
        if (page != null)
        {
            await page.DisplayAlertAsync(
                Strings.Resources.ResourceManager.GetString("AppTitle"),
                Strings.Resources.ResourceManager.GetString("CustomControlTapHappened"),
                Strings.Resources.ResourceManager.GetString("OK"));
        }
    }
}
