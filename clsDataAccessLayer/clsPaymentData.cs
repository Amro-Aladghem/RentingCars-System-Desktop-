using System;
using System.Collections.Generic;
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















    }
}
