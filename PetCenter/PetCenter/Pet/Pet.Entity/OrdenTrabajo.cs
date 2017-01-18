//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenTrabajo
    {
        public OrdenTrabajo()
        {
            this.InformeTecnico = new HashSet<InformeTecnico>();
            this.Tecnico = new HashSet<Tecnico>();
        }
    
        public int CodigoOrdenTrabajo { get; set; }
        public int CodigoFichaMantenimiento { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public int Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public Nullable<System.DateTime> FechaHoraActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
    
        public virtual EstadoOrdenTrabajo EstadoOrdenTrabajo { get; set; }
        public virtual FichaMantenimiento FichaMantenimiento { get; set; }
        public virtual ICollection<InformeTecnico> InformeTecnico { get; set; }
        public virtual ICollection<Tecnico> Tecnico { get; set; }
    }
}
