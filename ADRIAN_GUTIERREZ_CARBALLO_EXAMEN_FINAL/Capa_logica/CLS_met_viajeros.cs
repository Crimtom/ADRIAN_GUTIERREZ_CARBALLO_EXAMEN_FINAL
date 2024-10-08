﻿using ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_logica
{
    public class CLS_met_viajeros
    {
        public static int Agregar(string ced, string nombre, int age, string pais, CLS_registro reg_id, CLS_motivo_viaje mot)
        {
            int retorno = 0;
            CLS_viajeros.cedula = ced;
            CLS_viajeros.nom_viajero = nombre;
            CLS_viajeros.edad = age;
            CLS_viajeros.nacion = pais;
            CLS_viajeros.viaje_id = reg_id;
            CLS_viajeros.mot_id = mot;

            string querry = "INSERT INTO viajeros (cedula, nom_viajero, edad, nacion, viaje_id, mot_id) VALUES (@ced, @nombre, @age, @pais, @reg_id, @mot)";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);
                    cmd.Parameters.Add(new SqlParameter("@ced", ced));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@age", age));
                    cmd.Parameters.Add(new SqlParameter("@reg_id", reg_id));
                    cmd.Parameters.Add(new SqlParameter("@mot", mot));
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
            // variable retorno para validar la ejecucion del proceso 
            int retorno = 0;


            string query = "DELETE viajeros WHERE id_viaje = @codigo";
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

        public static int Editar(int codigo, string ced, string nombre, int age, string pais, CLS_registro reg_id, CLS_motivo_viaje mot)
        {
            int retorno = 0;
            CLS_viajeros.cedula = ced;
            CLS_viajeros.nom_viajero = nombre;
            CLS_viajeros.edad = age;
            CLS_viajeros.nacion = pais;
            CLS_viajeros.viaje_id = reg_id;
            CLS_viajeros.mot_id = mot;

            string querry = "UPDATE TABLE viajeros SET cedula = @ced, nom_viajero = @nombre, edad = @age, nacion = @pais, viaje_id = @reg_id, mot_id = @mot WHERE id_viaje = @codigo";
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = BDconexion.obtener_conexion())
                {
                    SqlCommand cmd = new SqlCommand(querry, Conn);

                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));

                    cmd.Parameters.Add(new SqlParameter("@ced", ced));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@age", age));
                    cmd.Parameters.Add(new SqlParameter("@reg_id", reg_id));
                    cmd.Parameters.Add(new SqlParameter("@mot", mot));

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