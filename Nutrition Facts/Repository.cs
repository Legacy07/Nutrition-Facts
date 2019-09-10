using System;
using System.Data;
using System.Data.SqlClient;

namespace Nutrition_Facts
{
    public class Repository
    {
        private SqlConnection OpenDbConnection()
        {
            SqlConnection connection = DatabaseClass.GetConnection();
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            throw new Exception();
        }

        private void CloseDbConnection(SqlConnection connection)
        {
            connection.Close();
        }

        public DataTable GetAllFoods()
        {
            var connection = OpenDbConnection();

            string query = "Select Name from Facts";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            this.CloseDbConnection(connection);

            return dataTable;
        }

        public DataTable GetFood(string foodName)
        {
            var connection = OpenDbConnection();

            string query = "Select * from Facts Where Name ='" + foodName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            var dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            this.CloseDbConnection(connection);
            return dataTable;
        }
    }
}
