namespace BagelsNStuff
{
    partial class receiptForm
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
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReceipt
            // 
            this.txtReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReceipt.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceipt.Location = new System.Drawing.Point(9, 10);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.Size = new System.Drawing.Size(540, 515);
            this.txtReceipt.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(237, 542);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // receiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 586);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtReceipt);
            this.Name = "receiptForm";
            this.Text = "Receipt Printed Successfully";
            this.Load += new System.EventHandler(this.receiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Button btnDone;
    }
}