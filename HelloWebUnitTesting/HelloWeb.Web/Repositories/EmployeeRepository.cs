using HelloWeb.Web.Db;
using HelloWeb.Web.Models;
using HelloWeb.Web.ViewModels.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Web.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee FindByUsername(string username); 
     
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CalidadAppContext context;

        public EmployeeRepository(CalidadAppContext context)
        {
            this.context = context;
        }
        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee FindByUsername(string username)
        {
            //return context.Employees
            //    .Where(o => o.Users.Any(x => x.Username == username))
            //    .FirstOrDefault();

            var user = context.Users.FirstOrDefault(o => o.Username == username);
            
            if (user != null)
                
                return context.Employees.FirstOrDefault(o => o.Id == user.EmployeeId);

            return null;
           
        }
    }
}
