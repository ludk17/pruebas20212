using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using HelloWeb.Web.ViewModels.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Web.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll(bool? isDeleted = null);
        void Create(User user);
        User FindUserByCredentials(string username, string password);
        List<User> GetAllUserByQuery(string username);
        List<User> GetAllUserByQuery(UserQuery query);
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
                .Where(o => o.DeletedAt == null)
                .FirstOrDefault(o => o.Username == username && o.Password == password);
        }

        public List<User> GetAll(bool? isDeleted = null)
        {
            if(isDeleted == null)
                return context.Users.ToList();            
            if(isDeleted == true)
                return context.Users.Where(o => o.DeletedAt != null ).ToList();
            else
                return context.Users.Where(o => o.DeletedAt == null).ToList();

        }

        public List<User> GetAllUserByQuery(string username)
        {
            return context.Users
                .Where(o => o.Username.Contains(username))
                .ToList();
        }

        public List<User> GetAllUserByQuery(UserQuery query)
        {
            var queryable = context.Users.AsQueryable();
            
            if (!string.IsNullOrEmpty(query.Username))
                queryable = queryable.Where(o => o.Username.Contains(query.Username));
            if (query.CreatedAt != null)
                queryable = queryable.Where(o => o.CreateAt >= query.CreatedAt);
            if (query.IsDeleted)
                queryable = queryable.Where(o => o.DeletedAt != null);

            return queryable.ToList();
        }
    }
}
