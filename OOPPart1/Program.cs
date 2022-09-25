namespace OOPPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new()
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "PC",
                UnitPrice = 2000,
                UnitsInStock = 17
            };

            Product product2 = new()
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "Notebook",
                UnitPrice = 1500,
                UnitsInStock = 12
            };

            ProductManager productManager = new();
            productManager.Add(product1);
            productManager.Add(product2);
        }
    }
}
