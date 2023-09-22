using CommunityToolkit.Mvvm.ComponentModel;
using PocketManager.Services;

namespace PocketManager.ViewModel;

[ObservableObject]
public partial class Preferences_ViewModel
{
    [ObservableProperty]
    private List<Model.Preference>
    preferences;
    private readonly PreferenceService service;
    public Preferences_ViewModel()
    {
        service = new();
    }
    public async Task Init()
    {
        Preferences = await service.GetPreferences();
    }
}
