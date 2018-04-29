using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class viewInventory : Form
    {
        public viewInventory()
        {
            InitializeComponent();
        }

        //On Button click to view inventory, this command will display all of the available 
        //raw inventory that is in the system and display it by part number
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection("Server=den1.mssql4.gear.host;Database=stiinventory;User Id=stiinventory;Password=Freedom294238!@");
            SqlCommand command = new SqlCommand(Resource.viewRawInventoryQuery, conn);
            

            using (conn)
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["partNumber"].ToString());
                    item.SubItems.Add(reader["partDescription"].ToString());
                    item.SubItems.Add(reader["qtyTotalAvailable"].ToString());
                    item.SubItems.Add(reader["qtyAllocated"].ToString());
                    item.SubItems.Add(reader["qtySti"].ToString());
                    item.SubItems.Add(reader["qtySglc"].ToString());

                    listView1.Items.Add(item);
                }

                conn.Close();
            }
        }
    }
}
