using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BusinessCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Business Credit is calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
