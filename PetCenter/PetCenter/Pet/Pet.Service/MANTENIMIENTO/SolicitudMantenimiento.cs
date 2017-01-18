using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Service.MANTENIMIENTO
{
  public   class SolicitudMantenimiento
    {
        public static object ConsultarSolicitud()
        {
            return Pet.Data.EF5.MANTENIMIENTO.SolicitudMantenimiento.ConsultarSolicitud();
        }
    }
}
