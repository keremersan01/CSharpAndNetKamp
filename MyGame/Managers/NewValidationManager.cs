using MyGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Managers
{
    internal class NewValidationManager : IUserValidationService
    {
        public bool ValidateUser(User user)
        {
            return true;
        }
    }
}
