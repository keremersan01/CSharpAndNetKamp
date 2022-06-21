namespace MyGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(name: "Kerem", surname: "Ersan", birthDate: "5 Aralık 1996", tcNo: "12561479836");

            UserService userService = new UserService();
            userService.Add(user);
            userService.Update(user);
            userService.Delete(user);

            // polymorphism
            ICampaignService campaignService = new KidCampaignService();

            SellService sellService = new SellService();

            sellService.SellGame(user, campaignService);
            sellService.SellGame(user, new VodafoneCampaignService());

        }
    }
}