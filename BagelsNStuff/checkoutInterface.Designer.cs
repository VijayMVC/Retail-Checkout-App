namespace BagelsNStuff
{
    partial class checkoutInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBagel = new System.Windows.Forms.Button();
            this.btnSand = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnSpread = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPriceOz = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPriceDoz = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPriceOz = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPriceDoz = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTopping = new System.Windows.Forms.TextBox();
            this.lblToppingCost = new System.Windows.Forms.Label();
            this.lblSpreadCost = new System.Windows.Forms.Label();
            this.txtToppingCost = new System.Windows.Forms.TextBox();
            this.txtSpreadCost = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.priceDoz = new System.Windows.Forms.ToolTip(this.components);
            this.itemName = new System.Windows.Forms.ToolTip(this.components);
            this.priceOz = new System.Windows.Forms.ToolTip(this.components);
            this.size = new System.Windows.Forms.ToolTip(this.components);
            this.quantity = new System.Windows.Forms.ToolTip(this.components);
            this.toppingName = new System.Windows.Forms.ToolTip(this.components);
            this.toppingCost = new System.Windows.Forms.ToolTip(this.components);
            this.spreadCost = new System.Windows.Forms.ToolTip(this.components);
            this.enterItem = new System.Windows.Forms.ToolTip(this.components);
            this.totalOrder = new System.Windows.Forms.ToolTip(this.components);
            this.resetOrder = new System.Windows.Forms.ToolTip(this.components);
            this.statusBarTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBagel
            // 
            this.btnBagel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagel.Location = new System.Drawing.Point(167, 90);
            this.btnBagel.Name = "btnBagel";
            this.btnBagel.Size = new System.Drawing.Size(105, 44);
            this.btnBagel.TabIndex = 0;
            this.btnBagel.Text = "Bagel";
            this.btnBagel.UseVisualStyleBackColor = true;
            this.btnBagel.Click += new System.EventHandler(this.btnBagel_Click);
            // 
            // btnSand
            // 
            this.btnSand.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSand.Location = new System.Drawing.Point(167, 140);
            this.btnSand.Name = "btnSand";
            this.btnSand.Size = new System.Drawing.Size(105, 44);
            this.btnSand.TabIndex = 1;
            this.btnSand.Text = "Sandwich";
            this.btnSand.UseVisualStyleBackColor = true;
            this.btnSand.Click += new System.EventHandler(this.btnSand_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.Location = new System.Drawing.Point(167, 190);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(105, 44);
            this.btnCoffee.TabIndex = 2;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnSpread
            // 
            this.btnSpread.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpread.Location = new System.Drawing.Point(167, 240);
            this.btnSpread.Name = "btnSpread";
            this.btnSpread.Size = new System.Drawing.Size(105, 44);
            this.btnSpread.TabIndex = 3;
            this.btnSpread.Text = "Spread";
            this.btnSpread.UseVisualStyleBackColor = true;
            this.btnSpread.Click += new System.EventHandler(this.btnSpread_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(307, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Item Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemName.SetToolTip(this.lblName, "Please enter the name of the item you are ringing up.");
            // 
            // lblPriceOz
            // 
            this.lblPriceOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOz.Location = new System.Drawing.Point(308, 112);
            this.lblPriceOz.Name = "lblPriceOz";
            this.lblPriceOz.Size = new System.Drawing.Size(160, 20);
            this.lblPriceOz.TabIndex = 5;
            this.lblPriceOz.Text = "Price / Oz";
            this.lblPriceOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceOz.SetToolTip(this.lblPriceOz, "Please enter the cost per ounce of this item.");
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(308, 138);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(160, 20);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size (# of oz)";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.size.SetToolTip(this.lblSize, "Please enter the number of ounces in this item.");
            // 
            // lblPriceDoz
            // 
            this.lblPriceDoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceDoz.Location = new System.Drawing.Point(308, 164);
            this.lblPriceDoz.Name = "lblPriceDoz";
            this.lblPriceDoz.Size = new System.Drawing.Size(160, 20);
            this.lblPriceDoz.TabIndex = 7;
            this.lblPriceDoz.Text = "Price / Doz";
            this.lblPriceDoz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceDoz.SetToolTip(this.lblPriceDoz, "Please enter the price per dozen as a number.");
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(308, 190);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(160, 20);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Quantity";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quantity.SetToolTip(this.lblNumber, "Please enter the quantity of this item that is being purchased.");
            // 
            // lblTopping
            // 
            this.lblTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(308, 216);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(160, 20);
            this.lblTopping.TabIndex = 9;
            this.lblTopping.Text = "Topping Name";
            this.lblTopping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toppingName.SetToolTip(this.lblTopping, "Please enter the name of the topping added.");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(474, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtPriceOz
            // 
            this.txtPriceOz.Location = new System.Drawing.Point(474, 112);
            this.txtPriceOz.Name = "txtPriceOz";
            this.txtPriceOz.Size = new System.Drawing.Size(213, 20);
            this.txtPriceOz.TabIndex = 11;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(474, 138);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(213, 20);
            this.txtSize.TabIndex = 12;
            // 
            // txtPriceDoz
            // 
            this.txtPriceDoz.Location = new System.Drawing.Point(474, 164);
            this.txtPriceDoz.Name = "txtPriceDoz";
            this.txtPriceDoz.Size = new System.Drawing.Size(213, 20);
            this.txtPriceDoz.TabIndex = 13;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(474, 190);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(213, 20);
            this.txtNumber.TabIndex = 14;
            // 
            // txtTopping
            // 
            this.txtTopping.Location = new System.Drawing.Point(474, 216);
            this.txtTopping.Name = "txtTopping";
            this.txtTopping.Size = new System.Drawing.Size(213, 20);
            this.txtTopping.TabIndex = 15;
            // 
            // lblToppingCost
            // 
            this.lblToppingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingCost.Location = new System.Drawing.Point(308, 242);
            this.lblToppingCost.Name = "lblToppingCost";
            this.lblToppingCost.Size = new System.Drawing.Size(160, 20);
            this.lblToppingCost.TabIndex = 16;
            this.lblToppingCost.Text = "Topping Cost";
            this.lblToppingCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toppingCost.SetToolTip(this.lblToppingCost, "Please enter the cost of the toppings being added.");
            // 
            // lblSpreadCost
            // 
            this.lblSpreadCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpreadCost.Location = new System.Drawing.Point(308, 268);
            this.lblSpreadCost.Name = "lblSpreadCost";
            this.lblSpreadCost.Size = new System.Drawing.Size(160, 20);
            this.lblSpreadCost.TabIndex = 17;
            this.lblSpreadCost.Text = "Spread Cost";
            this.lblSpreadCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spreadCost.SetToolTip(this.lblSpreadCost, "Please enter the cost of the spread that you are ringing up.");
            // 
            // txtToppingCost
            // 
            this.txtToppingCost.Location = new System.Drawing.Point(474, 242);
            this.txtToppingCost.Name = "txtToppingCost";
            this.txtToppingCost.Size = new System.Drawing.Size(213, 20);
            this.txtToppingCost.TabIndex = 18;
            // 
            // txtSpreadCost
            // 
            this.txtSpreadCost.Location = new System.Drawing.Point(474, 268);
            this.txtSpreadCost.Name = "txtSpreadCost";
            this.txtSpreadCost.Size = new System.Drawing.Size(213, 20);
            this.txtSpreadCost.TabIndex = 19;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(474, 314);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(65, 23);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.Text = "Enter";
            this.enterItem.SetToolTip(this.btnEnter, "Adds the entered item to the current order");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(548, 314);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(65, 23);
            this.btnTotal.TabIndex = 21;
            this.btnTotal.Text = "Total";
            this.totalOrder.SetToolTip(this.btnTotal, "Totals the current order and prints receipt");
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(622, 314);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.resetOrder.SetToolTip(this.btnReset, "Clears the current order and starts new");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Location = new System.Drawing.Point(18, 316);
            this.statusBar.Name = "statusBar";
            this.statusBar.ReadOnly = true;
            this.statusBar.Size = new System.Drawing.Size(408, 20);
            this.statusBar.TabIndex = 25;
            this.statusBarTip.SetToolTip(this.statusBar, "Displays system status information");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(264, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 32);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Bagels N Stuff";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(159, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 218);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(298, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 218);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 47);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(13, 81);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(140, 212);
            this.imageBox.TabIndex = 30;
            this.imageBox.TabStop = false;
            // 
            // checkoutInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtSpreadCost);
            this.Controls.Add(this.txtToppingCost);
            this.Controls.Add(this.lblSpreadCost);
            this.Controls.Add(this.lblToppingCost);
            this.Controls.Add(this.txtTopping);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtPriceDoz);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPriceOz);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPriceDoz);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPriceOz);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSpread);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnSand);
            this.Controls.Add(this.btnBagel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "checkoutInterface";
            this.Text = "Bagels N Stuff Checkout";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnBagel;
        public System.Windows.Forms.Button btnSand;
        public System.Windows.Forms.Button btnCoffee;
        public System.Windows.Forms.Button btnSpread;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblPriceOz;
        public System.Windows.Forms.Label lblSize;
        public System.Windows.Forms.Label lblPriceDoz;
        public System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.Label lblTopping;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPriceOz;
        public System.Windows.Forms.TextBox txtSize;
        public System.Windows.Forms.TextBox txtPriceDoz;
        public System.Windows.Forms.TextBox txtNumber;
        public System.Windows.Forms.TextBox txtTopping;
        public System.Windows.Forms.Label lblToppingCost;
        public System.Windows.Forms.Label lblSpreadCost;
        public System.Windows.Forms.TextBox txtToppingCost;
        public System.Windows.Forms.TextBox txtSpreadCost;
        public System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.Button btnTotal;
        public System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox statusBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.ToolTip priceDoz;
        private System.Windows.Forms.ToolTip itemName;
        private System.Windows.Forms.ToolTip priceOz;
        private System.Windows.Forms.ToolTip size;
        private System.Windows.Forms.ToolTip quantity;
        private System.Windows.Forms.ToolTip toppingName;
        private System.Windows.Forms.ToolTip toppingCost;
        private System.Windows.Forms.ToolTip spreadCost;
        private System.Windows.Forms.ToolTip enterItem;
        private System.Windows.Forms.ToolTip totalOrder;
        private System.Windows.Forms.ToolTip resetOrder;
        private System.Windows.Forms.ToolTip statusBarTip;
    }
}

