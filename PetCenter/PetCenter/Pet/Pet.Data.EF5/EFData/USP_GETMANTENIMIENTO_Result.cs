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
    
    public partial class USP_GETMANTENIMIENTO_Result
    {
        public int CodigoMantenimiento { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Descripcion { get; set; }
        public int CodigoSolicitud { get; set; }
        public int CodigoTipoMantenimiento { get; set; }
        public int CodigoArea { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public Nullable<System.DateTime> FechaHoraActualizacion { get; set; }
        public Nullable<bool> EstadoRegistro { get; set; }
    }
}
