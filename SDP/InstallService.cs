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
    public partial class InstallServices : Form
    {
        List<Customer> c = null;
        List<Staff> s = null;
        List<InstallationNote> i = null;
        List<SalesOrderInfo> soi = null;

        public InstallServices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private String getStaffName(int id)
        {
            foreach (var item in s)
            {
                if (item.staff_id == id)
                {
                    return item.staff_name;
                }
            }
            return " ";

        }

        private InstallationNote getInstallationNote(int id)
        {
            foreach (var item in i)
            {
                if (item.installationID == id)
                {
                    return item;
                }
            }
            return null;
        }

        private SalesOrderInfo getSalesOrder(int id)
        {
            foreach (var item in soi)
            {
                if (item.orderID == id)
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
                dataGridView_Installation.Rows.Clear();
                c = content.Customers.ToList();
                s = content.Staffs.ToList();
                DateTime dt = this.dateTimePicker1.Value.Date;
                DateTime dt2 = this.dateTimePicker2.Value.Date;
                var installDetail = content.InstallationNotes.Where(i => i.installDate >= dt && i.installDate <= dt2).ToList();
                foreach (var item in installDetail)
                {

                    Customer cusInfo = getCustomerDetail(int.Parse(item.cusPhone));

                    if (cusInfo != null)
                    {
                        dataGridView_Installation.Rows.Add(
                        new object[]
                        {
                            item.installationID,
                            item.installDate,
                            item.installSession,
                            cusInfo.cus_name,
                            cusInfo.cus_address,
                            cusInfo.cus_phone,
                            getStaffName(item.staffID),
                            item.isInstalled

                        });

                    }

                }
                c = null;
                s = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void printExcel_Click(object sender, EventArgs e)
        {
            DateTime dt = this.dateTimePicker1.Value.Date;
            DateTime dt2 = this.dateTimePicker2.Value.Date;
            MessageBox.Show("Generate an installation list \nFrom " + dt + "To " + dt2);
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
            for (int i = 1; i < dataGridView_Installation.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView_Installation.Columns[i - 1].HeaderText;
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView_Installation.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_Installation.Columns.Count; j++)
                {
                    try
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView_Installation.Rows[i].Cells[j].Value.ToString();
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
                i = content.InstallationNotes.ToList();
                soi = content.SalesOrderInfoes.ToList();
                foreach (DataGridViewRow row in dataGridView_Installation.Rows)
                {

                    InstallationNote iNote = getInstallationNote(int.Parse(row.Cells["InstallationID"].Value.ToString()));
                    if (iNote != null)
                    {
                        iNote.isInstalled = (bool)row.Cells["isInstalled"].Value;
                        if (iNote.isInstalled.Value)
                        {
                            SalesOrderInfo sInfo = getSalesOrder(iNote.orderNo.Value);
                            if (sInfo != null)
                            {
                                sInfo.orderstatus = "Done";
                            }
                        }
                    }
                    
                }
                content.SaveChanges();
                i = null;
                soi = null;
            }
            MessageBox.Show("The Installation Arrangement is saved! ");
        }
    }
}
