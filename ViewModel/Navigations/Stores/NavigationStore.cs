namespace PocketManager.ViewModel.Navigations.Stores;
public class NavigationStore
{
    public event Action CurrentVmChange;

    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel!;
        set
        {
            _currentViewModel = value;
            OnCurrentVmChanged();
        }
    }
    private void OnCurrentVmChanged() => CurrentVmChange?.Invoke();
}
