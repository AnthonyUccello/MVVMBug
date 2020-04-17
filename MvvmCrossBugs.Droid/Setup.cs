using System;
using System.Collections.Generic;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.ViewModels;

namespace MvvmCrossBugs.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override IDictionary<string, string> ViewNamespaceAbbreviations
        {
            get
            {
                var toReturn = base.ViewNamespaceAbbreviations;
                toReturn["mvd"] = "MvvmCrossBugs.Droid";
                return toReturn;
            }
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new App();
            return app;
        }
    }
}
