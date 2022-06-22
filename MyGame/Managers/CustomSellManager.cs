using MyGame.Services;


namespace MyGame.Managers
{
    internal class CustomSellManager : ISellService
    {
        ICampaignService _campaignService;
        public CustomSellManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void SellGame(User user,Campaign campaign)
        {
            _campaignService.Add(campaign);
            Console.WriteLine(user.Name + "Has purchased the game!");
        }
    }
}
