namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", 
                UnitPrice = 125.50, UnitsInStock = 250 };

            //Pascal Case  // Camel Case
            ProductManager productManager = new ProductManager();

            // value type - "100" is printed
            int sayı = 100;
            productManager.BirSeyYap(sayı);
            Console.WriteLine(sayı);

            // Reference type - "Kamera" is printed
            productManager.Add(product);
            Console.WriteLine(product.ProductName);

            // return 
            int result = productManager.Sum2(3, 6);
            Console.WriteLine("Result is: " + result * 2);
            // void 
            productManager.Sum(3, 6);
            


        }
    }
}