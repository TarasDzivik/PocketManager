using PocketManager.ViewModel;

namespace PocketManager.Veiw.Pages;

public partial class Login_Page : ContentPage
{
    public static ProgressBar LoginProgressBar;
    public static Label CreateAccount;
    Login_ViewModel vm = new Login_ViewModel();
    public Login_Page()
    {
        LoginProgressBar = new ProgressBar();
        CreateAccount = new Label();
        InitializeComponent();
        LoginStackLayout.Children.Add(LoginProgressBar);
        BindingContext = vm;
    }

    // TODO: to fix the margins/padding/ colours
    // TODO: implement loggining to the applicattion with the adding new user to the Database
}