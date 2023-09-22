using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PocketManager.ViewModel;
[ObservableObject]
internal partial class Login_ViewModel
{
    #region Observable Properties
    [ObservableProperty] private string name;
    [ObservableProperty] private string password;
    [ObservableProperty] private string email;
    [ObservableProperty] private bool activityIndicatorIsRunning = true;

    #endregion

    #region Commands
    [RelayCommand]
    private async void LogIn()
    {
        for (var i = 0.0; i < 1.0; i += 0.1)
        {
            await Veiw.Pages.Login_Page.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
        }

        await Application.Current.MainPage.DisplayAlert(
        "Submit",
        $"You entered {Name} and {Password}",
        "OK");
    }

    [RelayCommand]
    private async void SignUp()
    {
        try
        {
            for (double i = 0.0; i < 1.0; i += 0.1)
            {
                await Veiw.Pages.Login_Page.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
            }

            await Application.Current.MainPage.DisplayAlert(
            "Submit",
            $"You entered {Name} and {Password}",
            "OK");
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert(
                "Submit",
                $"There was an error \n\t {ex.Message}",
                "Ok");
        }
    }

    [RelayCommand]
    private async void ForgotPassword()
    {
        try
        {
            Veiw.Pages.Login_Page.CreateAccount.Text = (await Application.Current.MainPage.DisplayActionSheet(
            "How can we solve this?", // [1] The first parameter is the title.
            "Cancel",                 // [2] The second parameter is the text for the Cancel button.
            null,                     // [3] The third parameter is the text for the OK button. Since we don’t need OK, we pass in null.
            "Get new password",
            "Show me my hint",
            "Delete account"));
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert(
                "Submit",
                $"There was an error \n\t {ex.Message}",
                "Ok");
        }
    }
    #endregion
}
