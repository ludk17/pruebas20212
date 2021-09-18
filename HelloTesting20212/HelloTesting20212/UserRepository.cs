using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    //** Clase que se conecta a la base de datos **//
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Username = "liomessi10", IsEnable = true, CreatedAt = new DateTime(2021, 1,1) },
                new User { Id = 2, Username = "cronaldo7", IsEnable = true, CreatedAt = new DateTime(2021, 2,1) },
                new User { Id = 3, Username = "ronaldinho", IsEnable = false, CreatedAt = new DateTime(2021, 3,1) },
                new User { Id = 4, Username = "goku", IsEnable = true, CreatedAt = new DateTime(2021, 4,1) },
                new User { Id = 5, Username = "light", IsEnable = true, CreatedAt = new DateTime(2021, 5,1) },
                new User { Id = 6, Username = "seiya", IsEnable = false, CreatedAt = new DateTime(2021, 6,1) },
                new User { Id = 7, Username = "ketchup", IsEnable = true, CreatedAt = new DateTime(2021, 7,1) },
                new User { Id = 8, Username = "mayonesa", IsEnable = false, CreatedAt = new DateTime(2021, 8,1) },
                new User { Id = 9, Username = "helloworld", IsEnable = true, CreatedAt = new DateTime(2021, 9,1) },
                new User { Id = 10, Username = "ark", IsEnable = true, CreatedAt = new DateTime(2021, 10,1) }
            };
        }
    }
}
