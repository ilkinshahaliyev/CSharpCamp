using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"{product.ProductName} added successfully!");
        }

        public void Update(Product product)
        {
            Console.WriteLine($"{product.ProductName} updated successfully!");
        }
    }
}
