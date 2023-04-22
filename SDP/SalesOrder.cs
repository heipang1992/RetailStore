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
using Microsoft.Reporting.WinForms;

namespace SDP
{
    public partial class SalesOrder : Form
    {

        public DataGridView orderView = null;
        public double total = 0;
        double cast = 0;
        double change = 0;
        bool isDelivery = false;
        int tempOrderID = 0;
        List<int> avaibleWorkerMan = new List<int>();

        public SalesOrder(double total)
        {
            InitializeComponent();
            this.total = total;
            totalText.Text = "$" + total.ToString();
            billBtn.BackColor = Color.DimGray;
            billBtn.ForeColor = Color.White;
            foreach (var item in Dashboard.objet.Staffs.ToList())
            {
                if (item.active is true && item.staff_access == "I")
                {
                    avaibleWorkerMan.Add(item.staff_id);
                }
            }
        }

        private String getSession(String s)
        {
            switch (s)
            {
                case "A":
                    return "P";
                case "P":
                    return "M";
                case "M":
                    return "A";
                default:
                    return "A";
            }      
        }

        private int getWorkerMan(int pWorker)
        {
            int index = avaibleWorkerMan.FindIndex(i => i == pWorker);
            if (index+1 == avaibleWorkerMan.Count)
            {
                return avaibleWorkerMan[0];
            }
            else
            {
                return avaibleWorkerMan[index + 1];
            }
        }

        private void checkCustomer(int phone)
        {
            using (sdpEntities content = new sdpEntities())
            {
                Customer cus = content.Customers.SingleOrDefault(x => x.cus_phone == phone);
                if (cus != null)
                {
                    if (String.IsNullOrEmpty(nameText.Text) || String.IsNullOrEmpty(addressText.Text))
                    {
                        nameText.Text = cus.cus_name;
                        addressText.Text = cus.cus_address;
                    } else
                    {
                        if (cus.cus_name != nameText.Text)
                        {
                            cus.cus_name = nameText.Text;
                        }
                        if (cus.cus_address != addressText.Text)
                        {
                            cus.cus_address = addressText.Text;
                        }

                        content.SaveChanges();
                    }

                } else
                {
                    if (String.IsNullOrEmpty(nameText.Text) || String.IsNullOrEmpty(addressText.Text))
                    {
                        MessageBox.Show("Customer not found! Please enter name and address to continues");
                        return;
                    } else
                    {
                        Customer newC = new Customer
                        {
                            cus_name = nameText.Text,
                            cus_phone = int.Parse(phoneText.Text),
                            cus_address = addressText.Text
                        };

                        content.Customers.Add(newC);
                        content.SaveChanges();
                        return;
                     }
                }
            }
        }

