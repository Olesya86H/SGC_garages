using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_garages
{
    class AccClass
    {
        public int id_account;
        public string name_account;
        public string note;
        public int id_type_account;

        public void set_null()
        {
            this.id_account = 0;
            this.name_account = null;
            this.note = null;
            this.id_type_account = 0;
        }
    }
}
