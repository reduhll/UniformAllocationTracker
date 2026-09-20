using System;
using System.Data;
using System.Data.SQLite;
namespace UniformAllocationTracker
{

	public class UniformDatabase
	{
		private static string connectionString = "Data Source=UniformItem.db;Version=3";
		public static void InitializeDatabase()
		{
			using (SQLiteConnection connection
			= new SQLiteConnection(connectionString))
			{


				connection.Open();


				string sql = @"CREATE TABLE IF NOT EXISTS UniformItems( UniformID INTEGER PRIMARY KEY AUTOINCREMENT,
              ItemType TEXT NOT NULL, Size TEXT NOT NULL, AvailQuantity INTEGER NOT NULL)";

				using (SQLiteCommand command = new SQLiteCommand(sql, connection))
				{
					command.ExecuteNonQuery();

				}


			}
		}

		public static void AddUniform(
			string itemType,
			string size,
			int quantity)
		{
			using (SQLiteConnection connection
			= new SQLiteConnection(connectionString))
			{
				connection.Open();
				string sql = @"INSERT INTO UniformItems(ItemType, Size, AvailQuantity)
                      VALUES(@ItemType, @Size, @Qty)";

				using (SQLiteCommand command = new SQLiteCommand(sql, connection))
				{
					command.Parameters.AddWithValue(
						"@ItemType", itemType);

					command.Parameters.AddWithValue("@Size", size);

					command.Parameters.AddWithValue("@Qty", quantity);

					command.ExecuteNonQuery();
				}
			}

		}
		public static DataTable GetUniforms()
		{
			DataTable table = new DataTable();
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();
				string sql = "SELECT * FROM UniformItems";
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
				{
					adapter.Fill(table);
				}

			}
			return table;
		}

	}
}