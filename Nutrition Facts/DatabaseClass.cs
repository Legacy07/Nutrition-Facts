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
            //connection path
            string connString;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\Nutrition Facts\Nutrition Facts\Nutrition Facts\Database.mdf;Integrated Security=True;";
            return new SqlConnection(connString);
        }

        public static void Facts(string name, string cal, string pro, string carb, string fat, string qua)
        {
            SqlConnection connString = GetConnection();
            //to add data in parent table in the database
            string myQuery = "INSERT INTO Facts( Name, Calorie, Protein, Carb, Fat, Quantity) VALUES ('" + name + "' , '" + cal + "', '" + pro + "',  '" + carb + "',  '" + fat + "',  '" + qua + "')";
            SqlCommand myCommand = new SqlCommand(myQuery, connString);

            try
            {
                connString.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                connString.Close();
            }
        }

      
    }
}