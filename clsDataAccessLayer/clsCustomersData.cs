using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsCustomersData
    {

        private static void AddValueToParameter(SqlCommand command, string Parameter, object Value)
        {
            if (Value == null)
            {
                command.Parameters.AddWithValue(Parameter, System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(Parameter, Value);
            }
        }
        public static DataTable GetAllRecord()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from CustomerList";

                    using(SqlCommand command =new SqlCommand(query,connection))
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

        public static bool GetFullRecordByID(int CustomerID,ref int PersonID,ref string PhoneNumber,ref string Email,ref string Nationality,ref string NationalNum)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "\t select *from Customers where CustomerID=@CustomerID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        using (SqlDataReader reader =command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader[1];
                                PhoneNumber = (string)reader[2];
                                Email = (string)reader[3];
                                Nationality= (string)reader[4];
                                NationalNum = (string)reader[5];
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

        public static bool GetFullRecordByName(ref int CustomerID,  int PersonID, ref string PhoneNumber, ref string Email, ref string Nationality, ref string NationalNum)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "\t select *from Customers where PersonID=@PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                CustomerID= (int)reader[0];
                                PhoneNumber = (string)reader[2];
                                Email = (string)reader[3];
                                Nationality = (string)reader[4];
                                NationalNum = (string)reader[5];
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

        public static int AddNewRecord(int PersonID, string PhoneNumber, string Email, string Nationality, string NationalNum)
        {
            int NewID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into Customers (PersonID,PhoneNumber,Email,Nationality,NationalNum)\r\nvalues\r\n" +
                        "(@PersonID,@PhoneNumber,@Email,@Nationality,@NationalNum);select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@Nationality", Nationality);
                        command.Parameters.AddWithValue("NationalNum", NationalNum);
                        AddValueToParameter(command, "@Email", Email);

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

        public static bool UpdateRecord(int CustomerID,  string PhoneNumber, string Email)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Customers \r\nset PhoneNumber=@PhoneNumber ,Email=@Email where CustomerID=@CustomerID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        AddValueToParameter(command, "@Email", Email);
                        

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected > 0)
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

        public static bool DeleteRecord(int CustomerID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete Customers where CustomerID=@CustomerID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static bool IsExsits(int CustomerID)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "\t\tselect Customers.CustomerID from Customers where CustomerID=@CustomerID";

                    using(SqlCommand command =new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        object reader = command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            isFound=true;

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

























    }
}
