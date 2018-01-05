using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
  public class UserManager
    {
        public Model.Entities Context;



        public int ValidateUser(string username, string password)
        {
            int result;

            try

            {
                using (Context=new Model.Entities())
                {
                    var validateuser = (from u in Context.Users
                                        where u.Username == username && u.Password == password
                                        select u).FirstOrDefault();
                    if (validateuser != null)
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
            catch (Exception)            {

                throw;
            }

        }

        public string Devolvernombre(string user, string pass)
        {
            using (Context=new Model.Entities())
            {
                var query = (from u in Context.Users
                             where u.Username == user && u.Password == pass
                             select u.Username).FirstOrDefault().ToString();
                return query;

            }
        }

        public List<String> ListarUsername()
        {
            using (Context=new Model.Entities())
            {
                var query = (from u in Context.Users
                             select u.Username).ToList();
                return query;
            }

        }

        public int AuthorizationPRofile(string username, string password)
        {
            int result = 0;
            using (Context= new Model.Entities())
            {
                var iduser =(from p in Context.Users
                            where p.IDUser== username && p.Password==password
                            select p).FirstOrDefault();

                result = int.Parse(iduser.IDProfile.ToString());
                return result;




            }






        }

        public int Profile(string username, string password)
        {
            int result=0;

            try

            {
                using (Context = new Model.Entities())
                {
                    var idprofile = (from u in Context.Users
                                        where u.Username == username && u.Password == password
                                        select u.IDProfile).FirstOrDefault();

                    result = idprofile.Value;
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
