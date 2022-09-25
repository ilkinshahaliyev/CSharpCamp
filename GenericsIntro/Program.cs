namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);

            Console.WriteLine(myList.Count);

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}