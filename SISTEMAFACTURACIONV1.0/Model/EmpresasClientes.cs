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
    
    public partial class EmpresasClientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmpresasClientes()
        {
            this.AfectadoEmpresaCliente = new HashSet<AfectadoEmpresaCliente>();
        }
    
        public int IDEmpresaCliente { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AfectadoEmpresaCliente> AfectadoEmpresaCliente { get; set; }
    }
}
