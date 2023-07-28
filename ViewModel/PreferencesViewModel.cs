using CommunityToolkit.Mvvm.ComponentModel;
using PocketManager.Services;

namespace PocketManager.ViewModel;

[ObservableObject]
public partial class PreferencesViewModel
{
    [ObservableProperty]
    private List<Model.Preference>
    preferences;
    private readonly PreferenceService service;
    public PreferencesViewModel()
    {
        service = new();
    }
    public async Task Init()
    {
        Preferences = await service.GetPreferences();
    }
}
