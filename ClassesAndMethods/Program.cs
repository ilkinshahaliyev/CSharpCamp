namespace ClassesAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new()
            {
                Id = 1,
                Name = "Apple",
                Price = 0.6,
                Explanation = "Good apple",
                Stock = 12
            };

            BasketManager basketManager = new();
            basketManager.Add(product);

            Mathematic.Add(5, 8);
            Mathematic.Add(27, 19);
        }
    }
}
