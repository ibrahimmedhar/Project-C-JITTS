using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS.Database
{
    class GetData : Connecter
    {
        /// <summary>
        /// Show room information from the database
        /// </summary>
        /// <returns>
        /// Returns a List of Rooms
        /// </returns>
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

        public Tuple<string, string, string, string> ShowRoomByNoAndLoc(string roomnumber, string location)
        {
            try
            {
                Connection.Open();
                string oString = @"SELECT * from projectc.rooms WHERE room_number = @id AND room_location = @loc AND workplaces_available > 0";
                MySqlCommand oCmd = new MySqlCommand(oString, Connection);
                oCmd.Parameters.AddWithValue("@id", roomnumber);
                oCmd.Parameters.AddWithValue("@loc", location);

                using (MySqlDataReader getMovieInfo = oCmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Load(getMovieInfo);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        return Tuple.Create(row["room_number"].ToString(), row["workplaces"].ToString(), row["workplaces_available"].ToString(), row["room_location"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return Tuple.Create("", "", "", "");
        }
    }
}
