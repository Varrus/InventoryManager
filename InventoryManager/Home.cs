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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            menu menu = new menu();
            menu.MdiParent = this;
            menu.Show();
        }

    }
}
