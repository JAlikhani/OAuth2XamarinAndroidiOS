using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using OAuth2XamarinAndroidiOS.Services;
using OAuth2XamarinAndroidiOS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2MVVMLoginXamarinAndroidiOS
{ 
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ILogin, Login>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<LoginViewModel>());
        }
    }
}
