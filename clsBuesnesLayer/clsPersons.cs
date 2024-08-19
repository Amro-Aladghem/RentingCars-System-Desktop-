using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccessLayer;

namespace clsBuesnesLayer
{
    public class clsPersons
    {
        enum eMode { AddNew=1,Update=2};
        eMode Mode;


        public int PersonID {  get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public  bool Gendor { get; set; }

        private string LastSecondName = "";

        public clsPersons()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.LastName = string.Empty;
            this.Gendor = false;

            Mode=eMode.AddNew;

        }

        public clsPersons(int PersonID,string FirstName,string SecondName,string LastName,bool Gendor)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName=SecondName;
            this.LastName=LastName;
            this.Gendor = Gendor;
            this.LastSecondName = SecondName;

            Mode = eMode.Update;
        }

        public static clsPersons FindPersonByID(int PersonID)
        {
            string FirstName = "", SecondName = "", LastName = "";
            bool Gendor = false;

            if(clsPersonsData.GetfullRecord(PersonID,ref FirstName,ref SecondName,ref LastName,ref Gendor))
            {
                return new clsPersons(PersonID, FirstName, SecondName, LastName, Gendor);
            }
            else
            {
                return null;
            }
              
        }

        public static clsPersons FindPersonByName(string FirstName)
        {
            string  SecondName = "", LastName = "";
            bool Gendor = false;int PersonID = 0;

            if (clsPersonsData.GetFullRecordByName(ref PersonID,FirstName, ref SecondName, ref LastName, ref Gendor))
            {
                return new clsPersons(PersonID, FirstName, SecondName, LastName, Gendor);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonsData.AddNewRecord(this.FirstName, this.SecondName, this.LastName, this.Gendor);
            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            if(this.SecondName==this.LastSecondName)
            {
                return true;
            }
            else
            {
                return clsPersonsData.UpdateRecord(this.PersonID, this.SecondName);
            }
        }

        public virtual bool Save()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    {
                        if(_AddNewPerson())
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
                        if(_UpdatePerson())
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

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonsData.DeleteRecord(PersonID);
        }













    }
}
