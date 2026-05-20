namespace WheresButtons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Alway consider where keyboard focus is put when the app opens. In this case, by default
            // keyboard focus goes to the first button on the page, which is just fine for this app.
        }

        private async void OnReadMeClicked(object? sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri("https://github.com/gbarkerz/WheresButtons/blob/master/README.md");

                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {
                // An unexpected error occurred. Perhaps no browser is available on the device.
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync(
                Strings.Resources.ResourceManager.GetString("AppTitle"),
                Strings.Resources.ResourceManager.GetString("ButtonClickHappened"),
                Strings.Resources.ResourceManager.GetString("OK"));
        }
    }
}
