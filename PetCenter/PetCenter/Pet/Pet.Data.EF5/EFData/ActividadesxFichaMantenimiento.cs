//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet.Data.EF5.EFData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActividadesxFichaMantenimiento
    {
        public int CodigoActividadxFichaMantenimiento { get; set; }
        public string Descripcion { get; set; }
        public int CodigoFichaMantenimiento { get; set; }
        public int CodigoActividad { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public Nullable<System.DateTime> FechaHoraActualizacion { get; set; }
        public Nullable<bool> EstadoRegistro { get; set; }
    
        public virtual Actividades Actividades { get; set; }
        public virtual FichaMantenimiento FichaMantenimiento { get; set; }
    }
}
