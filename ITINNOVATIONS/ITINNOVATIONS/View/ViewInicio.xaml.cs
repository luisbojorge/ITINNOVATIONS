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
    public partial class ViewInicio : ContentPage
    {
        public ViewInicio()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);//Con esto se quita el tolbar color azul que biene por default.

            Task.Run(RotateImage);
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(360, 10000, Easing.Linear);
            }
        }
    }
}