using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashRegister;
using System.IO;

namespace BagelsNStuff
{
    public partial class checkoutInterface : Form
    {
        int selectedItem = 0;
        public checkout checkout;

        //Disable all form fields and labels
        public void disableAll()
        {
            lblName.Enabled = false;
            lblPriceOz.Enabled = false;
            lblSize.Enabled = false;
            lblPriceDoz.Enabled = false;
            lblNumber.Enabled = false;
            lblTopping.Enabled = false;
            lblToppingCost.Enabled = false;
            lblSpreadCost.Enabled = false;

            txtName.Enabled = false;
            txtPriceOz.Enabled = false;
            txtSize.Enabled = false;
            txtPriceDoz.Enabled = false;
            txtNumber.Enabled = false;
            txtTopping.Enabled = false;
            txtToppingCost.Enabled = false;
            txtSpreadCost.Enabled = false;
        }

        public checkoutInterface()
        {
            InitializeComponent();
            checkout = new checkout();
        }

        private void btnBagel_Click(object sender, EventArgs e)
        {
            imageBox.Image = itemImages.Bagels;
            clearFields();
            disableAll();

            enableBagel();

            selectedItem = 0;
        }

        //function to enable Bagel text fields and labels
        private void enableBagel()
        {
            lblName.Enabled = true;
            lblPriceDoz.Enabled = true;
            lblNumber.Enabled = true;

            txtName.Enabled = true;
            txtPriceDoz.Enabled = true;
            txtNumber.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageBox.Image = itemImages.Store;
            disableAll();
            statusBar.Text = "Number of Items: 0";
        }

        private void btnSand_Click(object sender, EventArgs e)
        {
            imageBox.Image = itemImages.Sandwich;
            clearFields();
            disableAll();
            enableSandwich();

            selectedItem = 1;
        }

        //function to enable Sandwich text fields and labels
        private void enableSandwich()
        {
            lblName.Enabled = true;
            lblTopping.Enabled = true;
            lblToppingCost.Enabled = true;

            txtName.Enabled = true;
            txtTopping.Enabled = true;
            txtToppingCost.Enabled = true;
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            imageBox.Image = itemImages.Coffee;
            clearFields();
            disableAll();
            enableCoffee();

            selectedItem = 2;
        }

        //function to enable Coffee text fields and labels
        private void enableCoffee()
        {
            lblName.Enabled = true;
            lblPriceOz.Enabled = true;
            lblSize.Enabled = true;

            txtName.Enabled = true;
            txtPriceOz.Enabled = true;
            txtSize.Enabled = true;
        }

        private void btnSpread_Click(object sender, EventArgs e)
        {
            imageBox.Image = itemImages.Spread;
            clearFields();
            disableAll();
            enableSpread();

            selectedItem = 3;
        }

        //function to enable Spread text fields and labels
        private void enableSpread()
        {
            lblName.Enabled = true;
            lblSpreadCost.Enabled = true;

            txtName.Enabled = true;
            txtSpreadCost.Enabled = true;
        }

