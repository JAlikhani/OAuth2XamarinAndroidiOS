using MvvmCross.Core.ViewModels;
using OAuth2XamarinAndroidiOS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Auth;

namespace OAuth2XamarinAndroidiOS.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly ILogin _login;
        public LoginViewModel(ILogin login)
        {
            _login = login;
            Username = _login.Username;
            Password = _login.Password;
        }
        public string Username {
            get { return _login.Username; }
            set
            {
                _login.Username = value;
                RaisePropertyChanged(() => Username);
            }
        }
        public string Password
        {
            get { return _login.Password; }
            set
            {
                _login.Password = value;
                RaisePropertyChanged(() => Password);
            }
        }
        public override void Start()
        {
            base.Start();
        }

        public string UsernameLabel => "Username";
        public string PasswordLabel => "Password";
        public string UsernameTip => "Please enter your username";
        public string PasswordTip => "Please enter your password";
        public string LoginButtonLabel => "Login";
        public ICommand LoginCommand => new MvxCommand(() => Username = Username + 1);

        private OAuth2Authenticator _oAuth2;
        public OAuth2Authenticator OAuth2 { get { return _oAuth2; } set { _oAuth2 = value; } }
        public ICommand GoogleCommand =>
                   new MvxCommand(() => { OAuth2 = googleOAuth2; RaisePropertyChanged(() => OAuth2); });
        private OAuth2Authenticator googleOAuth2 =
             new OAuth2Authenticator(
                   clientId: "?",
                   scope: "https://www.googleapis.com/auth/userinfo.email",
                   authorizeUrl: new Uri("https://accounts.google.com/o/oauth2/auth"),
                   redirectUrl: new Uri("https://www.googleapis.com/plus/v1/people/me"));
        public ICommand FacebookCommand =>
            new MvxCommand(() => { OAuth2 = facebookOAuth2; RaisePropertyChanged(() => OAuth2); });
        private OAuth2Authenticator facebookOAuth2 =
               new OAuth2Authenticator(
                   clientId: "?",
                   scope: "",
                   authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                   redirectUrl: new Uri("https://www.facebook.com/connect/login_success.html"));

        public ICommand TwitterCommand =>
            new MvxCommand(() => { OAuth2 = twitterOAuth2; RaisePropertyChanged(() => OAuth2); });

        private OAuth1Authenticator _oAuth1;
        public OAuth1Authenticator OAuth1 { get { return _oAuth1; } set { _oAuth1 = value; } }
        private OAuth1Authenticator twitterOAuth1 =
           new OAuth1Authenticator(
            consumerKey: "?",
            consumerSecret: "?",
            requestTokenUrl: new Uri("https://api.twitter.com/oauth/request_token"), 
            authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"), 
            accessTokenUrl: new Uri("https://api.twitter.com/oauth/access_token"), 
            callbackUrl: new Uri("http://twitter.com")
            );
        private OAuth2Authenticator twitterOAuth2 =
            new OAuth2Authenticator(
                clientId: "?",
                clientSecret: "?",
                scope: "",
                authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"),
                redirectUrl: new Uri("http://twitter.com"),
                accessTokenUrl: new Uri("https://api.twitter.com/oauth/request_token")
                );
    }
}
