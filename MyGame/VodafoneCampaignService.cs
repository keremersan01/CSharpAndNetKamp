using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class VodafoneCampaignService : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Vodafone campaign is added");
        }

        public void Remove()
        {
            Console.WriteLine("Vodafone campaign is removed");
        }

        public void Update()
        {
            Console.WriteLine("Vodafone campaign is updated");
        }
    }
}
