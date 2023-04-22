using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SDP
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.ActiveControl = name_input;
            //name_input.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name_input.Text))
            {
                MessageBox.Show("Username is required!");
                return;
            }

            if (String.IsNullOrEmpty(pass_input.Text))
            {
                MessageBox.Show("Password is required!");
                return;
            }

            using (sdpEntities content = new sdpEntities())
            {
                try
                {
                    Staff s = content.Staffs.SingleOrDefault(i => i.staff_name.ToLower() == name_input.Text.ToLower() && i.staff_password == pass_input.Text);
                    if (s != null && s.active == true)
                    {
                        this.Hide();
                        Dashboard form = new Dashboard(s, this);
                        Dashboard.account = s;
                        form.Show();

                        return;

                    } else if (s != null && s.active == false)
                    {
                        MessageBox.Show("This acccount is locked");
                    } else
                    {
                        MessageBox.Show("Username or Password is not correct! Please try again!");
                    }
                    
                } catch(InvalidOperationException)
                {
                    MessageBox.Show("Username or Password is not correct! Please try again!");
                    return;

                } finally
                {
                    if (!rememberBtn.Checked)
                    {
                        pass_input.Clear();
                    }
                    
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pass_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
