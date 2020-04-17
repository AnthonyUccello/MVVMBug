using MvvmCross.ViewModels;

namespace MvvmCrossBugs.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private string _titleLabel;
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

        public SecondViewModel()
        {
            TitleLabel = "This is hello world";
            ValueLabel = "This is value label";
        }
    }
}