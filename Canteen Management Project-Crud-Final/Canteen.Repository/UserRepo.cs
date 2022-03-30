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
    public class UserRepo : IUserRepo
    {
        private readonly Context context;
        public UserRepo()
        {
            context = new Context();
        }
        public void Add(User data)
        {
            context.User.Add(data);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = context.User.Find(Id);
                context.User.Remove(entity);
                context.SaveChanges();
        }

        public User GetById(int Id)
        {
            // return context.User.FirstOrDefault(x => x.Id == Id);
            return context.User.Find(Id);
        }

        public List<User> GetList()
        {
            //IQueryable<User> i = context.User;
            //var test = i.ToList();
            return context.User.ToList();
        }

        public void Update(User data)
        {
            var entity = GetById(data.Id);
            context.Entry(entity).State = EntityState.Detached;
            context.User.Attach(data);
            context.Entry(data).State = EntityState.Modified;

            context.SaveChanges();
        }

        public bool ValidateUser(string userName, string password)
        {
            IQueryable<User> i = context.User;
            var test = i.ToList().Where(u => u.Email == userName && u.Password == password).FirstOrDefault();
            if (test != null)
            {
                return true;
            }
            return false;

        }
    }
}

