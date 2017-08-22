using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
   public class ProveedorManager
    {
        //declaracion de DataContext y de la tabla proveedores
        public DataModel.Entities Context;
        public  DataModel.Table_Proveedores proveedor = new DataModel.Table_Proveedores();
        public DataModel.Table_CuentaCorriente cuentacorriente;
        

        public void insertar_proveedor(DataModel.Table_Proveedores proveedor)
        {
            using (Context=new DataModel.Entities())
            {
                Context.Table_Proveedores.Add(proveedor);
                Context.SaveChanges();

            }






        }

        public List<DataModel.View_Proveedores> ListarProveedores()
        {

            using (Context=new DataModel.Entities()) {
                var query = (from listproveedor in Context.View_Proveedores select listproveedor).ToList();
                return query;
            }
        }

        public List<DataModel.View_Proveedores> filtrarproveedores(string filtronombre)
        {
            using (Context = new DataModel.Entities()) {
                var filtro = (from p in Context.View_Proveedores where p.Nombre.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            } }

        public int EliminarProveedor(string cuit)
        {
            try
            {
                using (Context=new DataModel.Entities())
                {

                    var prov = (from p in Context.Table_Proveedores where p.Cuit == cuit select p).First();

                    Context.Table_Proveedores.Remove(prov);
                    Context.SaveChanges();
                    int result = 1;
                    return result;


                }
            }
            catch (Exception)
            {

                throw;
            }









            //}

        }

        public DataModel.Table_Proveedores EncontrarProveedor(string cuit)
        {
            using (Context=new DataModel.Entities()) {
                var query = (from p in Context.Table_Proveedores
                             where p.Cuit == cuit
                             select p).FirstOrDefault();

                return query;
            }
        }

       



        

        public void ActualizarProveedor(string nombre, string razon,string telefono,string direccion,string cuit)
        {
            using (Context = new DataModel.Entities())
            {
                var prov = (from p in Context.Table_Proveedores
                            where p.Cuit == cuit
                            select p).ToList();

                foreach (var item in prov)
                {
                    Context.Table_Proveedores.Attach(item);
                    item.Nombre = nombre;
                    item.Razon = razon;
                    item.Telefono = telefono;
                    item.Direccion = direccion;
                    Context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges();

                }     
                
            }

        }

        public int DevolverIdPRoveedorporNombre(string nombre)
        {
            int result = 0;
            using (Context=new DataModel.Entities())
            {
                var query =( from p in Context.Table_Proveedores
                            where p.Nombre == nombre
                            select p.IdProveedores).FirstOrDefault().ToString() ;
               result=int.Parse(query);
               return result;
            }
            

        }

        public void CrearCuentaCorriente(DataModel.Table_CuentaCorriente cuentacorriente)
        {
            using (Context = new DataModel.Entities())
            {
                Context.Table_CuentaCorriente.Add(cuentacorriente);
                Context.SaveChanges();


            }



        }

        public int devolverIDProveedorCUIT(string cuit)
        {
            using (Context = new DataModel.Entities())
            {
                int result = 0;

                var query = (from p in Context.Table_Proveedores
                             where p.Cuit == cuit
                             select p.IdProveedores).FirstOrDefault();

               result=int.Parse(query.ToString());
                return result;
            }
        }

        public int ValidateProveedor(string cuit)
        {
            int result;

            try
            {
                using (Context = new DataModel.Entities())
                {


                    var validatprov = (from p in Context.Table_Proveedores
                                       where p.Cuit == cuit
                                       select p).FirstOrDefault();

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

        public int ValidateCuentaCorriente(string cuit)
        {
            int result;

            try
            {
                using (Context = new DataModel.Entities())
                {


                    var validatprov = (from c in Context.Table_CuentaCorriente
                                       where c.Nombre == cuit
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

        public string DevolverCuit(int idproveedor)
        {
            using (Context=new DataModel.Entities())
            {
                var query = (from p in Context.Table_Proveedores
                             where p.IdProveedores == idproveedor
                             select p.Cuit).ToString();
                return query;
            }

        }

        public List<string> listarNombreProveedores()
        {
            using (Context=new DataModel.Entities())
            {

                var query = (from p in Context.Table_Proveedores
                             select p.Nombre).ToList();

                return query;
            }


        }


        public List<DataModel.View_Proveedores> filtrarproveedoresRazon(string filtroRazon)
        {
            using (Context = new DataModel.Entities())
            {
                var filtro = (from p in Context.View_Proveedores where p.Razon.Contains(filtroRazon.ToUpper()) select p).ToList();
                return filtro;
            }
        }



    }
}
