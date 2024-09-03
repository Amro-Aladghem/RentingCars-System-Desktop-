using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsManagersData
    {
        public static DataTable GetAllManagersInTheList()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Managers.ManagerID, Managers.ManagerName, SectionType.SectionName, Managers.UserID\r\nFROM   Managers INNER JOIN\r\n             SectionType ON Managers.SectionID = SectionType.SectionID";

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

        public static int AddNewRecord(string ManagerName, int SectionID, int UserID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into Managers (ManagerName,SectionID,UserID)\r\nvalues\r\n" +
                        "(@Name,@SectionID,@UserID);select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", ManagerName);
                        command.Parameters.AddWithValue("@SectionID", SectionID);
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool UpdateManagerSection(int ManagerID, int NewSectionID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Managers\r\nset SectionID=@SectionID where ManagerID=@ManagerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SectionID", NewSectionID);
                        command.Parameters.AddWithValue("@ManagerID", ManagerID);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
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

        public static bool DeleteManager(int ManagerID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete from Managers where ManagerID=@ManagerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ManagerID", ManagerID);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
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

            return isDone = true;
        }

        public static DataTable GetAllSectionsName()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select SectionName from SectionType";

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

        public static bool IsUserIsManger(int UserID)
        {
            bool isRight = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select ManagerID from Managers where UserID=@UserID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        object reader = command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            isRight = true;
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

        public static DataTable GetAllRentingHistoryRecords()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                 

                    using(SqlCommand command=new SqlCommand("SP_GetAllRentingHistory", connection))
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
