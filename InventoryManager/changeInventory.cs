using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManager
{
    public partial class changeInventory : Form
    {
        public changeInventory()
        {
            InitializeComponent();
        }

        private void cancelChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitChangeInventory_Click(object sender, EventArgs e)
        {
            //change an part numbers invenotry value based on a choice of adding or removing inventory
            SqlConnection conn = new SqlConnection("Server=den1.mssql4.gear.host;Database=stiinventory;User Id=stiinventory;Password=Freedom294238!@");
            try
                {

                    conn.Open();

                    //set necessary paramter values
                    var selection = changeAction.SelectedItem;
                    string select = selection.ToString();

                    var locationSelect = changeLocation.SelectedItem;
                    string loc = locationSelect.ToString();

                    int adjustqty = int.Parse(qtyBox.Text);
             
                    var changepn = pnDisplay1.SelectedItem;
                    string selectedpn = changepn.ToString();

                    
                    //Execute the appropiate query for changing an inventory quantity
                    if (select == "Add")
                    {
                        if (loc == "STI")
                        {
                            SqlCommand change = new SqlCommand(Resource.addStiInventory, conn);
                            change.Parameters.AddWithValue("@value", adjustqty);
                            change.Parameters.AddWithValue("@partNum", selectedpn);

                            change.ExecuteNonQuery();
                        MessageBox.Show("Added " + adjustqty + " of " + selectedpn + " to STI");
                        }
                        else if (loc == "SGLC")
                        {
                            SqlCommand change = new SqlCommand(Resource.addSglcInventory, conn);
                            change.Parameters.AddWithValue("@value", adjustqty);
                            change.Parameters.AddWithValue("@partNum", selectedpn);

                            change.ExecuteNonQuery();
                        MessageBox.Show("Added " + adjustqty + " of " + selectedpn + " to SGLC");
                    }

                    }
                    else if (select == "Remove")
                    {
                        if (loc == "STI")
                        {
                            SqlCommand change = new SqlCommand(Resource.removeStiInventory, conn);
                            change.Parameters.AddWithValue("@value", adjustqty);
                            change.Parameters.AddWithValue("@partNum", selectedpn);

                            change.ExecuteNonQuery();
                        MessageBox.Show("Removed " + adjustqty + " of " + selectedpn + " from STI");
                    }
                        else if (loc == "SGLC")
                        {
                            SqlCommand change = new SqlCommand(Resource.removeSglcinventory, conn);
                            change.Parameters.AddWithValue("@value", adjustqty);
                            change.Parameters.AddWithValue("@partNum", selectedpn);

                            change.ExecuteNonQuery();
                        MessageBox.Show("Removed " + adjustqty + " of " + selectedpn + " from SGLC");
                    }
                    }

                    conn.Close();
                }
                catch
                {

                }
            
        }

        private void changeInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stiinventoryDataSet.rawInventory' table. You can move, or remove it, as needed.
            this.rawInventoryTableAdapter.Fill(this.stiinventoryDataSet.rawInventory);

        }
    }
}
