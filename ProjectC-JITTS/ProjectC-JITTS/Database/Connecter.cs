using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectC_JITTS.Database
{
    class Connecter
    {
        protected MySqlConnection Connection;

        protected Connecter()
        {
            Initialize();
        }

        private void Initialize()
        {
            string dbstring = "server=localhost;user=root;pwd=admin;database=projectc";
            Connection = new MySqlConnection(dbstring);
        }
    }


}
