namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // credit managers
            ICreditManager manager = new HomeCreditManager();
            ICreditManager manager2 = new VehicleCreditManager();
            ICreditManager manager3 = new BusinessCreditManager();

            // logger services
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            ApplyManager applyManager = new ApplyManager();

            applyManager.Apply(manager, new List<ILoggerService>() { new FileLoggerService(), new DatabaseLoggerService() });
            Console.WriteLine("----------------------------------------");
            applyManager.Apply(manager2, new List<ILoggerService>() { new SmsLoggerService(), new DatabaseLoggerService() });

            List<ICreditManager> list = new List<ICreditManager>() {manager , manager2};

            //applyManager.PreInformUser(list);


        }
    }
}