using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace clsBuesnesLayer
{
    public class clsScheduling
    {
        public enum eSchedulingStatus { Active = 1, Cancled = 2, Completed = 3 };

        enum eMode { AddNew = 1, Update = 2 };
        eMode Mode;

        public int ScheduleID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime DateOfSechedule { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime StartFrom { get; set; }
        public DateTime EndAt { get; set; }
        public int Status { get; set; }
        public int? DriverID { get; set; }


        public clsScheduling()
        {

            this.ScheduleID = -1;
            this.CustomerID = -1;
            this.VehicleID = -1;
            this.DateOfSechedule = DateTime.Now;
            this.NumberOfDays = 0;
            this.StartFrom = DateTime.Now;
            this.EndAt = DateTime.Now.AddDays(1);
            this.Status = 1;
            this.DriverID = -1;

            Mode = eMode.AddNew;
        }

        public clsScheduling(int ScheduleID, int CustomerID, int VehicleID, DateTime DateOfSechedule, int NumberOfDays, DateTime StartFrom, DateTime EndAt, int Status, int? DriverID)
        {
            this.ScheduleID = ScheduleID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.DateOfSechedule = DateOfSechedule;
            this.NumberOfDays = NumberOfDays;
            this.StartFrom = StartFrom;
            this.EndAt = EndAt;
            this.Status = Status;
            this.DriverID = DriverID;

            Mode = eMode.Update;
        }

        public static clsScheduling FindSchedulingByID(int SchedulingID)
        {
            int CustomerID = -1, VehicleID = -1, NumberOfDays = -1, Status = -1; int? DriverID = -1;
            DateTime DateOfSechedule = DateTime.Now, StartFrom = DateTime.Now, EndAt = DateTime.Now;

            if (clsSchedulingData.GetFullRecordByID(SchedulingID, ref CustomerID, ref VehicleID, ref DateOfSechedule, ref NumberOfDays, ref StartFrom, ref EndAt, ref Status, ref DriverID))
            {
                return new clsScheduling(SchedulingID, CustomerID, VehicleID, DateOfSechedule, NumberOfDays, StartFrom, EndAt, Status, DriverID);
            }
            else
            {
                return null;
            }
        }

        public static clsScheduling FindSchedulingByCustomerName(string Firstname, string Lastname)
        {

            int SchedulingID = -1, CustomerID = -1, VehicleID = -1, NumberOfDays = -1, Status = -1; int? DriverID = -1;
            DateTime DateOfSechedule = DateTime.Now, StartFrom = DateTime.Now, EndAt = DateTime.Now;

            if (clsSchedulingData.GetFullRecordByCustomerName(Firstname, Lastname, ref SchedulingID, ref CustomerID, ref VehicleID, ref DateOfSechedule, ref NumberOfDays, ref StartFrom, ref EndAt, ref Status, ref DriverID))
            {
                return new clsScheduling(SchedulingID, CustomerID, VehicleID, DateOfSechedule, NumberOfDays, StartFrom, EndAt, Status, DriverID);
            }
            else
            {
                return null;
            }
        }

        public static clsScheduling FindSchedulingByCustomerNameAndVehicleID(string FirstName, string LastName, int VehicleID)
        {
            int SchedulingID = -1, CustomerID = -1, NumberOfDays = -1, Status = -1; int? DriverID = -1;
            DateTime DateOfSechedule = DateTime.Now, StartFrom = DateTime.Now, EndAt = DateTime.Now;

            if (clsSchedulingData.GetFullRecrodByCustomerNameAndVehicleID(FirstName, LastName, ref SchedulingID, ref CustomerID, VehicleID, ref DateOfSechedule, ref NumberOfDays, ref StartFrom, ref EndAt, ref Status, ref DriverID))
            {
                return new clsScheduling(SchedulingID, CustomerID, VehicleID, DateOfSechedule, NumberOfDays, StartFrom, EndAt, Status, DriverID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewScheduling()
        {
            this.VehicleID = clsSchedulingData.AddNewSchedule(this.CustomerID, this.VehicleID, this.DateOfSechedule, this.NumberOfDays, this.StartFrom, this.EndAt, this.Status, this.DriverID);
            return VehicleID != -1;
        }

        private bool _UpdateScheduling()
        {
            return clsSchedulingData.UpdateSchedule(this.ScheduleID, this.VehicleID, this.NumberOfDays, this.StartFrom, this.EndAt, this.Status, this.DriverID);
        }

        public virtual bool Save()
        {

            switch (Mode)
            {

                case eMode.AddNew:
                    {
                        if (_AddNewScheduling())
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

                        if (_UpdateScheduling())
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

        public static DataTable GetAllSchedulingInSystem()
        {
            return clsSchedulingData.GetAllRecordInSystem();
        }

        public static bool DeleteScheduling(int SchedulingID)
        {
            return clsSchedulingData.DeleteSchedule(SchedulingID);
        }

        public bool DeleteScheduling()
        {
            return clsSchedulingData.DeleteSchedule(this.ScheduleID);
        }

        public static bool ChangTheStatusOfScheduling(int SchedulingID,int NewStatus)
        {
            return clsSchedulingData.ChangeTheStatusOfSchedule(SchedulingID, NewStatus);
        }

        public static bool IsCustomerHasMoreOneScheduling(int CustomerID)
        {
            return clsSchedulingData.CheckIfCustomerHasAndActiveSchedule(CustomerID);
        }

        public static bool IsCustomerHasMoreOneScheduling(string FirstName,string LastName)
        {
            return clsSchedulingData.CheckIfCustomerHasAndActiveSchedule(FirstName, LastName);
        }





















    }
}
