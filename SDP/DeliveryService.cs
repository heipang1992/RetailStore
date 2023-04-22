using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDP;
using System.Data.Entity;

namespace SDP
{
    public partial class DeliveryService : Form
    {
        List<Customer> c = null;
        List<DeliveryNote> d = null;
        List<SalesOrderInfo> s = null;
        public DeliveryService()
        {
            InitializeComponent();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeliveryService_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_searchDate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Customer getCustomerDetail(int phone)
        {
            foreach (var item in c)
            {
                if (item.cus_phone == phone)
                {
                    return item;
                }
            }
            return null;
        }

        private DeliveryNote getDeliveryNote(int id)
        {
            foreach (var item in d)
            {
                if (item.deliveryID == id)
                {
                    return item;
                }
            }
            return null;
        }

        private SalesOrderInfo getSalesOrder(int id)
        {
            foreach (var item in s)
            {
                if (item.deliveryID == id)
                {
                    return item;
                }
            }
            return null;
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                dataGridView_Delivery.Rows.Clear();
                DateTime dt = this.dateTimePicker1.Value.Date;
                DateTime dt2 = this.dateTimePicker2.Value.Date;
                c = content.Customers.ToList();
                List<DeliveryNote> deliveryDetail = content.DeliveryNotes.Where(i => i.deliveryDate2 >= dt && i.deliveryDate2 <= dt2).ToList();
                foreach (var item in deliveryDetail)
                {

                    Customer cusInfo = getCustomerDetail(item.cus_phone.Value);

                    if (cusInfo != null)
                    {
                        dataGridView_Delivery.Rows.Add(
                        new object[]
                        {
                            item.deliveryID,
                            item.deliveryDate2,
                            item.deliverySession,
                            cusInfo.cus_name,
                            cusInfo.cus_address,
                            cusInfo.cus_phone,
                            item.staff_name,
                            item.vehicleNo,
                            item.isDelivered

                        });

                    }

                }
            }
            c = null;

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            DateTime dt = this.dateTimePicker1.Value.Date;
            DateTime dt2 = this.dateTimePicker2.Value.Date;
            MessageBox.Show("Generate a delivery list \nFrom " + dt + "To " + dt2);
            //}



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
            for (int i = 1; i < dataGridView_Delivery.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView_Delivery.Columns[i - 1].HeaderText;
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView_Delivery.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_Delivery.Columns.Count; j++)
                {
                    try
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_Delivery.Rows[i].Cells[j].Value.ToString();
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

        private void DsaveBtn_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                d = content.DeliveryNotes.ToList();
                s = content.SalesOrderInfoes.ToList();
                foreach (DataGridViewRow row in dataGridView_Delivery.Rows)
                {
                    DeliveryNote dn = getDeliveryNote(int.Parse(row.Cells["deliver_id"].Value.ToString()));
                    if (dn != null)
                    {
                        dn.staff_name = row.Cells["staffName"].Value.ToString();
                        dn.vehicleNo = row.Cells["vehicle"].Value.ToString();
                        dn.isDelivered = (bool)row.Cells["isDelivered"].Value;

                        if (dn.isDelivered)
                        {
                            SalesOrderInfo soi = getSalesOrder(dn.deliveryID);
                            if (soi != null)
                            {
                                soi.orderstatus = "Delivered";
                            }
                        }
                    }
                }
                content.SaveChanges();
                d = null;
                s = null;
            }
            MessageBox.Show("The Delivery Arrangement is saved! ");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deliveryTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
