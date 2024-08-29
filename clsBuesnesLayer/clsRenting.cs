using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using clsBuesnesLayer;
using clsDataAccessLayer;

namespace clsBuesnesLayer
{
    public class clsRenting
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        public  int RentID { get; set; }
        public int SechduleID { get; set; }
        public decimal? DistanceCovered { get; set; }
        public decimal InitialMileage { get; set; }
        public decimal? FinalMileage { get; set; }
        public DateTime ? ReturnDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPaid { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AddionalFees { get; set; }
        public string Note { get; set; }
        public decimal TotalPaidPrice { get; set; }

        
        public clsRenting()
        {

            this.RentID          = -1;
            this.SechduleID      = -1;
            this.DistanceCovered = null;
            this.InitialMileage  = -1;
            this.FinalMileage    =  null;
            this.ReturnDate      = null;
            this.IsActive        = true;
            this.IsPaid          = false;
            this.TotalPaidPrice  = 0;
            this.AddionalFees    = 0;
            this.Note            = null;
            this.TotalPrice      = 0;

            Mode = eMode.AddNew;
        }

        public clsRenting(int RentID,int ScheduleID,decimal ? DistanceCovered,decimal InitialMillage,decimal ?FinalMilleage,DateTime ?ReturnDate,bool isActive,bool isPaid,
           decimal TotalPrice,decimal AdditionalFees,string Note,decimal TotalPaidPrice )
        {

            this.RentID = RentID;
            this.SechduleID = ScheduleID;
            this.DistanceCovered = DistanceCovered;
            this.InitialMileage = InitialMillage;
            this.FinalMileage = FinalMileage;
            this.ReturnDate = ReturnDate;
            this.IsActive = isActive;
            this.IsPaid = isPaid;
            this.TotalPaidPrice = TotalPaidPrice;
            this.AddionalFees = AdditionalFees;
            this.Note = Note;
            this.TotalPrice = TotalPrice;

            Mode = eMode.Update;


        }

        public static clsRenting FindRentingByID(int RentID)
        {
            int SechduleID = 0; decimal? DistanceCovered = null,  FinalMilleage = null;   decimal InitialMileage = 0, TotalPrice = 0, AdditionalFees = 0, TotalPaidPrice = 0;
            DateTime? ReturnDate = null;  bool isActive = false, isPaid = false; string Note = null;

            if(clsRentingData.GetFullRecordByID(RentID,ref SechduleID,ref DistanceCovered,ref InitialMileage,ref FinalMilleage,ref ReturnDate,ref isActive,ref isPaid,ref TotalPrice,ref AdditionalFees,ref Note,ref TotalPaidPrice))
            {
                return new clsRenting(RentID, SechduleID, DistanceCovered, InitialMileage, FinalMilleage,ReturnDate, isActive, isPaid, TotalPrice, AdditionalFees, Note,TotalPaidPrice);
            }
            else
            {
                return null;
            }
        }

        public static clsRenting FindRentingByIDNotActive(int RentID)
        {
            int SechduleID = 0; decimal? DistanceCovered = null, FinalMilleage = null; decimal InitialMileage = 0, TotalPrice = 0, AdditionalFees = 0, TotalPaidPrice = 0;
            DateTime? ReturnDate = null; bool isActive = false, isPaid = false; string Note = null;

            if (clsRentingData.GetFullRecordByIDNotActive(RentID, ref SechduleID, ref DistanceCovered, ref InitialMileage, ref FinalMilleage, ref ReturnDate, ref isActive, ref isPaid, ref TotalPrice, ref AdditionalFees, ref Note, ref TotalPaidPrice))
            {
                return new clsRenting(RentID, SechduleID, DistanceCovered, InitialMileage, FinalMilleage, ReturnDate, isActive, isPaid, TotalPrice, AdditionalFees, Note, TotalPaidPrice);
            }
            else
            {
                return null;
            }
        }


        public static clsRenting FindRentingByCustomerName(string FirstName,string LastName)
        {
            int SechduleID = 0,RentID=0; decimal? DistanceCovered = null, FinalMilleage = null; decimal InitialMileage = 0, TotalPrice = 0, AdditionalFees = 0, TotalPaidPrice = 0;
            DateTime? ReturnDate = null; bool isActive = false, isPaid = false; string Note = null;

            if (clsRentingData.GetFullRecordByCustomerName(FirstName,LastName,ref RentID, ref SechduleID, ref DistanceCovered, ref InitialMileage, ref FinalMilleage, ref ReturnDate, ref isActive, ref isPaid, ref TotalPrice, ref AdditionalFees, ref Note, ref TotalPaidPrice))
            {
                return new clsRenting(RentID, SechduleID, DistanceCovered, InitialMileage, FinalMilleage, ReturnDate, isActive, isPaid, TotalPrice, AdditionalFees, Note, TotalPaidPrice);
            }
            else
            {
                return null;
            }
        }

        public static clsRenting FindRentingByCustomerNameNotActive(string FirstName, string LastName)
        {
            int SechduleID = 0, RentID = 0; decimal? DistanceCovered = null, FinalMilleage = null; decimal InitialMileage = 0, TotalPrice = 0, AdditionalFees = 0, TotalPaidPrice = 0;
            DateTime? ReturnDate = null; bool isActive = false, isPaid = false; string Note = null;

            if (clsRentingData.GetFullRecordByCustomerNameNotActive(FirstName, LastName, ref RentID, ref SechduleID, ref DistanceCovered, ref InitialMileage, ref FinalMilleage, ref ReturnDate, ref isActive, ref isPaid, ref TotalPrice, ref AdditionalFees, ref Note, ref TotalPaidPrice))
            {
                return new clsRenting(RentID, SechduleID, DistanceCovered, InitialMileage, FinalMilleage, ReturnDate, isActive, isPaid, TotalPrice, AdditionalFees, Note, TotalPaidPrice);
            }
            else
            {
                return null;
            }
        }


        public static clsRenting FindRentingByCustomerName(string CarName,string CarModel,string FirstName, string LastName)
        {
            int SechduleID = 0, RentID = 0; decimal? DistanceCovered = null, FinalMilleage = null; decimal InitialMileage = 0, TotalPrice = 0, AdditionalFees = 0, TotalPaidPrice = 0;
            DateTime? ReturnDate = null; bool isActive = false, isPaid = false; string Note = null;

            if (clsRentingData.GetFullRecordByCustomerAndVehcileName(CarName,CarModel,FirstName, LastName, ref RentID, ref SechduleID, ref DistanceCovered, ref InitialMileage, ref FinalMilleage, ref ReturnDate, ref isActive, ref isPaid, ref TotalPrice, ref AdditionalFees, ref Note, ref TotalPaidPrice))
            {
                return new clsRenting(RentID, SechduleID, DistanceCovered, InitialMileage, FinalMilleage, ReturnDate, isActive, isPaid, TotalPrice, AdditionalFees, Note, TotalPaidPrice);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewRenting()
        {
            this.RentID = clsRentingData.AddNewRentingRecord(this.SechduleID, this.InitialMileage, this.IsActive, this.IsPaid, this.TotalPrice, this.Note, this.TotalPaidPrice);
            return RentID != -1;
        }

        private bool _UpdateRenting()
        {
            return clsRentingData.UpdateRentingRecrod(this.RentID, (decimal)this.DistanceCovered, (decimal)this.FinalMileage, (DateTime)this.ReturnDate, this.IsActive, this.AddionalFees, this.Note);
        }

        public bool Save()
        {
            switch (Mode)
            {

                case eMode.AddNew:
                    {

                        if (_AddNewRenting())
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
                        if(_UpdateRenting())
                        {
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

        public static bool UpdateTotalPriceAndPaidAmount(int ScheduleID,decimal NewTotalPrice,decimal PaidAmount)
        {
            return clsRentingData.UpdateTotalAndPaidPrice(ScheduleID, NewTotalPrice, PaidAmount);
        }

        public static bool DeleteRenting(int RentID)
        {
            return clsRentingData.DeleteRecord(RentID);
        }

        public bool DeleteRenting()
        {
            return clsRentingData.DeleteRecord(this.RentID);
        }

        public static  DataTable GetAllRentingRecordInTheSys()
        {
            return clsRentingData.GetAllRecordInTheSystem();
        }

        public static bool IsCustomerHasMorThanOneActiveRenting(string FirstName,string LastName)
        {
            return IsCustomerHasMorThanOneActiveRenting(FirstName,LastName);
        }


        public static bool MakeIsPaidFalse(int RentID)
        {
            return clsRentingData.MakeisPaidFalse(RentID);
        }










    }
}
