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
		/// <param name="roomnumber">int of the roomnumber</param>
		/// <param name="roomlocation">string of the roomlocation</param>
		/// <param name="date">timedate converted to sql timedate</param>
		public void ReserveWorkplace(string user, int roomnumber, string roomlocation, string roomdate)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"INSERT INTO reservations (username, room_number, room_location, date) VALUES (@User, @RoomNumber, @RoomLocation, @Date)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				MySqlParameter UserParam = new MySqlParameter("@User", MySqlDbType.VarChar);
				MySqlParameter RoomNumberParam = new MySqlParameter("@RoomNumber", MySqlDbType.Int32);
				MySqlParameter RoomLocationParam = new MySqlParameter("@RoomLocation", MySqlDbType.VarChar);
				MySqlParameter DateParam = new MySqlParameter("@Date", MySqlDbType.DateTime);

				// convert date to right sql format
				DateTime date = Convert.ToDateTime(roomdate);
				string formattedroomdate = date.ToString("yyyy-MM-dd HH:mm:ss.fff");

				UserParam.Value = user;
				RoomNumberParam.Value = roomnumber;
				RoomLocationParam.Value = roomlocation;
				DateParam.Value = formattedroomdate;

				command.Parameters.Add(UserParam);
				command.Parameters.Add(RoomNumberParam);
				command.Parameters.Add(RoomLocationParam);
				command.Parameters.Add(DateParam);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0 )
				{
					UD.RemoveWorkplace(roomnumber, roomlocation);

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
