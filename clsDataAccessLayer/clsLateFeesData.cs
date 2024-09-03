using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsLateFeesData
    {
        public static  DataTable GetAllLateFeesRecordInTheSys()
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connectionn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();
                    string query = "select *From LateFees";

                    using(SqlCommand command=new SqlCommand(query, connectionn))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
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

        public static bool GetFullRecordByRentID(ref int LateFeesID,int RentID,ref decimal FeesAmount,ref string Reason,ref bool isPaid,ref int DaysOfDelay)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *From LateFees where RentID=@RentID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                LateFeesID = (int)reader[0];
                                FeesAmount = (decimal)reader[2];
                                Reason = reader[3]?.ToString();
                                isPaid = (bool)reader[4];
                                DaysOfDelay = (int)reader[5];
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

        public static int AddNewLateFeesRecord(int RentID,decimal FeesAmount,string Reason,int DaysOfDelay)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into LateFees (RentId,FeesAmount,Reason,isPaid,DaysOfDelay)\r\nvalues\r\n" +
                        "( @RentID,@FeesAmount,@Reason,0 ,@DaysOfDelay);select SCOPE_IDENTITY();";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);
                        command.Parameters.AddWithValue("@FeesAmount", FeesAmount);
                        command.Parameters.AddWithValue("@Reason", Reason);
                        command.Parameters.AddWithValue("@DaysOfDelay", DaysOfDelay);

                        object reader= command.ExecuteScalar();
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

            return NewID;
        }

        public static bool UpdateLateFeesRecord(int RentID,int DaysOfDelay)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update LateFees \r\nset DaysOfDelay=@DaysOfDelay where RentID=@RentID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);
                        command.Parameters.AddWithValue("@DaysOfDelay", DaysOfDelay);

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

        public static bool DeleteLateFeesRecord(int RentID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connectionn=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();
                    string query = "delete from LateFees where RentID=@RentID";

                    using(SqlCommand command =new SqlCommand(query,connectionn))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);

                        int rowaffected = command.ExecuteNonQuery();    
                        if(rowaffected> 0)
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

        public static bool CheckIfRentHasLateFeesRecord(int RentID)
        {
            bool isRight = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qurey = "select *from LateFees where RentID=@RentID";

                    using (SqlCommand command = new SqlCommand(qurey, connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isRight = true;
                            }
                        }


                    }
                }


            }
            catch
            {
                //
            }

            return isRight;
        }






    
    
    
    }



}
