using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
    class Zonas
    {
        public Model.Entities Context;
        public Model.Zonas ObjectZona;


       public List<Model.Zonas> ListarZonas()
        {
            using (Context = new Model.Entities())
            {
                var query = Context.Zonas.ToList();
                return query;
            }


        }
    }
}
