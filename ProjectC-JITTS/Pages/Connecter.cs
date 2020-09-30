using MySql.Data.MySqlClient;
using MySql.Data;
using MySql;
using System.Data;
using System.Collections.Generic;
using System;

namespace ProjectC_JITTS.Pages
{
    public abstract class Connecter
    {
        /// <summary>Connection that can only be inherited so you cannot blatently open the database</summary>
        protected MySqlConnection Connection;

        /// <summary>
        /// Initializes the connection
        /// </summary>
        protected Connecter()
        {
            Initialize();
        }

        /// <summary>
        /// not using this yet
        /// </summary>
        private void Initialize()
        {
            string dbstring = "server=localhost;user=root;pwd=admin;database=projectc";
            Connection = new MySqlConnection(dbstring);
        }
    }
}