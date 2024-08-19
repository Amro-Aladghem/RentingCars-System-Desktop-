using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsPersonsData
    {
        private static void AddValueToParameter(SqlCommand command,string Parameter,object Value)
        {

            if(Value==null)
            {
                command.Parameters.AddWithValue(Parameter,System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(Parameter,Value);   
            }


        }
        public static bool GetfullRecord(int PersonID,ref string FirstName,ref string SecondName,ref string LastName,ref bool Gendor)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Persons where PersonID=@PersonID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                FirstName = (string)reader[1];
                                SecondName = (string)reader[2];
                                LastName = (string)reader[3];
                                Gendor = (bool)reader[4];

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

        public static bool GetFullRecordByName(ref int PersonID,string FirstName,ref string SecondName,ref string LastName,ref bool Gendor)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select *from Persons where FirstName=@FirstName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader[0];
                                SecondName = (string)reader[2];
                                LastName = (string)reader[3];
                                Gendor = (bool)reader[4];

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

        public static int AddNewRecord(string FirstName,string SecondName ,string LastName,bool Gendor)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string qurey = "Insert Into Persons (FirstName,SecondName,LastName,Gendor)\r\nvalues\r\n" +
                        "(@FirstName,@SecondName,@LastName,@Gendor);select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(qurey, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gendor", Gendor);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(),out int value))
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

        public static bool UpdateRecord(int PersonID,string SecondName)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Persons\r\nset SecondName=@SecondName where PersonID=@PersonID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                   
                        AddValueToParameter(command, "@SecondName", SecondName);

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

        public static bool DeleteRecord(int PersonID)
        {
            bool isDone = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "delete Persons where PersonID=@PersonID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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
