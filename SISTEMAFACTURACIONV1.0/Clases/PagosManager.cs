using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class PagosManager
    {

        public Model.Entities Context;



        public int InsertarPagos(DateTime Fecha,double importe,string concepto)
        {
           
            using (Context=new Model.Entities())
            {
                int result;
                Model.Pagos pagos = new Model.Pagos();
                pagos.Fecha = Fecha;
                pagos.Importe = importe;
                pagos.Concepto = concepto;
                

                Context.Pagos.Add(pagos);
                Context.SaveChanges();
                result=   pagos.Idpago;

                
                return result;

            }



        }

        public int InsertarPagoContado(DateTime Fecha,string concepto,double importe)
        {

            using (Context = new Model.Entities())
            {
                int result;
                Model.Pagos pagos = new Model.Pagos();
                pagos.Fecha = Fecha;
                pagos.Importe = importe;
                pagos.Concepto = concepto;
                

                Context.Pagos.Add(pagos);
                Context.SaveChanges();
                result = pagos.Idpago;


                return result;

            }



        }

       




        public void InsertarDetallePago(int idpago,int idcomprobante)
        {

            using (Context=new Model.Entities())
            {
                Model.DetallesPago dpago = new Model.DetallesPago();

                dpago.IdPago = idpago;
                //dpago.idCuentaCorriente = idcuentacorriente;
                dpago.idComprobante = idcomprobante;

                Context.DetallesPago.Add(dpago);
                Context.SaveChanges();
             



            }




        }

        public List<Model.EncabezadoDeuda_Result> EncabezadpDeuda(int idprov)
        {
            using (Context = new Model.Entities())
            {
                var query = Context.EncabezadoDeuda(idprov);

                return query.ToList();

            }
        }


      public void InsertarDetallePagoCuentaCorriente(int idpago, int idcomprobante)
            {

            using (Context = new Model.Entities())
            {
                Model.DetallesPago dpago = new Model.DetallesPago();

                dpago.IdPago = idpago;
             
                dpago.idComprobante = idcomprobante;

                Context.DetallesPago.Add(dpago);
                Context.SaveChanges();




            }




        }

       
        public List<Model.OrdenPago_Result> OrdenPago(int idpago)
        {
            using (Context = new Model.Entities())
            {

                var query = Context.OrdenPago(idpago);

                return query.ToList();


            }
        }

        public List<Model.FacturasPendientesPago_Result> ListFacturasPendientesPago(int idproveedor)
        {
            using (Context=new Model.Entities())
            {

                var query = Context.FacturasPendientesPago(idproveedor);

                return query.ToList();


            }



        }

        public void InsertarMediosPago(int mediopago,DateTime FechaVencimiento,string nocheque,int idbanco,double importe,int idpago)
        {
            using (Context=new Model.Entities())
            {
                Model.DetalleMediosPagos Medio = new Model.DetalleMediosPagos();
                Medio.IdMedioPago = mediopago;
                Medio.NoCheque = nocheque;
                Medio.IdBanco = idbanco;
                Medio.Importe = importe;
                Medio.IdPago = idpago;
                Medio.FechaVencimientoCheque = FechaVencimiento;

                Context.DetalleMediosPagos.Add(Medio);
                Context.SaveChanges();
            }

        }

        public int DevolverMedioPago(string mediopago)
        {
            int result = 0;
            using (Context=new Model.Entities())
            {
                var query = (from m in Context.MediosPago
                             where m.MediosPago1 == mediopago
                             select m).FirstOrDefault();
                if (query != null)
                {
                    result = query.IdMedioPago;
                    return result;
                }
                else
                {
                   return result;
                }
                
            }


        }

        public int DevolverBanco(string banco)
        {
            int result = 0;
            using (Context = new Model.Entities())
            {
                var query = (from m in Context.Bancos   
                             where m.Nombre == banco
                             select m).FirstOrDefault();
                if (query != null)
                {
                    result = query.IdBanco;
                    return result;
                }
                else
                {
                    return result;
                }
            }


        }

        public List<Model.EncabezadoOrdenPago_Result> EncabezadoOdern(int idpago)
        {
            using (Context = new Model.Entities())
            {

                var query = Context.EncabezadoOrdenPago(idpago);

                return query.ToList();


            }

        }

        public List<Model.SeleccionarMediosDePagos_Result> MediosPagos(int idpago)
        {
            using (Context = new Model.Entities())
            {

                var query = Context.SeleccionarMediosDePagos(idpago);

                return query.ToList();


            }


        }

        public void InsertarMediosPagoContado(int mediopago,double importe, int idpago)
        {
         
            using (Context = new Model.Entities())
            {
                Model.DetalleMediosPagos Medio = new Model.DetalleMediosPagos();
                Medio.IdMedioPago = mediopago;
                Medio.Importe = importe;
                Medio.IdPago = idpago;

                Context.DetalleMediosPagos.Add(Medio);
                Context.SaveChanges();

            }   

               
        }

        public void ActualizarImportePago(int idpago)
        {
            using (Context = new Model.Entities())
            {
                var query = (from p in Context.Pagos
                             where p.Idpago == idpago
                             select p).ToList();

                var query2 = (from mp in Context.DetalleMediosPagos
                              where mp.IdPago == idpago
                              select mp.Importe).ToString() ;




                foreach (var item in query)
                {
                    Context.Pagos.Attach(item);

                    item.Importe =Convert.ToDouble(query2);

                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();
                }



            }

        }

            

        
    }
}
