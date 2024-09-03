using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public class clsManager
    {
        public static  DataTable GetAllManagerInSys()
        {
            return   clsManagersData.GetAllManagersInTheList();
        }

        public static DataTable GetAllSectionsNameInSys()
        {
            return clsManagersData.GetAllSectionsName();
        }

        public static bool DeleteMangerFromSys(int ManagerID)
        {
            return clsManagersData.DeleteManager(ManagerID);
        }

        public static bool AddNewManager(int SectionID,string ManagerName,int UserID)
        {
            int NewID = clsManagersData.AddNewRecord(ManagerName, SectionID, UserID);
            return NewID != -1;
        }

        public static bool UpdateManger(int ManagerId,int NewSectionID)
        {
            return clsManagersData.UpdateManagerSection(ManagerId, NewSectionID);
        }

        public static bool IsUserIsAManager(int UserID)
        {
            return clsManagersData.IsUserIsManger(UserID);
        }

        public static DataTable GetAllRentingHistory()
        {
            return clsManagersData.GetAllRentingHistoryRecords();
        }












    }
}
