using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public class UserService
    {
        public User FindById(int id)
        {
            var ur = new UserRepository();
            return ur.GetAllUsers().FirstOrDefault(o => o.Id == id);
        }

        public List<User> GetEnable()
        {
            var ur = new UserRepository();
            return ur.GetAllUsers().Where(o => o.IsEnable).ToList();
        }

        public List<User> GetCreatedSince(DateTime date)
        {
            var ur = new UserRepository();
            return ur.GetAllUsers().Where(o => o.CreatedAt >= date).ToList();
        }

    }
}
