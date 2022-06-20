namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            Console.WriteLine(list.Length);
            list.Add(1);
            Console.WriteLine(list.Length);
            list.Add(2);
            Console.WriteLine(list.Length);
            list.Add(3);
            Console.WriteLine(list.Length);


        }
    }
}