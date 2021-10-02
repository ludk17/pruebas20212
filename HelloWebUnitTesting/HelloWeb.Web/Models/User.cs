using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Web.Models
{
    public class User
    {
        public int Id { get; set; }        
        public string Username { get; set; }       
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UdaptedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Employee Employee { get; set; }
    }
}
