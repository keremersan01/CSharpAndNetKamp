using MyGame.Managers;
using MyGame.Services;

namespace MyGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(name: "Kerem", surname: "Ersaan", birthDate: "5 Aralık 1996", tcNo: "12561479836");
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Vodafone Campaign";

            IUserValidationService userValidationService = new CustomUserValidationManager();

            IUserService userService = new UserManager(userValidationService);
            userService.Add(user);
            IUserService userService2 = new UserManager(new NewValidationManager());
            userService2.Add(user);
           

            // polymorphism
            ICampaignService campaignService = new CustomCampaignManager();
            campaignService.Add(campaign);

            ISellService sellService = new CustomSellManager(campaignService);
            sellService.SellGame(user, campaign);
            

        }
    }
}