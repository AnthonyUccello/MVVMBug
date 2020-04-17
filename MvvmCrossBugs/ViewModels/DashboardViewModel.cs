using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossBugs.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public string MyProperty { get; set; }

        public string ButtonText { get; set; }

        public IMvxAsyncCommand OpenNewFragment { get; }

        public DashboardViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            MyProperty = "This is dashboard viewmodel property";
            ButtonText = "GO TO";
            OpenNewFragment = new MvxAsyncCommand(ExecuteOpenNewFragmentAsync);
        }

        private async Task ExecuteOpenNewFragmentAsync()
        {
            await _navigationService.Navigate<SecondViewModel>();
        }
    }
}