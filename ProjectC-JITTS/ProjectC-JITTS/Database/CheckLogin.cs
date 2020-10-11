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
        /// <summary>
        /// Checks if user is registered in the database to be able to login
        /// </summary>
        /// <param name="username">string of the username/email that belongs to the user that wants to log in</param>
        /// <param name="password">password for the account of the user</param>
        /// <returns>If the user is able to login of not to log in</returns>
        public bool TryLogin(string username, string password)
        {
            bool loggedIn = false;
            try
            {
                username = username.ToLower();
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
