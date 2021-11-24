using ITINNOVATIONS.Class;
using ITINNOVATIONS.Models;
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
    public partial class Menu : ContentPage
    {

        public MenuModel oEntityCLS { get; set; }
        public List<ClassMenu> listamenu { get; set; }
        public Menu()
        {
            InitializeComponent();

            listamenu = new List<ClassMenu>();
            listamenu.Add(new ClassMenu { nombreicono = "user", nombreitem = "Usuarios" });
            listamenu.Add(new ClassMenu { nombreicono = "add_user", nombreitem = "Agregar Usuario" });
            listamenu.Add(new ClassMenu { nombreicono = "activos", nombreitem = "Activos" });
            listamenu.Add(new ClassMenu { nombreicono = "agregar", nombreitem = "Agregar Activos" });
            listamenu.Add(new ClassMenu { nombreicono = "agregar", nombreitem = "Agregar Activos" });
            BindingContext = this;

        }

        private void lstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Ya tenemos en la variable objmenu todo el obejeto seleccionado
            ClassMenu classMenu = (ClassMenu)e.SelectedItem;

            switch (classMenu.nombreitem)
            {
                case "Inicio":
                    App.Navigate.PushAsync(new PaginaPrincipal()); break;
                case "Usuarios Registrados":
                    App.Navigate.PushAsync(new FormConsultaUsuarios()); break;
                case "Agregar Usuario":
                    App.Navigate.PushAsync(new RegistroUsuario()); break;
                case "Agregar Activos":
                    App.Navigate.PushAsync(new RegistroActivos()); break;
                case "Consulta Activos":
                    App.Navigate.PushAsync(new FormConsultaActivos()); break;
                case "Crear Asignación":
                    App.Navigate.PushAsync(new RegistroAsignaciones()); break;
                case "Reporte Asignaciones":
                    App.Navigate.PushAsync(new FormConsultaAsignaciones()); break;

                    
            }


            //Oculta el menu al selecionar opcion
            App.MenuApp.IsPresented = false;
        }
    }
}