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
    
    public partial class Detalle_Atencion
    {
        public int id_detalle { get; set; }
        public int id_cartilla_atencion { get; set; }
        public int id_tipo_examen { get; set; }
        public Nullable<int> CodigoEmpleado { get; set; }
        public string especificacion_examen { get; set; }
        public string estado_examen_atencion { get; set; }
        public Nullable<int> id_equipo { get; set; }
    
        public virtual Cartilla_Atencion Cartilla_Atencion { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Equipo_Sede Equipo_Sede { get; set; }
        public virtual Examen Examen { get; set; }
    }
}
