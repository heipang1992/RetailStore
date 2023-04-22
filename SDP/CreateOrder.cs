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

    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
            totalText.Text = "$0";
        }

        private void countTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in orderView.Rows)
            {
                if (row != null)
                {
                    total += (double.Parse(row.Cells["orderPrice"].Value.ToString(), CultureInfo.InvariantCulture) * int.Parse(row.Cells["orderQty"].Value.ToString()));
                }
                
            }

            totalText.Text = "$" + total.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            productOrderView.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                foreach (var item in content.Products.ToList())
                {
                    if (!item.active || item.quantity <= 0)
                    {
                        continue;
                    }
                    if (Dashboard.account.retailID != item.retailID)
                    {
                        continue;
                    }
                    if (item.productName.ToLower().Contains(searchText.Text.ToLower()) || item.model.ToLower().Contains(searchText.Text.ToLower()))
                    {
                        productOrderView.Rows.Add(
                            new object[]
                            {
                                item.productID,
                                item.productName,
                                item.model,
                                item.price,
                                Dashboard.checkSupplierName(item.supplierID),
                                Dashboard.checkCategoryName(item.categoryID),
                                item.quantity,
                            });
                    }

                }
            }
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }

        private void productOrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            qtyText.Text = "1";
            DataGridViewRow selectedRow = productOrderView.Rows[e.RowIndex];

            IDText.Text = selectedRow.Cells["p_ID"].Value.ToString();
            nameText.Text = selectedRow.Cells["p_name"].Value.ToString();
            modelText.Text = selectedRow.Cells["p_model"].Value.ToString();
            priceText.Text = "$" + selectedRow.Cells["p_price"].Value.ToString();

        }

        private void qtyText_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDText.Text))
            {
                MessageBox.Show("Please select a item to add!");
                return;
            }
            Boolean isNotFound = true;

            if (orderView.Rows.Count > 0 )
            {
                foreach (DataGridViewRow row in orderView.Rows)
                {
                    if (IDText.Text == row.Cells["orderProductID"].Value.ToString())
                    {
                        row.Cells["orderQty"].Value = int.Parse(row.Cells["orderQty"].Value.ToString()) + int.Parse(qtyText.Text);
                        isNotFound = false;
                    }
                }
            } 
            
            if (isNotFound)
            {
                orderView.Rows.Add(
                    new object[]
                    {
                        IDText.Text,
                        nameText.Text,
                        modelText.Text,
                        double.Parse(priceText.Text.Remove(0,1), CultureInfo.InvariantCulture),
                        int.Parse(qtyText.Text)
                    });
            }

            countTotal();
        }

        private void orderView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            countTotal();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            orderView.Rows.Clear();
            countTotal();
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            
            if (orderView.Rows.Count < 1)
            {
                MessageBox.Show("Add some items before create a order;");
                return;
            }
            double total = 0;
            foreach (DataGridViewRow row in orderView.Rows)
            {
                if (row != null)
                {
                    total += (double.Parse(row.Cells["orderPrice"].Value.ToString(), CultureInfo.InvariantCulture) * int.Parse(row.Cells["orderQty"].Value.ToString()));
                }

            }

            SalesOrder so = new SalesOrder(total);

            so.orderView = orderView;

            so.Show();

        }
    }
}
