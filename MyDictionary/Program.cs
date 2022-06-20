namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(1, "Kerem");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(2, "Mehmet");
            Console.WriteLine(myDictionary.Count);

            myDictionary.PrintKeys();
            myDictionary.PrintValues();
            myDictionary.PrintAll();
        }

        class MyDictionary<TKey,TValue>
        {
            public TKey[] KeyArray;
            public TValue[] ValueArray;

            public MyDictionary()
            {
                KeyArray = new TKey[0];
                ValueArray = new TValue[0];
            }

            public int Count
            {
                get { return KeyArray.Length; }
            }

            public void PrintAll()
            {
                for(int i = 0; i < KeyArray.Length; i++)
                {
                    Console.WriteLine($"Key = {KeyArray[i]} Value = {ValueArray[i]}");
                }
            }

            public void PrintKeys()
            {
                foreach (TKey key in KeyArray)
                    Console.WriteLine($"Key = {key}");
            }
            public void PrintValues()
            {
                foreach (TValue value in ValueArray)
                    Console.WriteLine($"Value = {value}");
            }

            public void Add(TKey key, TValue value)
            {
                TKey[] tempKeys = KeyArray;
                TValue[] tempValues = ValueArray;
                KeyArray = new TKey[KeyArray.Length + 1];
                ValueArray = new TValue[ValueArray.Length + 1];

                // Copying
                for (int i = 0; i < tempKeys.Length; i++)
                    KeyArray[i] = tempKeys[i];
                for(int i = 0; i < tempValues.Length; i++)
                    ValueArray[i] = tempValues[i];

                KeyArray[KeyArray.Length - 1] = key;
                ValueArray[ValueArray.Length - 1] = value;

            }
        }
    }
}