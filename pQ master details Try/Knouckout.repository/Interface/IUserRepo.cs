using Knockout.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knouckout.repository.Interface
{
    public interface IUserRepo
    {
        void Add(User data);
        void Update(User data);
        List<User> GetList();
        User GetById(int id);
        void Delete(int Id);
    }
}
