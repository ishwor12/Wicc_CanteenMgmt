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
    public class UserRepo : IUserRepo
    {
        private readonly Context context;
        public UserRepo()
        {
            context = new Context();
        }
        public void Add(User data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(User data)
        {
            throw new NotImplementedException();
        }
    }
}
