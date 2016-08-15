// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace OAuth2MVVMLoginXamarinAndroidiOS.iOS.Views
{
    [Register ("LoginView")]
    partial class LoginView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FacebookButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GoogleButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PasswordBindLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PasswordLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TwitterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UsernameBintLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UsernameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UsernameTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FacebookButton != null) {
                FacebookButton.Dispose ();
                FacebookButton = null;
            }

            if (GoogleButton != null) {
                GoogleButton.Dispose ();
                GoogleButton = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }

            if (PasswordBindLabel != null) {
                PasswordBindLabel.Dispose ();
                PasswordBindLabel = null;
            }

            if (PasswordLabel != null) {
                PasswordLabel.Dispose ();
                PasswordLabel = null;
            }

            if (PasswordTextField != null) {
                PasswordTextField.Dispose ();
                PasswordTextField = null;
            }

            if (TwitterButton != null) {
                TwitterButton.Dispose ();
                TwitterButton = null;
            }

            if (UsernameBintLabel != null) {
                UsernameBintLabel.Dispose ();
                UsernameBintLabel = null;
            }

            if (UsernameLabel != null) {
                UsernameLabel.Dispose ();
                UsernameLabel = null;
            }

            if (UsernameTextField != null) {
                UsernameTextField.Dispose ();
                UsernameTextField = null;
            }
        }
    }
}