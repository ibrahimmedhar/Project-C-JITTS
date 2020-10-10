using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS.Database
{
    class CheckLogin : Connecter
    {

        public bool TryLogin(string username, string password)
        {
            bool loggedIn = false;
            try
            {
                Connection.Open();

                string query = "SELECT COUNT(*) as account FROM `projectc`.`accounts` WHERE email = '" + username + "' AND password = '" + password + "';";

                MySqlCommand command = new MySqlCommand(query, Connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32("account") == 1)
                    {
                        loggedIn = true;
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return loggedIn;
        }

    }
}
