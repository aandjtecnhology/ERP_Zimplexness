using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
    class Sexos
    {
        private Model.Entities Context;
        private Sexos sexo;



        public List<Model.Sexos> ListarSexos()
        {
            using (Context = new Model.Entities())
            {
                var query = (from obj in Context.Sexos
                             select obj).ToList();
                return query;

            }


        }
    }
}
