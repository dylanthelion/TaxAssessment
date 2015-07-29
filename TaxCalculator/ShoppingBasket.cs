using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class ShoppingBasket
    {
        private List<Product> products;
        private int number;
        private double totalPrice = 0.0;
        private double totalTax = 0.0;

        public ShoppingBasket(List<Product> products, int number)
        {
            this.products = products;
            this.number = number;
        }

        public string description()
        {
            string output = "Output " + number;

            foreach (Product p in products)
            {
                output += "\n";
                output += p.description();
                totalTax += p.calculateTax();
                totalPrice += p.calculatePrice();
            }

            return addTotalsToOutput(output);
        }

        private string addTotalsToOutput(string output)
        {
            return output + "\nSales Taxes: " + totalTax.ToString("N2") + "\nTotal: " + totalPrice.ToString("N2");
        }
    }
}
