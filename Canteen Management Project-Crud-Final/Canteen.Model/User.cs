using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Model
{
    public class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public string Address { get; set; }
        public Int32 Phone_Number { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
