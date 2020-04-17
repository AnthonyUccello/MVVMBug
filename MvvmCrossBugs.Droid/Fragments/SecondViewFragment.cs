using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCrossBugs.ViewModels;

namespace MvvmCrossBugs.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(DashboardViewModel),
         Resource.Id.phone_main_region, true)]
    [Register("MvvmCrossBugs.Droid.Fragments.SecondView")]
    public class SecondViewFragment_ : MvxFragment<SecondViewModel>
    {
        private View _view;
        private TextView _textView3;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            this.EnsureBindingContextIsSet(inflater);

            _view = this.BindingInflate(Resource.Layout.SecondViewLayout, null);

            Init();
            return _view;
        }

        private void Init()
        {
            _textView3 = _view.FindViewById<TextView>(Resource.Id.MyId3);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            // Fluent Binding, this binding works fine. 
            var set = this.CreateBindingSet<SecondViewFragment_, SecondViewModel>();
            set.Bind(_textView3).For(v => v.Text).To(vm => vm.ValueLabel);

            set.Apply();

        }
    }
}
