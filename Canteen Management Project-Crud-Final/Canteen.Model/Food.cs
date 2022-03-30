using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description{ get; set; }
        public double Price { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; }
    }
}
