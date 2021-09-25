using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Web.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        void Create(User user);
        User FindUserByCredentials(string username, string password);
    }

    public class UserRepository: IUserRepository
    {
        private readonly CalidadAppContext context;

        public UserRepository(CalidadAppContext context)
        {
            this.context = context;
        }

        public void Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User FindUserByCredentials(string username, string password)
        {
            return context.Users
                .FirstOrDefault(o => o.Username == username && o.Password == password);
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}
