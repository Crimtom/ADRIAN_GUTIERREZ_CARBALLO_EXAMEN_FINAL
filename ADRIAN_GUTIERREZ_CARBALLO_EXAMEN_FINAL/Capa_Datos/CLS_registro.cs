using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADRIAN_GUTIERREZ_CARBALLO_EXAMEN_FINAL.Capa_Datos
{
    public class CLS_registro
    {
        public static int travel_id {  get; set; }
        public static CLS_tipo_registro tipo_id {  get; set; }
        public static DateTime fecha {  get; set; }
        public static string destino { get; set; }
    }
}