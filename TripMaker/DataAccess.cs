using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripMaker
{
    static class DataAccess
    {
        public static string conection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# project\TripMakerSL\TripMakerDB.mdf;Integrated Security=True;Connect Timeout=30";
     

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
        public static DataTable GetData(string query, out string error)
        {

            try
            {
                SqlConnection con = new SqlConnection(conection);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                con.Close();
                error = "";
                return dt;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }

        }
    }
}
