﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsVehiclesData
    {

        public static DataTable GetAllRecord()
        {

            DataTable dataTable = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllVehicles", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }


                        }

                    }
                }

            }
            catch
            {
                //
            }

            return dataTable;
        }

        public static bool GetFullRecordByID(int VehicleID, ref int CarTypeID, ref int CarModelID, ref string ProducedYear, ref decimal CurrentMillage, ref int ColorID, ref string isHasDamaged, ref int RentStatus, ref DateTime LastRentDate, ref string CarNumber)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = "select *From Vehicles where VehicleID=@vehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vehicleID", VehicleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                CarTypeID = (int)reader[1];
                                CarModelID = (int)reader[2];
                                ProducedYear = (string)reader[3];
                                CurrentMillage = (decimal)reader[4];
                                ColorID = (int)reader[5];
                                isHasDamaged = (string)reader[6];
                                RentStatus = (int)reader[7];
                                LastRentDate = (DateTime)reader[8];
                                CarNumber = (string)reader[9];

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

        public static bool GetFullRecordByTypeAndModel(ref int VehicleID, int CarTypeID, int CarModelID, ref string ProducedYear, ref decimal CurrentMillage, ref int ColorID, ref string isHasDamaged, ref int RentStatus, ref DateTime LastRentDate, ref string CarNumber)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = "select *From Vehicles where CarTypeID=@CarTypeID And CarModelID=@CarModelID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarTypeID", CarTypeID);
                        command.Parameters.AddWithValue("@CarModelID", CarModelID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                VehicleID = (int)reader[0];

                                ProducedYear = (string)reader[3];
                                CurrentMillage = (decimal)reader[4];
                                ColorID = (int)reader[5];
                                isHasDamaged = (string)reader[6];
                                RentStatus = (int)reader[7];
                                LastRentDate = (DateTime)reader[8];
                                CarNumber = (string)reader[9];

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

        public static int AddNewRecord(int CarTypeID, int CarModelID, string ProducedYear, decimal CurrentMillage, int ColorID, string isHasDamaged, int RentStatus, DateTime LastRentDate, string CarNumber)
        {
            int NewID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string qurey = "Insert INto Vehicles(CarTypeID,CarModelID,ProducedDate,CurrentMilleageCounter,ColorID,IsHasDamaged,RentStatus,LastDateForRent,CarNumber)\r\nvalues\r\n" +
                        "(@CarTypeID,@CarModelID,@ProducedYear,@CurrentMillage,@ColorID,@isHasDamaged,@RetainStatus,@LastRetianDate,@CarNumber);select SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(qurey, connection))
                    {
                        command.Parameters.AddWithValue("@CarTypeID", CarTypeID);
                        command.Parameters.AddWithValue("@CarModelID", CarModelID);
                        command.Parameters.AddWithValue("@ProducedYear", ProducedYear);
                        command.Parameters.AddWithValue("@CurrentMillage", CurrentMillage);
                        command.Parameters.AddWithValue("@ColorID", ColorID);
                        command.Parameters.AddWithValue("@isHasDamaged", isHasDamaged);
                        command.Parameters.AddWithValue("@RetainStatus", RentStatus);
                        command.Parameters.AddWithValue("@LastRetianDate", LastRentDate);
                        command.Parameters.AddWithValue("@CarNumber", CarNumber);

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
        public static bool UpdateRecord(int VehicleID, decimal CurrentMillage, string isHasDamaged, int RentStatus, DateTime LastRentDate)
        {
            bool isDone = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Vehicles \r\nset CurrentMilleageCounter=@CurrentMilleage , IsHasDamaged=@IsHasDamaged ,RentStatus=@RentStatus ,LastDateForRent=@LastDateOfRent where VehicleID=@VehicleID";
                  
                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@CurrentMilleage", CurrentMillage);
                        command.Parameters.AddWithValue("@IsHasDamaged", isHasDamaged);
                        command.Parameters.AddWithValue("@RentStatus", RentStatus);
                        command.Parameters.AddWithValue("@LastDateOfRent", LastRentDate);

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

        public static bool DeleteRecord(int VehicleID)
        {
            bool isDone = true;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete  Vehicles where VehicleID=@VehicledID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicledID", VehicleID);

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

        public static int AddNewCarType(string NewTypeName)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into CarsTypes(CarName)\r\nvalues\r\n(@NewCarName);select SCOPE_IDENTITY()";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@NewCarName", NewTypeName);

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

            return NewID;

        }

        public static int AddNewCarModel(string NewModelName,int CarTypeID)
        {
            int NewID = -1;

            try
            {

                using (SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into CarsModels (CarTypeID,ModelName)\r\nvalues\r\n(@CarTypeID,@ModelName);select SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarTypeID", CarTypeID);
                        command.Parameters.AddWithValue("@ModelName", NewModelName);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int Value))
                        {
                            NewID = Value;  
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

        public static bool ChangeRentStatus(int VehicleID,int RentStatusType) 
        {
            bool isDone = false;
           
            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = "Update Vehicles \r\nset RentStatus=@RentStatus where VehicleID=@VehicleID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@RentStatus", RentStatusType);

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

        public static bool ChangeLastRentStatus(int VehicleID,DateTime LastRentDate)
        {
            bool isDone = false; 

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Vehicles \r\nset LastDateForRent=@LastDateOfRent where VehicleID=@VehicleID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@LastDateOfRent", LastRentDate);

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

        public static bool ChangeCurrentMillage(int VehicleID,decimal NewMillageNum)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Vehicles \r\nset CurrentMilleageCounter=@NewMillageNum  where VehicleID=@VehicleID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@NewMillageNum", NewMillageNum);

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

        public static bool CheckIfCarAvaialable(int VehicleID)
        {
            bool isAvaialable = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_CheckIfVehicleAvailable",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(returnParameter);
                        command.ExecuteNonQuery();

                        isAvaialable = (int)returnParameter.Value == 1;

                    }

                }

            }
            catch
            {
                //
            }

            return isAvaialable;

        }

        public static DataTable GetAllCarTypeInTheSystem()
        {
            DataTable dt = new DataTable();

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = "select CarName From CarsTypes";

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

        public static DataTable GetAllCarsModelsForTheCar(int CarTypeID)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "\r\nselect ModelName from CarsModels where CarTypeID=@CarTypeID;";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CarTypeID", CarTypeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if( reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }

                    }

                }

            }
            catch
            {
                //
            }

            return dataTable;
        }

        public static DataTable GetAllCarsModelsForTheCar(string CarTypeName)
        {
            DataTable dataTable = new DataTable();

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllModelsForVehicle",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CarName", CarTypeName);

                        using(SqlDataReader reader =command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }

                        }

                    }

                }




            }
            catch
            {
                //
            }

            return dataTable;

        }

        public static DataTable GetAllColorIntSystem()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from ColorType";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader=command.ExecuteReader())
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

        public static DataTable GetAllColorOptionsForTheCar(int CarTypeID)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "\r\nSELECT DISTINCT ColorType.ColorName\r\nFROM   Vehicles INNER JOIN\r\n ColorType ON Vehicles.ColorID = ColorType.ColorId \r\n" +
                        "where Vehicles.CarTypeID=@CarTypeID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CarTypeID", CarTypeID);
                        
                        using(SqlDataReader reader = command.ExecuteReader())
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








    }
}
