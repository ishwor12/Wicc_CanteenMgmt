using Knockout.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knouckout.repository.Interface
{
    public interface IOrderRepo
    {
        void Add(Orders data);
        void Update(Orders data);
        List<Orders> GetList();
        Orders GetById(int id);
        void Delete(int Id);
    }
}
