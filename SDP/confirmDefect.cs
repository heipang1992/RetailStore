using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class confirmDefect : Form
    {
        DataGridViewRow product = null;
        int orderID = 0;
        public confirmDefect(int orderID, DataGridViewRow product)
        {
            InitializeComponent();
            this.product = product;
            this.orderID = orderID;
            messageLabel.Text = "Do you want defect item (" + product.Cells["productName"].Value.ToString() + ") ?";
            qtyCount.Maximum = int.Parse(product.Cells["qty"].Value.ToString());
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                int id = int.Parse(product.Cells["productID"].Value.ToString());
                SalesOrderDefect sod = new SalesOrderDefect
                {
                    orderID = orderID,
                    productID = id,
                    quantity = (int)qtyCount.Value
                };
                content.SalesOrderDefects.Add(sod);
                content.SaveChanges();
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
