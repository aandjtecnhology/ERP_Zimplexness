//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISTEMAFACTURACIONV1._0.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_CentroCosto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_CentroCosto()
        {
            this.Table_Comprobante = new HashSet<Table_Comprobante>();
        }
    
        public int IdCentroCosto { get; set; }
        public string CentroCosto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Comprobante> Table_Comprobante { get; set; }
    }
}
