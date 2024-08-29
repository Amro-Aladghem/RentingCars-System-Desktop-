using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsPaymentData
    {

        private static void AddValueToCommandParam(SqlCommand command, string ParaName, object Value)
        {

            if (Value == null)
            {
                command.Parameters.AddWithValue(ParaName, System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(ParaName, Value);
            }
        }

        public static int AddNewRecord(int RentID,DateTime DateOfPay,decimal PaidAmount,decimal ReturnAmount,string Note)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "INsert INto Payments(RentID,DateOfPaid,PaidAmount,ReturnAmount,Note)\r\nvalues\r\n" +
                        "(@RentID,@DateOFPaid,@PaidAmount,@ReturnAmount,@Note);select SCOPE_IDENTITY();";



                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);
                        command.Parameters.AddWithValue("@DateOFPaid", DateOfPay);
                        command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        command.Parameters.AddWithValue("@ReturnAmount", ReturnAmount);
                        AddValueToCommandParam(command, "@Note", Note);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int value))
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

        public static DataTable GetAllPaymentRecords()
        {
            DataTable dt = new DataTable();

            try
            {
             
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Payments";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
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

        public static bool GetFullRecordByRentID(ref int PaymentID,int RentID,ref DateTime DateOfPaid,ref decimal PaidAmount,ref decimal ReturnAmount,ref string Note)
        {
            bool isFound = false;


            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetPaymentByRentID",connection))
                    {
                       command.CommandType=CommandType.StoredProcedure;
                       command.Parameters.AddWithValue("@RentID", RentID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PaymentID = (int)reader[0];
                                DateOfPaid = (DateTime)reader[2];
                                PaidAmount = (decimal)reader[3];
                                ReturnAmount = (decimal)reader[4];
                                Note = reader[5]?.ToString();
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

        public static bool DeletePaymentRecord(int PaymentID)
        {
            bool isDone = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete from Payments where PaymentID=@PaymentID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
