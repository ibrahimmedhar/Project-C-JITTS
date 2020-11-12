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

        public bool RemoveWorkplace(int room_id, string date)
        {
			try
			{
				Connection.Open();

				string stringToInsert = @"UPDATE workplaces SET workplaces_available = workplaces_available - 1 WHERE (room_id = @roomid) AND (date = @reservationdate);";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);

				command.Parameters.AddWithValue("@roomid", room_id);
				command.Parameters.AddWithValue("@reservationdate", date);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
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
