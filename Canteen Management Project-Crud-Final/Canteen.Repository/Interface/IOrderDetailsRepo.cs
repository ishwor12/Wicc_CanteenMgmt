using Canteen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Repository.Interface
{
    interface IOrderDetailsRepo
    {
        void Add(OrderDetails data);
        void Update(OrderDetails data);
        List<OrderDetails> GetList();
        OrderDetails GetById(int id);
        void Delete(int Id);
    }
}
