﻿using ITINNOVATIONS.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITINNOVATIONS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ViewInicio ()); //NO BORRAR PLISSSSS 🙏🙏

            //MainPage = new MainPage(); //Primer pagina que saldra al ejecutar la App

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
