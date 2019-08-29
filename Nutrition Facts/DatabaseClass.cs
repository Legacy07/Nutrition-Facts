using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Nutrition_Facts
{
    public class DatabaseClass
    {

        public static SqlConnection GetConnection()
        {
            string databasePath;
            databasePath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\Nutrition Facts\Nutrition Facts\Nutrition Facts\Database.mdf;Integrated Security=True;";
            return new SqlConnection(databasePath);
        }

        public static void InsertFoods(string name, string calories, string protein, string carb, string fat, string quantity)
        {
            SqlConnection connection = GetConnection();
            string myQuery = "INSERT INTO Facts( Name, Calorie, Protein, Carb, Fat, Quantity) VALUES ('" + name + "' , '" + calories + "', '" + protein + "',  '" + carb + "',  '" + fat + "',  '" + quantity + "')";
            SqlCommand command = new SqlCommand(myQuery, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connection.Close();
            }
        }

      
    }
}