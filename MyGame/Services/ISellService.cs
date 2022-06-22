using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Services
{
    internal interface ISellService
    {
        void SellGame(User user, Campaign campaign);
    }
}
