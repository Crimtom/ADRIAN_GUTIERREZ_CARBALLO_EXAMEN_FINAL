using ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Vistas.Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidarUsuario(string nombre, string correo, string contra)
        {
            CLS_usuarios.nombre = nombre;
            CLS_usuarios.correo = correo;
            CLS_usuarios.contra = contra;
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT nombre, correo, contra FROM usuarios WHERE correo = '" + correo + "' " + "and contra = '" + contra + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                CLS_usuarios.nombre = registro["nombre"].ToString();
                Response.Redirect("Inicio.aspx");
            }
            conexion.Close();
        }
    }
}