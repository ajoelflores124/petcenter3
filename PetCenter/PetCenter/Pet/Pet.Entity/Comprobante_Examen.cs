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
    
    public partial class Comprobante_Examen
    {
        public int id { get; set; }
        public int id_comprobante { get; set; }
        public int id_tipo_examen { get; set; }
    
        public virtual Comprobante_Pago Comprobante_Pago { get; set; }
        public virtual Examen Examen { get; set; }
    }
}
