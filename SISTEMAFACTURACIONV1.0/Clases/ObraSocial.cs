using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
    class ObraSocial
    {
        private Model.Entities Context;
        private ObraSocial obrasocial;



        public List<Model.ObraSocial> ListarObraSocial()
        {
            using (Context = new Model.Entities())
            {
                var query = (from obj in Context.ObraSocial
                             select obj).ToList();
                return query;

            }


        }
    }
}
