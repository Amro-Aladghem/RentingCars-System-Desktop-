using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public class clsSystemRules
    {

        //VehiclePrice Table;
        public static DataTable GetAllVehiclePriceRecords()
        {
            return SystemRulesData.GetAllVehicelsPricesList();
        }

        public static bool AddPriceToVehicle(int VehicledID,decimal PricePerDay )
        {
            return SystemRulesData.AddPriceForVehcile(VehicledID,PricePerDay);  
        }

        public static bool UpdatePriceForVehicle(int VehicleID,decimal NewPricePerDay)
        {
            return SystemRulesData.UpdateRentingPriceFortheVehicle(VehicleID,NewPricePerDay);
        }

        public static bool DeleteVehiclePriceRecord(int VehicleID)
        {
            return SystemRulesData.DeleteRentingPriceRecord(VehicleID);
        }

        //StaticRules Table;
        

        public static DataTable GetAllStaticRulesRecord()
        {
            return SystemRulesData.GetAllStaticRulesRecord();
        }

        public static bool AddNewStaticRules(string RulesName,string Discribtion)
        {
            return SystemRulesData.AddNewStaticRules(RulesName, Discribtion);
        }

        public static bool UpdateStaticRules(int ID,string NewDiscribtion)
        {
            return SystemRulesData.UdpateStaticRules(ID, NewDiscribtion);
        }

        public static bool DeleteStaticRules(int ID)
        {
            return SystemRulesData.DeleteStaticRules(ID);
        }



    }
}
