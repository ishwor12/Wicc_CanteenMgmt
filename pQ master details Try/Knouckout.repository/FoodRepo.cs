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
    public class FoodRepo : IFoodRepo
    {
        private readonly Context context;
        public FoodRepo()
        {
            context = new Context();
        }
        public void Add(Food data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Food GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Food data)
        {
            throw new NotImplementedException();
        }
    }
}
