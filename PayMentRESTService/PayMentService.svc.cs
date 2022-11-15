using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PayMentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PayMentService.svc or PayMentService.svc.cs at the Solution Explorer and start debugging.
    public class PayMentService : IPayMentService
    {
        public string PayBill(string PayId)
        {
            return "Transaction having PayId " + PayId + " was successful";
        }
        //public string Constring(string Account_Holder_Last_Name)
        //{
        //    List<object> customers = new List<object>();
        //    string sql = "SELECT * FROM Current_Account_Holder_Details WHERE Account_Holder_Last_Name =@Account_Holder_Last_Name";
        //    using (SqlConnection conn = new SqlConnection())
        //    {
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["Data Source=10.50.51.117;Initial Catalog=TestDB;User ID=bms0176;Password=Welcome@123"].ConnectionString;
        //        using (SqlCommand cmd = new SqlCommand(sql))
        //        {
        //            cmd.Parameters.AddWithValue("@Account_Holder_Last_Name", Account_Holder_Last_Name);
        //            cmd.Connection = conn;
        //            conn.Open();
        //            using (SqlDataReader sdr = cmd.ExecuteReader())
        //            {
        //                if (sdr.HasRows)
        //                {
        //                    while (sdr.Read())

        //                    {
        //                        customers.Add(new
        //                        {
        //                            Tittle = sdr["Tittle"],
        //                            Account_Holder_First_Name = sdr["Account_Holder_First_Name"],
        //                            Account_Holder_Last_Name = sdr["Account_Holder_Last_Name"],

        //                        });
        //                    }

        //                }

        //            }
        //            conn.Close();
        //        }

        //        return (new JavaScriptSerializer().Serialize(customers));
        //    }

        //}
        public List<Cities> GetAllCities()
        {
            List<Cities> listCity = new List<Cities>();

           SqlConnection connection = new SqlConnection("Data Source=10.50.51.117;Initial Catalog=TestDB;User ID=bms0176;Password=Welcome@123");
           using (connection)
            {
               SqlCommand command = new SqlCommand("select * from dCity", connection);
               connection.Open();
               SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cities City = new Cities();
                    City.CityID = Convert.ToInt32(reader["CityID"]);
                    City.CityN = reader["CityN"].ToString();
                    listCity.Add(City);
                }
            }
            return listCity;
        }
    }
}
