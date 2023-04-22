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
    public partial class SalesOrderView : Form
    {
        public SalesOrderView()
        {
            InitializeComponent();
        }

        private List<Staff> s = null;

        private string checkStaffName(int id)
        {
            foreach (var staff in s)
            {
                if (staff.staff_id == id)
                {
                    return staff.staff_name;
                }
            }
            return " ";
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            salesView.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                s = content.Staffs.ToList();
                foreach (var item in content.SalesOrderInfoes.ToList())
                {
                    if (String.IsNullOrEmpty(searchText.Text))
                    {
                        salesView.Rows.Add(
                        new object[]
                        {
                            item.orderID,
                            item.customerNumber,
                            checkStaffName(item.staffID),
                            item.price,
                            item.cast,
                            item.date,
                            item.orderstatus,
                            item.remark
                        });
                    } else
                    {
                        if (item.orderID.ToString().Contains(searchText.Text) || ((item.customerNumber != null) ? item.customerNumber.ToString() : " ").Contains(searchText.Text)) 
                            {
                            salesView.Rows.Add(
                                new object[]
                                {
                                    item.orderID,
                                    item.customerNumber,
                                    checkStaffName(item.staffID),
                                    item.price,
                                    item.date,
                                    item.orderstatus,
                                    item.remark
                                });
                        }
                    }
                    
                }
                
            }
        }

        private void salesView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            orderViwer order = new orderViwer(salesView.Rows[e.RowIndex]);
            order.Show();
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
            }
        }
    }
}
