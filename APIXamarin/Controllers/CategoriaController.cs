using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIXamarin.Controllers
{
    public class CategoriaController : ApiController
    {

        public List<CategoriaCE> Get()
        {
            //Llamos a la capa de datos
            CategoriaCD oCategoriaCD = new CategoriaCD();

            return oCategoriaCD.listarCategoria();
        }

        // DELETE api/values/5
        //public int Delete(int id)
        //{
        //    CategoriaCD oCategoriaCD = new CategoriaCD();

        //    return oCategoriaCD.eliminarCategoria(id);
        //    //return oCategoriaDAL.
        //}

    }
}
