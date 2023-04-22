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
    public partial class orderViwer : Form
    {
        DataGridViewRow order = null;
        List<Product> p = null;
        List<Staff> s = null;
        List<Customer> c = null;
        int orderNo = 0;

        public orderViwer(DataGridViewRow order)
        {
            InitializeComponent();
            this.order = order;
            this.orderNo = int.Parse(order.Cells["orderID"].Value.ToString());
        }

        private Product checkProduct(int id)
        {
            foreach (var item in p)
            {
                if (item.productID == id)
                {
                    return item;
                }
            }

            return null;
        }

        private Staff checkStaff(string name)
        {
            foreach (var item in s)
            {
                if (item.staff_name == name)
                {
                    return item;
                }
            }

            return null;
        }

        private Customer checkCustomer(int phoneNum)
        {
            foreach (var item in c)
            {
                if (item.cus_phone == phoneNum)
                {
                    return item;
                }
            }

            return null;
        }

        private void orderViwer_Load(object sender, EventArgs e)
        {
            orderIDTag.Text = "#" + order.Cells["orderID"].Value.ToString();
            orderStatus.Text = order.Cells["orderStatus"].Value.ToString();
            if (orderStatus.Text == "Processing")
            {
                orderStatus.BackColor = Color.FromArgb(239, 208, 44);
                orderStatus.ForeColor = Color.FromArgb(255, 255, 192);
            }
            else if (orderStatus.Text == "Cancelled")
            {
                orderStatus.BackColor = Color.FromArgb(210, 20, 20);
                orderStatus.ForeColor = Color.FromArgb(242, 110, 110);
                cancelBtn.Visible = false;
            }
            else if (orderStatus.Text == "Delivering" || orderStatus.Text == "Delivered")
            {
                orderStatus.BackColor = Color.FromArgb(56, 29, 165);
                orderStatus.ForeColor = Color.FromArgb(147, 127, 225);
            }
            else if (orderStatus.Text == "Installing")
            {
                orderStatus.BackColor = Color.FromArgb(56, 29, 165);
                orderStatus.ForeColor = Color.FromArgb(147, 127, 225);
            }
            else
            {
                orderStatus.BackColor = Color.FromArgb(21, 157, 37);
                orderStatus.ForeColor = Color.FromArgb(135, 238, 147);
                cancelBtn.Visible = false;
            }

            using (sdpEntities content = new sdpEntities())
            {
                p = content.Products.ToList();
                s = content.Staffs.ToList();
                c = content.Customers.ToList();
                foreach (var item in content.SalesOrderProducts.ToList())
                {
                    if (order.Cells["orderID"].Value.Equals(item.orderID))
                    {
                        Product product = checkProduct(item.productID);
                        if (product != null)
                        {
                            orderProducts.Rows.Add(
                            new object[]
                            {
                                product.productID,
                                product.productName,
                                item.quantity,
                                product.price,
                                product.price * item.quantity
                            });
                        }
                        
                    }
                }

                foreach (var item in content.SalesOrderDefects.ToList())
                {
                    if (order.Cells["orderID"].Value.Equals(item.orderID))
                    {
                        Product product = checkProduct(item.productID);
                        if (product != null)
                        {
                            orderDefectProduct.Rows.Add(
                                new object[]
                                {
                                    product.productID,
                                    product.productName,
                                    item.quantity,
                                    product.price,
                                    item.isReturn
                                });
                        }
                    }
                }
            }

            Staff pic = checkStaff(order.Cells["staffName"].Value.ToString());
            picName.Text = pic.staff_name;
            picAccess.Text = pic.staff_access;

            DateTime orderDate = DateTime.Parse(order.Cells["date"].Value.ToString());
            orderCreateText.Text = orderDate.ToShortDateString();
            orderTimeText.Text = orderDate.TimeOfDay.ToString();

            orderTotal.Text = "$" + order.Cells["totalPrice"].Value.ToString();
            orderCharge.Text = "$" + order.Cells["charged"].Value.ToString();

            if (order.Cells["customerNumber"].Value != null)
            {
                Customer cus = checkCustomer(int.Parse(order.Cells["customerNumber"].Value.ToString()));
                cusNameText.Text = cus.cus_name;
                cusPhoneText.Text = cus.cus_phone.ToString();

                String[] str = cus.cus_address.Split(','); 
                addressText.Text = (str.Length > 0) ? str[0] : "-------";
                flatText.Text = (str.Length > 1) ? str[1] : "-------";
                streetText.Text = (str.Length > 2) ? str[2] : "-------";
            }

            remarkText.Text = (order.Cells["remark"].Value != null) ? order.Cells["remark"].Value.ToString() : "N/A";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                SalesOrderInfo soi = content.SalesOrderInfoes.SingleOrDefault(i => i.orderID == orderNo);
                if (soi != null)
                {
                    if (soi.orderstatus == "Processing")
                    {
                        soi.orderstatus = "Cancelled";
                        orderStatus.Text = "Cancelled";
                        orderStatus.BackColor = Color.FromName("DarkRed");
                        cancelBtn.Visible = false;
                        content.SaveChanges();
                    } else if (soi.orderstatus == "Delivering" || soi.orderstatus == "Delivered")
                    {
                        MessageBox.Show("Product has shipped! You cannot cancel this order.");
                        return;
                    } else if (soi.orderstatus == "Installing")
                    {
                        MessageBox.Show("Product is installed! You cannot cancel this order.");
                        return;
                    }
                }
            }
        }

        private void orderProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderStatus.Text == "Cancelled")
            {
                return;
            } 
            confirmDefect cd = new confirmDefect(orderNo, orderProducts.Rows[e.RowIndex]);
            cd.Show();
            
        }

        private void orderDefectProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                DataGridViewRow product = orderDefectProduct.Rows[e.RowIndex];
                int productID = int.Parse(product.Cells["productIDDefect"].Value.ToString());
                SalesOrderDefect sod = content.SalesOrderDefects.SingleOrDefault(i => i.orderID == orderNo && i.productID == productID);
                if (sod != null)
                {
                    sod.isReturn = (bool)product.Cells["is_return"].Value;
                }
                content.SaveChanges();
            }
        }
    }
}
