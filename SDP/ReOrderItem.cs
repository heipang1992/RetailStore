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
    public partial class ReOrderItem : Form
    {
        sdpEntities content = new sdpEntities();
        bool purchasePanelExpand;
        double total = 0;

        public ReOrderItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reorderview.Rows.Clear();

            foreach (var item in Dashboard.objet.Products.ToList())
            {
                reorderview.Rows.Add(
                    new object[]
                    {
                        item.productID,
                        item.productName,
                        item.model,
                        Dashboard.checkSupplierName(item.supplierID),
                        Dashboard.checkCategoryName(item.categoryID),
                        item.price,
                        item.quantity,
                        item.reorderLevel
                    });
            }
            MessageBox.Show("Check all Product successfully");
        }


        private void countTotal()
        {
            total = 0;
            foreach (DataGridViewRow row in orderView.Rows)
            {
                if (row != null)
                {
                    total += (double.Parse(row.Cells["orderPrice"].Value.ToString(), CultureInfo.InvariantCulture) * int.Parse(row.Cells["orderQty"].Value.ToString()));
                }

            }

            txt_total.Text = "$" + total.ToString();
        }

        private void reorderview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void button2_Click(object sender, EventArgs e)
        {
            reorderview.Rows.Clear();
            // foreach (var item in Dashboard.objet.Products.ToList())
            foreach (var item in content.Products.ToList())
            {
                if (item.quantity < item.reorderLevel)
                {
                    reorderview.Rows.Add(
                    new object[]  {
                            item.productID,
                            item.productName,
                            item.model,
                            Dashboard.checkSupplierName(item.supplierID),
                            Dashboard.checkCategoryName(item.categoryID),
                            item.price,
                            item.quantity,
                            item.reorderLevel,
                    });
                }
            }

            MessageBox.Show("Check under Reorder Level Item successfully");
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_productID.Text) || String.IsNullOrEmpty(txt_reorderLevel.Text))
            {
                MessageBox.Show("Please enter the Product ID for editting!");
                txt_productID.Clear();
                txt_reorderLevel.Clear();
                return;
            }
            else
            {
                Product p = content.Products.SingleOrDefault(i => i.productID.ToString() == txt_productID.Text);
                if (p == null)
                {
                    MessageBox.Show("The Product ID of " + txt_productID.Text + " does not exist!");
                }
                else
                {
                    p.reorderLevel = int.Parse(txt_reorderLevel.Text);
                    content.SaveChanges();
                    MessageBox.Show("Reorder Level has been updated successfully!");
                    txt_productID.Clear();
                    txt_reorderLevel.Clear();
                    Dashboard.objet = new sdpEntities();   //合拼個陣要留意OOP
                }

            }
        }

        private void reorderview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printExcel_Click(object sender, EventArgs e)
        {
            reorderview.Rows.Clear();
            foreach (var item in content.Products.ToList())
            {
                if (item.quantity < item.reorderLevel)
                {
                    reorderview.Rows.Add(
                    new object[]  {
                            item.productID,
                            item.productName,
                            item.model,
                            Dashboard.checkSupplierName(item.supplierID),
                            Dashboard.checkCategoryName(item.categoryID),
                            item.price,
                            item.quantity,
                            item.reorderLevel,
                    });
                }
            }

            MessageBox.Show("Generate a Re Order List");

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program  
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";

            // storing header part in Excel  
            for (int i = 1; i < reorderview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = reorderview.Columns[i - 1].HeaderText;
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < reorderview.Rows.Count; i++)
            {
                for (int j = 0; j < reorderview.Columns.Count; j++)
                {
                    try
                    {
                        worksheet.Cells[i + 2, j + 1] = reorderview.Rows[i].Cells[j].Value.ToString();
                    }
                    catch (NullReferenceException)
                    {
                        //recover from exception
                    }

                }
            }
            // save the application  
            workbook.SaveAs("C:\\Users\\Asher\\Desktop\\output.xls", Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive);

            // Exit from the application  
            //app.Quit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void purchaseMenu_Tick(object sender, EventArgs e)
        {
            if (purchasePanelExpand)
            {
                Panel.Width -= 10;
                if (Panel.Width == Panel.MinimumSize.Width)
                {
                    purchasePanelExpand = false;
                    purchaseMenu.Stop();

                    IDText.ResetText();
                    txt_productName.Text = "------";
                    txt_productModel.Text = "------";
                    txt_productPrice.Text = "------";
                    txt_qty.ResetText();

                }
            }
            else
            {
                Panel.Width += 10;
                if (Panel.Width == Panel.MaximumSize.Width)
                {
                    purchasePanelExpand = true;
                    purchaseMenu.Stop();

                }
            }
        }

        private void closeAccountMenu_Click(object sender, EventArgs e)
        {
            purchaseMenu.Start();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            orderView.Rows.Clear();
            countTotal();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDText.Text))
            {
                MessageBox.Show("Please select a item to add!");
                return;
            }
            Boolean isNotFound = true;

            if (orderView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in orderView.Rows)
                {
                    if (IDText.Text == row.Cells["orderProductID"].Value.ToString())
                    {
                        row.Cells["orderQty"].Value = int.Parse(row.Cells["orderQty"].Value.ToString()) + int.Parse(txt_qty.Text);
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
                        txt_productName.Text,
                        txt_productModel.Text,
                        double.Parse(txt_productPrice.Text.Remove(0,1), CultureInfo.InvariantCulture),
                        int.Parse(txt_qty.Text)
                    });
            }

            countTotal();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                PurchaseOrder lastPurchaseOrder = content.PurchaseOrders.OrderByDescending(i => i.purchaseID).FirstOrDefault();
                int tempPurchaseOrderID = (lastPurchaseOrder != null) ? lastPurchaseOrder.purchaseID + 1 : 1;
                foreach (DataGridViewRow row in orderView.Rows)
                {
                    PurchaseList pcl = new PurchaseList
                    {
                        purchaseID = tempPurchaseOrderID,
                        productID = int.Parse(row.Cells["orderProductID"].Value.ToString()),
                        quantity = int.Parse(row.Cells["orderQty"].Value.ToString())
                    };

                    content.PurchaseLists.Add(pcl);
                }

                PurchaseOrder po = new PurchaseOrder
                {
                    purchaseID = tempPurchaseOrderID,
                    orderDate = DateTime.Now,
                    total = total,
                    remark = ""
                };
                content.PurchaseOrders.Add(po);
                content.SaveChanges();
            }
            purchaseMenu.Start();
            orderView.Rows.Clear();
        }

        private void reorderview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (!purchasePanelExpand)
            {
                purchaseMenu.Start();
            }

            txt_qty.Text = "1";
            DataGridViewRow selectedRow = reorderview.Rows[e.RowIndex];

            IDText.Text = selectedRow.Cells["p_ID"].Value.ToString();
            txt_productName.Text = selectedRow.Cells["p_Name"].Value.ToString();
            txt_productModel.Text = selectedRow.Cells["p_model"].Value.ToString();
            txt_productPrice.Text = "$" + selectedRow.Cells["p_price"].Value.ToString();
        }
    }
}
