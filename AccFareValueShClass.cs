using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_garages
{
    public static class AccFareValueShClass
    {
        public static int id_account;
        public static string name_account;
        public static string note;
        public static int id_type_account;

        public static void set_null()
        {
            id_account = 0;
            name_account = null;
            note = null;
            id_type_account = 0;
        }

    }
}
