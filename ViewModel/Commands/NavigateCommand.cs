using PocketManager.ViewModel.Commands.Abstract;
using PocketManager.ViewModel.Navigations.Stores;

namespace PocketManager.ViewModel.Commands;
public class NavigateCommand<TVM> : CommandBase where TVM : ViewModelBase
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<TVM> _createVM;
    public NavigateCommand(NavigationStore navigationStore, Func<TVM> CreateVM)
    {
        _navigationStore = navigationStore;
        _createVM = CreateVM;
    }

    public override void Execute(object? parameter) => _navigationStore.CurrentViewModel = _createVM();

}
