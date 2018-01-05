using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class AlmacenManager
    {
        public Model.Entities Context;
        public Model.Almacenes Almacen;


        public int InsertarAlmacen(DateTime fecha,string nombre,string codigo,int idencargado,int idzona)
        {
            int result;
            using (Context = new Model.Entities())
            {
                Almacen = new Model.Almacenes();
                Almacen.FechaAlta = fecha;
                Almacen.Nombre = nombre;
                Almacen.Codigo = codigo;
                Almacen.IdEncargado = idencargado;
                Almacen.IDZona = idzona;

                Context.Almacenes.Add(Almacen);
                Context.SaveChanges();
                result = 1;
                return result;
            }

        }

        public List<Model.Zonas> ListarZonas()
        {
            using (Context = new Model.Entities())
            {
                var query = (from z in Context.Zonas
                             select z).ToList();
                return query;
            }



        }

        //public List<Model.View_Almacenes> ListarAlamcenes()
        //{
        //    using (Context = new Model.Entities())
        //    {
        //        var query = (from listalmacen in Context.View_Almacenes
        //                     select listalmacen).ToList();
        //        return query;



        //    }


        //}


    }
}
