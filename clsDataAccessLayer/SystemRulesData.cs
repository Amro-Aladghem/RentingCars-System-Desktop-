using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public  class SystemRulesData
    {
        public static DataTable GetAllVehicelsPricesList()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehiclesPrices", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                       
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return dt;
        }

        public static bool GetVehiclePriceRecordById(ref int ID, int VehicleID,ref decimal PricePerDay)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from VehicleRentingPrice where VehicleID=@VehicleID";

                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                ID = (int)reader[0];
                                PricePerDay = (decimal)reader[2];
                            }
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return isFound;
        }

        public static bool AddPriceForVehcile(int VehicleID,decimal PricePerDay)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "insert Into VehicleRentingPrice (VehicleID,PricePerDay)\r\nvalues\r\n" +
                      "(@VehicleID,@PricePerDay);select SCOPE_IDENTITY();";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@PricePerDay", PricePerDay);

                        object reader = command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            NewID = value;
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return NewID != -1;
        }

        public static bool UpdateRentingPriceFortheVehicle(int VehicleID,decimal NewPricePerDay)
        {
            bool isDone = false;

            try
            {

                using(SqlConnection connectionn=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();
                    string query = "Update VehicleRentingPrice\r\nset PricePerDay=@NewPricePerDay where VehicleID=@VehicleID";

                    using (SqlCommand command=new SqlCommand(query,connectionn))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@NewPricePerDay", NewPricePerDay);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected>0)
                        {
                            isDone = true;
                        }
                    }    
                }
            }
            catch
            {
                //
            }

            return isDone;
        }

        public static bool DeleteRentingPriceRecord(int VehicleID)
        {
            bool isDone =false ;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qurey = "delete from VehicleRentingPrice where VehicleID=@VehicleID";

                    using(SqlCommand command=new SqlCommand(qurey,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        int rowaffected = command.ExecuteNonQuery();    
                        if(rowaffected>0)
                        {
                            isDone = true;
                        }

                    }    



                }



            }
            catch
            {
                //
            }

            return isDone;
        }

        public static DataTable GetAllStaticRulesRecord()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from SystemStaticRules";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }

            }
            catch
            {
                //
            }
            return dt;
        }

        public static bool AddNewStaticRules(string RulesName,string Discription)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into SystemStaticRules (RulesName,Discribtion)\r\nvalues\r\n" +
                        "(@RulesName,@Discription);select SCOPE_IDENTITY()";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RulesName", RulesName);
                        command.Parameters.AddWithValue("@Discription", Discription);

                        object reader = command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            NewID = value;
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return NewID != -1;
        }

        public static bool UdpateStaticRules(int ID,string Disciption)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update SystemStaticRules \r\nset Discribtion =@Discription where ID=@ID";


                    using (SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Discription", Disciption);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected>0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
               //
            }

            return isDone;
        }

        public static bool DeleteStaticRules(int ID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete from  SystemStaticRules where Id=@ID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowaffected = command.ExecuteNonQuery();    
                        if(rowaffected>0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return isDone;
        }


















    }
}
