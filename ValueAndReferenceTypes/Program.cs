namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 25;
            number1 = number2;
            number2 = 30;
            // sayı1 ??? ---> cevap: 25


            int[] numbers = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers = numbers2;

            numbers2[0] = 999;
            // numbers[0] = ??? cevap: 999

            // int, bool, double, decimal, float => value type
            // array, class, interface => reference type
            Console.WriteLine("Hello, World!");
        }
    }
}