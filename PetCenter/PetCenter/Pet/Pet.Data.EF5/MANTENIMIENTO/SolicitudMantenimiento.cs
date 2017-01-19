using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet.Entity;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using log4net;

namespace Pet.Data.EF5.MANTENIMIENTO
{
   public static class SolicitudMantenimiento
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SolicitudMantenimiento));

        public static object ConsultarSolicitud(Nullable<int> codigoSolicitud, string descripcion, Nullable<int> codigoTipoMantenimiento, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> estado, Nullable<int> codigoSede, Nullable<int> codigoArea)
        {
            //int p_codSol,
            //String p_desc ,int p_codTipMant, String p_fecini, String p_fecfin, String p_estado, String p_codSede,String p_codArea  
            using (var db = new EFData.PET_DBEntities())
                {
                    //var result = db.USP_CONSULTA_SOLICITUDES(0,"pr",0,null,null,1,0,0).ToList()  ;
                var result = db.USP_CONSULTA_SOLICITUDES(codigoSolicitud, descripcion, codigoTipoMantenimiento, fechaInicio, fechaFin, estado, codigoSede, codigoArea).ToList();
                return result;
                
            }
        }


    }
}
