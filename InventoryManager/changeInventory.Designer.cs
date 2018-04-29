namespace InventoryManager
{
    partial class changeInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnDisplay1 = new System.Windows.Forms.ComboBox();
            this.rawInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stiinventoryDataSet = new InventoryManager.stiinventoryDataSet();
            this.changeLocation = new System.Windows.Forms.ComboBox();
            this.changeAction = new System.Windows.Forms.ComboBox();
            this.submitChangeInventory = new System.Windows.Forms.Button();
            this.cancelChange = new System.Windows.Forms.Button();
            this.qtyBox = new System.Windows.Forms.MaskedTextBox();
            this.rawInventoryTableAdapter = new InventoryManager.stiinventoryDataSetTableAdapters.rawInventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rawInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiinventoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/Remove Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Action";
            // 
            // pnDisplay1
            // 
            this.pnDisplay1.FormattingEnabled = true;
            this.pnDisplay1.Items.AddRange(new object[] {
            "MED018S",
            "MED300",
            "MED040",
            "MED009",
            "MED396",
            "MED397"});
            this.pnDisplay1.Location = new System.Drawing.Point(142, 76);
            this.pnDisplay1.Name = "pnDisplay1";
            this.pnDisplay1.Size = new System.Drawing.Size(121, 24);
            this.pnDisplay1.TabIndex = 5;
            // 
            // rawInventoryBindingSource
            // 
            this.rawInventoryBindingSource.DataMember = "rawInventory";
            this.rawInventoryBindingSource.DataSource = this.stiinventoryDataSet;
            // 
            // stiinventoryDataSet
            // 
            this.stiinventoryDataSet.DataSetName = "stiinventoryDataSet";
            this.stiinventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // changeLocation
            // 
            this.changeLocation.FormattingEnabled = true;
            this.changeLocation.Items.AddRange(new object[] {
            "STI",
            "SGLC"});
            this.changeLocation.Location = new System.Drawing.Point(142, 119);
            this.changeLocation.Name = "changeLocation";
            this.changeLocation.Size = new System.Drawing.Size(121, 24);
            this.changeLocation.TabIndex = 6;
            // 
            // changeAction
            // 
            this.changeAction.FormattingEnabled = true;
            this.changeAction.Items.AddRange(new object[] {
            "Add",
            "Remove"});
            this.changeAction.Location = new System.Drawing.Point(142, 199);
            this.changeAction.Name = "changeAction";
            this.changeAction.Size = new System.Drawing.Size(121, 24);
            this.changeAction.TabIndex = 8;
            // 
            // submitChangeInventory
            // 
            this.submitChangeInventory.Location = new System.Drawing.Point(44, 260);
            this.submitChangeInventory.Name = "submitChangeInventory";
            this.submitChangeInventory.Size = new System.Drawing.Size(90, 36);
            this.submitChangeInventory.TabIndex = 9;
            this.submitChangeInventory.Text = "Submit";
            this.submitChangeInventory.UseVisualStyleBackColor = true;
            this.submitChangeInventory.Click += new System.EventHandler(this.submitChangeInventory_Click);
            // 
            // cancelChange
            // 
            this.cancelChange.Location = new System.Drawing.Point(173, 260);
            this.cancelChange.Name = "cancelChange";
            this.cancelChange.Size = new System.Drawing.Size(90, 36);
            this.cancelChange.TabIndex = 10;
            this.cancelChange.Text = "Cancel";
            this.cancelChange.UseVisualStyleBackColor = true;
            this.cancelChange.Click += new System.EventHandler(this.cancelChange_Click);
            // 
            // qtyBox
            // 
            this.qtyBox.Location = new System.Drawing.Point(142, 160);
            this.qtyBox.Mask = "00000";
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(121, 22);
            this.qtyBox.TabIndex = 11;
            this.qtyBox.ValidatingType = typeof(int);
            // 
            // rawInventoryTableAdapter
            // 
            this.rawInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // changeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 331);
            this.Controls.Add(this.qtyBox);
            this.Controls.Add(this.cancelChange);
            this.Controls.Add(this.submitChangeInventory);
            this.Controls.Add(this.changeAction);
            this.Controls.Add(this.changeLocation);
            this.Controls.Add(this.pnDisplay1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changeInventory";
            this.Text = "Add/Remove Inventory";
            this.Load += new System.EventHandler(this.changeInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stiinventoryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pnDisplay1;
        private System.Windows.Forms.ComboBox changeLocation;
        private System.Windows.Forms.ComboBox changeAction;
        private System.Windows.Forms.Button submitChangeInventory;
        private System.Windows.Forms.Button cancelChange;
        private System.Windows.Forms.MaskedTextBox qtyBox;
        private stiinventoryDataSet stiinventoryDataSet;
        private System.Windows.Forms.BindingSource rawInventoryBindingSource;
        private stiinventoryDataSetTableAdapters.rawInventoryTableAdapter rawInventoryTableAdapter;
    }
}