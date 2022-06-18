namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "First Product";
            product1.Price = 15.65;
            product1.Description = "First Product's Desc.";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Second Product";   
            product2.Price = 18.95;
            product2.Description = "Second Product's Desc.";

            Product[] prods = new Product[] {product1, product2};

            foreach(Product product in prods)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("----------METHODS------");
            ProductManager productManager = new ProductManager();

            productManager.AddProductToTheBasket(product1);
            productManager.AddProductToTheBasket(product2);
        }
    }
}