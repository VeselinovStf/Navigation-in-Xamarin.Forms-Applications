﻿using Navigations.MasterDetailDemo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CutommersMasterDetailPage( );
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
