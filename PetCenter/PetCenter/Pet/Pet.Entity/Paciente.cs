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
    
    public partial class Paciente
    {
        public Paciente()
        {
            this.ACI_OrdenAtencion = new HashSet<ACI_OrdenAtencion>();
            this.Cartilla_Atencion = new HashSet<Cartilla_Atencion>();
            this.Comprobante_Pago = new HashSet<Comprobante_Pago>();
        }
    
        public int id_paciente { get; set; }
        public string nombre { get; set; }
        public string raza { get; set; }
        public string tipo { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public string color { get; set; }
        public int id_cliente { get; set; }
    
        public virtual ICollection<ACI_OrdenAtencion> ACI_OrdenAtencion { get; set; }
        public virtual ICollection<Cartilla_Atencion> Cartilla_Atencion { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Cliente1 { get; set; }
        public virtual ICollection<Comprobante_Pago> Comprobante_Pago { get; set; }
    }
}