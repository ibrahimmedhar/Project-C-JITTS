using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS.Database
{
    class AddData : Connecter
    {
		UpdateData UD = new UpdateData();
		/// <summary>
		/// Add reservation to reservation table in sql and call removeWorkplace to remove an available workplace
		/// </summary>
		/// <param name="user">string of the username</param>
		/// <param name="room_id">id of the room with info</param>
		/// <param name="roomnumber">int of the roomnumber</param>
		/// <param name="roomlocation">string of the roomlocation</param>
		/// <param name="date">timedate converted to sql timedate</param>
		public bool ReserveWorkplace(string user, int room_id, int roomnumber, string roomlocation, string roomdate)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"INSERT INTO reservations (username, room_id, date) VALUES (@User, @RoomID, @Date)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);

				// convert date to right sql format
				DateTime date = Convert.ToDateTime(roomdate);
				string formattedroomdate = date.ToString("yyyy-MM-dd HH:mm:ss.fff");

				command.Parameters.AddWithValue("@User", user);
				command.Parameters.AddWithValue("@RoomID", room_id);
				command.Parameters.AddWithValue("@Date", formattedroomdate);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0 )
				{
					// if succesful remove an available workplace of a room with the right date
					return UD.RemoveWorkplace(room_id, formattedroomdate);
				}
				else
                {
					return false;
                }
			}
			catch (MySqlException)
			{
				throw;
			}
			finally
			{
				Connection.Close();
			}
		}

		public bool AddUser(string email, string password, int permissionlvl)
        {
			try
			{
				Connection.Open();

				string stringToInsert = @"INSERT INTO accounts (email, password, permission_level) VALUES (@Email, @Password, @PermissionLevel)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				command.Parameters.AddWithValue("@Email", email);
				command.Parameters.AddWithValue("@Password", password);
				command.Parameters.AddWithValue("@PermissionLEvel", permissionlvl);

				command.Prepare();

				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
					// if succesful 
					return true;
				}
                else
                {
					return false;
                }
			}
			catch (MySqlException)
			{
				throw;
			}
			finally
			{
				Connection.Close();
			}
		}

		public bool AddRoom(int roomno, int workplaces, string roomlocation, string locationname)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"INSERT INTO rooms (room_number, workplaces, room_location, location_name) VALUES (@RoomNo, @Workplaces, @RoomLocation, @LocationName)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				command.Parameters.AddWithValue("@RoomNo", roomno);
				command.Parameters.AddWithValue("@Workplaces", workplaces);
				command.Parameters.AddWithValue("@RoomLocation", roomlocation);
				command.Parameters.AddWithValue("@LocationName", locationname);

				command.Prepare();

				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
					// if succesful 
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (MySqlException)
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
