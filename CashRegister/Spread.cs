using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Spread : BakeryGood
    {
        private double pricePer;
        public static int count = 0;

        //no-arg constructor
        public Spread()
        {
            count++;
        }

        //arg constructor
        public Spread(String name, double price)
        {
            this.name = name;
            this.pricePer = price;
            count++;
        }

        //overrides abstract getCost()
        public override double getCost()
        {
            double cost = (double)(pricePer);
            return cost;
        }

        //accessor
        public double getPrice()
        {
            return pricePer;
        }

        //mutator
        public void setPrice(double c)
        {
            pricePer = c;
        }

        //overrides toString()
        public override string ToString()
        {
            string mess = "1 @ $" + checkout.formatDecimal(this.pricePer) + ". " + this.getName() + " Spread \t\t\t\t$" + checkout.formatDecimal(getCost());
            return mess;
        }
    }
}
