using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Model
{
    public class OrderDetails
    {
        public int Id { get; set; }

        public int FoodId { get; set; }
        public Food food { get; set; }

        [Column(TypeName="date")]  // change datetime to date
        public DateTime Expected_Delivary { get; set; }

        public string OrderType { get; set; }

        [Column(TypeName = "date")]  // change datetime to date
        public DateTime OrderedTime{ get; set; }

        public string Status { get; set; }

        
    }
}
