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
    public partial class transferInventory : Form
    {
        public transferInventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transferClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transferSubmit_Click(object sender, EventArgs e)
        {
            //Transfer an part numbers invenotry value based on a choice of adding or removing inventory
            SqlConnection conn = new SqlConnection("Server=den1.mssql4.gear.host;Database=stiinventory;User Id=stiinventory;Password=Freedom294238!@");

            try
            {
                conn.Open();

                //set parameter values
                var part = transferPart.SelectedItem;
                string selectpart = part.ToString();

                var from = transFrom.SelectedItem;
                string fromSelect = from.ToString();

                var to = transto.SelectedItem;
                string toSelect = to.ToString();

                int transAmount = int.Parse(transferCount.Text);

                if (fromSelect == toSelect)
                {
                    MessageBox.Show("Error: Transfer From and Transfer To can't be the same");
                    transferCount.Clear();

                }
                else if (fromSelect == "STI" && toSelect == "SGLC")
                {
                    SqlCommand transfer = new SqlCommand(Resource.transferStitoSglc, conn);

                    transfer.Parameters.AddWithValue("@out", transAmount);
                    transfer.Parameters.AddWithValue("@in", transAmount);
                    transfer.Parameters.AddWithValue("@partNum", selectpart);

                    transfer.ExecuteNonQuery();
                    MessageBox.Show("Transfer has been Completed");
                }
                else if (fromSelect == "SGLC" && toSelect == "STI")
                {
                    SqlCommand transfer = new SqlCommand(Resource.transferSglctoSti, conn);

                    transfer.Parameters.AddWithValue("@out", transAmount);
                    transfer.Parameters.AddWithValue("@in", transAmount);
                    transfer.Parameters.AddWithValue("@partNum", selectpart);

                    transfer.ExecuteNonQuery();
                    MessageBox.Show("Transfer has been Completed");
                }
                conn.Close();
            }

            catch
            {

            }
        }
    }
}
