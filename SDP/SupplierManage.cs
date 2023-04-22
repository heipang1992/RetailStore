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
    public partial class SupplierManage : Form
    {
        bool supplierPanelExpand;
        public SupplierManage()
        {
            InitializeComponent();
        }

        private void SupplierManage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void p_searchBtn_Click(object sender, EventArgs e)
        {
            supplierView.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                foreach (var item in content.Suppliers.ToList())
                {
                    if (item.supName.ToLower().Contains(txt_supplier.Text.ToLower()))
                    {
                        supplierView.Rows.Add(
                            new object[]
                            {
                                item.supplierID,
                                item.supName,
                                item.supPhone,
                                item.supAddress
                            });
                    }
                }
                    MessageBox.Show("Check Supplier successfully");
            }
        }

        private void supplierView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierEdit edit = new SupplierEdit(supplierView.Rows[e.RowIndex]);
            edit.Show();
        }

        private void supplierMenu_Tick(object sender, EventArgs e)
        {
            if (supplierPanelExpand)
            {
                supplierPanel.Width -= 10;
                if (supplierPanel.Width == supplierPanel.MinimumSize.Width)
                {
                    supplierPanelExpand = false;
                    supplierMenu.Stop();

                    supplierAddress_text.ResetText();
                    supplierName_text.ResetText();
                    supplierPhone_text.ResetText();
                }
            }
            else
            {
                supplierPanel.Width += 10;
                if (supplierPanel.Width == supplierPanel.MaximumSize.Width)
                {
                    supplierPanelExpand = true;
                    supplierMenu.Stop();

                }
            }
        }

        private void closeAccountMenu_Click(object sender, EventArgs e)
        {
            supplierMenu.Start();
        }

        private void supplierCreate_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                Supplier s = content.Suppliers.SingleOrDefault(i => i.supName.ToLower() == supplierName_text.Text);
                if (s != null)
                {
                    MessageBox.Show("Supplier already exists");
                    return;
                } else
                {
                    Supplier news = new Supplier
                    {
                        supName = supplierName_text.Text,
                        supPhone = supplierPhone_text.Text,
                        supAddress = supplierAddress_text.Text
                    };
                    content.Suppliers.Add(news);
                }
                content.SaveChanges();
            }
            supplierMenu.Start();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            supplierMenu.Start();
        }
    }
}
