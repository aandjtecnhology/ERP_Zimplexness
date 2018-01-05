using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class Nacionalidades
    {
        private Model.Entities Context;
        private Model.Nacionalidades nacionalidad;


        public List<Model.Nacionalidades> ListarNacionalidades()
        {
            using (Context = new Model.Entities())
            {
                var query = (from n in Context.Nacionalidades
                             select n).ToList();
                return query;

            }


        }





    }
}
