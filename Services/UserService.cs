using BookApp.ADO;
using System.Linq;

namespace BookApp.Services
{
    public class UserService : BaseService
    {
        /// <summary>
        /// Получить одного пользователя по логину.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public C27_02_User_ GetUser(string login, string password)
        {
            return 
                this.db.C27_02_User_
                    .Where(u => u.UserLogin == login && u.UserPassword == password)
                    .First();
        }
    }
}
