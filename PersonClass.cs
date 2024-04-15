using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_garages
{
    class PersonClass
    {
        public int id_person;
        public string FIO;
        public string phone_number;
        public string address;
        public string note;
        public int is_owner;
        public int is_payer;
        public int is_user;

        public void set_null()
        {
            this.id_person = 0;
            this.FIO = null;
            this.phone_number = null;
            this.address = null;
            this.note = null;
            this.is_owner = 0;
            this.is_payer = 0;
            this.is_user = 0;
        }
    }
}
