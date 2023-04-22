using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SDP
{
    public partial class PurchaseListForm : Form
    {
        DataGridViewRow purchaseviewlist;

        public PurchaseListForm(DataGridViewRow view)
        {
            purchaseviewlist = view;
            InitializeComponent();
            confirmBtn.Visible = !(bool)view.Cells["isClaimed"].Value;
            txt_total.Text = "$" + view.Cells["totalPrice"].Value.ToString();
        }

        private void PurchaseListForm_Load(object sender, EventArgs e)
        {            
            txt_purchaseid.Text = "#" + purchaseviewlist.Cells["purchase_id"].Value.ToString();
            txt_date.Text = purchaseviewlist.Cells["Column2"].Value.ToString();

            listview.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {

                foreach (var item in content.PurchaseLists.ToList())
                {
                    if ((int)purchaseviewlist.Cells["purchase_id"].Value == item.purchaseID)
                    {
                        foreach (var product in content.Products.ToList())
                        {
                            if (product.productID == item.productID)
                            {
                                listview.Rows.Add(
                                     new object[]
                                     {
                                        product.productID,
                                        product.productName,
                                        product.model,
                                        product.price,
                                        item.quantity
                                     });
                            }
                        }
                        
                    }
                }
            }
        }

        private void txt_purchaseid_Click(object sender, EventArgs e)
        {
           
        }

        private void listview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                int orderID = int.Parse(purchaseviewlist.Cells["purchase_id"].Value.ToString());
                PurchaseOrder pco = content.PurchaseOrders.SingleOrDefault(i => i.purchaseID == orderID);
                if (pco != null)
                {
                    if (pco.isClaimed)
                    {
                        MessageBox.Show("This order was been claimed!");
                        confirmBtn.Visible = false;
                        return;

                    }
                    pco.isClaimed = true;
                    MessageBox.Show("Product Quantity has been updated successfully!");
                }
                else
                {
                    MessageBox.Show("Can't find the product!");
                    return;
                }

                foreach (DataGridViewRow row in listview.Rows)
                {
                    int productID = int.Parse(row.Cells["productID"].Value.ToString());
                    Product p = content.Products.SingleOrDefault(i => i.productID == productID); {
                        p.quantity = p.quantity + int.Parse(row.Cells["qty"].Value.ToString());

                    };     
                }
                content.SaveChanges();

            }
            this.Close();
        }
    }
}
