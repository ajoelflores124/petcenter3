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
    
    public partial class ACI_Chip_OrdenAtencion
    {
        public int idChipOrdenAtencion { get; set; }
        public int idOrdenAtencion { get; set; }
        public int idChip { get; set; }
    
        public virtual ACI_Chip ACI_Chip { get; set; }
        public virtual ACI_OrdenAtencion ACI_OrdenAtencion { get; set; }
    }
}
