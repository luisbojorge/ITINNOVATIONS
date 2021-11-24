using ITINNOVATIONS.Class;
using ITINNOVATIONS.Generic;
using ITINNOVATIONS.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITINNOVATIONS.Models
{
    public class MenuModel : BaseBending
    {
		private List<ClassMenu> _listaMenu;

		public List<ClassMenu> listaMenu
		{
			get { return _listaMenu; }
			set { SetValue(ref _listaMenu, value); }
		}
	}
}
