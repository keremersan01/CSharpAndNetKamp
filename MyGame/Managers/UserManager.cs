using MyGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Managers
{
    internal class UserManager : IUserService
    {
        IUserValidationService _userValidationService;
        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if(_userValidationService.ValidateUser(user) == true)
                Console.WriteLine("User eklendi!");
            else
                Console.WriteLine("User ekleme başarısız!");
        }

        public void Delete(User user)
        {
            Console.WriteLine("User silindi!");
        }

        public void Update(User user)
        {
            Console.WriteLine("User update edildi!");
        }
    }
}
