using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class SellService
    {
        public void SellGame(User user, ICampaignService campaignService)
        {
            campaignService.Add();
            Console.WriteLine(user.Name + " has purchased the game!");
        }
    }
}
