using System;
using System.Collections.Generic;
using SignInWithAppleSample.ViewModels;
using Xamarin.Forms;

namespace SignInWithAppleSample
{
    public partial class LoginPage : ContentPage
    {
        LoginViewModel _vm;
        public LoginPage()
        {
            _vm = new LoginViewModel();
            _vm.OnSignIn += OnSignIn;
            BindingContext = _vm;
            InitializeComponent();
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        async void  AppleSignInButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await _vm.OnAppleSignInRequest();
        }
    }
}
