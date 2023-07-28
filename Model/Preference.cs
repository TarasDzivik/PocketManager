using CommunityToolkit.Mvvm.ComponentModel;

namespace PocketManager.Model;

[ObservableObject]
public partial class Preference
{
    [ObservableProperty] private string preferencePrompt;
    [ObservableProperty] private string preferenceValue;
}
