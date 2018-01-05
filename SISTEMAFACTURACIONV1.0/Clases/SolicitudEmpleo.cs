using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0.Clases
{
   public class SolicitudEmpleo
    {
        private Model.Entities Context;
        private Model.Personas solicitud;


        public int DevolverDNI_CUIL(string dni, string cuil)
        {
            int result = 0;
            using (Context = new Model.Entities())
            {
                var validateuser = (from u in Context.Personas
                                    where u.DNI == dni|| u.CUIL == cuil
                                    select u).FirstOrDefault();
                if (validateuser!=null)
                {
                    return result=1;
                }
                else
                {
                    return 0;
                }
            }

        }

        public List<Model.DetallesSolicitudesEmpleo> ListarSolicitudesEmpleo()
        {
           
            using (Context = new Model.Entities())
            {
                var query = (from obj in Context.DetallesSolicitudesEmpleo
                             select obj).ToList();
                return query;
            }

        }

        public List<Model.DetallesSolicitudesEmpleo> filtrarsolicitudespornombre(string filtronombre)
        {
            using (Context = new Model.Entities())
            {
                var filtro = (from p in Context.DetallesSolicitudesEmpleo where p.Apellido.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public List<Model.DetallesSolicitudesEmpleo> filtrarsolicitudesporcuil(string filtronombre)
        {
            using (Context = new Model.Entities())
            {
                var filtro = (from p in Context.DetallesSolicitudesEmpleo where p.CUIL.Contains(filtronombre.ToUpper()) select p).ToList();
                return filtro;
            }
        }

        public void EliminarSolicitudEmpleo(string cuil)
        {

            int idp = 0;
            using (Context = new Model.Entities())
            {
                var objectpersona = (from p in Context.Personas
                                    where p.CUIL==cuil
                                    select p.IdPersona).First();

                idp = int.Parse(objectpersona.ToString());

                var objectsolicitud = (from s in Context.SolicitudesEmpleo
                                       where s.idPersona == idp
                                       select s).First();

               

                var query = (from p in Context.Personas
                             where p.CUIL == cuil
                             select p).First();
                Context.SolicitudesEmpleo.Remove(objectsolicitud);
                Context.SaveChanges();
                Context.Personas.Remove(query);
                Context.SaveChanges();

            }



        }

    }
}
