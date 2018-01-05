using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class Estudios
    {
        private Model.Entities Context;
        private Estudios estudiorealizados;



        public List<Model.EstudiosRealizados> ListarEstudios()
        {
            using (Context = new Model.Entities())
            {
                var query = (from obj in Context.EstudiosRealizados
                             select obj).ToList();
                return query;

            }


        }
    }
}
