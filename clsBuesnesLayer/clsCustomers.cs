using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public class clsCustomers :clsPersons
    {
        enum eMode { AddNew=1, Update=2 };
        eMode Mode;

        public int CustomerID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; } 
        public string NationalNum { get; set; }

        public clsPersons Person;

        public clsCustomers()
        {
            base.PersonID = -1;
            base.FirstName= string.Empty;
            base.LastName= string.Empty;
            base.SecondName= string.Empty;
            base.Gendor = false;

            this.CustomerID= -1;
            this.PhoneNumber = string.Empty;
            this.Email = string.Empty;
            this.Nationality= string.Empty;
            this.NationalNum = NationalNum;

            Mode = eMode.AddNew;

        }

        public clsCustomers(int CustomerID,clsPersons Person,string PhoneNumber,string Email,string Nationality,string NationalNum)
        {
            this.CustomerID= CustomerID;
            this.PhoneNumber = PhoneNumber;
            this.Email= Email;
            this.Nationality = Nationality;
            this.NationalNum = NationalNum;

            base.PersonID = Person.PersonID;
            base.FirstName = Person.FirstName;
            base.SecondName = Person.SecondName;
            base.LastName = Person.LastName;
            base.Gendor = Person.Gendor;

            this.Person = Person;

            Mode = eMode.Update;

        }


        public static clsCustomers FindCustomerByID(int CustomerID)
        {
            string PhoneNumber = "", Email = "", Nationlaity = "";
            string NationalNum = ""; int PersonID = 0;
             
            if(clsCustomersData.GetFullRecordByID(CustomerID,ref PersonID,ref PhoneNumber,ref Email,ref Nationlaity,ref NationalNum))
            {
                clsPersons persons = clsPersons.FindPersonByID(PersonID);
                return new clsCustomers(CustomerID,persons,PhoneNumber,Email,Nationlaity,NationalNum);
            }
            else
            {
                return null;
            }

        }

        public static clsCustomers FindCustomerByName(int PersonID)
        {
            string PhoneNumber = "", Email = "", Nationlaity = "";
            string NationalNum = "";int CustomerID = 0;

            if (clsCustomersData.GetFullRecordByName(ref CustomerID,PersonID, ref PhoneNumber, ref Email, ref Nationlaity, ref NationalNum))
            {
                clsPersons persons = clsPersons.FindPersonByID(PersonID);
                return new clsCustomers(CustomerID, persons, PhoneNumber, Email, Nationlaity, NationalNum);
            }
            else
            {
                return null;
            }

        }

        private bool AddNewCustomer()
        {
            this.CustomerID = clsCustomersData.AddNewRecord(base.PersonID, this.PhoneNumber, this.Email, this.Nationality, this.NationalNum);
            return CustomerID != -1;
        }

        private bool UpdateCustomer()
        {
            return clsCustomersData.UpdateRecord(this.CustomerID, this.PhoneNumber, this.Email);
        }

        public override bool Save()
        {
            switch (Mode)
            {
                case eMode.AddNew:
                    {
                        if(!base.Save())
                        {
                            return false;
                        }

                        if(AddNewCustomer())
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
                        if(!Person.Save())
                        {
                            return false;
                        }

                        if(UpdateCustomer())
                        {
                            Mode = eMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                default: return false;

            }
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomersData.DeleteRecord(CustomerID);
        }

        public  bool DeleteCustomer()
        {
            return clsCustomersData.DeleteRecord(this.CustomerID) && clsPersons.DeletePerson(this.PersonID);
        }

        public static bool IsCustomerExsits(int CustomerID)
        {
            return clsCustomersData.IsExsits(CustomerID);
        }

        public static DataTable GetAllCustomerInTheSystem()
        {
            return clsCustomersData.GetAllRecord();
        }












    }
}
