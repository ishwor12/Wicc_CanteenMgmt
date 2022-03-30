using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knockout.model
{
    public class Food /*master banauna khoojeko*/
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Orders> OrderList { get; set; } /*details list taneko */
    }
}
