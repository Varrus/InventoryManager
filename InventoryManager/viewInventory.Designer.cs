namespace InventoryManager
{
    partial class viewInventory
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.partNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyAvail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyAllo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtySTI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtySGLC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partNumber,
            this.partDesc,
            this.qtyAvail,
            this.qtyAllo,
            this.qtySTI,
            this.qtySGLC});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(240, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(989, 506);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // partNumber
            // 
            this.partNumber.Text = "Part Number";
            this.partNumber.Width = 116;
            // 
            // partDesc
            // 
            this.partDesc.Text = "Description";
            this.partDesc.Width = 199;
            // 
            // qtyAvail
            // 
            this.qtyAvail.Text = "Available";
            this.qtyAvail.Width = 104;
            // 
            // qtyAllo
            // 
            this.qtyAllo.Text = "Allocated";
            this.qtyAllo.Width = 111;
            // 
            // qtySTI
            // 
            this.qtySTI.Text = "Quantity STI";
            this.qtySTI.Width = 123;
            // 
            // qtySGLC
            // 
            this.qtySGLC.Text = "Quantity SGLC";
            this.qtySGLC.Width = 140;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Raw Inventory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Views";
            // 
            // viewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "viewInventory";
            this.Text = "Inventory View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader partNumber;
        private System.Windows.Forms.ColumnHeader partDesc;
        private System.Windows.Forms.ColumnHeader qtyAvail;
        private System.Windows.Forms.ColumnHeader qtyAllo;
        private System.Windows.Forms.ColumnHeader qtySTI;
        private System.Windows.Forms.ColumnHeader qtySGLC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}