using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BagelsNStuff
{
    public partial class receiptForm : Form
    {
        public receiptForm()
        {
            InitializeComponent();
        }

        private void receiptForm_Load(object sender, EventArgs e)
        {
            //Reads in receipt text from file and displays on form
            StreamReader sr = new StreamReader("receipt.txt");
            string receiptText = sr.ReadToEnd();
            txtReceipt.Text = "The folling receipt was successfully sent to the printer: \r\n\r\n" + receiptText;
            sr.Close();
            txtReceipt.Select(0, 0);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
