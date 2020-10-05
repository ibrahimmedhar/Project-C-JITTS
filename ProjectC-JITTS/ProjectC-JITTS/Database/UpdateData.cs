using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC_JITTS.Database
{
    class UpdateData : Connecter
    {
		/// <summary>
		/// After adding te reservation we want to remove 1 available workplace 
		/// </summary>
		/// <param name="roomnumber">int of the room number</param>
		/// <param name="roomlocation">string of the room location</param>
        public void RemoveWorkplace(int roomnumber, string roomlocation)
        {
			try
			{
				Connection.Open();

				string stringToInsert = @"UPDATE rooms SET workplaces_available = workplaces_available - 1 WHERE (room_number = @RoomNumber) and (room_location = @RoomLocation);";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				MySqlParameter RoomNumberParam = new MySqlParameter("@RoomNumber", MySqlDbType.Int32);
				MySqlParameter RoomLocationParam = new MySqlParameter("@RoomLocation", MySqlDbType.VarChar);

				RoomNumberParam.Value = roomnumber;
				RoomLocationParam.Value = roomlocation;

				command.Parameters.Add(RoomNumberParam);
				command.Parameters.Add(RoomLocationParam);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
					// code when succesful
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
