using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossBugs.ViewModels
{
    public class Name
    {
        public string FullName { get; set; }
    }

    public class SecondViewModel : MvxViewModel
    {
        private string _titleLabel;
        private IMvxNavigationService _navigationService;

        public string TitleLabel
        {
            get => _titleLabel;
            set => SetProperty(ref _titleLabel, value);
        }

        private string _valueLabel;
        public string ValueLabel
        {
            get => _valueLabel;
            set => SetProperty(ref _valueLabel, value);
        }

        public ObservableCollection<Name> Names { get; set; }

        public ICommand NavigateToThirdView { get; }

        public SecondViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            TitleLabel = "This is hello world";
            ValueLabel = "This is value label";

            Names = new ObservableCollection<Name>();

            NavigateToThirdView = new MvxCommand(ExecuteNavigateToThirdView);
        }

        private void ExecuteNavigateToThirdView()
        {
            _navigationService.Navigate<ThirdViewModel>();
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Names.Add(new Name() { FullName = "John Doe" });
            Names.Add(new Name() { FullName = "Jane Doe" });
            Names.Add(new Name() { FullName = "Aggresser Doe" });
        }
    }
}