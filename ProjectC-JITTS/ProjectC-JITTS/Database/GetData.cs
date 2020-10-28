﻿using MySql.Data.MySqlClient;
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
        /// importent class saved while the application is running!
        /// </summary>
        public static class LoginInfo
        {
            public static string UserID;
            public static int PermissionLevel;
        }

        public List<string> ShowLocations()
        {
            List<string> locationList = new List<string>();
            try
            {
                Connection.Open();
                string oString = @"SELECT DISTINCT room_location from rooms";
                MySqlCommand command = new MySqlCommand(oString, Connection);

                string roomlocation;
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    roomlocation = dataReader["room_location"].ToString();
                    locationList.Add(roomlocation);
                }
                
                dataReader.Close();
                return locationList;
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

        public List<string> ShowDatesByLocation(string location)
        {
            List<string> dateList = new List<string>();
            try
            {
                Connection.Open();
                string oString = @"SELECT DISTINCT workplaces.date FROM workplaces LEFT JOIN rooms ON rooms.room_id = workplaces.room_id WHERE rooms.room_location = @loc";
                MySqlCommand oCmd = new MySqlCommand(oString, Connection);
                oCmd.Parameters.AddWithValue("@loc", location);

                string roomdate;
                MySqlDataReader dataReader = oCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    roomdate = dataReader["date"].ToString();
                    dateList.Add(roomdate);
                }

                dataReader.Close();
                return dateList;
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
                Connection.Open();
                string oString = @"SELECT rooms.*, workplaces.workplaces_available FROM rooms LEFT JOIN workplaces ON rooms.room_id=workplaces.room_id";
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

        public List<Tuple<int, string, string, string, string, string, string >> ShowRoomsByDateAndLoc(string roomdate, string location)
        {
            List<Tuple<int, string, string, string, string, string, string>> roomList = new List<Tuple<int, string, string, string, string, string, string>>();

            try
            {
                Connection.Open();
                string oString = @"SELECT rooms.*, workplaces.workplaces_available, workplaces.date FROM rooms LEFT JOIN workplaces ON rooms.room_id = workplaces.room_id WHERE workplaces.date = @roomdate AND room_location = @loc AND workplaces.workplaces_available > 0";

                MySqlCommand oCmd = new MySqlCommand(oString, Connection);

                DateTime date = Convert.ToDateTime(roomdate);
                string formattedroomdate = date.ToString("yyyy-MM-dd HH:mm:ss.fff");

                oCmd.Parameters.AddWithValue("@roomdate", formattedroomdate);
                oCmd.Parameters.AddWithValue("@loc", location);

                // creating the strings
                string roomid;
                string roomnumber;
                string workplaces;
                string workplacesAvailable;
                string roomlocation;
                string roomlocationname;

                MySqlDataReader dataReader = oCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    roomid = dataReader["room_id"].ToString();
                    roomnumber = dataReader["room_number"].ToString();
                    workplaces = dataReader["workplaces"].ToString();
                    workplacesAvailable = dataReader["workplaces_available"].ToString();
                    roomlocation = dataReader["room_location"].ToString();
                    roomlocationname = dataReader["location_name"].ToString();

                    roomList.Add(Tuple.Create(Int32.Parse(roomid), roomnumber, workplaces, workplacesAvailable, roomlocation, roomdate, roomlocationname));
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

        public Tuple<string, string, string, string, string, string> ShowRoomByKeys(int room_id)
        {
            try
            {
                Connection.Open();
                string oString = @"SELECT rooms.*, workplaces.workplaces_available, workplaces.date FROM rooms LEFT JOIN workplaces ON rooms.room_id = workplaces.room_id WHERE workplaces.room_id = @roomid AND workplaces.workplaces_available > 0";
                MySqlCommand oCmd = new MySqlCommand(oString, Connection);
                oCmd.Parameters.AddWithValue("@roomid", room_id);

                using (MySqlDataReader getRoom = oCmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Load(getRoom);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        return Tuple.Create(row["room_number"].ToString(), row["workplaces"].ToString(), row["workplaces_available"].ToString(), row["room_location"].ToString(), row["date"].ToString(), row["location_name"].ToString());
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
            return Tuple.Create("", "", "", "","","");
        }

        public Tuple<string,int> ShowAccountInfo(string email)
        {
            try
            {
                Connection.Open();
                string oString = @"SELECT * from accounts WHERE email = @email";
                MySqlCommand oCmd = new MySqlCommand(oString, Connection);

                oCmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader getRoom = oCmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Load(getRoom);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        return Tuple.Create(row["email"].ToString(), Int32.Parse(row["permission_level"].ToString()));
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
            return Tuple.Create("",0);
        }
    }
}
