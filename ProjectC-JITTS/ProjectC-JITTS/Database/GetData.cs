using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS.Database
{
    class GetData : Connecter
    {
        public List<Tuple<string, string, string, string>> ShowRooms()
        {
            List<Tuple<string, string, string, string>> roomList = new List<Tuple<string, string, string, string>>();
            try
            {
                List<int> MovieIDs = new List<int>();
                Connection.Open();
                string oString = @"SELECT * from rooms";
                MySqlCommand command = new MySqlCommand(oString, Connection);

                // creating the strings 
                string roomnumber;
                string workplaces;
                string workplacesAvailable;
                string roomlocation;

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    roomnumber = dataReader["room_number"].ToString();
                    workplaces = dataReader["workplaces"].ToString();
                    workplacesAvailable = dataReader["workplaces_available"].ToString();
                    roomlocation = dataReader["room_location"].ToString();

                    roomList.Add(Tuple.Create(roomnumber, workplaces, workplacesAvailable, roomlocation));
                }
                dataReader.Close();
                return roomList;
            }
            catch (MySqlException ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
