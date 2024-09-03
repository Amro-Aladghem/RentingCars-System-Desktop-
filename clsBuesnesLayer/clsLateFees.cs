using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public  class clsLateFees
    {
        enum eMode { AddNew=1,Update=2};
        eMode Mode;

        public int LateFeesID { get; set; }
        public int RentID { get; set; }
        public decimal FeesAmount { get; set; }
        public bool isPaid { get; set; }
        public string Reason { get; set; }
        public int DaysOfDelay { get; set; }

        public clsLateFees()
        {
            LateFeesID     = -1;
            RentID         = -1;
            FeesAmount     = 0;
            isPaid         = false;
            Reason         = string.Empty;
            DaysOfDelay    = 0;

            Mode = eMode.AddNew;
        }

        public clsLateFees(int LateFeesID,int RentID,decimal FeesAmount, bool isPaid,string reason,int DaysOfDelay)
        {
            this.LateFeesID = LateFeesID;
            this.RentID = RentID;
            this.FeesAmount = FeesAmount;
            this.isPaid = isPaid;
            this.Reason = Reason;
            this.DaysOfDelay = DaysOfDelay;

            Mode = eMode.Update;
        }

        public static clsLateFees FindLateFeesRecord(int RentID)
        {
            int DaysOfDelay = 0, LateFeesID = 0; decimal FeesAmount = 0; bool isPaid = false; string Reason = "";

            if(clsLateFeesData.GetFullRecordByRentID(ref LateFeesID,RentID,ref FeesAmount,ref Reason,ref isPaid,ref DaysOfDelay))
            {
                return new clsLateFees(LateFeesID,RentID,FeesAmount,isPaid,Reason,DaysOfDelay);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewLateFees()
        {
            this.LateFeesID = clsLateFeesData.AddNewLateFeesRecord(this.RentID, this.FeesAmount, this.Reason, this.DaysOfDelay);
            return LateFeesID != -1;
        }

        private bool _UpdateLateFeesRecord()
        {
            return clsLateFeesData.UpdateLateFeesRecord(this.RentID, this.DaysOfDelay);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    {
                        if(_AddNewLateFees())
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
                        if(_UpdateLateFeesRecord())
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
        public static DataTable GetAllLateFeesRecord()
        {
            return clsLateFeesData.GetAllLateFeesRecordInTheSys();
        }

        public static bool CheckIfRentingIsHasLateFees(int RentID)
        {
            return clsLateFeesData.CheckIfRentHasLateFeesRecord(RentID);
        }

        public static bool DeleteLateRentingFeesRecord(int RentID)
        {
            return clsLateFeesData.DeleteLateFeesRecord(RentID);
        }






    }
}
