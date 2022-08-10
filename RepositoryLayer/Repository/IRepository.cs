using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WttCore.Models;

namespace RepositoryLayer.Repository
{
    public interface IRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Insert(User User);
    }
}
