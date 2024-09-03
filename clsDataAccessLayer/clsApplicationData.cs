using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsApplicationData
    {

        public static void AddNewApplication(int ApplicationTypeID,int UserID)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into Applications (ApplictionTypeID,DateOfApplication,UserID)\r\nvalues\r\n" +
                        "( @ApplicationTypeID ,CONVERT(DATE, GETDATE()),@UserID)";

                    using(SqlCommand command =new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        object reader=command.ExecuteScalar();
                    }
                }
            }
            catch
            {
                //
            }
        }

        public static DataTable GetAllApplicationsRecords()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllApplications",connection))
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














    }
}
