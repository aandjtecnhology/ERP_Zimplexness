using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
  public  class ArticulosComprobanteManager
    {

        public DataModel.Entities Context;
        public DataModel.Table_DetallesComprobanteArticulos ComprobanteArticulo;

        public void InsertarArticuloComprobante(DataModel.Table_DetallesComprobanteArticulos comp)
        {
            using (Context = new DataModel.Entities())
            {
                
                Context.Table_DetallesComprobanteArticulos.Add(comp);
                Context.SaveChanges();
            }


        }

        public void InsertarTableArticuloComprobante(int idcomprobante,int idarticulo,double cant,double precio,double ivacompra,double ivacalculado,double importe)
        {
            using (Context = new DataModel.Entities())
            {
                ComprobanteArticulo = new DataModel.Table_DetallesComprobanteArticulos();
                ComprobanteArticulo.IdComprobante = idcomprobante;
                ComprobanteArticulo.IdArticulo = idarticulo;
                ComprobanteArticulo.Cantidad = cant;
                ComprobanteArticulo.Precio = precio;
                ComprobanteArticulo.Iva = ivacompra;
                ComprobanteArticulo.IvaCalculado = ivacalculado;
                ComprobanteArticulo.Importe =importe;
                Context.Table_DetallesComprobanteArticulos.Add(ComprobanteArticulo);
                Context.SaveChanges();
            }


        }

        public List<DataModel.Table_DetallesComprobanteArticulos> ListarArticulosComprobante(int idcomprobante)
        {

            using (Context = new DataModel.Entities())
            {
                var query = (from artcomp in Context.Table_DetallesComprobanteArticulos
                             where artcomp.IdComprobante==idcomprobante
                             select artcomp).ToList();
                return query;       
            }


        }

        public int EliminarArticuloComprobante(int idcomproart)
        {
            try
            {
                using (Context = new DataModel.Entities())
                {
                   
                    var detallecompart = (from a in Context.Table_DetallesComprobanteArticulos
                                       where a.idTable_DetallesComprobanteArticulos==idcomproart
                                       select a).First();


                    Context.Table_DetallesComprobanteArticulos.Remove(detallecompart);
                    Context.SaveChanges();
                    int result = 1;
                    return result;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
