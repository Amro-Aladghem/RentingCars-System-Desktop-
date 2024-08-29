using clsDataAccessLayer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public class clsPayment
    {
        enum eMode { AddNew = 1, Update = 2 }
        eMode Mode;

        public int PaymentID { get; set; }
        public int RentID { get; set; } 
        public DateTime DateOfPaid { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal ReturnAmount { get; set; }
        public string  Note { get; set; }

        public clsPayment()
        {
            this.PaymentID         = -1;
            this.RentID            = -1;
            this.DateOfPaid        = DateTime.Now;
            this.PaidAmount        = 0;
            this.ReturnAmount      = 0;
            this.Note              = string.Empty;

            Mode = eMode.AddNew;
        }

        public clsPayment(int PaymentID,int RentID,DateTime DateOfPaid,decimal PaidAmount,decimal ReturnAmount,string Note)
        {
            this.PaymentID = PaymentID;
            this.RentID = RentID;
            this.DateOfPaid = DateOfPaid;
            this.PaidAmount = PaidAmount;
            this.ReturnAmount = ReturnAmount;
            this.Note = Note;

            Mode = eMode.Update;
        }

        private bool _AddNewPayment()
        {
            this.PaymentID=clsPaymentData.AddNewRecord(this.RentID,this.DateOfPaid,this.PaidAmount,this.ReturnAmount,this.Note);
            return PaymentID != -1;
        }

        public bool save()
        {
            switch (Mode)
            {
                case eMode.AddNew:
                    {
                        if(_AddNewPayment())
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

        public  static clsPayment FindPaymentByRentID(int RentID)
        {
            int PaymentID = -1; string Note= null;
            DateTime DateOfPaid= DateTime.MinValue;decimal PaidAmount = 0, ReturnAmount = 0;

            if (clsPaymentData.GetFullRecordByRentID(ref PaymentID, RentID, ref DateOfPaid, ref PaidAmount, ref ReturnAmount, ref Note))
            {
               return new clsPayment(PaymentID,RentID,DateOfPaid,PaidAmount,ReturnAmount,Note);
            }
            else
            {
                return null;
            }
        }

        public bool DeletePaymentRecord(int PaymentID)
        {
            return clsPaymentData.DeletePaymentRecord(PaymentID);
        }

        public static DataTable GetAllPaymentsRecords()
        {
            return clsPaymentData.GetAllPaymentRecords();
        }










    }


}
