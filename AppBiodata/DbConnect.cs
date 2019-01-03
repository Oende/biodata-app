using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiodataDbConnect
{
	class DBConnect
	{
		private MySqlConnection connection;
		private string server;
		private string database;
		private string uid;
		private string password;

		//Constructor
		public DBConnect()
		{
			Initialize();
		}

		//Initialize values
		private void Initialize()
		{
			server = "localhost";
			database = "connectcsharptomysql";
			uid = "root";
			password = "";
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" +
			database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

			connection = new MySqlConnection(connectionString);
		}

		//open connection to database
		private bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch(MySqlException ex)
			{
				//When handling errors, you can your application's response based 
				//on the error number.
				//The two most common error numbers when connecting are as follows:
				//0: Cannot connect to server.
				//1045: Invalid user name and/or password.
				switch(ex.Number)
				{
					case 0:
						MessageBox.Show("Cannot connect to server.  Contact administrator");
						break;

					case 1045:
						MessageBox.Show("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}

		//Close connection
		private bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch(MySqlException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		//Create statement
		public bool Create(String[] data)
		{
			string query = "INSERT INTO biodata VALUES(null, @val1, @val2, @val3, @val4, @val5)";

			//open connection
			if(this.OpenConnection() == true)
			{
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@val1", data[0]);
				cmd.Parameters.AddWithValue("@val2", data[1]);
				cmd.Parameters.AddWithValue("@val3", data[2]);
				cmd.Parameters.AddWithValue("@val4", data[3]);
				cmd.Parameters.AddWithValue("@val5", data[4]);

				cmd.Prepare();
				cmd.ExecuteNonQuery();
				this.CloseConnection();
				return true;
			}
			return false;
		}

		//Read statement
		public String[,] Select()
		{
			string query = "SELECT * FROM biodata";
			int inc = 0;

			//Create a list to store the result
			List<String> list = new List<String>();
			String[,] data = new string[inc, 6];

			if(this.OpenConnection() == true)
			{
				//Create Command
				MySqlCommand cmd = new MySqlCommand(query, connection);
				//Create a data reader and Execute the command
				MySqlDataReader dataReader = cmd.ExecuteReader();

				// Storing data into array
				for(int i = 0; dataReader.Read() == true; i++)
				{
					for(int j = 0; j == 0; j++)
					{
						list.Add(dataReader["id"].ToString());
						list.Add(dataReader["name"].ToString());
						list.Add(dataReader["gender"].ToString());
						list.Add(dataReader["date_born"].ToString());
						list.Add(dataReader["phone"].ToString());
						list.Add(dataReader["address"].ToString());
					}
					++inc;
				}
				data = new string[inc, 6];
				int z = 0;
				for(int i = 0; i < inc; i++)
				{
					for(int j = 0; j == 0; j++)
					{
						data[i, 0] = list[z];
						data[i, 1] = list[z+1];
						data[i, 2] = list[z+2];
						data[i, 3] = list[z+3];
						data[i, 4] = list[z+4];
						data[i, 5] = list[z+5];
					}
					z += 6;
				}
				//close Data Reader
				dataReader.Close();

				//close Connection
				this.CloseConnection();

				//return list to be displayed
				return data;
			} else
			{
				return data;
			}
		}

		//Update statement
		public void Update()
		{
			string query = "UPDATE biodata SET name='Joe' WHERE id";
			
			if(this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand();
				//Assign the query using CommandText
				cmd.CommandText = query;
				//Assign the connection using Connection
				cmd.Connection = connection;
				
				cmd.ExecuteNonQuery();
				this.CloseConnection();
			}
		}

		//Delete statement
		public void Delete()
		{
			string query = "DELETE FROM biodata WHERE id";

			if(this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				this.CloseConnection();
			}
		}

		

		//Count statement
		public int Count()
		{
			string query = "SELECT Count(*) FROM biodata";
			int Count = -1;

			//Open Connection
			if(this.OpenConnection() == true)
			{
				//Create Mysql Command
				MySqlCommand cmd = new MySqlCommand(query, connection);

				//ExecuteScalar will return one value
				Count = int.Parse(cmd.ExecuteScalar() + "");

				//close Connection
				this.CloseConnection();

				return Count;
			} else
			{
				return Count;
			}
		}

		//Backup
		public void Backup()
		{
			try
			{
				DateTime Time = DateTime.Now;
				int year = Time.Year;
				int month = Time.Month;
				int day = Time.Day;
				int hour = Time.Hour;
				int minute = Time.Minute;
				int second = Time.Second;
				int millisecond = Time.Millisecond;

				//Save file to C:\ with the current date as a filename
				string path;
				path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
			"-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
				StreamWriter file = new StreamWriter(path);


				ProcessStartInfo psi = new ProcessStartInfo();
				psi.FileName = "mysqldump";
				psi.RedirectStandardInput = false;
				psi.RedirectStandardOutput = true;
				psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
					uid, password, server, database);
				psi.UseShellExecute = false;

				Process process = Process.Start(psi);

				string output;
				output = process.StandardOutput.ReadToEnd();
				file.WriteLine(output);
				process.WaitForExit();
				file.Close();
				process.Close();
			}
			catch(IOException ex)
			{
				MessageBox.Show("Error , unable to backup!");
			}
		}

		//Restore
		public void Restore()
		{
			try
			{
				//Read file from C:\
				string path;
				path = "C:\\MySqlBackup.sql";
				StreamReader file = new StreamReader(path);
				string input = file.ReadToEnd();
				file.Close();

				ProcessStartInfo psi = new ProcessStartInfo();
				psi.FileName = "mysql";
				psi.RedirectStandardInput = true;
				psi.RedirectStandardOutput = false;
				psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
					uid, password, server, database);
				psi.UseShellExecute = false;


				Process process = Process.Start(psi);
				process.StandardInput.WriteLine(input);
				process.StandardInput.Close();
				process.WaitForExit();
				process.Close();
			}
			catch(IOException ex)
			{
				MessageBox.Show("Error , unable to Restore!");
			}
		}
	}
}
