namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new() { "Ibrahim", "Ahmed", "Nurlan" };
            names.Add("Ilkin");
            names.Add("Kenan");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
        }
    }
}
