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
    
    public partial class Cartilla_Atencion
    {
        public Cartilla_Atencion()
        {
            this.Detalle_Atencion = new HashSet<Detalle_Atencion>();
        }
    
        public int id_cartilla_atencion { get; set; }
        public int id_cliente { get; set; }
        public int id_paciente { get; set; }
        public int CodigoEmpleado { get; set; }
        public string codigo { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string estado_cartilla { get; set; }
        public string numero_comprobante { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Detalle_Atencion> Detalle_Atencion { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
