using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Core.ViewModels;

namespace OAuth2MVVMLoginXamarinAndroidiOS.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
            : base(appDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}