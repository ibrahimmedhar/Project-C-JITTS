using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS.Database
{
    class GetAllUsers : Connecter
    {

        public void FetchUsers()
        {
            try
            {
                Connection.Open();

                string query = "SELECT email, permission_level FROM projectc.accounts;";
                MySqlCommand cmd = new MySqlCommand(query, Connection);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

    }
}
