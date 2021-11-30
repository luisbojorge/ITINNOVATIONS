using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//para la base de datos 
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class CategoriaCD
    {
        //0 (error) (1) exitoso

        public int eliminarCategoria(int idcategoria)
        {
            //suponiendo que hay error
            int rpta = 0;
            string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("uspEliminarCategoria", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idcategoria", idcategoria);
                        //INSERT , UPDATE O DELETE 
                        //El numero de registros afectados (1) -> (0)
                        rpta = cmd.ExecuteNonQuery();
                        conexion.Close();

                    }
                }
                catch (Exception ex)
                {
                    conexion.Close();
                    rpta = 0;
                }


            }

            return rpta;
        }


        public List<CategoriaCE> listarCategoria()
        {
            List<CategoriaCE> lista = null;
            //"Data Source=SQL5061.site4now.net;Initial Catalog=db_a76fdd_bdxamarin;User Id=db_a76fdd_bdxamarin_admin;Password=Licito2022"
            string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            //Definimos la conexion
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                try
                {
                    //Abrimos la conexion
                    conexion.Open();
                    //Definio el procedure a ejecutar
                    using (SqlCommand cmd = new SqlCommand("uspListarCategoria", conexion))
                    {
                        //Indico que es un procedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        //sELECT
                        SqlDataReader drd = cmd.ExecuteReader();

                        if (drd != null)
                        {
                            lista = new List<CategoriaCE>();
                            CategoriaCE oCategoriaCE;
                            while (drd.Read())
                            {
                                oCategoriaCE = new CategoriaCE();
                                //int idcategoria=drd.GetInt32(0)
                                oCategoriaCE.iidcategoria = drd.IsDBNull(0) ? 0 : drd.GetInt32(0);
                                oCategoriaCE.nombre = drd.IsDBNull(1) ? "" : drd.GetString(1);
                                oCategoriaCE.descripcion = drd.IsDBNull(2) ? "" : drd.GetString(2);
                                lista.Add(oCategoriaCE);
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    //Si lista es igual a null cerramos la conxion 
                    lista = null;
                    conexion.Close();

                }

            }
            return lista;
        }

    }
}
