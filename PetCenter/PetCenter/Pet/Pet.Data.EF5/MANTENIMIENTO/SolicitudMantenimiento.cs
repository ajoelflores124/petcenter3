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

        public static object ConsultarSolicitud()
        {
            
                using (var db = new EFData.PET_DBEntities())
                {
                var result = db.USP_CONSULTA_SOLICITUDES(0,"pr",0,null,null,1,0,0).ToList()  ;                   
                    return result;
                
            }
        }


    }
}
