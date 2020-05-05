using System.Collections.Generic;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCrossBugs.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        private string _selectedmode;
        private List<string> _modes;

        public List<string> Modes
        {
            get { return _modes; }
            set
            {
                _modes = value;
                RaisePropertyChanged(() => Modes);
            }
        }

        public string SelectedMode
        {
            get { return _selectedmode; }
            set
            {
                _selectedmode = value;
                RaisePropertyChanged(() => SelectedMode);
            }
        }

        public IMvxCommand<string> SelectCommand { get; }

        public DashboardViewModel()
        {
            Modes = new List<string> { "Item 1", "Item 2", "item 3", "item 4", "item 5", "item 6" };
            SelectCommand = new MvxCommand<string>(ExecuteSelectCommand);
        }

        private void ExecuteSelectCommand(string args)
        {
           SelectedMode = args;
        }
    }
}