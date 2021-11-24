using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ITINNOVATIONS.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : MasterDetailPage
    {
        public PaginaPrincipal()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);//Con esto se quita el tolbar color azul que biene por default.

            Navigation.BarBackgroundColor = Color.OrangeRed;

            App.Navigate = Navigation;
            App.MenuApp = this;
        }
    }
}