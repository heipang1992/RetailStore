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
    public partial class Products : Form
    {
        bool productPanelExpand;
        int accountFrom = Dashboard.account.retailID;
        int index = 0;

        public Products()
        {
            InitializeComponent();
            if (Dashboard.account.staff_access == "A")
            {
                index = 0;
                foreach (var item in Dashboard.r)
                {
                    retail_search_text.Items.Insert(index++, item.location);
                }
                retail_search_text.Text = Dashboard.checkRetailStore(accountFrom);
            } else
            {
                retail_search_text.Text = Dashboard.checkRetailStore(accountFrom);
                retail_search_text.Enabled = false;
            }

            index = 0;
            foreach (var item in Dashboard.s)
            {
                txt_supplierID.Items.Insert(index, item.supName);
                index++;
            }

            index = 0;
            foreach (var item in Dashboard.c)
            {
                txt_categoryID.Items.Insert(index, item.categoryName);
                index++;
            }

            loadTable();

        }

        private void loadTable()
        {
            productView.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                foreach (var item in content.Products.ToList())
                {
                    if (accountFrom != item.retailID)
                    {
                        continue;
                    }
                    if (item.productName.ToLower().Contains(txt_search.Text.ToLower()) || item.model.ToLower().Contains(txt_search.Text.ToLower()))
                    {
                        productView.Rows.Add(
                            new object[]
                            {
                                item.productID,
                                Dashboard.checkSupplierName(item.supplierID),
                                Dashboard.checkCategoryName(item.categoryID),
                                item.productName,
                                item.model,
                                item.price,
                                item.quantity,
                                item.active
                            });
                    }

                }

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void for_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_supplierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void productview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            loadTable();
            MessageBox.Show("Check all Product successfully");
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            MenuTitle.Text = "Create A Product";
            productMenu.Start();
            productCreate.Visible = true;
            productSave.Visible = false;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void productMenu_Tick(object sender, EventArgs e)
        {
            if (productPanelExpand)
            {
                productPanel.Width -= 10;
                if (productPanel.Width == productPanel.MinimumSize.Width)
                {
                    productPanelExpand = false;
                    productMenu.Stop();

                    txt_productID.ResetText();
                    txt_supplierID.ResetText();
                    txt_categoryID.ResetText();
                    txt_productName.Clear();
                    txt_model.Clear();
                    txt_price.Clear();
                    txt_quantity.Clear();
                    txt_active.ResetText();
                }
            }
            else
            {
                productPanel.Width += 10;
                if (productPanel.Width == productPanel.MaximumSize.Width)
                {
                    productPanelExpand = true;
                    productMenu.Stop();

                }
            }
        }

        private void productCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_supplierID.Text) || String.IsNullOrEmpty(txt_active.Text) || String.IsNullOrEmpty(txt_categoryID.Text) || String.IsNullOrEmpty(txt_productName.Text) || String.IsNullOrEmpty(txt_model.Text) || String.IsNullOrEmpty(txt_price.Text) || String.IsNullOrEmpty(txt_quantity.Text))
            {
                MessageBox.Show("TextBox can't be empty");
                return;
            }

            using (sdpEntities content = new sdpEntities())
            {

                Product p = new Product
                {
                    supplierID = Dashboard.checkSupplierID(txt_supplierID.Text),
                    categoryID = Dashboard.checkCategoryID(txt_categoryID.Text),
                    productName = txt_productName.Text,
                    model = txt_model.Text,
                    price = Convert.ToDouble(txt_price.Text),
                    quantity = int.Parse(txt_quantity.Text),
                    retailID = Dashboard.checkRetailStoreID(retail_search_text.Text),
                    active = (txt_active.Text == "Yes") ? true : false
                };

                content.Products.Add(p);
                content.SaveChanges();

            }
            loadTable();
            productMenu.Start();
        }

        private void closeAccountMenu_Click(object sender, EventArgs e)
        {
            productMenu.Start();
        }

        private void productview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!productPanelExpand)
            {
                productMenu.Start();
            }
            DataGridViewRow row = productView.Rows[e.RowIndex];

            MenuTitle.Text = "Edit A Product";
            productCreate.Visible = false;
            productSave.Visible = true;
            txt_productID.Text = row.Cells["p_productId"].Value.ToString();
            txt_supplierID.Text = row.Cells["p_supplierId"].Value.ToString();
            txt_categoryID.Text = row.Cells["p_categoryId"].Value.ToString();
            txt_productName.Text = row.Cells["p_name"].Value.ToString();
            txt_model.Text = row.Cells["p_model"].Value.ToString();
            txt_price.Text = row.Cells["p_price"].Value.ToString();
            txt_quantity.Text = row.Cells["p_qty"].Value.ToString();

            if (row.Cells["p_active"].Value.ToString() == "True")
            {
                txt_active.Text = "Yes";
            }
            else
            {
                txt_active.Text = "No";
            }
        }

        private void productSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_productID.Text) || String.IsNullOrEmpty(txt_supplierID.Text) || String.IsNullOrEmpty(txt_active.Text) || String.IsNullOrEmpty(txt_categoryID.Text) || String.IsNullOrEmpty(txt_productName.Text) || String.IsNullOrEmpty(txt_model.Text) || String.IsNullOrEmpty(txt_price.Text) || String.IsNullOrEmpty(txt_quantity.Text))
            {
                MessageBox.Show("TextBox can't be empty");
                return;
            }

            using (sdpEntities content = new sdpEntities())
            {
                int pid = int.Parse(txt_productID.Text);

                Product p = content.Products.SingleOrDefault(i => i.productID == pid);
                if (p == null)
                {
                    MessageBox.Show("Error: Something is wrong!");
                }
                else
                {
                    p.supplierID = Dashboard.checkSupplierID(txt_supplierID.Text);
                    p.categoryID = Dashboard.checkCategoryID(txt_categoryID.Text);
                    p.productName = txt_productName.Text;
                    p.model = txt_model.Text;
                    p.price = Convert.ToDouble(txt_price.Text);
                    p.quantity = int.Parse(txt_quantity.Text);
                    p.active = (txt_active.Text == "Yes") ? true : false;

                    content.SaveChanges();
                }

            }
            loadTable();
            productMenu.Start();
        }

        private void retail_search_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountFrom = Dashboard.checkRetailStoreID(retail_search_text.Text.ToString());
            loadTable();
        }
    }
 }
