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
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Vehiculos = new HashSet<Vehiculos>();
            this.AfectadoEmpresaCliente = new HashSet<AfectadoEmpresaCliente>();
        }
    
        public int IDEmpleado { get; set; }
        public string NoLegajo { get; set; }
        public int idPersona { get; set; }
        public Nullable<int> idDepartamento { get; set; }
        public Nullable<int> IdObraSocial { get; set; }
        public Nullable<int> idSindicato { get; set; }
        public Nullable<int> idEspecialidad { get; set; }
        public Nullable<int> idCategoriaEmpleado { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string NoCuentaFondoDesempleo { get; set; }
        public Nullable<bool> Ieric { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaCeseLaboral { get; set; }
        public string Comentario { get; set; }
    
        public virtual CategoriaEmpleado CategoriaEmpleado { get; set; }
        public virtual Departamentos Departamentos { get; set; }
        public virtual Empleados Empleados1 { get; set; }
        public virtual Empleados Empleados2 { get; set; }
        public virtual Empleados Empleados11 { get; set; }
        public virtual Empleados Empleados3 { get; set; }
        public virtual Empleados Empleados12 { get; set; }
        public virtual Empleados Empleados4 { get; set; }
        public virtual Especialidades Especialidades { get; set; }
        public virtual ObraSocial ObraSocial { get; set; }
        public virtual Personas Personas { get; set; }
        public virtual Sindicatos Sindicatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AfectadoEmpresaCliente> AfectadoEmpresaCliente { get; set; }
    }
}