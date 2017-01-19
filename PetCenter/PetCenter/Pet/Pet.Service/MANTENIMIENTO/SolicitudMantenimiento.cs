using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Service.MANTENIMIENTO
{
  public   class SolicitudMantenimiento
    {
        public static object ConsultarSolicitud(Nullable<int> codigoSolicitud, string descripcion, Nullable<int> codigoTipoMantenimiento, string  fechaInicio, string  fechaFin, Nullable<int> estado, Nullable<int> codigoSede, Nullable<int> codigoArea)
        {
            return Pet.Data.EF5.MANTENIMIENTO.SolicitudMantenimiento.ConsultarSolicitud(codigoSolicitud, descripcion, codigoTipoMantenimiento, fechaInicio, fechaFin, estado, codigoSede, codigoArea);
        }
    }
}
