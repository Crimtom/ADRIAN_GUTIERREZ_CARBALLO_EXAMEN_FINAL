using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos
{
    public class BDconexion
    {
        public static SqlConnection obtener_conexion()
        {
            string rutaconexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(rutaconexion);
            conexion.Open();
            return conexion;
        }
    }
}