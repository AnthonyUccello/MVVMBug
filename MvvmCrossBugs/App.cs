using System.Globalization;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MvvmCrossBugs
{
    public class App : MvxApplication
    {
        public App()
        {
            //adding comment to test auto build
            string currLang = CultureInfo.CurrentUICulture.Name;
            if (currLang.Contains("fr") || currLang.Contains("Fr"))
            {
                CultureInfo newCultureInfo = new CultureInfo("fr-CA");
                Resources.Culture = newCultureInfo;
            }
        }

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterCustomAppStart<AppStart>();
        }
    }
}