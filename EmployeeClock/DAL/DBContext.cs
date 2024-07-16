using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;




namespace EmployeeClock.DAL
{
    public class DBContext
    {
        private readonly string _dbConnectionString;
        public DBContext()
        {
            _dbConnectionString = GetConnString();
        }
        private static string GetConnString()
        {
            IConfiguration builder = new ConfigurationBuilder()
             .AddJsonFile("Secret.json", optional: true) // Add secrets.json
             .Build();

            string conn = builder["Connection"];
            if (conn == null) throw new Exception("Cannot read conn striong from secrets");
            return conn;
        }

        public DataTable MakeQuery(string query, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_dbConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddRange(parameters);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                                adapter.Fill(output);

                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL error occurred: " + ex.Message);
                    }
                }

            }
            return output;
        }
        

        public bool ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_dbConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 1;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL error occurred: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
        
    }
}
