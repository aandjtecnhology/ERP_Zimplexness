using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
    class ComprobantesManager
    {

        public Model.Entities Context;


        public List<Model.CentroCostos> ListarCentroCosto()

        {
            using (Context = new Model.Entities())
            {
                var query = (from centrocosto in Context.CentroCostos select centrocosto).ToList();
                return query;
            }



        }

        public List<Model.TiposComprobante> ListarTipoComprobantes()
        {
            using (Context = new Model.Entities())
            {
                var query = (from tipocomp in Context.TiposComprobante
                             select tipocomp).ToList();
                return query;

            }


        }

        public List<Model.TiposFactura> ListarTipoFactura()
        {
            using (Context = new Model.Entities())
            {
                var query = (from tipofactura in Context.TiposFactura select tipofactura).ToList();
                return query;

            }


        }

        public List<Model.SP_DEUDASPROVEEDORES_Result> ListarDeudasProveedores(DateTime fechainicio, DateTime fechafin)
        {
            using (Context = new Model.Entities())
            {
                var query = Context.SP_DEUDASPROVEEDORES(fechainicio, fechafin);
                return query.ToList();

            }

        }

        public List<Model.Contable> ListarContable()
        {
            using (Context = new Model.Entities())
            {
                var query = (from contable in Context.Contable select contable).ToList();
                return query;
            }



        }

        public List<Model.MediosPago> MediosdePago()
        {
            using (Context = new Model.Entities())
            {
                var query = (from mdp in Context.MediosPago
                             select mdp).ToList();
                return query;



            }



        }

        public List<Model.Bancos> Bancos()
        {
            using (Context = new Model.Entities())
            {
                var query = (from b in Context.Bancos
                             select b).ToList();
                return query;


            }


        }

        public int InsertarComprobante(string sucursal,string nofactura,DateTime fecha,DateTime fechavencimiento,int tipocomprobante,
                                      int idcentrocosto,int tipofactura,int contable,int condicioncompra,
                                      int idproveedor)
        {   int result;
            using (Context = new Model.Entities())
            {
                Model.Comprobantes c = new Model.Comprobantes();
                c.Sucursal = sucursal;
                c.NoFactura = nofactura;
                c.Fecha = fecha;
                c.FechaVencimiento = fechavencimiento;
                c.IdTipoComprobante = tipocomprobante;
                c.IdCentroCosto = idcentrocosto;
                c.IdTipoFactura = tipofactura;
                c.Contable = contable;
                c.IdCondicionCompra = condicioncompra;
                c.IdProveedor = idproveedor;
                Context.Comprobantes.Add(c);
                Context.SaveChanges();
                result = 1;
                return result;

            }

        }

        public int DevolverIDporNoFactura(string facta, string factb,int idproveedor)
        {
            int result;

            using (Context = new Model.Entities())
            {

                var query = (from c in Context.Comprobantes
                             where (c.Sucursal == facta && c.NoFactura == factb) && c.IdProveedor==idproveedor
                             select c.IdComprobante).FirstOrDefault();
                result = int.Parse(query.ToString());

                return result;

            }

        }
        public int DevolverIDporNoFactura2(string facta, string factb)
        {
            int result;

            using (Context = new Model.Entities())
            {

                var query = (from c in Context.Comprobantes
                             where (c.Sucursal == facta && c.NoFactura == factb) 
                             select c.IdComprobante).FirstOrDefault();
                result = int.Parse(query.ToString());

                return result;

            }

        }

        public List<Model.CondicionesCompra> ListarCondicionCompra()
        {
            using (Context = new Model.Entities())
            {
                var query = (from c in Context.CondicionesCompra
                             select c).ToList();
                return query;

            }




        }

        public List<Model.View_DetalleArticuloComprobante> VistaComprobantesArticulos(int idcomprobante)
        {
            using (Context = new Model.Entities())
            {
                var query = (from a in Context.View_DetalleArticuloComprobante
                             where a.IdComprobante == idcomprobante
                             select a).ToList();
                return query;

            }

        }

        public void ActualizarImporteComprobante(int idcomprobante)
        {
            using (Context = new Model.Entities())
            {
                var query = (from a in Context.DetallesComprobanteArticulos
                             where a.IdComprobante == idcomprobante
                             select a.Importe).ToList();


                var query2 = (from c in Context.Comprobantes
                              where c.IdComprobante == idcomprobante
                              select c).ToList();


                foreach (var item in query2)
                {
                    Context.Comprobantes.Attach(item);
                    
                    Double IMPORTE= Math.Round( query.Sum().Value,2);

                    item.Importe = IMPORTE;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }


            }

        }

        public List<Model.Comprobantes> ListarComprobantesPendientes(int idproveedor)
        {
            using (Context = new Model.Entities())
            {

                var query = (from c in Context.Comprobantes
                             where c.IdEstado == 2
                             select c).ToList();
                return query;



            }





        }


        public void ActualizarEstado(int idcomprobante, int idestado)
        {
            using (Context = new Model.Entities())
            {
                var comprobante = (from c in Context.Comprobantes
                                   where c.IdComprobante == idcomprobante
                                   select c).ToList();

                foreach (var item in comprobante)
                {
                    Context.Comprobantes.Attach(item);
                    item.IdEstado = idestado;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }

            }






        }


        public List<Model.FACTURASXPROVEEDORES_Result> ListarFacturasXproveedores(DateTime fechainicio,DateTime fechafin,int idproveedor)
        {
            using (Context = new Model.Entities())
            {
                var query = Context.FACTURASXPROVEEDORES(fechainicio,fechafin,idproveedor);
                return query.ToList() ;

            }

        }

        public List<Model.Gastos_ComprasxPeriodo_Result> ListarFacturasComprasGastos(DateTime fechainicio, DateTime fechafin)
        {
            using (Context = new Model.Entities())
            {
                var query = Context.Gastos_ComprasxPeriodo(fechainicio,fechafin);
                return query.ToList();

            }

        }

        public List<Model.CuentasxPagarProveedores_Result> ListarCuentasxPagarProveedores()
        {
            using (Context = new Model.Entities())
            {
                var query = Context.CuentasxPagarProveedores();
                return query.ToList();

            }

        }


        public void ActualizarOtrosGastosComprobante(int idcomprobante, double iibb, double retenciones,double otrosgastos,double percepcionesIva )
        {
            using (Context = new Model.Entities())
            {
               var query2 = (from c in Context.Comprobantes
                              where c.IdComprobante == idcomprobante
                              select c).ToList();


                foreach (var item in query2)
                {
                    Context.Comprobantes.Attach(item);

                    item.IIBB = iibb;
                    item.Retenciones = retenciones;
                    item.ConceptosNograbado = otrosgastos;
                    item.PercepcionIva=percepcionesIva;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }


            }

        }

        public int ValidateComprobante(int idproveedor,string sucursal, string nofactura)
        {
            int result;

            try
            {
                using (Context = new Model.Entities())
                {


                    var validatc = (from c in Context.Comprobantes
                                    where c.Sucursal == sucursal && c.NoFactura == nofactura && c.IdProveedor==idproveedor
                                    select c).FirstOrDefault();

                    if (validatc != null)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int EliminarComprobante(string sucursal, string nofactura)
        {
            try
            {
                using (Context = new Model.Entities())
                {

                    var comprobante = (from c in Context.Comprobantes
                                where c.Sucursal == sucursal && c.NoFactura==nofactura
                                select c).First();

                    Context.Comprobantes.Remove(comprobante);
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
