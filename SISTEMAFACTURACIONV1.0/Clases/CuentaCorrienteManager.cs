using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class CuentaCorrienteManager

    {
       public DataModel.Entities Context;

        public int ValidateCuentaCorriente(string nombre)
        {
            using (Context = new DataModel.Entities())

            {
                int result;
                var validatecuenta = (from c in Context.Table_CuentaCorriente
                                      where c.Nombre == nombre
                                      select c).FirstOrDefault();
                if (validatecuenta != null)
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

        public int DevolverIDCuentaCorriente(int idproveedor)
        {
            int result;
            using (Context=new DataModel.Entities())
            {
                var query = (from c in Context.Table_CuentaCorriente
                             where c.IDProveedor==idproveedor
                             select c.IdCuentaCorriente).FirstOrDefault().ToString();
               
                return result = int.Parse(query);
            }

        }

       

        public int ValidateCuentaCorrienteProveedor(int idproveedor)
        {
            int result;

            try
            {
                using (Context = new DataModel.Entities())
                {


                    var validatprov = (from c in Context.Table_CuentaCorriente
                                       where c.IDProveedor==idproveedor
                                       select c).FirstOrDefault();

                    if (validatprov != null)
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
            catch (Exception)
            {

                throw;
            }

        }


    }
}
