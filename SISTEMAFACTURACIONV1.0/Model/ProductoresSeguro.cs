//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISTEMAFACTURACIONV1._0.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductoresSeguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductoresSeguro()
        {
            this.DetalleProveedor_ProductorSeguro = new HashSet<DetalleProveedor_ProductorSeguro>();
        }
    
        public int IdProductorSeguro { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProveedor_ProductorSeguro> DetalleProveedor_ProductorSeguro { get; set; }
    }
}
