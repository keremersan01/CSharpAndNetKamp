using MyGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Managers
{
    internal class CustomCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is added!");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Campaign is removed!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated!");
        }
    }
}
