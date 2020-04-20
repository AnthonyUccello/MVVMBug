using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCrossBugs.ViewModels;

namespace MvvmCrossBugs.Droid.Fragments
{
    [MvxFragmentPresentation(
        typeof(DashboardViewModel),
        Resource.Id.phone_main_region,
        true)]
    [Register("MvvmCrossBugs.Droid.Fragments.ThirdView")]
    public class ThirdViewFragment_ : MvxFragment<ThirdViewModel>
    {
        private View _view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            this.EnsureBindingContextIsSet(inflater);

            _view = this.BindingInflate(Resource.Layout.ThirdViewLayout, null);

            return _view;
        }
    }
}