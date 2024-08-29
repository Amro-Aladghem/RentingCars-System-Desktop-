using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsSchedulingData
    {

        private static void AddValueToCommandParam(SqlCommand command,string ParamName,object value)
        {
            if (value == null)
            {
                command.Parameters.AddWithValue(ParamName,System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(ParamName,value);
            }
        }

        public static DataTable GetAllRecordInSystem()
        {
            DataTable dt=new DataTable();

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllSchedules",connection))
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

        public static bool GetFullRecordByID(int ScheduleID,ref int CustomerID,ref int VehicleID,ref DateTime DateOfSchedule,ref int NumberOfDay,ref DateTime StartDate,ref DateTime EndDate,ref int StatusID,ref int?DriverID)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = " select *from Schedules where ScheduleID=@ScheduleID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                CustomerID = (int)reader[1];
                                VehicleID = (int)reader[2];
                                DateOfSchedule = (DateTime)reader[3];
                                NumberOfDay = (int)reader[4];
                                StartDate = (DateTime)reader[5];
                                EndDate = (DateTime)reader[6];
                                StatusID = (int)reader[7];
                                if (reader[8]==System.DBNull.Value)
                                {
                                    DriverID = null;
                                }
                                else
                                {
                                    DriverID = (int?)reader[8];
                                }
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

        public static bool GetFullRecordByCustomerName(string FirstName,string LastName,ref int ScheduleID, ref int CustomerID, ref int VehicleID, ref DateTime DateOfSchedule, ref int NumberOfDay, ref DateTime StartDate, ref DateTime EndDate, ref int StatusID, ref int? DriverID)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_FindScheduleByCustomerName",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                ScheduleID = (int)reader[0];
                                CustomerID = (int)reader[1];
                                VehicleID = (int)reader[2];
                                DateOfSchedule = (DateTime)reader[3];
                                NumberOfDay = (int)reader[4];
                                StartDate = (DateTime)reader[5];
                                EndDate = (DateTime)reader[6];
                                StatusID = (int)reader[7];
                                if (reader[8] == System.DBNull.Value)
                                {
                                    DriverID = null;
                                }
                                else
                                {
                                    DriverID = (int?)reader[8];
                                }
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

        public static bool GetFullRecrodByCustomerNameAndVehicleID(string FirstName, string LastName, ref int ScheduleID, ref int CustomerID,  int VehicleID, ref DateTime DateOfSchedule, ref int NumberOfDay, ref DateTime StartDate, ref DateTime EndDate, ref int StatusID, ref int? DriverID)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_FindScheduleByVehicleOfCustomer",connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@VehcileID", VehicleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                ScheduleID = (int)reader[0];
                                CustomerID = (int)reader[1];
                                VehicleID = (int)reader[2];
                                DateOfSchedule = (DateTime)reader[3];
                                NumberOfDay = (int)reader[4];
                                StartDate = (DateTime)reader[5];
                                EndDate = (DateTime)reader[6];
                                StatusID = (int)reader[7];
                                if (reader[8] == System.DBNull.Value)
                                {
                                    DriverID = null;
                                }
                                else
                                {
                                    DriverID = (int?)reader[8];
                                }

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

        public static int AddNewSchedule(int CustomerID, int VehicleID, DateTime DateOfSchedule, int NumberOfDay, DateTime StartDate, DateTime EndDate, int StatusID, int? DriverID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into Schedules(CustomerID,VehicleID,DateOfSchedule,NumberOfDay,StartFrom,EndAt,status,DriverID)\r\nvalues\r\n" +
                        "(@CustomerID,@VehicleID,@DateOfSchedule,@NumberOfDay,@StartFrom,@EndAt,@status,@DriverID);select SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@DateOfSchedule", DateOfSchedule);
                        command.Parameters.AddWithValue("@NumberOfDay", NumberOfDay);
                        command.Parameters.AddWithValue("@StartFrom", StartDate);
                        command.Parameters.AddWithValue("@EndAt", EndDate);
                        command.Parameters.AddWithValue("@status", StatusID);
                        AddValueToCommandParam(command, "@DriverID", DriverID);

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

        public static bool UpdateSchedule(int ScheduleID,int VehicleID,int NumberOfDays,DateTime StartFrom,DateTime EndAt,int ?DriverID)
        {
            bool isDone = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = " Update Schedules \r\n set VehicleID=@VehicleID ,DateOfSchedule=GETDATE(), NumberOfDay=@NumberOfDay,StartFrom=@StartFrom , EndAt=@EndAt , DriverID=@DriverID where ScheduleID=@ScheduleID;";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@NumberOfDay", NumberOfDays);
                        command.Parameters.AddWithValue("@StartFrom", StartFrom);
                        command.Parameters.AddWithValue("@EndAt", EndAt);
                        AddValueToCommandParam(command, "@DriverID", DriverID);

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

        public static bool DeleteSchedule(int ScheduleID)
        {
            bool isDone = false;


            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = " delete Schedules where ScheduleID=@ScheduleID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);

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

        public static bool ChangeTheStatusOfSchedule(int ScheduleID, int NewStatusID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qurey = "Update Schedules \r\n set status=@NewStatus  where ScheduleID=@ScheduleID";

                    using(SqlCommand command=new SqlCommand(qurey,connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", NewStatusID);
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);

                        int rowaffected= command.ExecuteNonQuery();
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

        public static bool CheckIfCustomerHasAndActiveSchedule(int CustomerID)
        {

            bool isRight = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = " select Count(CustomerID) from Schedules where CustomerID=@CustomerID And status=1;";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        object reader=command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(),out int value))
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

        public static bool CheckIfCustomerHasAndActiveSchedule(string FirstName,string LastName)
        {

            bool isRight = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = " SELECT COUNT(Schedules.CustomerID) AS Expr1\r\nFROM   Schedules INNER JOIN\r\n             Customers ON Schedules.CustomerID = Customers.CustomerID INNER JOIN\r\n             Persons ON Customers.PersonID = Persons.PersonID\r\n\t\t\t where FirstName=@FirstName And LastName=@LastName ANd status=1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

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
