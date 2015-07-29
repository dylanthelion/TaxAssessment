using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            ShoppingBasket s1 = new ShoppingBasket(new List<Product>()
                {
                    new Product(12.49, 1, "book", exempt: true),
                    new Product(14.99, 1, "music CD"),
                    new Product(0.85, 1, "chocolate bar", exempt: true)
                },
                1);

            ShoppingBasket s2 = new ShoppingBasket(new List<Product>()
                {
                    new Product(10.00, 1, "imported box of chocolates", exempt: true, imported: true),
                    new Product(47.50, 1, "imported bottle of perfume", imported: true)
                },
                2);

            ShoppingBasket s3 = new ShoppingBasket(new List<Product>()
                {
                    new Product(27.99, 1, "imported bottle of perfume", imported: true),
                    new Product(18.99, 1, "bottle of perfume"),
                    new Product(9.75, 1, "packet of headache pills", exempt: true),
                    new Product(11.25, 1, "imported box of chocolates", exempt: true, imported: true)
                },
                3);

            Console.WriteLine(s1.description() + "\n\n" + s2.description() + "\n\n" + s3.description());

            Console.Read();
        }
    }
}
