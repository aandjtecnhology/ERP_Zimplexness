using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
  public  class ArticulosComprobanteManager
    {

        public Model.Entities Context;
        public Model.DetallesComprobanteArticulos ComprobanteArticulo;

        public void InsertarArticuloComprobante(Model.DetallesComprobanteArticulos comp)
        {
            using (Context = new Model.Entities())
            {
                
                Context.DetallesComprobanteArticulos.Add(comp);
                Context.SaveChanges();
            }


        }

        public void InsertarTableArticuloComprobante(int idcomprobante,int idarticulo,double cant,double precio,double ivacompra,double ivacalculado,double importe)
        {
            using (Context = new Model.Entities())
            {
                ComprobanteArticulo = new Model.DetallesComprobanteArticulos();
                ComprobanteArticulo.IdComprobante = idcomprobante;
                ComprobanteArticulo.IdArticulo = idarticulo;
                ComprobanteArticulo.Cantidad = cant;
                ComprobanteArticulo.Precio = precio;
                ComprobanteArticulo.Iva = ivacompra;
                ComprobanteArticulo.IvaCalculado = ivacalculado;
                ComprobanteArticulo.Importe =importe;
                Context.DetallesComprobanteArticulos.Add(ComprobanteArticulo);
                Context.SaveChanges();
            }


        }

        public List<Model.DetallesComprobanteArticulos> ListarArticulosComprobante(int idcomprobante)
        {

            using (Context = new Model.Entities())
            {
                var query = (from artcomp in Context.DetallesComprobanteArticulos
                             where artcomp.IdComprobante==idcomprobante
                             select artcomp).ToList();
                return query;       
            }


        }

        public int EliminarArticuloComprobante(int idcomproart)
        {
            try
            {
                using (Context = new Model.Entities())
                {
                   
                    var detallecompart = (from a in Context.DetallesComprobanteArticulos
                                       where a.idTable_DetallesComprobanteArticulos==idcomproart
                                       select a).First();


                    Context.DetallesComprobanteArticulos.Remove(detallecompart);
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

        public List<Model.SeleccionarDetalleComprobantesArticulos_Result> SeleccionarDetallesComprobantesArticulos(int idcomprobante)
        {
            using (Context = new Model.Entities())
            {
                var query = Context.SeleccionarDetalleComprobantesArticulos(idcomprobante);
                return query.ToList();
            }

        }



    }
}
