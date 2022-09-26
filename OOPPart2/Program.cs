namespace OOPPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new()
            {
                Id = 1,
                CustomerNumber = "1123",
                Identity = "125656152",
                Name = "Ilkin",
                Surname = "Shahaliyev"
            };

            CoorporateCustomer customer2 = new()
            {
                Id = 1,
                CustomerNumber = "1234",
                CompanyName = "IlkinShahaliyev.com",
                TaxNumber = "18776219874"
            };

            //Polymorphism

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
