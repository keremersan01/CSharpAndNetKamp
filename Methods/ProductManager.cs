using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ProductManager
    {

        public void AddProductToTheBasket(Product product)
        {
            // do the logic.
            Console.WriteLine("Product is added to the basket: " + product.Name);
        }
    }
}
