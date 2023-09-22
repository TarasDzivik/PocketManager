using CommunityToolkit.Mvvm.ComponentModel;

namespace PocketManager.ViewModel;
[ObservableObject]
public partial class About_ViewModel
{
    [ObservableProperty] public string apiVersion;

    public About_ViewModel()
    {
        apiVersion = "0.1";
    }
}
