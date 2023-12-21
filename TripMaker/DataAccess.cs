using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripMaker
{
    class DataAccess
    {
        public static string conection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\TripMakerSL\mdf file\TripMakerDB.mdf;Integrated Security=True;Connect Timeout=30";
        public static void ExecuteData(string query, out string error)
        {

            try
            {
                SqlConnection con = new SqlConnection(conection);
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                
                con.Close();
                error = "";

            }
            catch (Exception ex)
            {
                error = ex.Message;

            }

        }
    }
}
