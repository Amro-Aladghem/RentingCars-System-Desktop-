using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RetainCarsProject.LoginSystem
{
    public static class clsLogedInUser
    {

        public static clsUsers LoggedUser { get; set; }

        public static void SetValueToUser(clsUsers users)
        {
            LoggedUser=users;
        }


    }
}
