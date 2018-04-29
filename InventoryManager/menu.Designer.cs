namespace InventoryManager
{
    partial class menu
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Transfer Inventory");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Add/Remove Inventory");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inventory Transactions", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("View Inventory");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Inventory Views", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Transfer Inventory";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Add/Remove Inventory";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Inventory Transactions";
            treeNode4.Name = "Node4";
            treeNode4.Text = "View Inventory";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Inventory Views";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(216, 685);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 685);
            this.Controls.Add(this.treeView1);
            this.Name = "menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}