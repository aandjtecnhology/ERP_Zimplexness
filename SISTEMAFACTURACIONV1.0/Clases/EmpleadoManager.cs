using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class EmpleadoManager
    {
        public DataModel.Entities Context;
        public DataModel.Table_Empleado Empleado;

        public List<DataModel.View_ListaEmpleados> ListarEmpleados()
        {
            using (Context=new DataModel.Entities())
            {
                var query = (from e in Context.View_ListaEmpleados
                             select e).ToList();
                return query;

            }




        } 




    }
}
