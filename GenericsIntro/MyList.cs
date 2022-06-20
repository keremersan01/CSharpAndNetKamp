using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public int Length
        {
            get { return items.Length; }
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            // copy the previous array to the newly created one.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            // add the element that we wanna add.
            items[items.Length - 1] = item;
        }
    }
}
