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
    
    public partial class GPC_HistoricoDeSolicitud
    {
        public int codigo_historia { get; set; }
        public string numero_solicitud { get; set; }
        public Nullable<System.DateTime> fecha_operacion { get; set; }
        public int CodigoEmpleado { get; set; }
        public Nullable<int> codigo_estado { get; set; }
    }
}
