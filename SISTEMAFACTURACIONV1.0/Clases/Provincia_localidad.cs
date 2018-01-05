using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class Provincia_localidad
    {

        public Model.Entities Context = new Model.Entities();

        public List<Model.Provincias> ListarProvincias()
        {
            using (Context = new Model.Entities())
            {
                var query = (from provin in Context.Provincias select provin).ToList();
                return query;
            }
        }

        public List<Model.Localidades> ListarLocalidades()
        {
            using (Context = new Model.Entities())
            {
                var query = (from loca in Context.Localidades select loca).ToList();
                return query;
            }

        }

        public void InsertarLocalidad(string localidad, string cp)
        {
            using (Context=new Model.Entities())
            {
                Model.Localidades Elocalidad = new Model.Localidades();
                Elocalidad.Localidades1 = localidad;
                Elocalidad.CodigoPostal = cp;
                Context.Localidades.Add(Elocalidad);
                Context.SaveChanges();


            }




        }



    }
}
