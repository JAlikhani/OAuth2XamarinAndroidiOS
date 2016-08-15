using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using OAuth2MVVMLoginXamarinAndroidiOS.Services;
using OAuth2XamarinAndroidiOS.ViewModels;
using System;

using UIKit;
using Xamarin.Auth;

namespace OAuth2MVVMLoginXamarinAndroidiOS.iOS.Views
{
    public partial class LoginView : MvxViewController<LoginViewModel>
    {
        private void Alert(string title, string message)
        {
            DismissViewController(true, null);
            UIAlertView alert = new UIAlertView()
            {
                Title = title,
                Message = message
            };
            alert.AddButton("OK");
            alert.Show();
        }

        /*public OAuth1Authenticator _oAuth1;
        public OAuth1Authenticator OAuth1
        {
            get { return _oAuth1; }
            set
            {
                _oAuth1 = value;
                PresentViewController(OAuth1.GetUI(), true, null);
                OAuth1.Completed += (object sender, AuthenticatorCompletedEventArgs e) =>
                {
                    DismissModalViewController(false);
                    if (e.IsAuthenticated) Alert("Authentication", "Authentication Successfully Done");
                };
            }
        }*/
        public OAuth2Authenticator _oAuth2;
        public OAuth2Authenticator OAuth2
        {
            get { return _oAuth2; }
            set {
                _oAuth2 = value;
                PresentViewController(OAuth2.GetUI(), true, null);
                OAuth2.Completed += (object sender, AuthenticatorCompletedEventArgs e) =>
                {
                    DismissModalViewController(false);
                    if (e.IsAuthenticated) Alert("Authentication", "Authentication Successfully Done");
                };
            }
        }
        public LoginView() : base("LoginView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.SetNavigationBarHidden(true, true);

            this.CreateBinding(UsernameLabel).To((LoginViewModel vm) => vm.UsernameLabel).Apply();
            this.CreateBinding(UsernameTextField).To((LoginViewModel vm) => vm.Username).Apply();
            this.CreateBinding(PasswordLabel).To((LoginViewModel vm) => vm.PasswordLabel).Apply();            
            this.CreateBinding(PasswordTextField).To((LoginViewModel vm) => vm.Password).Apply();
            this.CreateBinding(LoginButton).For("Title").To((LoginViewModel vm) => vm.LoginButtonLabel).Apply();
            this.CreateBinding(LoginButton).To((LoginViewModel vm) => vm.LoginCommand).Apply();
            this.CreateBinding(UsernameBintLabel).To((LoginViewModel vm) => vm.Username).Apply();
            this.CreateBinding(PasswordBindLabel).To((LoginViewModel vm) => vm.Password).Apply();
            //this.CreateBinding().For(v => v.OAuth1).To((LoginViewModel vm) => vm.OAuth1).Apply();
            this.CreateBinding().For(v => v.OAuth2).To((LoginViewModel vm) => vm.OAuth2).Apply();
            this.CreateBinding(GoogleButton).To((LoginViewModel vm) => vm.GoogleCommand).Apply();
            this.CreateBinding(FacebookButton).To((LoginViewModel vm) => vm.FacebookCommand).Apply();
            this.CreateBinding(TwitterButton).To((LoginViewModel vm) => vm.TwitterCommand).Apply();
        }
    }
}
