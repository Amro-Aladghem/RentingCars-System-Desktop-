using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public static class clsGlobal
    {

        public static clsUsers LoggedUser { get; set; }

        public static void SetValueToUser(clsUsers users)
        {
            LoggedUser=users;
        }


        public static decimal DriverFees { get; set; } = clsDrivers.GetDriverFees();

        public static int NumberOfNotificationList =clsRenting.GetNumberOfRentingThatMustBeEndToday();

    }
}
