using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_garages
{
    public static class GarageClass
    {
        public static int id;
        public static int id_owner;
        public static int id_type;
        public static string num;
        public static string address;
        public static string note;

        public static void setnull()
        {
            id = 0;
            id_owner = 0;
            id_type = 0;
            num = "";
            address = "";
            note = "";
         }

    }
}
