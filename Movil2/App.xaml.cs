﻿using Movil2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListProductView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
