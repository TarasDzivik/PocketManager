using PocketManager.ViewModel;

namespace PocketManager.Veiw.Pages;

public partial class LoginPage : ContentPage
{
    public static ProgressBar LoginProgressBar;
    public static Label CreateAccount;
    LoginViewModel vm = new LoginViewModel();
    public LoginPage()
    {
        LoginProgressBar = new ProgressBar();
        CreateAccount = new Label();
        InitializeComponent();
        LoginStackLayout.Children.Add(LoginProgressBar);
        BindingContext = vm;
    }
}
