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
    
    public partial class Table_DetallePago
    {
        public int IdDetallePago { get; set; }
        public Nullable<int> idComprobante { get; set; }
        public Nullable<int> IdPago { get; set; }
    
        public virtual Table_Comprobante Table_Comprobante { get; set; }
        public virtual Table_Pagos Table_Pagos { get; set; }
    }
}
