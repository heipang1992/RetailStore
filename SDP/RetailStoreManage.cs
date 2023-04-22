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
    public partial class RetailStoreManage : Form
    {
        bool retailStorePanelExpand;

        public RetailStoreManage()
        {
            InitializeComponent();
        }

        private void loadTable()
        {
            retailStoreView.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                foreach (var item in content.RetailStores.ToList())
                {
                    if (item.location.ToLower().Contains(txt_search.Text) || item.phone.Contains(txt_search.Text))
                    {
                        retailStoreView.Rows.Add(
                            new object[]
                            {
                                item.retailID,
                                item.location,
                                item.address,
                                item.phone
                            });
                    }

                }
            }
        }

        private void retailStoreMenu_Tick(object sender, EventArgs e)
        {
            if (retailStorePanelExpand)
            {
                retailStorePanel.Width -= 10;
                if (retailStorePanel.Width == retailStorePanel.MinimumSize.Width)
                {
                    retailStorePanelExpand = false;
                    retailStoreMenu.Stop();

                    retailIDText.ResetText();
                    loactionText.ResetText();
                    phoneText.ResetText();
                    addressText.ResetText();
                }
            }
            else
            {
                retailStorePanel.Width += 10;
                if (retailStorePanel.Width == retailStorePanel.MaximumSize.Width)
                {
                    retailStorePanelExpand = true;
                    retailStoreMenu.Stop();

                }
            }
        }

        private void closeAccountMenu_Click(object sender, EventArgs e)
        {
            retailStoreMenu.Start();
        }

        private void p_searchBtn_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (!retailStorePanelExpand)
            {
                retailStoreMenu.Start();
            }

            MenuTitle.Text = "Create A Retail Store";
            storeSave.Visible = false;
            storeCreate.Visible = true;
        }

        private void retailStoreView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = retailStoreView.Rows[e.RowIndex];
            if (!retailStorePanelExpand)
            {
                retailStoreMenu.Start();
            }
            MenuTitle.Text = "Edit A Retail Store";
            storeSave.Visible = true;
            storeCreate.Visible = false;

            retailIDText.Text = row.Cells["retailID"].Value.ToString();
            loactionText.Text = row.Cells["location"].Value.ToString();
            addressText.Text = row.Cells["address"].Value.ToString();
            phoneText.Text = row.Cells["phone"].Value.ToString();

        }

        private void storeSave_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                int retailID = int.Parse(retailIDText.Text);
                RetailStore rs = content.RetailStores.SingleOrDefault(i => i.retailID == retailID);
                if (rs != null)
                {
                    rs.location = loactionText.Text;
                    rs.phone = phoneText.Text;
                    rs.address = addressText.Text;
                }
                content.SaveChanges();
            }
            retailStoreMenu.Start();
            loadTable();
        }

        private void storeCreate_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                RetailStore rs = new RetailStore
                {
                    location = loactionText.Text,
                    phone = phoneText.Text,
                    address = addressText.Text,
                };
                content.RetailStores.Add(rs);
                content.SaveChanges();
            }
            retailStoreMenu.Start();
            loadTable();
        }
    }
}
