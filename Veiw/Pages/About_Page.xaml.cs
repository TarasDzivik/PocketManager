using PocketManager.ViewModel;

namespace PocketManager.Veiw.Pages;

public partial class About_Page : ContentPage
{
    public About_Page()
    {
        BindingContext = new About_ViewModel();
        InitializeComponent();
    }
}