using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SDP
{
    public partial class Account : Form
    {
        bool createAccountPanelExpand;
        bool editAccountPanelExpand;
        public Account()
        {
            InitializeComponent();
            loadTable();
            accountCreate.Enabled = false;
            int index = 0;
            foreach (var item in Dashboard.r)
            {
                edit_retail_text.Items.Insert(index, item.location);
                staff_retail_text.Items.Insert(index, item.location);
                index++;
            }
        }

        private void loadTable()
        {
            AccountView.Rows.Clear();
            using (sdpEntities content = new sdpEntities())
            {
                foreach (var item in content.Staffs.ToList())
                {
                    if (item.staff_name.ToLower().Contains(searchTxt.Text.ToLower()) || item.staff_email.ToLower().Contains(searchTxt.Text.ToLower()))
                    {
                        AccountView.Rows.Add(
                            new object[]
                            {
                                item.staff_id,
                                item.staff_password,
                                item.staff_name,
                                item.staff_email,
                                item.staff_access,
                                Dashboard.checkRetailStore(item.retailID),
                                item.active
                            });
                    }

                }
            }
        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staff_name_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_pwd_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if(String.IsNullOrEmpty(staff_email_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if(String.IsNullOrEmpty(staff_role_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            } else
            {
                accountCreate.Enabled = true;
            }
        }

        private void staff_email_text_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staff_name_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_pwd_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_email_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_role_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else
            {
                accountCreate.Enabled = true;
            }
        }

        private void dataAddBtn_Click(object sender, EventArgs e)
        {
            createAccountMenu.Start();
        }

        private void search_name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            loadTable();
        }

        private void staff_pwd_text_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staff_name_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_pwd_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_email_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_role_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else
            {
                accountCreate.Enabled = true;
            }
        }

        private void staff_role_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staff_name_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_pwd_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_email_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else if (String.IsNullOrEmpty(staff_role_text.Text))
            {
                accountCreate.Enabled = false;
                return;
            }
            else
            {
                accountCreate.Enabled = true;
            }
        }

        private void search_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButton1_Click_1(sender, e);
            }
        }

        private void createAccountMenu_Tick(object sender, EventArgs e)
        {
            if(createAccountPanelExpand)
            {
                createAccountPanel.Width -= 10;
                if (createAccountPanel.Width == createAccountPanel.MinimumSize.Width)
                {
                    createAccountPanelExpand = false;
                    createAccountMenu.Stop();
                }
            }
            else
            {
                createAccountPanel.Width += 10;
                if (createAccountPanel.Width == createAccountPanel.MaximumSize.Width)
                {
                    createAccountPanelExpand = true;
                    createAccountMenu.Stop();
                }
            }
        }

        private void accountCreate_Click(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {
                Staff check = content.Staffs.SingleOrDefault(i => i.staff_name.ToLower() == staff_name_text.Text.ToLower());
                if (check != null)
                {
                    MessageBox.Show("Account already exists!");
                    return;
                }
                Staff s = new Staff
                {

                    staff_name = staff_name_text.Text,
                    staff_password = staff_pwd_text.Text,
                    staff_email = staff_email_text.Text,
                    staff_access = staff_role_text.Text.Substring(0, 1),
                    retailID = Dashboard.checkRetailStoreID(staff_retail_text.Text),
                    active = true

                };
                content.Staffs.Add(s);
                content.SaveChanges();
                MessageBox.Show("Account '" + staff_name_text.Text + "' has been created successfully!");

                createAccountMenu.Start();
                staff_name_text.Clear();
                staff_pwd_text.Clear();
                staff_email_text.Clear();
                staff_role_text.SelectedItem = null;

                loadTable();
                editAccountMenu.Start();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            createAccountMenu.Start();
        }

        private void AccountView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = AccountView.Rows[e.RowIndex];
            if (!editAccountPanelExpand)
            {
                editAccountMenu.Start();
            }
            edit_id.Text = row.Cells["staff_id"].Value.ToString();
            edit_name_text.Text = row.Cells["staff_name"].Value.ToString();
            edit_password_text.Text = row.Cells["staff_password"].Value.ToString();
            edit_email_text.Text = row.Cells["staff_email"].Value.ToString();
            edit_access_text.Text = row.Cells["staff_access"].Value.ToString();
            edit_retail_text.Text = row.Cells["retail"].Value.ToString();

            disableAccount.Text = (bool)row.Cells["active"].Value ? "Disable Account" : "Enable Account";

        }

        private void editAccountMenu_Tick(object sender, EventArgs e)
        {
            if (createAccountPanelExpand)
            {
                createAccountMenu.Start();
            }
            if (editAccountPanelExpand)
            {
                editAccountPanel.Width -= 10;
                if (editAccountPanel.Width == editAccountPanel.MinimumSize.Width)
                {
                    editAccountPanelExpand = false;
                    editAccountMenu.Stop();
                }
            }
            else
            {
                editAccountPanel.Width += 10;
                if (editAccountPanel.Width == editAccountPanel.MaximumSize.Width)
                {
                    editAccountPanelExpand = true;
                    editAccountMenu.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            editAccountMenu.Start();
        }

        private void disableAccount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edit_id.Text))
            {
                return;
            }

            using (sdpEntities content = new sdpEntities())
            {

                Staff s = content.Staffs.SingleOrDefault(i => i.staff_id == edit_id.Value);
                if (s != null)
                {
                    if (disableAccount.Text == "Disable Account")
                    {
                        s.active = false;
                    }
                    else
                    {
                        s.active = true;
                    }
                }

                content.SaveChanges();

            }
            loadTable();

            editAccountMenu.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edit_id.Text) || String.IsNullOrEmpty(edit_name_text.Text) || String.IsNullOrEmpty(edit_password_text.Text) || String.IsNullOrEmpty(edit_email_text.Text) || String.IsNullOrEmpty(edit_access_text.Text) || String.IsNullOrEmpty(edit_retail_text.Text))
            {
                MessageBox.Show("Something is missing!");
                return;
            }
            using (sdpEntities content = new sdpEntities())
            {

                Staff s = content.Staffs.SingleOrDefault(i => i.staff_id == edit_id.Value);
                if (s != null)
                {
                    s.staff_name = edit_name_text.Text;
                    s.staff_password = edit_password_text.Text;
                    s.staff_email = edit_email_text.Text;
                    s.staff_access = edit_access_text.Text.Substring(0, 1).ToUpper();
                    s.retailID = Dashboard.checkRetailStoreID(edit_retail_text.Text);

                }
                content.SaveChanges();

            }
            loadTable();

            editAccountMenu.Start();
        }
    }
}
