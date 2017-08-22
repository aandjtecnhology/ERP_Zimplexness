using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
    class ComprobantesManager
    {

        public DataModel.Entities Context;


        public List<DataModel.Table_CentroCosto> ListarCentroCosto()

        {
            using (Context = new DataModel.Entities())
            {
                var query = (from centrocosto in Context.Table_CentroCosto select centrocosto).ToList();
                return query;
            }



        }

        public List<DataModel.Table_TipoComprobante> ListarTipoComprobantes()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from tipocomp in Context.Table_TipoComprobante
                             select tipocomp).ToList();
                return query;

            }


        }

        public List<DataModel.Table_TipoFactura> ListarTipoFactura()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from tipofactura in Context.Table_TipoFactura select tipofactura).ToList();
                return query;

            }


        }

        public List<DataModel.Table_Contable> ListarContable()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from contable in Context.Table_Contable select contable).ToList();
                return query;
            }



        }

        public List<DataModel.Table_MedioPago> MediosdePago()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from mdp in Context.Table_MedioPago
                             select mdp).ToList();
                return query;



            }



        }

        public List<DataModel.Table_Banco> Bancos()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from b in Context.Table_Banco
                             select b).ToList();
                return query;


            }


        }

        public int InsertarComprobante(string sucursal,string nofactura,DateTime fecha,DateTime fechavencimiento,int tipocomprobante,
                                      int idcentrocosto,int tipofactura,int contable,int condicioncompra,
                                      int idproveedor)
        {   int result;
            using (Context = new DataModel.Entities())
            {
                DataModel.Table_Comprobante c = new DataModel.Table_Comprobante();
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
                Context.Table_Comprobante.Add(c);
                Context.SaveChanges();
                result = 1;
                return result;

            }

        }

        public int DevolverIDporNoFactura(string facta, string factb)
        {
            int result;

            using (Context = new DataModel.Entities())
            {

                var query = (from c in Context.Table_Comprobante
                             where c.Sucursal == facta && c.NoFactura == factb
                             select c.IdComprobante).FirstOrDefault();
                result = int.Parse(query.ToString());

                return result;

            }

        }

        public List<DataModel.Table_CondicionCompra> ListarCondicionCompra()
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from c in Context.Table_CondicionCompra
                             select c).ToList();
                return query;

            }




        }

        public List<DataModel.View_DetalleArticuloComprobante> VistaComprobantesArticulos(int idcomprobante)
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from a in Context.View_DetalleArticuloComprobante
                             where a.IdComprobante == idcomprobante
                             select a).ToList();
                return query;

            }

        }

        public void ActualizarImporteComprobante(int idcomprobante)
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from a in Context.Table_DetallesComprobanteArticulos
                             where a.IdComprobante == idcomprobante
                             select a.Importe).ToList();


                var query2 = (from c in Context.Table_Comprobante
                              where c.IdComprobante == idcomprobante
                              select c).ToList();


                foreach (var item in query2)
                {
                    Context.Table_Comprobante.Attach(item);
                    
                    Double IMPORTE= Math.Round( query.Sum().Value,2);

                    item.Importe = IMPORTE;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }


            }

        }

        public List<DataModel.Table_Comprobante> ListarComprobantesPendientes(int idproveedor)
        {
            using (Context = new DataModel.Entities())
            {

                var query = (from c in Context.Table_Comprobante
                             where c.IdEstado == 2
                             select c).ToList();
                return query;



            }





        }


        public void ActualizarEstado(int idcomprobante, int idestado)
        {
            using (Context = new DataModel.Entities())
            {
                var comprobante = (from c in Context.Table_Comprobante
                                   where c.IdComprobante == idcomprobante
                                   select c).ToList();

                foreach (var item in comprobante)
                {
                    Context.Table_Comprobante.Attach(item);
                    item.IdEstado = idestado;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }

            }






        }

        public List<DataModel.FACTURASXPROVEEDORES_Result> ListarFacturasXproveedores(DateTime fechainicio,DateTime fechafin,int idproveedor)
        {
            using (Context = new DataModel.Entities())
            {
                var query = Context.FACTURASXPROVEEDORES(fechainicio,fechafin,idproveedor);
                return query.ToList() ;

            }

        }

        public void ActualizarOtrosGastosComprobante(int idcomprobante, double iibb, double retenciones,double otrosgastos )
        {
            using (Context = new DataModel.Entities())
            {
               var query2 = (from c in Context.Table_Comprobante
                              where c.IdComprobante == idcomprobante
                              select c).ToList();


                foreach (var item in query2)
                {
                    Context.Table_Comprobante.Attach(item);

                    item.IIBB = iibb;
                    item.Retenciones = retenciones;
                    item.ConceptosNograbado = otrosgastos;

                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }


            }

        }

        public int ValidateComprobante(string sucursal, string nofactura)
        {
            int result;

            try
            {
                using (Context = new DataModel.Entities())
                {


                    var validatc = (from c in Context.Table_Comprobante
                                    where c.Sucursal == sucursal && c.NoFactura == nofactura
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
                using (Context = new DataModel.Entities())
                {

                    var comprobante = (from c in Context.Table_Comprobante
                                where c.Sucursal == sucursal && c.NoFactura==nofactura
                                select c).First();

                    Context.Table_Comprobante.Remove(comprobante);
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
