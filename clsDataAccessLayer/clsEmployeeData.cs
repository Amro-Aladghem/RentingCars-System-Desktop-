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
    public class clsEmployeeData
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

        public static DataTable GetAllRecords()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qurey = "select *from EmployeeList;";

                    using(SqlCommand command=new SqlCommand(qurey, connection))
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

        public static bool GetFullRecord(int EmployeeID,ref int PersonID,ref DateTime DateOfBirth,ref bool isActive,ref decimal Salary,ref DateTime DateOfSet,ref int DepartmentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Employees where EmployeeID=@EmployeeID"; 

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {

                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader[1];
                                DateOfBirth = (DateTime)reader[2];
                                isActive = (bool)reader[3];
                                Salary = (decimal)reader[4];
                                DateOfSet= (DateTime)reader[5];
                                DepartmentID = (int)reader[6];

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

        public static bool GetFullRecordByName(ref int EmployeeID, int PersonID, ref DateTime DateOfBirth, ref bool isActive, ref decimal Salary, ref DateTime DateOfSet, ref int DepartmentID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Employees where  PersonID=@PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID",PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                EmployeeID = (int)reader[0];
                                DateOfBirth = (DateTime)reader[2];
                                isActive = (bool)reader[3];
                                Salary = (decimal)reader[4];
                                DateOfSet = (DateTime)reader[5];
                                DepartmentID = (int)reader[6];

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

        public static int AddNewRecord(int PersonID, DateTime DateOfBirth, bool isActive, decimal Salary, DateTime DateOfSet, int DepartmentID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Insert Into Employees(PersonID,DateOfBirth,isActive,Salary,DateOfSet,DepartmentID)\r\nvalues\r\n" +
                        "(@PersonId,@DateOfBirth,@isActive,@Salary,@DateOfSet,@DepartmentID);select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", PersonID);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@isActive", isActive);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@DateOfSet", DateOfSet);
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

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

        public static bool Update(int EmployeeID, bool isActive,string SecondName ,decimal Salary, int DepartmentID)
        {
            bool isDone = false;

            try
            {

                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Employees \r\nset isActive=@isActive,Salary=@Salary,DepartmentID=@DepartmentID where EmployeeID=@EmployeeID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@isActive", isActive);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                        

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

        public static bool Delete(int EmployeeID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string qeury = "delete Employees where EmployeeID=@EmployeeID";

                    using(SqlCommand command =new SqlCommand(qeury,connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

        public static bool isExits(int EmployeeID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select  EmployeeID from Employees where EmployeeID=@EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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

        public static string GetDepartment(int DepartmentID)
        {
            string DepartmentName = "";
            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select   DepartmentName  from Departments where DepartmentID=@DepartmentID";
                    
                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

                        using(SqlDataReader reader =command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                DepartmentName = (string)reader["DepartmentName"];

                            }

                        }

                    }

                }
            }
            catch
            {
                //
            }

            return DepartmentName;
        }








    }
}
