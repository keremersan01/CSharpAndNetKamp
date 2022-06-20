namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Kerem", "Halil", "Miraç", "Salim" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names = new string[5];
            //names[4] = "İlker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);

            List<string> list = new List<string>() { "Kerem", "Halil", "Miraç", "Salim" };
            list.Add("İlker");
            foreach (string s in list)
                Console.WriteLine(s);
        }
    }
}