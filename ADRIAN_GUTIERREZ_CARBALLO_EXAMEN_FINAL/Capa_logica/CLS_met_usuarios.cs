using ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_logica
{
    public class CLS_met_usuarios
    {
        public static int Agregar(string nom, string email, string contrase)
        {
            int retorno = 0;
            CLS_usuarios.nombre = nom;
            CLS_usuarios.correo = email;
            CLS_usuarios.contra = contrase;

            string querry = "INSERT INTO usuarios (nombre, correo, contra) VALUES (@nom, @email, @contrase)";
            SqlConnection Conn = new SqlConnection();
            try
            {

            }
        }
    }
}