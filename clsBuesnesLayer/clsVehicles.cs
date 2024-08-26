using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBuesnesLayer
{
    public class clsVehicles
    {

        enum eMode { AddNew = 1, Update = 2 };
        eMode Mode;

        public enum eStatusType { Rented = 1, Not_Rented = 2, Hasing_Issue = 3 };

        public int VehicleID { get; set; }
        public int CarTypeID { get; set; }
        public int CarModelID { get; set; }
        public string ProducedYear { get; set; }
        public decimal CurrentMillageCounter { get; set; }
        public int ColorID { get; set; }
        public string IsHasDamaged { get; set; }
        public int RentStatusID { get; set; }
        public DateTime? LastDateForRent { get; set; }
        public string CarNumber { get; set; }

        public static int CarType_ID { get; set; }    //these fields used when I dont have an object of vehicle ,Ex.FindByTypeAndModelName 
        public static int CarModel_ID { get; set; }


        public clsVehicles()
        {
            this.VehicleID = -1;
            this.CarTypeID = -1;
            this.CarModelID = -1;
            this.ProducedYear = string.Empty;
            this.CurrentMillageCounter = 0;
            this.ColorID = -1;
            this.IsHasDamaged = string.Empty;
            this.RentStatusID = -1;
            this.LastDateForRent = null;
            this.CarNumber = string.Empty;

            Mode = eMode.AddNew;
        }

        public clsVehicles(int VehicleID, int CarTypeId, int CarModelID, string ProducedYear, decimal CurrentMilageCounter, int ColorID, string IsHasDamaged, int RentStatusID, DateTime? LastDateForRent, string CarNumber)
        {
            this.VehicleID = VehicleID;
            this.CarTypeID = CarTypeId;
            this.CarModelID = CarModelID;
            this.ProducedYear = ProducedYear;
            this.CurrentMillageCounter = CurrentMilageCounter;
            this.ColorID = ColorID;
            this.IsHasDamaged = IsHasDamaged;
            this.RentStatusID = RentStatusID;
            this.LastDateForRent = LastDateForRent;
            this.CarNumber = CarNumber;

            Mode = eMode.Update;
        }

        public static clsVehicles FindVehicleByID(int VehicleID)
        {
            int CarTypeID = -1, CarModelID = -1, RentStatusID = -1, ColorID = -1;
            string ProducedYear = "", IsHasDamaged = "", CarNumber = "";
            decimal CurrentMillageCounter = 0; DateTime? LastDateForRent = DateTime.MinValue;

            if (clsVehiclesData.GetFullRecordByID(VehicleID, ref CarTypeID, ref CarModelID, ref ProducedYear, ref CurrentMillageCounter, ref ColorID, ref IsHasDamaged, ref RentStatusID, ref LastDateForRent, ref CarNumber))
            {
                return new clsVehicles(VehicleID, CarTypeID, CarModelID, ProducedYear, CurrentMillageCounter, ColorID, IsHasDamaged, RentStatusID, LastDateForRent, CarNumber);
            }
            else
            {
                return null;
            }
        }

        public static clsVehicles FindVehicleByCarTypeAndModel(int CarTypeID, int CarModelID)
        {
            int VehicleID = -1, RentStatusID = -1, ColorID = -1;
            string ProducedYear = "", IsHasDamaged = "", CarNumber = "";
            decimal CurrentMillageCounter = 0; DateTime? LastDateForRent = DateTime.MinValue;

            if (clsVehiclesData.GetFullRecordByTypeAndModel(ref VehicleID, CarTypeID, CarModelID, ref ProducedYear, ref CurrentMillageCounter, ref ColorID, ref IsHasDamaged, ref RentStatusID, ref LastDateForRent, ref CarNumber))
            {
                return new clsVehicles(VehicleID, CarTypeID, CarModelID, ProducedYear, CurrentMillageCounter, ColorID, IsHasDamaged, RentStatusID, LastDateForRent, CarNumber);
            }
            else
            {
                return null;
            }
        }

        public static clsVehicles FindVehicleByCarTypeAndModelName(string CarTypeName,string CarModelName)
        {
            int CarTypeID = -1, CarModelID = -1, RentStatusID = -1, ColorID = -1;
            string ProducedYear = "", IsHasDamaged = "", CarNumber = "";
            decimal CurrentMillageCounter = 0; DateTime? LastDateForRent = DateTime.MinValue; int VehicleID = -1;

            if(clsVehiclesData.GetFullRecorrdByTwoName(CarTypeName,CarModelName, ref VehicleID, ref CarTypeID, ref CarModelID, ref ProducedYear, ref CurrentMillageCounter, ref ColorID, ref IsHasDamaged, ref RentStatusID, ref LastDateForRent, ref CarNumber))
            {
                CarType_ID = CarTypeID;
                CarModel_ID=CarModelID;
                return new clsVehicles(VehicleID, CarTypeID, CarModelID, ProducedYear, CurrentMillageCounter, ColorID, IsHasDamaged, RentStatusID, LastDateForRent, CarNumber);

            }
            else
            {
                return null; 
            }

        }

        private bool _AddNewVehicle()
        {
            this.VehicleID = clsVehiclesData.AddNewRecord(this.CarTypeID, this.CarModelID, this.ProducedYear, this.CurrentMillageCounter, this.ColorID, this.IsHasDamaged, this.RentStatusID, this.LastDateForRent, this.CarNumber);
            return VehicleID != -1;
        }

        private bool _UpdateVehicle()
        {
            return clsVehiclesData.UpdateRecord(this.VehicleID, this.CurrentMillageCounter, this.IsHasDamaged, this.RentStatusID, this.LastDateForRent);
        }

        public bool Save()
        {

            switch (Mode)
            {

                case eMode.AddNew:
                    {
                        if (_AddNewVehicle())
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
                        if (_UpdateVehicle())
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

        public static bool DeleteVehicle(int VehicleID)
        {
            return clsVehiclesData.DeleteRecord(VehicleID);
        }

        public bool DeleteVehicle()
        {
            return clsVehiclesData.DeleteRecord(this.VehicleID);
        }

        public static DataTable GetAllVehiclesInTheSystem()
        {
            return clsVehiclesData.GetAllRecord();
        }

        public static bool IsVehicleAllowedForRent(int VehicleID)
        {
            return clsVehiclesData.CheckIfCarAvaialable(VehicleID);
        }

        public static DataTable GetAllCarTypesInTheSystem()
        {
            return clsVehiclesData.GetAllCarTypeInTheSystem();
        }

        public static DataTable GetAllModelsForTheVehicl(int CarTypeID)
        {
            return clsVehiclesData.GetAllCarsModelsForTheCar(CarTypeID);
        }

        public static DataTable GetAllColorOptionsInTheSystem()
        {
            return clsVehiclesData.GetAllColorIntSystem();
        }

        public static DataTable GetAllColorOptionsForTheVehicle(int CarTypeID)
        {
            return clsVehiclesData.GetAllColorOptionsForTheCar(CarTypeID);
        }

        public static bool AddNewCarType(string VehicleTypeName)
        {
            int i= clsVehiclesData.AddNewCarType(VehicleTypeName);
            return i != -1;
        }

        public static bool AddNewCarModel(string NewModelName, string CarTypeName)
        {
            int NewID = clsVehiclesData.AddNewCarModel(NewModelName,CarTypeName);
            return NewID != -1;
        }

        public static bool ChangeRentStatus(int VehicleID, eStatusType statusType)
        {
            return clsVehiclesData.ChangeRentStatus(VehicleID, (int)statusType);
        }

        public static bool ChangeLastRentStatus(int VehicleID, DateTime NewLastRentDate)
        {
            return clsVehiclesData.ChangeLastRentStatus(VehicleID, NewLastRentDate);
        }

        public static bool ChangeMillageCounterValue(int VehicleID, decimal NewMillageCounterValue)
        {
            return ChangeMillageCounterValue(VehicleID, NewMillageCounterValue);
        }

        public static DataTable GetAllModelsForTheVehicl(string CarTypeName)
        {
            return clsVehiclesData.GetAllCarsModelsForTheCar(CarTypeName);
        }

        public static int GetCarTypeIDByName(string CarTypeName)
        {
            return clsVehiclesData.GetCarIDByName(CarTypeName);
        }

        public static int GetCarModelIDByName(string ModelName)
        {
            return clsVehiclesData.GetCarModelIDByName(ModelName);
        }

        public static string GetColorNameByID(int ColorID)
        {
            return clsVehiclesData.GetColorNameByID(ColorID);
        }

        public static int GetColorIDByHisName(string ColorName)
        {
            return clsVehiclesData.GetColorID(ColorName);
        }


        public static DataTable GetAllCarsInTheSystem()
        {
            return clsVehiclesData.GetAllCarsInTheSystem();
        }

        public static bool DeleteCarFromSystem(int CarTypeID, int CarModelID)
        {
            return clsVehiclesData.DeleteCarFromSystem(CarTypeID, CarModelID);
        }

        public static bool AddingNewCarWithModel(string ModelName,string CarName)
        {
            int ID=clsVehiclesData.AddingNewCarTypeWithModel(ModelName, CarName);
            return ID != -1;
        }

        public static bool IsVehicleAvialableForRenting(string CarTypeName,string ModelName,ref DateTime? ReturnDate)
        {
            return clsVehiclesData.IsVehcileAvalableForRenting(CarTypeName,ModelName,ref ReturnDate);
        }


        public static decimal GetPriceForRentingVehciel(int VehcileID)
        {
            return clsVehicles.GetPriceForRentingVehciel(VehcileID);
        }


    }
}
