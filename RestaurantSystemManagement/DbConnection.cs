using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace RestaurantSystemManagement
{
    class DbConnection
    {
        private string connectionString;
        private OleDbConnection connection;

        public DbConnection(string databasePath)
        {
           
            //connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";
            connectionString = $"Provider = Microsoft.Jet.OLEDB.4.0; Data Source={databasePath};";
            connection = new OleDbConnection(connectionString);

        }
        public DataTable Search(string query)
        {

            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing search query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        public User CheckUser(string userName , string password)
        {
            User user = null;
            string check = "";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT COUNT(*)  FROM Users WHERE UserName = @name and UserPassword = @pass;", connection);
                command.Parameters.AddWithValue("@name", userName);
                command.Parameters.AddWithValue("@pass", password);
                int i = (int)command.ExecuteScalar();
                if (i > 0)
                {
                   // MessageDialog.ShowDialog("kdjf");
                    check = "exist";

                    connection.Close();
                    string id = Program.dbase.ReadValue("SELECT UserID  FROM Users WHERE UserName = '"+userName+"'  AND UserPassword = "+password+" ;");
                    OleDbConnection con = new OleDbConnection(this.connectionString);
                    con.Open();

                  
                    OleDbCommand query = new OleDbCommand("SELECT PermissionID FROM UserPermissions WHERE UserID = " + id + ";", con);
                    OleDbDataReader reader = query.ExecuteReader();
                    bool[] pers = new bool[4];
                    
                   while (reader.Read())
                    {
                        
                        if (reader["PermissionID"].ToString() == "1")
                        {
                            pers[0] = true;
                           

                        }
                         if (reader["PermissionID"].ToString() == "2")
                        {
                            pers[1] = true;
                           
                        }
                        if (reader["PermissionID"].ToString() == "3")
                        {
                            pers[2] = true;
                           
                        }
                    }
                    user = new User(int.Parse(id), userName, password, pers[2], pers[0], pers[1]);
                    con.Close();

                }
                else
                {
                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error executing search query: " + ex.Message);
                check =ex.Message;
            }
            finally
            {
               // connection.Close();
            }
            return user;
        }
        
        public int CountItem(string tbName,string con="")
        {
            int number = -1;
            try
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM " + tbName + " " + con ;
                OleDbCommand command = new OleDbCommand(sql, connection);
                
                number = (int)command.ExecuteScalar();
        
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error executing search query: " + ex.Message);
                number = -2;
            }
            finally
            {
               
                connection.Close();
            }
            return number;
        }
        public string Add(string query)
        {
            string result;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                result = ("Record added successfully.");
            }
            catch (Exception ex)
            {
                result = ("Error executing add query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public string Update(string query)
        {
            string result;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                result = "Record updated successfully.";
            }
            catch (Exception ex)
            {
                result = "Error executing update query: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public string Delete(string query)
        {
            string result;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                result = "Record deleted successfully.";
            }
            catch (Exception ex)
            {
                result = ("Error executing delete query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public Dictionary<string, object> ReadOneRecord(string query)
        {
            Dictionary<string, object> dataDictionary = new Dictionary<string, object>();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
              
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        object columnValue = reader.GetValue(i);
                        Console.WriteLine(columnName);
                        dataDictionary.Add(columnName, columnValue);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ssss"+ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataDictionary;
        }
        public Dictionary<string, string> ReadRelations(string query)
        {
            Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                        
                        string columnValue = reader["SectionID"].ToString();
                        string columnName = reader["SectionName"].ToString();
     
                        dataDictionary.Add(columnValue,columnName);
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ssss" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataDictionary;
        }
        public String ReadValue(string query)
        {
            string value = "";

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    value = reader.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
              value = ("" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return value;
        }
        public Dictionary<string, string> ReadNameWithID(string query)
        {
            Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string columnValue = reader[0].ToString();
                    string columnName = reader[1].ToString();

                    dataDictionary.Add(columnValue, columnName);

                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("sssfromrelations" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataDictionary;
        }
        public int GetID (string query)
        {
            int number = 0;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                number = (int)command.ExecuteScalar();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error executing search query: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return number;
        }

    }
}
