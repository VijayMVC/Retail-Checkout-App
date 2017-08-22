using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Coffee : BakeryGood
    {
        private double size;
        private double priceOz;
        public int count = 0;

        //no-arg constructor
        public Coffee()
        {
            count++;
        }

        //arg constructor
        public Coffee(string name, double size, double price)
        {
            this.name = name;
            this.size = size;
            this.priceOz = price;
            count++;
        }

        //overrides abstract getCost()
        public override double getCost()
        {
            double cost = size * priceOz;
            return cost;
        }

        //accessor
        public double getPrice()
        {
            return priceOz;
        }

        //mutator
        public void setPrice(double c)
        {
            priceOz = c;
        }

        //accessor
        public double getSize()
        {
            return size;
        }

        //mutator
        public void setSize(int n)
        {
            size = n;
        }

        //overrides toString()
        public override string ToString()
        {
            string mess = this.size + "oz @ $" + checkout.formatDecimal(this.priceOz) + "/oz. " + this.getName() + " Coffee \t\t\t\t$" + checkout.formatDecimal(getCost());
            return mess;
        }
    }
}
