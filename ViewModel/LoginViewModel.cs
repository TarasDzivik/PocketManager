using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PocketManager.Veiw.Pages;

namespace PocketManager.ViewModel;
[ObservableObject]
internal partial class LoginViewModel
{
    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string password;

    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private bool activityIndicatorIsRunning = true;


    [RelayCommand]
    private async void Submit()
    {
        for (var i = 0.0; i < 1.0; i += 0.1)
        {
            await LoginPage.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
        }

        await Application.Current.MainPage.DisplayAlert(
        "Submit",
        $"You entered {Name} and {Password}",
        "OK");
    }
}
