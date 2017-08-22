using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CashRegister
{
    public class checkout
    {
        public double TAX_RATE = .07; // 7%
        List<BakeryGood> list = new List<BakeryGood>();
        //ArrayList list = new ArrayList();
        public checkout() {} //create a checkout instance with an empty list

        //clears list
        public void clear() 
        {
            list.Clear();
        }

        //adds current item to list
        public void enterItem(BakeryGood item) 
        {
            list.Add(item);
        }

        //returns the number of items in the list
        public int numberOfItems() 
        {
            return list.Count;
        }

        //overrides toString()
        public override string ToString()
        {
            int index = 0;
            string receipt = "";
            while (index < list.Count)
            {
                receipt += (list[index] + "\r\n");
                index++;
            }
            return receipt;
        }

        //calculates total cost of all items
        public double totalCost() 
        {
            double tc = 0;
            int index = 0;
            while(index < list.Count) 
            {
                tc += list[index].getCost();
                index++;
            }
            return tc;
        }

        //calculates total tax
        public double totalTax() 
        {
            double tt = totalCost() * TAX_RATE;
            return tt;
        }

        //function that formats double to two decimal places
        public static decimal formatDecimal(double numToFormat)
        {
            decimal formattedNumber = Convert.ToDecimal(string.Format("{0:0.00}", numToFormat));
            return formattedNumber;
        }
    }
}
