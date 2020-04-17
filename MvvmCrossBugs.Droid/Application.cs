using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MvvmCrossBugs.Droid
{
    [Application]
    public partial class Application : MvxAppCompatApplication<Setup, App>
    {
        public Application(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {
            System.Diagnostics.Debug.WriteLine("Executing custom application ctor!");
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
        }
    }
}
