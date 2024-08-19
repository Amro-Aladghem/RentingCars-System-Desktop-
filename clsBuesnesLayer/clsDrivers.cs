using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccessLayer;

namespace clsBuesnesLayer
{
    public class clsDrivers
    {
        enum eMode { AddNew=1,Update=2 };
        eMode Mode;

        public int DriverID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfSet { get; set; }

        public clsDrivers()
        {
            this.DriverID = -1;
            this.FirstName = string.Empty;
            this.LastName=string.Empty;
            this.PhoneNumber = string.Empty;
            this.Nationality = string.Empty;
            this.Salary = 0;
            this.DateOfSet = DateTime.MinValue;

            Mode = eMode.AddNew;

        }

        public clsDrivers(int DriverId,string FirstName,string LastName,string PhoneNumber,string Nationality,decimal Salary,DateTime DateOfSet)
        {
            this.DriverID = DriverId;
            this.FirstName = FirstName;
            this.LastName= LastName;
            this.PhoneNumber= PhoneNumber;
            this.Nationality= Nationality;
            this.Salary = Salary;
            this.DateOfSet = DateOfSet;

            Mode = eMode.Update;
        }

        public static clsDrivers FindDriverByID(int DriverID)
        {
            string FirstName = "", LastName = "", PhoneNumber = "", Nationality = "";
            decimal Salary = 0;DateTime DateOfSet=DateTime.MinValue;

            if(clsDriversData.GetFullRecord(DriverID,ref FirstName,ref LastName,ref PhoneNumber,ref Nationality,ref Salary,ref DateOfSet))
            {
                return new clsDrivers(DriverID,FirstName,LastName,PhoneNumber,Nationality,Salary,DateOfSet);
            }
            else
            {
                return null;
            }
        }

        public static clsDrivers FindDriverByName(string FirstName)
        {
            string  LastName = "", PhoneNumber = "", Nationality = "";int DriverID = 0;
            decimal Salary = 0; DateTime DateOfSet = DateTime.MinValue;

            if (clsDriversData.GetFullRecordByName(ref DriverID,  FirstName, ref LastName, ref PhoneNumber, ref Nationality, ref Salary, ref DateOfSet))
            {
                return new clsDrivers(DriverID, FirstName, LastName, PhoneNumber, Nationality, Salary, DateOfSet);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewDriver()
        {

            this.DriverID = clsDriversData.AddNewRecord(this.FirstName, this.LastName, this.PhoneNumber, this.Nationality, this.Salary, this.DateOfSet);
            return DriverID != -1;

        }

        private bool _UpdateDriver()
        {
            return clsDriversData.UpdateRecord(this.DriverID, this.FirstName, this.LastName, this.PhoneNumber, this.Nationality, this.Salary, this.DateOfSet);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    {
                        if(_AddNewDriver())
                        {
                            Mode = eMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case eMode.Update:
                    {
                        if(_UpdateDriver())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                default:
                    return false;

            }

        }

        public static bool DeleteDriver(int DriverID)
        {
            return clsDriversData.DeleteRecord(DriverID);
        }

        public static bool isExits(int DriverID)
        {
            return clsDriversData.isExits(DriverID);
        }

        public static bool isExitsByName(string FirstName)
        {
            return clsDriversData.isExitsByName(FirstName);
        }

        public static DataTable GetAllDriverRecord()
        {
            return clsDriversData.GetAllRecord();
        }






    }
}
