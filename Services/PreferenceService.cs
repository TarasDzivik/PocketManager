using PocketManager.Model;

namespace PocketManager.Services;
/// <summary>
/// In time, our PreferenceService's GetPreferences method will call into our API to
/// get the list of preferences from our database, which will be stored in the cloud.
/// For now, it will call GetPreferencesMock, which will handcraft the list and return it to us.
/// </summary>
public class PreferenceService
{
    public async Task<List<Preference>> GetPreferences()
    {
        return await GetPreferencesMock();
    }
    private async Task<List<Preference>> GetPreferencesMock()
    {
        List<Preference> preferences = new()
        {
            new Preference()
            {
                PreferencePrompt = "Shirt Size",
                PreferenceValue = ""
            },
            new Preference()
            {
                PreferencePrompt = "Favorite Music Genre",
                PreferenceValue = ""
            },
            new Preference()
            {
                PreferencePrompt = "Favorite Color",
                PreferenceValue = ""
            },
            new Preference()
            {
                PreferencePrompt = "Favorite Food",
                PreferenceValue = ""
            },
            new Preference()
            {
                PreferencePrompt = "Favorite Movie",
                PreferenceValue = ""
            },
        };
        return preferences;
    }
}
