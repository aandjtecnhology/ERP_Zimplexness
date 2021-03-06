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
    
    public partial class Comprobantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comprobantes()
        {
            this.DetallesPago = new HashSet<DetallesPago>();
            this.DetallesComprobanteArticulos = new HashSet<DetallesComprobanteArticulos>();
        }
    
        public int IdComprobante { get; set; }
        public string Sucursal { get; set; }
        public string NoFactura { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<int> IdTipoComprobante { get; set; }
        public Nullable<int> IdCentroCosto { get; set; }
        public Nullable<int> IdTipoFactura { get; set; }
        public Nullable<double> Importe { get; set; }
        public Nullable<int> Contable { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdCondicionCompra { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<double> IIBB { get; set; }
        public Nullable<double> Retenciones { get; set; }
        public Nullable<double> ConceptosNograbado { get; set; }
        public Nullable<double> PercepcionIva { get; set; }
    
        public virtual CentroCostos CentroCostos { get; set; }
        public virtual CondicionesCompra CondicionesCompra { get; set; }
        public virtual Contable Contable1 { get; set; }
        public virtual Estados Estados { get; set; }
        public virtual Proveedores Proveedores { get; set; }
        public virtual TiposComprobante TiposComprobante { get; set; }
        public virtual TiposFactura TiposFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesPago> DetallesPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesComprobanteArticulos> DetallesComprobanteArticulos { get; set; }
    }
}
