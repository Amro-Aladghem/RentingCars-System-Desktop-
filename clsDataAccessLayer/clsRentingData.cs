using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsRentingData
    {

        private static void AddValueToCommandParam(SqlCommand command, string ParaName, object Value)
        {

            if(Value==null)
            {
               command.Parameters.AddWithValue(ParaName,System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(ParaName,Value);
            }
        }

        public static bool GetFullRecordByID(int RentingID,ref int ScheduleID,ref decimal ? DistanceCoverd,ref decimal InitialMileage,ref decimal ? FinalMillage,ref DateTime? ReturnDate,ref bool isActive,ref bool isPaid,ref decimal TotalPrice,ref decimal AdditionalFees,ref string Note,ref decimal TotalPaidPrice)
        {
            bool isFonud = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings .ConnectionString))
                {
                    connection.Open();
                    string query = "select *From Rents where RentID=@RentID And isActive=1";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentingID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFonud = true;

                                ScheduleID = (int)reader[1];
                                DistanceCoverd = (decimal?)reader[2];
                                InitialMileage = (decimal)reader[3];
                                FinalMillage = (decimal?)reader[4];
                                if (reader[5] != System.DBNull.Value)
                                {
                                    ReturnDate = (DateTime?)reader[5];
                                }
                                else
                                {
                                    ReturnDate = null;
                                }

                                isActive = (bool)reader[6];
                                isPaid = (bool)reader[7];
                                TotalPrice = (decimal)reader[8];
                                AdditionalFees = (decimal)reader[9];
                                Note = reader[10]?.ToString();
                                TotalPaidPrice= (decimal)reader[11];

                            }
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return isFonud;
        }

        public static bool GetFullRecordByIDNotActive(int RentingID, ref int ScheduleID, ref decimal? DistanceCoverd, ref decimal InitialMileage, ref decimal? FinalMillage, ref DateTime? ReturnDate, ref bool isActive, ref bool isPaid, ref decimal TotalPrice, ref decimal AdditionalFees, ref string Note, ref decimal TotalPaidPrice)
        {
            bool isFonud = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *From Rents where RentID=@RentID And isActive=0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentingID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFonud = true;

                                ScheduleID = (int)reader[1];
                                DistanceCoverd = (decimal?)reader[2];
                                InitialMileage = (decimal)reader[3];
                                FinalMillage = (decimal?)reader[4];
                                if (reader[5] != System.DBNull.Value)
                                {
                                    ReturnDate = (DateTime?)reader[5];
                                }
                                else
                                {
                                    ReturnDate = null;
                                }

                                isActive = (bool)reader[6];
                                isPaid = (bool)reader[7];
                                TotalPrice = (decimal)reader[8];
                                AdditionalFees = (decimal)reader[9];
                                Note = reader[10]?.ToString();
                                TotalPaidPrice = (decimal)reader[11];

                            }
                        }
                    }
                }
            }
            catch
            {
                //
            }

            return isFonud;
        }

        public static bool GetFullRecordByCustomerName(string FirstName,string LastName, ref int RentingID, ref int ScheduleID, ref decimal? DistanceCoverd, ref decimal InitialMileage, ref decimal? FinalMillage, ref DateTime? ReturnDate, ref bool isActive, ref bool isPaid, ref decimal TotalPrice, ref decimal AdditionalFees, ref string Note, ref decimal TotalPaidPrice)
        {
            bool isFonud = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    
                    using(SqlCommand command= new SqlCommand("SP_GetRentingByCustomerName",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFonud = true;

                                ScheduleID = (int)reader[1];
                                DistanceCoverd = (decimal?)reader[2];
                                InitialMileage = (decimal)reader[3];
                                FinalMillage = (decimal)reader[4];
                                if (reader[5] != System.DBNull.Value)
                                {
                                    ReturnDate = (DateTime?)reader[5];
                                }
                                else
                                {
                                    ReturnDate = null;
                                }
                                isActive = (bool)reader[6];
                                isPaid = (bool)reader[7];
                                TotalPrice = (decimal)reader[8];
                                AdditionalFees = (decimal)reader[9];
                                Note = reader[10]?.ToString();
                                TotalPaidPrice = (decimal)reader[11];
                            }
                        }
                    }
                }

            }
            catch
            {
                //
            }

            return isFonud;
        }

        public static bool GetFullRecordByCustomerNameNotActive(string FirstName, string LastName, ref int RentingID, ref int ScheduleID, ref decimal? DistanceCoverd, ref decimal InitialMileage, ref decimal? FinalMillage, ref DateTime? ReturnDate, ref bool isActive, ref bool isPaid, ref decimal TotalPrice, ref decimal AdditionalFees, ref string Note, ref decimal TotalPaidPrice)
        {
            bool isFonud = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetNotActiveRentingByCustomerName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFonud = true;

                                ScheduleID = (int)reader[1];
                                DistanceCoverd = (decimal?)reader[2];
                                InitialMileage = (decimal)reader[3];
                                FinalMillage = (decimal)reader[4];
                                if (reader[5] != System.DBNull.Value)
                                {
                                    ReturnDate = (DateTime?)reader[5];
                                }
                                else
                                {
                                    ReturnDate = null;
                                }
                                isActive = (bool)reader[6];
                                isPaid = (bool)reader[7];
                                TotalPrice = (decimal)reader[8];
                                AdditionalFees = (decimal)reader[9];
                                Note = reader[10]?.ToString();
                                TotalPaidPrice = (decimal)reader[11];
                            }
                        }
                    }
                }

            }
            catch
            {
                //
            }

            return isFonud;
        }

        public static bool GetFullRecordByCustomerAndVehcileName(string CarName,string CarModel, string FirstName, string LastName, ref int RentingID, ref int ScheduleID, ref decimal? DistanceCoverd, ref decimal InitialMileage, ref decimal? FinalMillage, ref DateTime? ReturnDate, ref bool isActive, ref bool isPaid, ref decimal TotalPrice, ref decimal AdditionalFees, ref string Note, ref decimal TotalPaidPrice)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_FindRentingByCustomerAndVehicleName",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@CarName", CarName);
                        command.Parameters.AddWithValue("@CarModel", CarModel);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                isFound = true;

                                ScheduleID = (int)reader[1];
                                DistanceCoverd = (decimal?)reader[2];
                                InitialMileage = (decimal)reader[3];
                                FinalMillage = (decimal)reader[4];
                                ReturnDate = (DateTime?)reader[5];
                                isActive = (bool)reader[6];
                                isPaid = (bool)reader[7];
                                TotalPrice = (decimal)reader[8];
                                AdditionalFees = (decimal)reader[9];
                                Note = reader[10]?.ToString();
                                TotalPaidPrice = (decimal)reader[11];
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

        public static int AddNewRentingRecord(  int ScheduleID,  decimal InitialMileage,   bool isActive, bool isPaid,  decimal TotalPrice,  string Note,  decimal TotalPaidPrice)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into Rents(ScheduleID,InitialMileage,isActive,isPaid,TotalPrice,Note,TotalPaidPrice)\r\nvalues\r\n" +
                        "(@ScheduleID,@InitialMileage,@isActive,@isPaid,@TotalPrice,@Note,@TotalPaidPrice);select SCOPE_IDENTITY()";

                    using(SqlCommand command =new SqlCommand(query,connection)) 
                    {
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);
                        command.Parameters.AddWithValue("@InitialMileage", InitialMileage);
                        command.Parameters.AddWithValue("@isActive", isActive);
                        command.Parameters.AddWithValue("@isPaid", isPaid);
                        command.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                        AddValueToCommandParam(command, "@Note", Note);
                        command.Parameters.AddWithValue("@TotalPaidPrice", TotalPaidPrice);

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

        public static bool UpdateRentingRecrod(int RentingID,decimal DistanseCovered,decimal FinalMillage,DateTime ReturnDate,bool isActive,decimal AdditionalFees,string Note)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = " Update Rents\r\n Set DistanceCovered=@DistanceCoverd,FinalMileage=@FinalMileage,ReturnDate=@ReturnDate,isActive=@isActive,AdditionalFees=@AdditionalFees,Note=@Note where RentID=@RentID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentingID);
                        command.Parameters.AddWithValue("@DistanceCoverd", DistanseCovered);
                        command.Parameters.AddWithValue("@FinalMileage", FinalMillage);
                        command.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                        command.Parameters.AddWithValue("@isActive", isActive);

                        command.Parameters.AddWithValue("@AdditionalFees", AdditionalFees);
                        command.Parameters.AddWithValue("@Note", Note);

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

        public static bool UpdateTotalAndPaidPrice(int ScheduleID,decimal NewTotalPrice,decimal PaidAmount)
        {

            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Rents\r\nset TotalPrice=@TotalPrice, TotalPaidPrice=@TotalPaidPrice where ScheduleID=@ScheduleID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@TotalPrice", NewTotalPrice);
                        command.Parameters.AddWithValue("@TotalPaidPrice", PaidAmount);
                        command.Parameters.AddWithValue("@ScheduleID", ScheduleID);

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

        public static DataTable GetAllRecordInTheSystem()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllRentingInTheSystem",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        
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

        public static bool DeleteRecord(int RentingID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_DeleteRenting",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RentID", RentingID);

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

        public static bool CheckIfCustomerHasMorethanOneActiveRenting(string FirstName,string LastName)
        {
            bool isRight = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select  dbo.IsCustomerHasMorethanActiveRenting(@Firstname,@LastName);";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Firstname", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        object reader=command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            if(value!=1)
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




        public static bool MakeisPaidFalse(int RentID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = " Update Rents \r\n set isPaid=0 where RentID=@RentID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RentID", RentID);

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
