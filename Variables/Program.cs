namespace CSharpAndNetKamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // c# is has type-safety
            string name = "Sample Name";
            double averageSalary = 1425.25;
            int age = 22;
            bool isMale = true;

            if(name.Equals("Sample Name"))
                Console.WriteLine("Name equals Sample Name");
            else
                Console.WriteLine("It is not equivalent!");

            if(averageSalary < 1400)
                Console.WriteLine("Your salary is under minimum wage!");
            else
                Console.WriteLine("Your salary is above minimum wage!");

            if(age < 18)
                Console.WriteLine("You are not eligible to enter this night club!");
            else
                Console.WriteLine("You are permitted to enter this club!");

            if(isMale)
                Console.WriteLine("You are male");
            else
                Console.WriteLine("You are female");

            Console.WriteLine("Your name is " + name);
            Console.WriteLine($"Your name is {name}");


        }
    }
}