        private void updateQty(DataGridView order)
        {
            using (sdpEntities content = new sdpEntities())
            {
                foreach (DataGridViewRow row in orderView.Rows)
                {
                    int tempID = int.Parse(row.Cells["orderProductID"].Value.ToString());
                    Product updateP = content.Products.SingleOrDefault(i => i.productID == tempID);
                    if (updateP != null)
                    {
                        updateP.quantity -= int.Parse(row.Cells["orderQty"].Value.ToString());
                    }
                }
                content.SaveChanges();
            }
                
        }
        private void billBtn_Click(object sender, EventArgs e)
        {
            deliverPanel.Visible = false;
            billBtn.BackColor = Color.DimGray;
            billBtn.ForeColor = Color.White;
            deliveryBtn.BackColor = Color.White;
            deliveryBtn.ForeColor = Color.Black;
            isDelivery = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        ReportDataSource rs = new ReportDataSource();
        private void finishBtn_Click(object sender, EventArgs e)
        {
            string deliverySessionText = null;

            if (isDelivery)
            {
                if (String.IsNullOrEmpty(nameText.Text) || String.IsNullOrEmpty(phoneText.Text) || String.IsNullOrEmpty(addressText.Text) || String.IsNullOrEmpty(deliverySText.Text))
                {
                    MessageBox.Show("Customer or Delivery Information is missing!");
                    return;
                }

                checkCustomer(Convert.ToInt32(phoneText.Text));
                if (deliverySText.Text == "Morning (9:00am – 12:00pm)")
                {
                    deliverySessionText = "A";
                }
                else if (deliverySText.Text == "Afternoon (1:00pm – 5:00pm)")
                {
                    deliverySessionText = "P";
                }
                else if (deliverySText.Text == "Evening (6:00pm – 10:00pm)")
                {
                    deliverySessionText = "N";
                }
            }

            List<Receipt> report = new List<Receipt>();

            using (sdpEntities content = new sdpEntities())
            {
                if (isDelivery)
                {
                    int countDeliverySession = 0;
                    int countDelivery = 0;
                    foreach (var order in content.DeliveryNotes.ToList())
                    {
                        if (order.deliveryDate2.Value.Date == DeliveryTimeText.Value.Date)
                        {
                            countDelivery++;
                            if (order.deliverySession == deliverySessionText)
                            {
                                countDeliverySession++;
                            }
                        }
                    }
                    if (countDelivery >= 15)
                    {
                        MessageBox.Show("The Delivery Date is full! Please enter another data.");
                        return;
                    }
                    if (countDeliverySession >= 5)
                    {
                        MessageBox.Show("The Delivery Session is full! Please enter another session.");
                        return;
                    }
                }
                    
                SalesOrderInfo lastOrder = content.SalesOrderInfoes.OrderByDescending(i => i.orderID).FirstOrDefault();
                DeliveryNote lastDelivery = content.DeliveryNotes.OrderByDescending(i => i.deliveryID).FirstOrDefault();
                InstallationNote lastInstallation = content.InstallationNotes.OrderByDescending(i => i.installationID).FirstOrDefault();
                tempOrderID = (lastOrder != null) ? lastOrder.orderID + 1 : 1;
                foreach (DataGridViewRow row in orderView.Rows)
                {
                    report.Add(new Receipt
                    {
                        ID = int.Parse(row.Cells["orderProductID"].Value.ToString()),
                        name = row.Cells["orderName"].Value.ToString(),
                        model = row.Cells["orderModel"].Value.ToString(),
                        price = double.Parse(row.Cells["orderPrice"].Value.ToString(), CultureInfo.InvariantCulture),
                        qty = int.Parse(row.Cells["orderQty"].Value.ToString())
                    });

                    SalesOrderProduct sop = new SalesOrderProduct
                    {
                        orderID = tempOrderID,
                        productID = int.Parse(row.Cells["orderProductID"].Value.ToString()),
                        quantity = int.Parse(row.Cells["orderQty"].Value.ToString())
                    };

                    content.SalesOrderProducts.Add(sop);
                }

                if (isDelivery)
                {
                    if (cast < (total * 0.2))
                    {
                        MessageBox.Show("You have to pay addless 20% of the total cost!");
                        return;
                    }

                    if (installationBox.Checked)
                    {
                        SalesOrderInfo soi = new SalesOrderInfo
                        {
                            orderID = tempOrderID,
                            customerNumber = phoneText.Text.ToString(),
                            deliveryID = (lastDelivery != null) ? lastDelivery.deliveryID + 1 : 1,
                            installationID = (lastInstallation != null) ? lastInstallation.installationID + 1 : 1,
                            staffID = Dashboard.account.staff_id,
                            price = total,
                            cast = cast,
                            orderchange = change,
                            date = DateTime.Now,
                            orderstatus = "Processing",
                            remark = remarkText.Text
                        };

                        InstallationNote itn = new InstallationNote
                        {
                            orderNo = tempOrderID,
                            staffID = getWorkerMan((lastInstallation != null) ? lastInstallation.staffID + 1 : 1),
                            installSession = getSession(deliverySessionText),
                            installDate = DeliveryTimeText.Value.Date,
                            cusPhone = phoneText.Text.ToString()
                        };
                        content.SalesOrderInfoes.Add(soi);
                        content.InstallationNotes.Add(itn);
                    } else
                    {
                        SalesOrderInfo soi = new SalesOrderInfo
                        {
                            orderID = tempOrderID,
                            customerNumber = phoneText.Text.ToString(),
                            deliveryID = (lastDelivery != null) ? lastDelivery.deliveryID + 1 : 1,
                            staffID = Dashboard.account.staff_id,
                            price = total,
                            cast = cast,
                            orderchange = change,
                            date = DateTime.Now,
                            orderstatus = "Processing",
                            remark = remarkText.Text
                        };
                        content.SalesOrderInfoes.Add(soi);
                    }
                    

                    DeliveryNote dn = new DeliveryNote
                    {
                        orderNo = tempOrderID,
                        staff_id = Dashboard.account.staff_id,
                        staff_name = null,
                        vehicleNo = null,
                        deliverySession = deliverySessionText,
                        isDelivered = false,
                        cus_name = nameText.Text,
                        cus_address = addressText.Text,
                        cus_phone = int.Parse(phoneText.Text),
                        deliveryDate2 = DeliveryTimeText.Value.Date
                    };
                    content.DeliveryNotes.Add(dn);
                    
                } else
                {
                    if (cast == 0 || change <= 0)
                    {
                        MessageBox.Show("You are not enough money!");
                        return;
                    }

                    SalesOrderInfo soi = new SalesOrderInfo
                    {
                        orderID = tempOrderID,
                        customerNumber = null,
                        deliveryID = null,
                        installationID = null,
                        staffID = Dashboard.account.staff_id,
                        price = total,
                        cast = cast,
                        orderchange = change,
                        date = DateTime.Now,
                        orderstatus = "Done",
                        remark = remarkText.Text
                    };
                    content.SalesOrderInfoes.Add(soi);
                }

                content.SaveChanges();
            }
            

            rs.Name = "DataSet1";
            rs.Value = report;

            ReportParameter p_orderId = new ReportParameter("p_orderId", tempOrderID.ToString());
            ReportParameter p_total = new ReportParameter("p_total", totalText.Text.ToString());
            ReportParameter p_cast = new ReportParameter("p_cast", "$" + castText.Text.ToString());
            ReportParameter p_change = new ReportParameter("p_change", changeText.Text.ToString());
            ReportParameter p_customer = new ReportParameter("p_customer", (isDelivery) ? nameText.Text.ToString() : "-------"); 
            ReportParameter p_phone = new ReportParameter("p_phone", (isDelivery) ? phoneText.Text.ToString() : "-------");
            ReportParameter p_address = new ReportParameter("p_address", (isDelivery) ? addressText.Text.ToString() : "-------");

            Print receiptPrint = new Print();
            receiptPrint.reportPage.LocalReport.DataSources.Clear();
            receiptPrint.reportPage.LocalReport.DataSources.Add(rs);
            receiptPrint.reportPage.LocalReport.ReportEmbeddedResource = "SDP.SalesOrderReport.rdlc";

            receiptPrint.reportPage.LocalReport.SetParameters(p_orderId);
            receiptPrint.reportPage.LocalReport.SetParameters(p_total);
            receiptPrint.reportPage.LocalReport.SetParameters(p_cast);
            receiptPrint.reportPage.LocalReport.SetParameters(p_change);
            receiptPrint.reportPage.LocalReport.SetParameters(p_customer);
            receiptPrint.reportPage.LocalReport.SetParameters(p_phone);
            receiptPrint.reportPage.LocalReport.SetParameters(p_address);

            receiptPrint.reportPage.RefreshReport();
            updateQty(orderView);
            this.Close();
            orderView.Rows.Clear();
            receiptPrint.ShowDialog();

        }

        private void deliveryBtn_Click(object sender, EventArgs e)
        {
            billBtn.BackColor = Color.White;
            billBtn.ForeColor = Color.Black;
            deliveryBtn.BackColor = Color.DimGray;
            deliveryBtn.ForeColor = Color.White;
            deliverPanel.Visible = true;
            isDelivery = true;
        }

        private void phoneText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(phoneText.Text))
                {
                    return;
                }
                checkCustomer(Convert.ToInt32(phoneText.Text));
            }
        }

        private void castText_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(castText.Text, out cast))
            {
                MessageBox.Show("Please enter number!");
                return;
            }
            cast = double.Parse(castText.Text.ToString(), CultureInfo.InvariantCulture);
            change = Math.Round(cast - total, 1);
            changeText.Text = "$" + change.ToString();
        }
    }
}
