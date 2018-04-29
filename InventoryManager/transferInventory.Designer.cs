namespace InventoryManager
{
    partial class transferInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.transferFrom = new System.Windows.Forms.Label();
            this.transferTo = new System.Windows.Forms.Label();
            this.transferPartNumber = new System.Windows.Forms.Label();
            this.transferQty = new System.Windows.Forms.Label();
            this.transferPart = new System.Windows.Forms.ComboBox();
            this.transFrom = new System.Windows.Forms.ComboBox();
            this.transto = new System.Windows.Forms.ComboBox();
            this.transferSubmit = new System.Windows.Forms.Button();
            this.transferClear = new System.Windows.Forms.Button();
            this.transferCount = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // transferFrom
            // 
            this.transferFrom.AutoSize = true;
            this.transferFrom.Location = new System.Drawing.Point(36, 132);
            this.transferFrom.Name = "transferFrom";
            this.transferFrom.Size = new System.Drawing.Size(98, 17);
            this.transferFrom.TabIndex = 1;
            this.transferFrom.Text = "Transfer From";
            // 
            // transferTo
            // 
            this.transferTo.AutoSize = true;
            this.transferTo.Location = new System.Drawing.Point(36, 169);
            this.transferTo.Name = "transferTo";
            this.transferTo.Size = new System.Drawing.Size(83, 17);
            this.transferTo.TabIndex = 2;
            this.transferTo.Text = "Transfer To";
            // 
            // transferPartNumber
            // 
            this.transferPartNumber.AutoSize = true;
            this.transferPartNumber.Location = new System.Drawing.Point(39, 88);
            this.transferPartNumber.Name = "transferPartNumber";
            this.transferPartNumber.Size = new System.Drawing.Size(88, 17);
            this.transferPartNumber.TabIndex = 3;
            this.transferPartNumber.Text = "Part Number";
            // 
            // transferQty
            // 
            this.transferQty.AutoSize = true;
            this.transferQty.Location = new System.Drawing.Point(39, 209);
            this.transferQty.Name = "transferQty";
            this.transferQty.Size = new System.Drawing.Size(61, 17);
            this.transferQty.TabIndex = 4;
            this.transferQty.Text = "Quantity";
            // 
            // transferPart
            // 
            this.transferPart.FormattingEnabled = true;
            this.transferPart.Items.AddRange(new object[] {
            "MED018S",
            "MED040",
            "MED009",
            "MED300",
            "MED302",
            "MED396",
            "MED397"});
            this.transferPart.Location = new System.Drawing.Point(163, 88);
            this.transferPart.Name = "transferPart";
            this.transferPart.Size = new System.Drawing.Size(123, 24);
            this.transferPart.TabIndex = 5;
            // 
            // transFrom
            // 
            this.transFrom.FormattingEnabled = true;
            this.transFrom.Items.AddRange(new object[] {
            "STI",
            "SGLC"});
            this.transFrom.Location = new System.Drawing.Point(163, 132);
            this.transFrom.Name = "transFrom";
            this.transFrom.Size = new System.Drawing.Size(123, 24);
            this.transFrom.TabIndex = 6;
            // 
            // transto
            // 
            this.transto.FormattingEnabled = true;
            this.transto.Items.AddRange(new object[] {
            "STI",
            "SGLC"});
            this.transto.Location = new System.Drawing.Point(163, 169);
            this.transto.Name = "transto";
            this.transto.Size = new System.Drawing.Size(123, 24);
            this.transto.TabIndex = 7;
            // 
            // transferSubmit
            // 
            this.transferSubmit.Location = new System.Drawing.Point(56, 274);
            this.transferSubmit.Name = "transferSubmit";
            this.transferSubmit.Size = new System.Drawing.Size(96, 34);
            this.transferSubmit.TabIndex = 9;
            this.transferSubmit.Text = "Submit";
            this.transferSubmit.UseVisualStyleBackColor = true;
            this.transferSubmit.Click += new System.EventHandler(this.transferSubmit_Click);
            // 
            // transferClear
            // 
            this.transferClear.Location = new System.Drawing.Point(179, 274);
            this.transferClear.Name = "transferClear";
            this.transferClear.Size = new System.Drawing.Size(96, 34);
            this.transferClear.TabIndex = 10;
            this.transferClear.Text = "Cancel";
            this.transferClear.UseVisualStyleBackColor = true;
            this.transferClear.Click += new System.EventHandler(this.transferClear_Click);
            // 
            // transferCount
            // 
            this.transferCount.Location = new System.Drawing.Point(163, 209);
            this.transferCount.Name = "transferCount";
            this.transferCount.Size = new System.Drawing.Size(123, 22);
            this.transferCount.TabIndex = 11;
            // 
            // transferInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 356);
            this.Controls.Add(this.transferCount);
            this.Controls.Add(this.transferClear);
            this.Controls.Add(this.transferSubmit);
            this.Controls.Add(this.transto);
            this.Controls.Add(this.transFrom);
            this.Controls.Add(this.transferPart);
            this.Controls.Add(this.transferQty);
            this.Controls.Add(this.transferPartNumber);
            this.Controls.Add(this.transferTo);
            this.Controls.Add(this.transferFrom);
            this.Controls.Add(this.label1);
            this.Name = "transferInventory";
            this.Text = "Transaction - Transfer Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transferFrom;
        private System.Windows.Forms.Label transferTo;
        private System.Windows.Forms.Label transferPartNumber;
        private System.Windows.Forms.Label transferQty;
        private System.Windows.Forms.ComboBox transferPart;
        private System.Windows.Forms.ComboBox transFrom;
        private System.Windows.Forms.ComboBox transto;
        private System.Windows.Forms.Button transferSubmit;
        private System.Windows.Forms.Button transferClear;
        private System.Windows.Forms.MaskedTextBox transferCount;
    }
}