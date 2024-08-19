using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using clsDataAccessLayer;

namespace clsBuesnesLayer
{
    public class clsEmployee:clsPersons
    {

        enum eMode { AddNew=1,Udpate=2}
        eMode Mode;

        public int EmployeeID { get; set; }   
        public DateTime DateOfBirth {  get; set; }
        public bool isActive { get; set; }
        public decimal Salary {  get; set; }
        public DateTime DateOfSet { get; set; }
        public clsPersons Person { get; set; }
        public int DepartmentID { get; set; }

        public clsEmployee()
        {

            base.PersonID = -1;
            base.FirstName = "";
            base.SecondName = "";
            base.LastName = "";
            base.Gendor = false;

            this. EmployeeID = -1;
            this. DateOfBirth = DateTime.MinValue;
            isActive = false;
            Salary = 0;
            DateOfSet= DateTime.MinValue;
            Person = null;

         
            Mode = eMode.AddNew;
          
        }

        public clsEmployee(int EmployeeID,clsPersons Person,DateTime DateOfBirth,bool isActive,decimal Salary,DateTime DateOfSet,int DepartmentID)
        {
            this.EmployeeID = EmployeeID;
            this.DateOfBirth=DateOfBirth;
            this.isActive = isActive;
            this.Salary = Salary;
            this.DateOfSet = DateOfSet;
            this.Person = Person;
            this.DepartmentID=DepartmentID;

            base.PersonID = Person.PersonID;
            base.FirstName = Person.FirstName;
            base.SecondName = Person.SecondName;
            base.LastName=Person.LastName;
            base.Gendor = Person.Gendor;

            Mode = eMode.Udpate;
        }

        public static clsEmployee FindEmployee(int EmployeeID)
        {
            DateTime DateOfBirth = DateTime.MinValue,DateOfSet = DateTime.MinValue;
            bool isActive = false; decimal Salary = 0; int PersonID = 0, DepartmentID = 0;
           
            if(clsEmployeeData.GetFullRecord(EmployeeID,ref PersonID,ref DateOfBirth,ref isActive,ref Salary,ref DateOfSet,ref DepartmentID))
            {
                clsPersons person = clsPersons.FindPersonByID(PersonID);
                return new clsEmployee(EmployeeID, person, DateOfBirth, isActive, Salary, DateOfSet, DepartmentID);
            }
            else
            {
                return null;
            }

        }

        public static clsEmployee FindEmployeeByName(int PersonID)
        {
            DateTime DateOfBirth = DateTime.MinValue, DateOfSet = DateTime.MinValue;
            bool isActive = false; decimal Salary = 0; int DepartmentID = 0, EmployeeID = 0;

            if (clsEmployeeData.GetFullRecordByName(ref EmployeeID,  PersonID, ref DateOfBirth, ref isActive, ref Salary, ref DateOfSet, ref DepartmentID))
            {
                clsPersons person = clsPersons.FindPersonByID(PersonID);
                return new clsEmployee(EmployeeID, person, DateOfBirth, isActive, Salary, DateOfSet, DepartmentID);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewEmployee()
        {
            this.EmployeeID = clsEmployeeData.AddNewRecord(base.PersonID, this.DateOfBirth, this.isActive, this.Salary, this.DateOfSet, this.DepartmentID);
            return EmployeeID != -1;
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeeData.Update(this.EmployeeID, this.isActive,this.SecondName, this.Salary, this.DepartmentID);
        }

        public override bool Save()
        {
            switch(Mode)
            {

                case eMode.AddNew:
                    {
                        if (!base.Save())
                        {
                            return false;
                        }

                        if(_AddNewEmployee())
                        {
                            Mode = eMode.Udpate;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case eMode.Udpate:
                    {
                        if(!Person.Save())
                        {
                            return false;
                        }

                        if(_UpdateEmployee())
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

        public static bool DeleteEmployee(int EmployeeID,int PersonID)
        {
            return clsEmployeeData.Delete(EmployeeID) && DeletePerson(PersonID);
        }

        public static bool isExits(int EmployeeID)
        {
            return clsEmployeeData.isExits(EmployeeID);
        }

        public static string GetDepartmentName(int DepartmentID)
        {
            return clsEmployeeData.GetDepartment(DepartmentID);
        }

        public static DataTable GetAllEmployeeRecord()
        {
            return clsEmployeeData.GetAllRecords();
        }








    }
}
