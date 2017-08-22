using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class PagosManager
    {

        public DataModel.Entities Context;



        public int InsertarPagos(DateTime Fecha,double importe,string concepto)
        {
           
            using (Context=new DataModel.Entities())
            {
                int result;
                DataModel.Table_Pagos pagos = new DataModel.Table_Pagos();
                pagos.Fecha = Fecha;
                pagos.Importe = importe;
                pagos.Concepto = concepto;
                

                Context.Table_Pagos.Add(pagos);
                Context.SaveChanges();
                result=   pagos.Idpago;

                
                return result;

            }



        }

        public int InsertarPagoContado(DateTime Fecha,string concepto,double importe)
        {

            using (Context = new DataModel.Entities())
            {
                int result;
                DataModel.Table_Pagos pagos = new DataModel.Table_Pagos();
                pagos.Fecha = Fecha;
                pagos.Importe = importe;
                pagos.Concepto = concepto;
                

                Context.Table_Pagos.Add(pagos);
                Context.SaveChanges();
                result = pagos.Idpago;


                return result;

            }



        }

       




        public void InsertarDetallePago(int idpago,int idcomprobante)
        {

            using (Context=new DataModel.Entities())
            {
                DataModel.Table_DetallePago dpago = new DataModel.Table_DetallePago();

                dpago.IdPago = idpago;
                //dpago.idCuentaCorriente = idcuentacorriente;
                dpago.idComprobante = idcomprobante;

                Context.Table_DetallePago.Add(dpago);
                Context.SaveChanges();
             



            }




        }

        public List<DataModel.EncabezadoDeuda_Result> EncabezaDeuda(int idprov)
        {
            using (Context = new DataModel.Entities())
            {
                var query = Context.EncabezadoDeuda(idprov);

                return query.ToList();

            }
        }


      public void InsertarDetallePagoCuentaCorriente(int idpago, int idcomprobante)
            {

            using (Context = new DataModel.Entities())
            {
                DataModel.Table_DetallePago dpago = new DataModel.Table_DetallePago();

                dpago.IdPago = idpago;
             
                dpago.idComprobante = idcomprobante;

                Context.Table_DetallePago.Add(dpago);
                Context.SaveChanges();




            }




        }

       
        public List<DataModel.OrdenPago_Result> OrdenPago(int idpago)
        {
            using (Context = new DataModel.Entities())
            {

                var query = Context.OrdenPago(idpago);

                return query.ToList();


            }
        }

        public List<DataModel.FacturasPendientesPago_Result> ListFacturasPendientesPago(int idproveedor)
        {
            using (Context=new DataModel.Entities())
            {

                var query = Context.FacturasPendientesPago(idproveedor);

                return query.ToList();


            }



        }

        public void InsertarMediosPago(int mediopago,string nocheque,int idbanco,double importe,int idpago)
        {
            using (Context=new DataModel.Entities())
            {
                DataModel.Table_DetalleMediosPago Medio = new DataModel.Table_DetalleMediosPago();
                Medio.IdMedioPago = mediopago;
                Medio.NoCheque = nocheque;
                Medio.IdBanco = idbanco;
                Medio.Importe = importe;
                Medio.IdPago = idpago;

                Context.Table_DetalleMediosPago.Add(Medio);
                Context.SaveChanges();
            }

        }

        public int DevolverMedioPago(string mediopago)
        {
            int result = 0;
            using (Context=new DataModel.Entities())
            {
                var query = (from m in Context.Table_MedioPago
                             where m.MediosPago == mediopago
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
            using (Context = new DataModel.Entities())
            {
                var query = (from m in Context.Table_Banco   
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

        public List<DataModel.EncabezadoOrdenPago_Result> EncabezadoOdern(int idpago)
        {
            using (Context = new DataModel.Entities())
            {

                var query = Context.EncabezadoOrdenPago(idpago);

                return query.ToList();


            }

        }

        public List<DataModel.SeleccionarMediosDePagos_Result> MediosPagos(int idpago)
        {
            using (Context = new DataModel.Entities())
            {

                var query = Context.SeleccionarMediosDePagos(idpago);

                return query.ToList();


            }


        }

        public void InsertarMediosPagoContado(int mediopago,double importe, int idpago)
        {
         
            using (Context = new DataModel.Entities())
            {
                DataModel.Table_DetalleMediosPago Medio = new DataModel.Table_DetalleMediosPago();
                Medio.IdMedioPago = mediopago;
                Medio.Importe = importe;
                Medio.IdPago = idpago;

                Context.Table_DetalleMediosPago.Add(Medio);
                Context.SaveChanges();

            }   

               
        }

        public void ActualizarImportePago(int idpago)
        {
            using (Context = new DataModel.Entities())
            {
                var query = (from p in Context.Table_Pagos
                             where p.Idpago == idpago
                             select p).ToList();

                var query2 = (from mp in Context.Table_DetalleMediosPago
                              where mp.IdPago == idpago
                              select mp.Importe).ToString() ;




                foreach (var item in query)
                {
                    Context.Table_Pagos.Attach(item);

                    item.Importe =Convert.ToDouble(query2);

                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();
                }



            }

        }

            

        
    }
}
