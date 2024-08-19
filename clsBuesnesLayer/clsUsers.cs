using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using clsDataAccessLayer;

namespace clsBuesnesLayer
{
    public class clsUsers
    {
        public enum eApplicationTypes {Customers=1,Vehicles=2,Retain=4,Payments=8,SystemRules=16,Employees=32,Notificaion=64,LateFees=128,Application=256,Users=512,Manegment=1024 }

        enum eMode { AddNew=1,Update=2 }
        eMode Mode;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int EmployeeID { get; set; }
        public int NumberOfPermisions { get; set; }
        public bool isActive { get; set; }

        public clsUsers()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            EmployeeID = -1;
            NumberOfPermisions = 0;
            isActive = false;

            Mode = eMode.AddNew;

        }

        public clsUsers(int UserID,string UserName,string Password,int EmployeeID,int NumberOfPermisions,bool isActive)
        {
            this.UserID = UserID;
            this.UserName=UserName;
            this.Password=Password;
            this.EmployeeID = EmployeeID;
            this.NumberOfPermisions=NumberOfPermisions;
            this.isActive=isActive;

            Mode = eMode.Update;
        }


        public static clsUsers FindUserByID(int UserID)
        {
            string UserName = "", Password = ""; int EmployeeID = 0, NumberOfPermisions = 0;bool isActive = false;

            if(clsUsersData.GetFullRecordByID(UserID,ref UserName,ref Password,ref EmployeeID,ref NumberOfPermisions,ref isActive))
            {
                return new clsUsers(UserID,UserName,Password,EmployeeID,NumberOfPermisions,isActive);
            }
            else
            {
                return null;
            }


        }

        public static clsUsers FindUserByName(string UserName)
        {
            string Password = ""; int EmployeeID = 0, NumberOfPermisions = 0; bool isActive = false;
            int UserID = 0;

            if (clsUsersData.GetFullRecordByName(ref UserID, UserName, ref Password, ref EmployeeID, ref NumberOfPermisions, ref isActive))
            {
                return new clsUsers(UserID, UserName, Password, EmployeeID, NumberOfPermisions, isActive);
            }
            else
            {
                return null;
            }


        }
        private bool _AddNewUser()
        {
            this.UserID = clsUsersData.AddNewRecord(this.UserName, this.Password, this.EmployeeID, this.NumberOfPermisions, this.isActive);
            return UserID != -1;
        }
        private bool _UpdateUser()
        {
            return clsUsersData.UdpateReocrd(this.UserID, this.UserName, this.Password, this.NumberOfPermisions, this.isActive);
        }

        public bool Save()
        {
            switch(Mode)
            {

                case eMode.AddNew:
                    {
                        if(_AddNewUser())
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
                        if(_UpdateUser())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                default: { return false; }

            }
        }

        public static bool isExits(int UserID)
        {
            return clsUsersData.isExits(UserID);
        }

        public static bool DeActivateUser(int UserID)
        {
            return clsUsersData.DeactivateUser(UserID);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteRecord(UserID);
        }

        public static bool UpdatePassword(int UserID,string newPassword)
        {
            return clsUsersData.UpdatePassword(UserID, newPassword);
        }

        public static DataTable GetAllUsersInTheSystem()
        {
            return clsUsersData.GetAllRecord();
        }

        public  bool UdpatePassword(string newPassword)
        {
            return clsUsersData.UpdatePassword(this.UserID, newPassword);
        }

        public bool DeActivateUser()
        {
            return clsUsersData.DeactivateUser(this.UserID);
        }

        public bool Delete()
        {
            return clsUsersData.DeleteRecord(this.UserID);
        }

        public static bool IsEmployeeAlreadyUser(int EmployeeID)
        {
            return clsUsersData.CheckIfEmployeeIsUser(EmployeeID);
        }



        public static  DataTable GetAllPeople()
        {
            return clsVehiclesData.GetAllRecord();
        }


    }
}
