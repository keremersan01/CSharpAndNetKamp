using MyGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Managers
{
    internal class CustomUserValidationManager : IUserValidationService
    {
        public bool ValidateUser(User user)
        {
            if (user.Name.Equals("Kerem") && user.Surname.Equals("Ersan"))
                return true;
            else
                return false;
        }
    }
}
