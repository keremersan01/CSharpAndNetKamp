using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class KidCampaignService : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Kid Campaign is added");
        }
        public void Update()
        {
            Console.WriteLine("Kid Campaign is updated!");
        }
        public void Remove()
        {
            Console.WriteLine("Kid Campaign is removed!");
        }
    }
}
