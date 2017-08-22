using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public abstract class BakeryGood
    {
        public string name;

        public string STORE_NAME = "BagelsNStuff";

        //Null constructor for BakeryGood class
        public BakeryGood()
        {
            
        }

        //Initialize BakeryGood Data
        public BakeryGood(string name)
        {
            this.name = name;
        }

        //Return name of BakeryGood
        public string getName()
        {
            return name;
        }

        public abstract double getCost();
    }
}
