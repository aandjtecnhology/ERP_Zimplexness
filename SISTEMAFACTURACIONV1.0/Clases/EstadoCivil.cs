using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class EstadoCivil
    {
        private Model.Entities Context;
        private EstadoCivil estadocivil;



        public List<Model.EstadoCivil> ListarEstadoCivil()
        {
            using (Context = new Model.Entities())
            {
                var query = (from obj in Context.EstadoCivil
                             select obj).ToList();
                return query;

            }


        }
    }
}
