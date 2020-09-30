using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectC_JITTS.Pages;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql;
using System.Data;

namespace ProjectC_JITTS.Pages
{
    public class RoomsModel : PageModel
    {
        protected MySqlConnection Connection;

        public string Message { get; private set; }
        public string Message2 { get; private set; }
        public void OnGet()
        {
            // string to connect to the database
            string dbstring = "server=localhost;user=root;pwd=admin;database=projectc";

            Connection = new MySqlConnection(dbstring);

            List<Tuple<string, string>> rooms = new List<Tuple<string, string>>();
            Connection.Open();
            string oString = @"SELECT * from rooms";
            MySqlCommand oCmd = new MySqlCommand(oString, Connection);
            string text = "";

            using (MySqlDataReader reader = oCmd.ExecuteReader())
            {
                DataTable dataTable = new DataTable();

                dataTable.Load(reader);

                foreach (DataRow row in dataTable.Rows)
                {
                    text = "room no = " + row["room_number"].ToString() + " - workplaces= " + row["workplaces"].ToString() + " - workplaces left = " + row["workplaces_available"].ToString() + " - location = " + row["room_location"].ToString();
                }

            }

            Message2 = "test: " + text;
        }
        public void ShowRooms()
        {
            
        }
    }
}
