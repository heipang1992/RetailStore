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
    public partial class SupplierEdit : Form
    {
        DataGridViewRow edit = null;
        public SupplierEdit(DataGridViewRow edit)
        {
            InitializeComponent();
            this.edit = edit;
            idLabel.Text = edit.Cells["supplierID"].Value.ToString();
            supplierName.Text = edit.Cells["supplierName"].Value.ToString();
            supplierPhone.Text = edit.Cells["supplierPhone"].Value.ToString();
            supplierAddress.Text = edit.Cells["supplierAddress"].Value.ToString();

            updateMapInfo("http://google.com/maps?q=" + supplierAddress.Text);

        }
        private void updateMapInfo(String queryAddress)
        {
            mapViewer.Navigate(queryAddress.ToString());
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            if (saveEditBtn.IconChar == FontAwesome.Sharp.IconChar.Pen)
            {
                saveEditBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
                supplierName_box.Text = supplierName.Text;
                supplierPhone_box.Text = supplierPhone.Text;
                supplierAddress_box.Text = supplierAddress.Text;

                supplierName_box.Visible = true;
                supplierPhone_box.Visible = true;
                supplierAddress_box.Visible = true;
            } else
            {
                saveEditBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;

                if (String.IsNullOrEmpty(supplierAddress_box.Text) || String.IsNullOrEmpty(supplierName_box.Text) || String.IsNullOrEmpty(supplierPhone_box.Text))
                {
                    MessageBox.Show("Please fill in all the information!");
                    return;
                }
                supplierName.Text = supplierName_box.Text;
                supplierPhone.Text = supplierPhone_box.Text;
                supplierAddress.Text = supplierAddress_box.Text;

                supplierName_box.Visible = false;
                supplierPhone_box.Visible = false;
                supplierAddress_box.Visible = false;

                int id = int.Parse(idLabel.Text);
                using (sdpEntities content = new sdpEntities())
                {
                    Supplier s = content.Suppliers.SingleOrDefault(i => i.supplierID == id);
                    if (s != null)
                    {
                        s.supName = supplierName.Text;
                        s.supPhone = supplierPhone.Text;
                        s.supAddress = supplierAddress.Text;
                    }
                    updateMapInfo("http://google.com/maps?q=" + supplierAddress.Text);
                    content.SaveChanges();
                }
            }
        }
    }
}
