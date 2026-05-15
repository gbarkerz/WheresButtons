namespace WheresButtons
{

// NOTES:
// Button or ImageButton.
// UI not understandbale or perceiable.
// Even if force focus to move in response to a tab (or arrow?) does UIA FocusChanged event get raised. I recently foudn a case where that failed.


    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Alway consider where keyboard focus is put when the app opens. 
            // In this case, by default keyboard focus goes to the first button
            // on the page, which is just fine for this app.
        }

        private void OnReadMeClicked(object? sender, EventArgs e)
        {
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
