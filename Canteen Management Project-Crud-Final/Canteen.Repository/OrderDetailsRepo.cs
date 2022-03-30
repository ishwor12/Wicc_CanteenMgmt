using Canteen.Core;
using Canteen.Model;
using Canteen.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Repository
{
    public class OrderDetailsRepo : IOrderDetailsRepo
    {
        private readonly Context context;
        public OrderDetailsRepo()
        {
            context = new Context();
        }
        public void Add(OrderDetails data)
        {
            context.OrderDetails.Add(data);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = context.OrderDetails.Find(Id);
            context.OrderDetails.Remove(entity);
            context.SaveChanges();
        }

        public OrderDetails GetById(int id)
        {
            return context.OrderDetails.Find(id);
        }

        public List<OrderDetails> GetList()
        {
            return context.OrderDetails.ToList();
        }

        public void Update(OrderDetails data)
        {
            var entity = GetById(data.Id);
            context.Entry(entity).State = EntityState.Detached;
            context.OrderDetails.Attach(data);

            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();
        }
       
    }
    
    }
