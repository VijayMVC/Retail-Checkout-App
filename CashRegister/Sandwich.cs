using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Sandwich : Bagel
    {
        private string Topping;
        private double ToppingCost;
        new public int count = 0;

        //no-arg constructor
        public Sandwich()
        {
            count++;
        }

        //arg constructor
        public Sandwich(string name, string Topping, double ToppingCost)
        {
            this.name = name;
            this.Topping = Topping;
            this.ToppingCost = ToppingCost;
            count++;
        }

        //overrides abstract getCost()
        public override double getCost()
        {
            double cost = ToppingCost + 2;
            return cost;
        }

        //accessor
        public override double getPrice()
        {
            return ToppingCost;
        }

        //mutator
        public override void setPrice(double c)
        {
            ToppingCost = c;
        }

        //overrides toString()
        public override string ToString()
        {
            string mess = "1 @ $" + checkout.formatDecimal(this.ToppingCost) + "/toppings + $2/Bagel " + this.name + " Sandwich \t$" + checkout.formatDecimal(getCost());
            return mess;
        }
    }
}
