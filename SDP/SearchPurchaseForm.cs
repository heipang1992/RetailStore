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
    public partial class SearchPurchaseForm : Form
    {
        List<PurchaseOrder> po = null;
        public SearchPurchaseForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView purchaseviewCopy = purchaseview;
            PurchaseListForm list = new PurchaseListForm(purchaseviewCopy.Rows[e.RowIndex]);
            list.Show();
        }



        private void txt_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseListForm list = new PurchaseListForm(purchaseview.Rows[0]);
            list.Show();
        }

        private PurchaseOrder getPurchaseOrder(int id)
        {
            foreach (var item in po)
            {
                if (item.purchaseID == id)
                {
                    return item;
                }
            }
            return null;
        }
        private void p_searchBtn_Click(object sender, EventArgs e)
        {
            purchaseview.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                foreach (var item in content.PurchaseOrders.ToList())
                {
                    if (item.purchaseID.ToString().Contains(txt_SearchText.Text.ToString()))
                    {
                        purchaseview.Rows.Add(
                         new object[]
                         {
                                item.purchaseID,
                                item.orderDate,
                                item.total,
                                item.approval,
                                item.orderStatus,
                                item.orderChecked,
                                item.remark,
                                item.isClaimed,
                         });
                    }
                }
                MessageBox.Show("Check all Purchase Form successfully");
            }
        }

        private void DsaveBtn_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                po = content.PurchaseOrders.ToList();
                foreach (DataGridViewRow row in purchaseview.Rows)
                {
                    PurchaseOrder pco = getPurchaseOrder(int.Parse(row.Cells["purchase_id"].Value.ToString()));
                    if (pco != null)
                    {
                        pco.approval = (bool)row.Cells["approval"].Value;
                        pco.orderStatus = (bool)row.Cells["purchaseStatus"].Value;
                        pco.orderChecked = (bool)row.Cells["checkGood"].Value;
                        pco.remark = (row.Cells["remark"].Value == null) ? " " : row.Cells["remark"].Value.ToString();
                    }
                }
                content.SaveChanges();
                MessageBox.Show("Saved");
            }
            po = null;
        }
    }
}
