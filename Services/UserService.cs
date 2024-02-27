using BookApp.ADO;
using System.Linq;

namespace BookApp.Services
{
    public class UserService : BaseService
    {
        public C27_02_User_ GetUserByLogin(string login)
        {
            return this.db.C27_02_User_.Where(u => u.UserLogin == login).First();
        }
    }
}
