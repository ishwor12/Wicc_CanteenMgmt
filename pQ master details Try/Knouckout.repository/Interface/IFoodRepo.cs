using Knockout.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knouckout.repository.Interface
{
   public  interface IFoodRepo
    {
        
       
            void Add(Food data);
            void Update(Food data);
            List<Food> GetList();
            Food GetById(int Id);
            void Delete(int Id);
        
    }
}
