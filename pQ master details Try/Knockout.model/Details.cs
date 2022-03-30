using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knockout.model
{
    public class Details /*orders*/
    {

        public int ID { get; set; }

        public String AddressName { get; set; }
        public String District { get; set; }
        public String Municipality { get; set; }

        public int MasterID { get; set; }
        public User Master { get; set; }

    }
}
