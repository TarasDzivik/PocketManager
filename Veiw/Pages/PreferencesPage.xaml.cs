using PocketManager.ViewModel;

namespace PocketManager.Veiw.Pages;

public partial class PreferencesPage : ContentPage
{
    private PreferencesViewModel vm;
    public PreferencesPage()
    {
        vm = new PreferencesViewModel();
        BindingContext = vm;
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await vm.Init();
    }

    public void SavePreferences(object sender, EventArgs e)
    {
        ShowToast();
    }
    private async Task ShowToast()
    {

        //var cancellationTokenSource = new
        //CancellationTokenSource();
        //var message = "Your preferences were saved";
        //ToastDuration duration = ToastDuration.Short;
        //var fontSize = 14;
        //var toast = Toast.Make(message, duration,
        //fontSize);
        //await toast.Show(cancellationTokenSource.Token);
    }
}