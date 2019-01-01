﻿using System;
using Wasel.View;
using Wasel.View.HomePage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Wasel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage( new ReisterPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
