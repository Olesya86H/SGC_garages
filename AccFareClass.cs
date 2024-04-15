using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_garages
{
    class AccFareClass
    {
        public int id_account;
        public decimal fare_value;
        public int id_si;
        public int id_garage_type;
        public DateTime date_on = Convert.ToDateTime("01.01.1900");
        public DateTime date_off = Convert.ToDateTime("01.01.3000");
        public int id_acc_value;

        public void set_null()
        {
            this.id_account = 0;
            this.fare_value = 0;
            this.id_si = 0;
            this.id_garage_type = 0;
            this.date_on = Convert.ToDateTime("01.01.1900");
            this.date_off = Convert.ToDateTime("01.01.3000");
            this.id_acc_value = 0;
        }
    }
}
