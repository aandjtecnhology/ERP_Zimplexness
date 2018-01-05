using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
  public  class Afectado_a_Cliente
    {

        private Model.Entities Context;
        private Model.EmpresasClientes objempresasclientes;
        private Model.AfectadoEmpresaCliente afectadoempresa;

        public List<Model.EmpresasClientes> ListarEmpresasClientes()
        {
            using (Context=new Model.Entities())
            {
                var query = Context.EmpresasClientes.ToList();
                return query;
            

            }
        }

        public void InsertarEmpleadoAfectadoCliente(int idempleado, int idempresacliente)
        {

            using (Context = new Model.Entities())
            {
                afectadoempresa = new Model.AfectadoEmpresaCliente();
                afectadoempresa.IdEmpleado = idempleado;
                afectadoempresa.IdEmpresaCliente = idempresacliente;
                Context.AfectadoEmpresaCliente.Add(afectadoempresa);
                Context.SaveChanges();




            }


        }

    }
}
