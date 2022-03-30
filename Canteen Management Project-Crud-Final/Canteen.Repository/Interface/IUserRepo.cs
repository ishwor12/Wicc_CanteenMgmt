using Canteen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Repository.Interface
{
    public interface IUserRepo
    {
        void Add(User data);
        void Delete(int Id);
        User GetById(int Id);
        List<User> GetList();
        bool ValidateUser(string userName, string password);
        void Update(User data);
    }
}
