using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public class clsApplications
    {
       public enum eApplicationType {Login=1,AddRenting=2,ChangeRenting=3,PayRenting=4,MakePayment=5};

        public static DataTable GetAllApplicationList()
        {
            return clsApplicationData.GetAllApplicationsRecords();
        }

        public static void AddNewApplication(eApplicationType ApplicationType,int UserID)
        {
           clsApplicationData.AddNewApplication((int)ApplicationType,UserID);   
        }

    }
}
