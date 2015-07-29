using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Product
    {

        private double taxRate;
        private double price;
        private int number;
        private string name;

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Product()
        {
            taxRate = TaxRates.SalesTax;
        }

        public Product(double price, int number, string name) : this()
        {
            this.price = price;
            this.number = number;
            this.name = name;
        }

        public Product(double price, int number, string name, bool imported = false, bool exempt = false) : this(price, number, name)
        {
            // Tax rates affected by exemption should be checked and processed before exemption

            if (exempt)
            {
                taxRate = 0.0;
            }
            
            if (imported)
            {
                taxRate += TaxRates.ImportTax;
            }
        }

        public double calculateTax()
        {
            return (taxRate * price * number).RoundedTaxRate();
        }

        public double calculatePrice()
        {
            return price * number + calculateTax();
        }

        public string description()
        {
            return number + " " + name + ": " + calculatePrice().ToString("N2"); 
        }
    }
}
