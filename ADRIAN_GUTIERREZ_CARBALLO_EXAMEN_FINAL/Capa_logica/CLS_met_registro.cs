using ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_logica
{
    public class CLS_met_registro
    {
        public static int Agregar(CLS_tipo_registro tipo, DateTime tim, string location)
        {
            int retorno = 0;
            CLS_registro.tipo_id = tipo;
            CLS_registro.fecha = tim;
            CLS_registro.destino = location;

            string querry = "INSERT INTO registro (tipo_id, fecha, destino) VALUES (@tipo, @tim, @location)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                    cmd.Parameters.Add(new SqlParameter("@tim", tim));
                    cmd.Parameters.Add(new SqlParameter("@location", location));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }
            return retorno;
        }

        public static int Borrar(int codigo)
        {
            int retorno = 0;

            string query = "DELETE registro WHERE travel_id = @codigo";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);

                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int Editar(int codigo, CLS_tipo_registro tipo, DateTime tim, string location)
        {
            int retorno = 0;
            CLS_registro.tipo_id = tipo;
            CLS_registro.fecha = tim;
            CLS_registro.destino = location;

            string querry = "UPDATE TABLE registro SET tipo_id = @tipo, fecha = @tim, destino = @location WHERE travel_id = @codigo";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);

                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

                    cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                    cmd.Parameters.Add(new SqlParameter("@tim", tim));
                    cmd.Parameters.Add(new SqlParameter("@location", location));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }
            return retorno;
        }
    }
}