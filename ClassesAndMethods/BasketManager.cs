using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"Congratulations! {product.Name} added to basket successfully!");
        }
    }
}
