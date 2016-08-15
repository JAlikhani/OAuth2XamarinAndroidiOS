using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Xamarin.Auth;
using OAuth2XamarinAndroidiOS.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace OAuth2MVVMLoginXamarinAndroidiOS.Droid.Views
{
    [Activity(Label = "LoginView", MainLauncher = true, Icon = "@drawable/icon")]
    public class LoginView : MvxActivity
    {
        private void Alert(string title, string message)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle(title);
            alert.SetMessage(message);
            alert.SetPositiveButton("OK", (senderAlert, args) => {
                //Toast.MakeText(this, "OK...", ToastLength.Short).Show();
            });

            alert.Show();
        }
        /*
        public OAuth1Authenticator _oAuth1;
        public OAuth1Authenticator OAuth1
        {
            get { return _oAuth1; }
            set
            {
                _oAuth1 = value;
                StartActivity(OAuth1.GetUI(this));
                OAuth1.Completed += (object sender, AuthenticatorCompletedEventArgs e) =>
                {
                    if (e.IsAuthenticated) Alert("Authentication", "Authentication Successfully Done");
                };
            }
        }*/
        public OAuth2Authenticator _oAuth2;
        public OAuth2Authenticator OAuth2
        {
            get { return _oAuth2; }
            set
            {
                _oAuth2 = value;
                StartActivity(OAuth2.GetUI(this));
                OAuth2.Completed += (object sender, AuthenticatorCompletedEventArgs e) =>
                {
                    if (e.IsAuthenticated) Alert("Authentication", "Authentication Successfully Done");
                };
            }
        }
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Login);
            //this.CreateBinding().For(v => v.OAuth1).To((LoginViewModel vm) => vm.OAuth1).Apply();
            this.CreateBinding().For(v => v.OAuth2).To((LoginViewModel vm) => vm.OAuth2).Apply();
        }
    }
}
