using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCrossBugs.Droid.Fragments;
using MvvmCrossBugs.ViewModels;

namespace MvvmCrossBugs.Droid.Activities
{
    [Activity(Label = "DashboardActivity")]
    public class DashboardView : MvxAppCompatActivity<DashboardViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainLayout);
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();

            var dashboardFrag = new DashboardViewFragment_
            {
                ViewModel = ViewModel
            };
            Show(dashboardFrag);
        }

        public void Show(MvxFragment fragment)
        {
            var ft = FragmentManager.BeginTransaction();

            ft.Replace(Resource.Id.phone_main_region, fragment);

            ft.Commit();
        }
    }
}
