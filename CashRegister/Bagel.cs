using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Bagel : BakeryGood
    {
        private int number;
        private double pricePer;
        public static int count = 0;

        //no-arg constructor
        public Bagel()
        {
            
            count++;
        }

        //arg constructor
        public Bagel(string name, int num, double price)
        {
            this.name = name;
            this.number = num;
            this.pricePer = price;
            count++;
        }

        //overrides abstract getCost()
        public override double getCost()
        {
            double cost = (number * pricePer) / 12;
            return cost;
        }

        //accessor
        public virtual double getPrice()
        {
            return pricePer;
        }

        //mutator
        public virtual void setPrice(double c)
        {
            pricePer = c;
        }

        //accessor
        public int getNum()
        {
            return number;
        }

        //mutator
        public void setNum(int n)
        {
            number = n;
        }

        //overrides toString()
        public override string ToString()
        {
            string mess = this.number + " @ $" + checkout.formatDecimal(this.pricePer) + "/dz. " + this.getName() + " Bagels \t\t\t\t$" + checkout.formatDecimal(getCost());
            return mess;
        }

    }
}
