using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos
{
    public class CLS_viajeros
    {
        public static int id_viaje {  get; set; }
        public static string cedula { get; set; }
        public static string nom_viajero { get; set; }
        public static int edad {  get; set; }
        public static string nacion { get; set; }
        public static CLS_registro viaje_id { get; set; }
        public static CLS_motivo_viaje mot_id { get; set; }
    }
}