namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 1;
            corporateCustomer.CustomerNo = "123123123";
            corporateCustomer.CompanyName = "Test inc.";
            corporateCustomer.TaxNo = "12121212";

            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 2;
            individualCustomer.CustomerNo = "2132132132";
            individualCustomer.TCNo = "24156749390";
            individualCustomer.Name = "Kerem";
            individualCustomer.Surname = "Ersan";

            //SOLID
            Customer customer = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            
            CustomerManager customerManager = new CustomerManager();
            // we can pass customer reference points to different types of customer to the add method.
            customerManager.Add(customer);
            customerManager.Add(customer2);

        }
    }
}