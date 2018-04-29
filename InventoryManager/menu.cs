using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node1")
            {
                transferInventory trinv = new transferInventory();
                trinv.MdiParent = this.ParentForm;
                trinv.Show();
            }
            else if (e.Node.Name == "Node2")
            {
                changeInventory trinv = new changeInventory();
                trinv.MdiParent = this.ParentForm;
                trinv.Show();
            }
            else if (e.Node.Name == "Node4")
            {
                viewInventory trinv = new viewInventory();
                trinv.MdiParent = this.ParentForm;
                trinv.Show();
            }
        }
    }
}
