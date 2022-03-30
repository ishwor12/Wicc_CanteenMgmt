using Knockout.model;
using Knouckout.repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Knouckout.repository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly Context context;
        public OrderRepo()
        {
            context = new Context();
        }
        public void Add(Orders data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Orders data)
        {
            throw new NotImplementedException();
        }
    }
}
