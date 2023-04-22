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
    
    public partial class Dashboard : Form
    {
        public static sdpEntities objet = new sdpEntities();
        public static List<Category> c = null;
        public static List<Supplier> s = null;
        public static List<RetailStore> r = null;
        public static Form activeForm = null;
        public static Staff account = null;
        private Form login = null;

        public Dashboard(Staff account, Form login)
        {
            InitializeComponent();
            this.login = login;
            getList(objet);
            if (account.staff_access == "A")
            {
                openChildForm(new StaticViewer());
                productBtn.Visible = true;
                accountBtn.Visible = true;
                ordersBtn.Visible = true;
                deliveryServiceBtn.Visible = true;
                reorderBtn.Visible = true;
                salesOrderViewBtn.Visible = true;
                installServiceViewBtn.Visible = true;
                supplierViewBtn.Visible = true;
                searchPurchaseViewBtn.Visible = true;
                staticViewBtn.Visible = true;
                retailStoreViewBtn.Visible = true;

            } else if (account.staff_access == "S")
            {
                openChildForm(new CreateOrder());
                ordersBtn.Visible = true;
                salesOrderViewBtn.Visible = true;

            } else if (account.staff_access == "D")
            {
                openChildForm(new DeliveryService());
                deliveryServiceBtn.Visible = true;

            } else if (account.staff_access == "M")
            {
                openChildForm(new StaticViewer());
                ordersBtn.Visible = true;
                deliveryServiceBtn.Visible = true;
                reorderBtn.Visible = true;
                productBtn.Visible = true;
                salesOrderViewBtn.Visible = true;
                staticViewBtn.Visible = true;

            } else if (account.staff_access == "I")
            {
                openChildForm(new InstallServices());
                installServiceViewBtn.Visible = true;
            }
                
        }

        public static String checkCategoryName(int id)
        {
            foreach (var item in c)
            {
                if (item.categoryID == id)
                {
                    return item.categoryName;
                }
            }
            return " ";
        }

        public static int checkCategoryID(String name)
        {
            foreach (var item in c)
            {
                if (item.categoryName == name)
                {
                    return item.categoryID;
                }
            }
            return 0;
        }

        public static String checkSupplierName(int id)
        {
            foreach (var item in s)
            {
                if (item.supplierID == id)
                {
                    return item.supName;
                }
            }
            return " ";
        }

        public static int checkSupplierID(String name)
        {
            foreach (var item in s)
            {
                if (item.supName == name)
                {
                    return item.supplierID;
                }
            }
            return 0;
        }

        public static String checkRetailStore(int id)
        {
            foreach (var item in r)
            {
                if (item.retailID == id)
                {
                    return item.location;
                }
            }

            return " ";
        }

        public static int checkRetailStoreID(String location)
        {
            foreach (var item in r)
            {
                if (item.location == location)
                {
                    return item.retailID;
                }
            }

            return 0;
        }


        private void getList(sdpEntities content)
        {
            c = content.Categories.ToList();
            s = content.Suppliers.ToList();
            r = content.RetailStores.ToList();

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Products());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Account());
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateOrder());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DeliveryService());
        }

        private void reorderBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ReOrderItem());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new SalesOrderView());
        }

        private void installServiceViewBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new InstallServices());
        }

        private void supplierViewBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new SupplierManage());
        }

        private void iconButton1_Click_4(object sender, EventArgs e)
        {
            openChildForm(new SearchPurchaseForm());
        }

        private void staticViewBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StaticViewer());
        }

        private void retailStoreViewBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new RetailStoreManage());
        }
    }
}