        //clears all text fields
        private void clearFields()
        {
            txtName.Text = "";
            txtPriceOz.Text = "";
            txtSize.Text = "";
            txtPriceDoz.Text = "";
            txtNumber.Text = "";
            txtTopping.Text = "";
            txtToppingCost.Text = "";
            txtSpreadCost.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            disableAll();

            switch (selectedItem)
            {
                case 0: //Bagel
                    //Validate Bagel Name input
                    if (validateItemName(txtName.Text) == true)
                    {
                        double dblResult;
                        //Validate Price per dozen input
                        if (double.TryParse(txtPriceDoz.Text, out dblResult)) {
                            int intResult;
                            //Validate quantity input
                            if (int.TryParse(txtNumber.Text, out intResult))
                            {
                                Bagel b = new Bagel(txtName.Text, Int32.Parse((txtNumber.Text)), Double.Parse((txtPriceDoz.Text)));
                                statusBar.Text = b.ToString();
                                checkout.enterItem(b);
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                enableBagel();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid item price per dozen", "Invalid Price Per Dozen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            enableBagel();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid bagel name", "Invalid Bagel Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enableBagel();
                    }
                    break;

                case 1: //Sandwich
                    //Validate Sandwich Name input
                    if (validateItemName(txtName.Text) == true)
                    {
                        //Validate Topping Name input
                        if (validateItemName(txtTopping.Text) == true)
                        {
                            double dblResult;
                            //Validate Topping Cost input
                            if (double.TryParse(txtToppingCost.Text, out dblResult))
                            {
                                Sandwich s = new Sandwich(txtName.Text, txtTopping.Text, Double.Parse((txtToppingCost.Text)));
                                statusBar.Text = s.ToString();
                                checkout.enterItem(s);
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid topping cost", "Invalid Topping Cost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                enableSandwich();
                            } 
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid topping name", "Invalid Topping Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            enableSandwich();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid topping name", "Invalid Sandwich Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enableSandwich();
                    }
                    break;

                case 2: //Coffee
                    //Validate Coffee Name input
                    if (validateItemName(txtName.Text) == true)
                    {
                        double dblResult;
                        //Validate Coffee Size input
                        if (double.TryParse(txtSize.Text, out dblResult))
                        {
                            //Validate Coffee Price Per Ounce input
                            if (double.TryParse(txtPriceOz.Text, out dblResult))
                            {
                                Coffee c = new Coffee(txtName.Text, Double.Parse((txtSize.Text)), Double.Parse((txtPriceOz.Text)));
                                statusBar.Text = c.ToString();
                                checkout.enterItem(c);
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid cost per ounce", "Invalid Cost Per Ounce", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                enableCoffee();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid coffee size", "Invalid Coffee Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            enableCoffee();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid coffee name", "Invalid Coffee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enableCoffee();
                    }
                    break;

                case 3: //Spread
                    //Validate Spread Name input
                    if (validateItemName(txtName.Text) == true)
                    {
                        double dblResult;
                        //Validate Spread Cost input
                        if (double.TryParse(txtSpreadCost.Text, out dblResult))
                        {
                            Spread p = new Spread(txtName.Text, Double.Parse((txtSpreadCost.Text)));
                            statusBar.Text = p.ToString();
                            checkout.enterItem(p);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid spread cost", "Invalid Spread Cost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            enableSpread();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid spread name", "Invalid Spread Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enableSpread();
                    }
                    break;
            }
        }

        //Function to test to see if string is empty
        public static bool validateItemName(string nameToCheck)
        {
            if(nameToCheck != ""){
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //Check to see if file exists
            try
            {
                FileStream fs = new FileStream("receipt.txt", FileMode.Open);
                fs.Close();
            }
            //Handling File Not Found Exception, allowing user to create new file if one does not exist
            catch (FileNotFoundException)
            {
                MessageBox.Show("The receipt file does not yet exist, create new?", "File Not Found", MessageBoxButtons.OK);
                printReceipt();
            }
            printReceipt();

            //Show printed receipt in new form window
            receiptForm receiptFormWindow = new receiptForm();
            receiptFormWindow.Show();
            
        }

        //Function to output receipt text to .txt file
        private void printReceipt()
        {
            StreamWriter sw = new StreamWriter("receipt.txt", false);
            sw.WriteLine("\t\t\tBagelsNStuff");
            sw.WriteLine("\t\t\t------------");
            sw.WriteLine();
            sw.WriteLine(checkout.ToString());
            sw.WriteLine();

            sw.Write("Number of Items: " + checkout.numberOfItems());
            sw.WriteLine();
            sw.WriteLine();

            sw.Write("Subtotal:\t\t\t\t\t\t");
            sw.Write("$" + checkout.formatDecimal(checkout.totalCost()));
            sw.WriteLine();

            sw.Write("Tax:\t\t\t\t\t\t\t");
            sw.Write("$" + checkout.formatDecimal(checkout.totalTax()));
            sw.WriteLine();
            sw.Write("Total Cost:\t\t\t\t\t\t");
            sw.Write("$" + checkout.formatDecimal((checkout.totalCost()) + checkout.totalTax()));

            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine("Please take our annoying 30 question survey at ");
            sw.WriteLine("www.giveusfreemarketingstats.com, for a one in seven ");
            sw.WriteLine("billion chance to win a semi-inclusive paid trip ");
            sw.WriteLine("to Nebraska!");
            sw.Close();

            statusBar.Text = "Receipt printed successfully to receipt.txt";
        }

        //Calls reset function to clear list
        private void btnReset_Click(object sender, EventArgs e)
        {
            checkout.clear();
            statusBar.Text = "Checkout items cleared";
        }
    }
}
