using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsDriversData
    {

        public static DataTable GetAllRecord()
        {
            DataTable dt = new DataTable(); 
            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Drivers";

                    using(SqlCommand command =new SqlCommand(query, connection))
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

        public static bool GetFullRecord(int DriverID,ref string FirstName,ref string LastName,ref string PhoneNumber,ref string Nationality,ref decimal Salary,ref DateTime DateOfSet)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qeury = "select *from Drivers where DriverID=@DriverID";

                    using(SqlCommand command =new SqlCommand(qeury, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;
                                FirstName = (string)reader[1];
                                LastName = (string)reader[2];
                                PhoneNumber = (string)reader[3];
                                Nationality = (string)reader[4];
                                Salary = (decimal)reader[5];
                                DateOfSet = (DateTime)reader[6];
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

        public static bool GetFullRecordByName(ref int DriverID, string FirstName, ref string LastName, ref string PhoneNumber, ref string Nationality, ref decimal Salary, ref DateTime DateOfSet)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qeury = "select *from Drivers where FirstName=@FirstName";

                    using (SqlCommand command = new SqlCommand(qeury, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName",FirstName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                DriverID = (int)reader[0];
                                LastName = (string)reader[2];
                                PhoneNumber = (string)reader[3];
                                Nationality = (string)reader[4];
                                Salary = (decimal)reader[5];
                                DateOfSet = (DateTime)reader[6];
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

        public static int AddNewRecord(string FirstName,  string LastName,  string PhoneNumber,  string Nationality, decimal Salary, DateTime DateOfSet)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string qurey = "Insert Into Drivers (FirstName,LastName,PhoneNumber,Nationality,Salary,DateOfSet)\r\nvalues\r\n" +
                        "(@FirstName,@LastName,@PhoneNumber,@Nationality,@Salary,@DateOfSet);select SCOPE_IDENTITY();";

                    using(SqlCommand command =new SqlCommand(qurey, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@Nationality", Nationality);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@DateOfSet", DateOfSet);

                        object reader=command.ExecuteScalar();
                        if(reader!=null&& int.TryParse(reader.ToString(),out int value))
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

        public static bool  UpdateRecord(int DriverID, string FirstName, string LastName, string PhoneNumber, string Nationality, decimal Salary, DateTime DateOfSet)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Drivers\r\nset PhoneNumber=@PhoneNumber,Nationality=@Nationality,Salary=@Salary Where DriverID=@DriverID";

                    using(SqlCommand command =new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@Nationality", Nationality);
                        command.Parameters.AddWithValue("@Salary", Salary);

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

        public static bool DeleteRecord(int DriverID)
        {
            bool isFound = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string qeury = "delete Drivers where DriverID=@DriverID";

                    using (SqlCommand command = new SqlCommand(qeury, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
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

        public static bool isExits(int DriverID)
        {
            bool isFound=false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select Drivers.DriverID from Drivers where DriverID=@DriverID";

                    using(SqlCommand command =new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        object reader = command.ExecuteScalar();
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

        public static bool isExitsByName(string DriverName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select Drivers.DriverID from Drivers where FirstName=@FirstName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", DriverName);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int value))
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

        public static bool IsDriverAvailableForDriving(int DriverID,ref DateTime? ReturnDate)
        {
            bool isAvailable = true;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select dbo.GetEndOfRentingTimeForDriverIDIFExits(@DriverID)";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {

                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        object reader = command.ExecuteScalar();
                        if (reader != null && DateTime.TryParse(reader.ToString(), out DateTime Value))
                        {
                            ReturnDate= Value;
                            isAvailable = false;
                        }
                    }

                }
            }
            catch
            {
                //
            }

            return isAvailable;
        }

        public static DataTable GetAllAvaialableDrivers()
        {
            DataTable dt = new DataTable();

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select (FirstName+' ' +LastName) as DriverName from Drivers where isActive=1; ";

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

        public static int GetDriverIDByFullName(string FirstName,string LastName)
        {
            int ID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = "select DriverID from Drivers where FirstName=@FirstName And LastName=@LastName";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        object reader=command.ExecuteScalar();
                        if(reader!= null && int.TryParse(reader.ToString(), out int value))
                        {
                            ID = value;
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return ID;
        }
        

        public static decimal GetDriverFees()
        {
            decimal Fees = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select  DriverFees from DriverFees";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object reader = command.ExecuteScalar();
                        if (reader != null && decimal.TryParse(reader.ToString(), out decimal value))
                        {
                            Fees = value;
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return Fees;
        }

        public static bool UpdateDriverFees(decimal DriverFees)
        {
            bool isDone = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update DriverFees \r\nset DriverFees=@DriverFees";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@DriverFees", DriverFees);

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
