using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class Provincia_localidad
    {

        public DataModel.Entities Context = new DataModel.Entities();

        public List<DataModel.Table_Provincias> ListarProvincias()
        {
            var query = (from provincia in Context.Table_Provincias select provincia).ToList();
            return query;

        }

        public List<DataModel.Table_Localidades> ListarLocalidades()
        {
            var query = (from localidades in Context.Table_Localidades select localidades).ToList();
            return query;


        }


    }
}
