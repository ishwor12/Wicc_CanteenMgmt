using Canteen.Core;
using Canteen.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Repository
{
    public class FoodRepo : IfoodRepo
    {
        private readonly Context context;
        public FoodRepo()
        {
            context = new Context();
        }
        public void Add(Food data)
        {
            context.Food.Add(data);
            context.SaveChanges();
        }

        //public void Delete(Food id)
        //{
        //    var entity = context.Food.Find(id);
        //    context.Food.Remove(entity);
        //    context.SaveChanges();
        //}

        public Food GetById(int id)
        {
            return context.Food.Find(id);
        }

        public List<Food> GetList()
        {
            return context.Food.ToList();
        }

        public void Update(Food data)
        {
            var entity = GetById(data.Id);
            //entity.Name = data.Name;
            //entity.Contact = data.Contact;
            context.Entry(entity).State = EntityState.Detached;
            context.Food.Attach(data);

            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = context.Food.Find(Id);
            context.Food.Remove(entity);
            context.SaveChanges();
        }
        //    public void Delete(Food Id)
        ////    {
        //        var entity = context.Food.Find(Id);
        //        context.Food.Remove(entity);
        //        context.SaveChanges();

        //    }
        }
    }
