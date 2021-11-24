using ITINNOVATIONS.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITINNOVATIONS
{
    public partial class App : Application
    {
        public static NavigationPage Navigate { get; internal set; }
        public static PaginaPrincipal MenuApp { get; internal set; }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaPrincipal()); //NO BORRAR PLISSSSS 🙏🙏 ES PARA PROBAR MIS MODULOS

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
