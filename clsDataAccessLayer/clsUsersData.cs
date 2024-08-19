using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SecurityLayer;

namespace clsDataAccessLayer
{
    public class clsUsersData
    {

        public static DataTable GetAllRecord()
        {
            DataTable dataTable = new DataTable();


            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select UserID,UserName,Password='*****',EmployeeID,NumberOfPermision,Users.IsActive   from Users ";
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }


                        }

                    }

                }
            }
            catch { }

            return dataTable;   
        }

        public static bool GetFullRecordByID(int UserID,ref string UserName,ref string Password,ref int EmployeeID,ref int NumberOfPermission,ref bool isActive)
        {

            bool isFound = false;

            try
            {

                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Users where UserID=@UserID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;
                                UserName = (string)reader[1];
                                Password= (string)reader[2];
                                EmployeeID = (int)reader[3];
                                NumberOfPermission = (int)reader[4];
                                isActive = (bool)reader[5];
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

        public static bool GetFullRecordByName(ref int UserID, string UserName, ref string Password, ref int EmployeeID, ref int NumberOfPermission, ref bool isActive)
        {

            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Users where UserName=@UserName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName",UserName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserID = (int)reader[0];
                                Password = (string)reader[2];
                                EmployeeID = (int)reader[3];
                                NumberOfPermission = (int)reader[4];
                                isActive = (bool)reader[5];
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

        public static int AddNewRecord( string UserName,  string Password ,int EmployeeID,  int NumberOfPermission,  bool isActive)
        {
            int NewId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString ))
                {
                    connection.Open();
                    string query = "Insert Into Users(UserName,Password,EmployeeID,NumberOfPermision,IsActive)\r\nvalues\r\n" +
                        "(@UserName,@Password,@EmployeeID,@NumberOfPermision,@IsActive);select SCOPE_IDENTITY();";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", SecurityClass.Encrypt(Password));
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@NumberOfPermision", NumberOfPermission);
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        object reader=command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(),out int value))
                        {
                            NewId = value;
                        }

                    }



                }

            }
            catch
            {
                //
            }

            return NewId;
        }

        public static bool UdpateReocrd(int UserID,string UserName,string Password,int NumberOfPermission,bool isActive)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Users\r\nset UserName=@UserName,Password=@Password,NumberOfPermision=@NumberOfPermision,IsActive=@IsActive where UserID=@UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@NumberOfPermision", NumberOfPermission);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@Password", SecurityClass.Encrypt(Password));
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool DeleteRecord(int UserID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete Users Where UserID=@UserID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        int rowaffected= command.ExecuteNonQuery();
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

        public static bool UpdatePassword(int UserID, string Password)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Users\r\nset Password=@Password where UserID=@UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Password", SecurityClass.Encrypt(Password));

                        int rowaffected= command.ExecuteNonQuery();
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

        public static bool isExits(int UserID)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select UserID from Users where  UserID=@UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("UserID", UserID);

                        object reader= command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            isFound = true;
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

        public static bool DeactivateUser(int UserID)
        {

            bool isDone= false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Users \r\nset IsActive=0 where UserID=@UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserID", UserID);
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

        public static bool CheckIfEmployeeIsUser(int EmployeeID)
        {
            bool isRight = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select UserID from Users where EmployeeID=@EmoloyeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmoloyeeID", EmployeeID);

                        object reader = command.ExecuteScalar();

                        if (reader != null && int.TryParse(reader.ToString(), out int value))
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





    }









}
