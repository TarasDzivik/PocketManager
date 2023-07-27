using PocketManager.ViewModel;

namespace PocketManager.Veiw.Pages;

public partial class LoginPage : ContentPage
{
    public static ProgressBar LoginProgressBar;
    LoginViewModel vm = new LoginViewModel();
    public LoginPage()
    {
        //LoginProgressBar = new ProgressBar();
        InitializeComponent();
        //LoginStackLayout.Children.Add(LoginProgressBar);
        BindingContext = vm;
    }

    //private async void Submit(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        await DisplayAlert(
    //        "Submit",
    //        $"You entered {vm.Name} and {vm.Password}",
    //        "OK");
    //    }
    //    catch (Exception ex)
    //    {
    //        await DisplayAlert(
    //            "Submit",
    //            $"There was an error \n\t {ex.Message}",
    //            "Ok");
    //    }
    //}

    private async void OnCreate(object sender, EventArgs e)
    {
        try
        {
            CancellationTokenSource token = new CancellationTokenSource();
            // Toast and the Snackbar are doesn't works anywhere except Android (usles)
            //for (double i = 0.0; i < 1.0; i += 0.1)
            //{
            //    await LoginProgressBar.ProgressTo(i, 500,
            //    Easing.Linear);
            //}
            // TODO: Create validation and to check existing email in DB
            CreateAccount.Text = await DisplayPromptAsync(
                    title: "Do you want to create account?",
                    message: "Please enter your email",
                    placeholder: "example@mail.com",
                    keyboard: Keyboard.Email,
                    accept: "OK",
                    cancel: "Cancel");

        }
        catch (Exception ex)
        {
            await DisplayAlert(
                "Submit",
                $"There was an error \n\t {ex.Message}",
                "Ok");
        }
    }

    private async void OnForgotPassword(object sender, EventArgs e)
    {
        try
        {
            CreateAccount.Text = (await DisplayActionSheet(
            "How can we solve this?", // [1] The first parameter is the title.
            "Cancel",                 // [2] The second parameter is the text for the Cancel button.
            null,                     // [3] The third parameter is the text for the OK button. Since we don’t need OK, we pass in null.
            "Get new password",
            "Show me my hint",
            "Delete account"));
        }
        catch (Exception ex)
        {
            await DisplayAlert(
                "Submit",
                $"There was an error \n\t {ex.Message}",
                "Ok");
        }
    }
}
