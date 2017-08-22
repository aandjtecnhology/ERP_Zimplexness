using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class ArticuloManager
    {
        //declaracion del datacontext de todas las entities

         public  DataModel.Entities Context;
         public DataModel.Table_Articulos articulo;
        public DataModel.Table_IngresoMateriales IngresoMateriales;       

        public List<DataModel.Table_Categoria> Categorias()
        {
            using (Context=new DataModel.Entities())
            {
                var query = (from cat in Context.Table_Categoria
                             select cat).ToList();
                return query;
            }



        }

        public void InsertarArticulos(int idcategoria,  int idubicacion,string nombre, 
            string descripcion, string codigo,float iva )
        {
            using (Context = new DataModel.Entities())
            {
                articulo = new DataModel.Table_Articulos();
                articulo.IDCategoria = idcategoria;
                articulo.IdUbicacion = idubicacion;
                articulo.Nombre = nombre;
                articulo.Descripcion = descripcion;
                articulo.Codigo = codigo;
                articulo.Iva = iva;


                Context.Table_Articulos.Add(articulo);
                Context.SaveChanges();

            }



        }

        public List<DataModel.View_DetalleArticulo> ListarArticulos()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from art in Context.View_DetalleArticulo
                             select art).ToList();
                return query;
            }


        }


        public int EliminarArticulo(int articulo)
        {
            using (Context=new DataModel.Entities())
            {
                var query = (from art in Context.Table_Articulos
                             where art.IDArticulo==articulo
                             select art).First();

                Context.Table_Articulos.Remove(query);
                Context.SaveChanges();
                int result=1;
                return result;

            }


        }

        public List<DataModel.View_DetalleArticulo> FiltrarArticulos(string nombre)
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from filtro in Context.View_DetalleArticulo
                             where filtro.Nombre.Contains(nombre.ToUpper())
                             select filtro).ToList();
                return query;
            }


        }


        public int ActualizarArticulos(int idart,string nombre,int ubicacion,string Descripcion,string codigo)
        {
            int result;
            using (Context=new DataModel.Entities())
            {
                var art = (from a in Context.Table_Articulos
                           where a.IDArticulo==idart
                           select a).ToList();

                foreach (var item in art)
                {

                    Context.Table_Articulos.Attach(item);
                    item.Nombre = nombre;
                    item.IdUbicacion=ubicacion;
                    item.Descripcion = Descripcion;
                    item.Codigo = codigo;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();
                    
                }
                result = 1;
                return result;



            }




        }

        public DataModel.Table_Articulos EncontrarArticulo(int idarticulo)
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from a in Context.Table_Articulos
                             where a.IDArticulo==idarticulo
                             select a).First();

                return query;


            }


        }

        public int ValidateArticulo(string nombre)
        {
            int result;
            using (Context=new DataModel.Entities())
            {
                
                    var validatearticulo = (from a in Context.Table_Articulos
                                        where a.Nombre==nombre
                                        select a).FirstOrDefault();

                    if (validatearticulo!= null)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }


                }


                return result;

            

               

        }

        public int DevolverIDporNombre(string nombre)
        {
            int result;

            using (Context = new DataModel.Entities())
            {

                var query = (from a in Context.Table_Articulos
                             where a.Nombre == nombre
                             select a.IDArticulo).FirstOrDefault();
                result = int.Parse(query.ToString());

                return result;

            }

        }

        //listar ubicacion

        public List<DataModel.Table_Ubicacion> ListarUbicacion()
        {
            using (Context=new DataModel.Entities())
            {
                var query = (from u in Context.Table_Ubicacion
                             select u).ToList();
                return query;
            }

        }

        //listar almacenes
        public List<DataModel.Table_Almacen> ListarAlmacenes()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from a in Context.Table_Almacen
                             select a).ToList();
                return query;
            }


        }

        public List<string> ListarNombresArticulos()
        {
            using (Context = new DataModel.Entities())
            {

                var query = (from a in Context.Table_Articulos

                             select a.Nombre).ToList();
                return query;


            }


        }

        public void ActualizarStock(int idarticulo,double cant)
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from a in Context.Table_Articulos
                             where a.IDArticulo == idarticulo
                             select a).FirstOrDefault();
                Context.Table_Articulos.Attach(query);
                double stock=query.Stock.Value;
                double stockupdate = stock + cant;
                
                query.Stock = stockupdate;
                

                Context.Entry(query).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
            }


        }

        public void IngresoMaterialesMetodo(DateTime fecha,string noremito,int idalmacen, int idrecepcion,int idarticulo,float cant)
        {
            using (Context=new DataModel.Entities())
            {
                IngresoMateriales = new DataModel.Table_IngresoMateriales();
                IngresoMateriales.Fecha = fecha;
                IngresoMateriales.NoRemito = noremito;
                IngresoMateriales.IdAlmacen = idalmacen;
                IngresoMateriales.IdRecepcion = idrecepcion;
                IngresoMateriales.idArticulo = idarticulo;
                IngresoMateriales.Cantidad =cant;
                Context.Table_IngresoMateriales.Add(IngresoMateriales);
                Context.SaveChanges();


            }


        }


    }
}
