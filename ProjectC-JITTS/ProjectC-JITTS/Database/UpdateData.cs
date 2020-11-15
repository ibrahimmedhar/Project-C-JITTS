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

        public bool RemoveAvailableWorkplace(int room_id, string date)
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

		public bool AddAvailableWorkplace(string added_wp, string room_id)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"UPDATE workplaces SET workplaces_available = workplaces_available + @addedwp WHERE (room_id = @roomid);";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);

				command.Parameters.AddWithValue("@addedwp", added_wp);
				command.Parameters.AddWithValue("@roomid", room_id);

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

		public bool RemoveRoom(int room_id)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"DELETE FROM rooms WHERE (room_id = @roomid)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);

				command.Parameters.AddWithValue("@roomid", room_id);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
					Connection.Close();
					// if room was deleted, delete all workplaces connected to that room
					if (RemoveWorkplace(room_id))
                    {
						Connection.Open();
						return true;
					}
					else
                    {
						return false;
                    }
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

		public bool EditRoom(string added_wp, string room_loc, string loc_name, string room_id)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"UPDATE rooms SET workplaces = workplaces + @addedwp, room_location = @roomlocation, location_name = @locationname WHERE (room_id = @roomid)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);

				command.Parameters.AddWithValue("@addedwp", added_wp);
				command.Parameters.AddWithValue("@roomlocation", room_loc);
				command.Parameters.AddWithValue("@locationname", loc_name);
				command.Parameters.AddWithValue("@roomid", room_id);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
					// added workplaces, add these extra workplaces to the old workplaces
					Connection.Close();
					if (AddAvailableWorkplace(added_wp, room_id))
                    {
						Connection.Open();
						return true;
					}
					else
                    {
						return false;
                    }
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

		public bool RemoveWorkplace(int room_id)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"DELETE FROM workplaces WHERE (room_id = @roomid)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);

				command.Parameters.AddWithValue("@roomid", room_id);

				command.Prepare();
				int rowsUpdated = command.ExecuteNonQuery();
				if (rowsUpdated != 0)
				{
					// if workplace was deleted, return true
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
