using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAFACTURACIONV1._0
{
  public class UserManager
    {
        public DataModel.Entities Context;



        public int ValidateUser(string username, string password)
        {
            int result;

            try

            {
                using (Context=new DataModel.Entities())
                {
                    var validateuser = (from u in Context.Table_User
                                        where u.name == username && u.Password == password
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
            using (Context=new DataModel.Entities())
            {
                var query = (from u in Context.Table_User
                             where u.name == user && u.Password == pass
                             select u.name).FirstOrDefault().ToString();
                return query;

            }
        }

        public List<String> ListarUsername()
        {
            using (Context=new DataModel.Entities())
            {
                var query = (from u in Context.Table_User
                             select u.name).ToList();
                return query;
            }

        }

    }
}
