using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class AlmacenManager
    {
        public DataModel.Entities Context;
        public DataModel.Table_Almacen Almacen;


        public int InsertarAlmacen(DateTime fecha,string nombre,string codigo,int idencargado,int idzona)
        {
            int result;
            using (Context = new DataModel.Entities())
            {
                Almacen = new DataModel.Table_Almacen();
                Almacen.FechaAlta = fecha;
                Almacen.Nombre = nombre;
                Almacen.Codigo = codigo;
                Almacen.IdEncargado = idencargado;
                Almacen.IDZona = idzona;

                Context.Table_Almacen.Add(Almacen);
                Context.SaveChanges();
                result = 1;
                return result;
            }

        }

        public List<DataModel.Table_Zonas> ListarZonas()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from z in Context.Table_Zonas
                             select z).ToList();
                return query;
            }



        }

        public List<DataModel.View_Almacenes> ListarAlamcenes()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from listalmacen in Context.View_Almacenes
                             select listalmacen).ToList();
                return query;



            }


        }


    }
}
