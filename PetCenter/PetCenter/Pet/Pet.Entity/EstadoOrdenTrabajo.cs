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
    
    public partial class EstadoOrdenTrabajo
    {
        public EstadoOrdenTrabajo()
        {
            this.OrdenTrabajo = new HashSet<OrdenTrabajo>();
        }
    
        public int CodigoEstadoOrdenTrabajo { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<OrdenTrabajo> OrdenTrabajo { get; set; }
    }
}
