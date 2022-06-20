using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + "Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Update edildi!");
        }
        public void BirSeyYap(int sayı)
        {
            sayı = 75;
        }
        public void Sum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public int Sum2(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
