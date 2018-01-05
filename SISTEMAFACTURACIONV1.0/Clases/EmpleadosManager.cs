using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class EmpleadosManager
    {
       public Model.Entities Context;
       public Model.Empleados empleado=new Model.Empleados();
        public Model.Departamentos departamento;
        public Model.ObraSocial obrasocial;
        public Model.Sindicatos sindicato;
        public Model.CategoriaEmpleado categoriaempleado;
        public Model.Personas solicitudempleo;
        public Model.AfectadoEmpresaCliente objectempresacliente;
       
        public EmpleadosManager() { }

       

       public List<Model.Departamentos> ListarDepartamentos()
        {
            using (Context = new Model.Entities())
            {
                var query = (from d in Context.Departamentos
                            select d).ToList();
                return query;
            }




        }

        public List<Model.Solicitudesempleos> ListarSolicitudesEmpleo()
        {
            using (Context = new Model.Entities())
            {
                var query = (from d in Context.Solicitudesempleos
                             select d).ToList();
                return query;
            }




        }

        public List<Model.ObraSocial> ListarObraSocial()
        {
            using (Context = new Model.Entities())
            {
                var query = (from d in Context.ObraSocial
                             select d).ToList();
                return query;
            }




        }

        public List<Model.Sindicatos> ListarSindicatos()
        {
            using (Context = new Model.Entities())
            {
                var query = (from d in Context.Sindicatos
                             select d).ToList();
                return query;
            }




        }

        public List<Model.Especialidades> ListarEspecialidades()
        {
            using (Context = new Model.Entities())
            {
                var query = (from d in Context.Especialidades
                             select d).ToList();
                return query;
            }




        }

        public List<Model.CategoriaEmpleado> ListarCategoriaEmpleado()
        {
            using (Context = new Model.Entities())
            {
                var query = (from d in Context.CategoriaEmpleado
                             select d).ToList();
                return query;
            }




        }

        public int InsertarEmpleadoBasico(string nolegajo, int persona, int departamento,int sindicato,DateTime fechaingreso,
            int especialidad,int categoria,bool activo,bool ieric,string comentario)
        {
            int result = 0;
            using (Context=new Model.Entities())
            {
                empleado.NoLegajo = nolegajo;
                empleado.idPersona = persona;
                empleado.idDepartamento = departamento;
                empleado.idSindicato = sindicato;
                empleado.FechaIngreso = fechaingreso;
                empleado.idEspecialidad = especialidad;
                empleado.idCategoriaEmpleado = categoria;
   
                empleado.Activo = activo;
                empleado.Ieric = ieric;
                empleado.Comentario = comentario;
                Context.Empleados.Add(empleado);
                Context.SaveChanges();
                result = empleado.IDEmpleado;
                return result;

            }


        }

        public int DevolverNolegajo(int persona,string nolegajo)
        {
            int result=0;
            using (Context=new Model.Entities())
            {
                var query = (from obj in Context.Empleados
                            select obj.NoLegajo).FirstOrDefault();
                if (query==nolegajo)
                {
                    return result;
                }
                else
                {
                    return 1;
                }
            }

        }

        public List<Model.DatosEmpleadosActivos> ListarEmpleadosActivos() {

            using (Context=new Model.Entities())
            {
                var query = (from obj in Context.DatosEmpleadosActivos
                             select obj).ToList();
                return query;
            }



        }
        public List<Model.DatosEmpleadosActivos> ListarEmpleadosActivosporID(int id)
        {

            using (Context = new Model.Entities())
            {
                var query = (from obj in Context.DatosEmpleadosActivos
                             where obj.IDEmpleado == id

                             select obj).ToList();
                return query;
            }



        }


       
    }
}
