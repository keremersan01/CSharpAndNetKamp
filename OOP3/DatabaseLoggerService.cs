namespace OOP3
{
    internal class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("It is logged to the database!");
        }
    }
}
