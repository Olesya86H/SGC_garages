using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_garages
{
    class DictItemClass
    {
        public int id_item;
        public string name_item;
        public string note;

        public void set_null()
        {
            this.id_item = 0;
            this.name_item = null;
            this.note = null;
        }
    }
}
