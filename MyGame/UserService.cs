using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class UserService
    {
        public void Add(User user)
        {
            // check the requirements
            if(user != null)
                Console.WriteLine("User eklendi! " + user.Name);
        }
        public void Update(User user)
        {
            Console.WriteLine("User update edildi! " + user.Name);
        }
        public void Delete(User user)
        {
            Console.WriteLine("User silindi! " + user.Name);
        }
    }
}
