using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knockout.model
{
    public class Orders
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public DateTime OrderTime { get; set; }
        public DateTime ExpectedDelivary { get; set; }
        public String Status { get; set; }

        public int FoodId { get; set; } //foreign key link//
        public Food Food { get; set; } //details ma master taneko//

    }
}
