using clsDataAccessLayer;
using System;
using System.CodeDom;
using System.Collections.Generic;
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












    }


}
