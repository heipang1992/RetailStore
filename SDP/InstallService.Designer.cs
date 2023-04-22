namespace SDP
{
    partial class InstallServices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Installation = new System.Windows.Forms.DataGridView();
            this.InstallationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInstalled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salesOrderViewTitle = new System.Windows.Forms.Label();
            this.DsaveBtn = new FontAwesome.Sharp.IconButton();
            this.printExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Installation)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 112);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(508, 112);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(317, 32);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(458, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // dataGridView_Installation
            // 
            this.dataGridView_Installation.AllowUserToAddRows = false;
            this.dataGridView_Installation.AllowUserToDeleteRows = false;
            this.dataGridView_Installation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Installation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Installation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Installation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Installation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstallationID,
            this.Date,
            this.Session,
            this.cus_name,
            this.Address,
            this.Phone,
            this.Staff,
            this.isInstalled});
            this.dataGridView_Installation.Location = new System.Drawing.Point(33, 170);
            this.dataGridView_Installation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Installation.Name = "dataGridView_Installation";
            this.dataGridView_Installation.RowTemplate.Height = 28;
            this.dataGridView_Installation.Size = new System.Drawing.Size(1312, 441);
            this.dataGridView_Installation.TabIndex = 6;
            this.dataGridView_Installation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InstallationID
            // 
            this.InstallationID.HeaderText = "Installation No";
            this.InstallationID.Name = "InstallationID";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Session
            // 
            this.Session.HeaderText = "Session";
            this.Session.Name = "Session";
            // 
            // cus_name
            // 
            this.cus_name.HeaderText = "Customer Name";
            this.cus_name.Name = "cus_name";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Staff
            // 
            this.Staff.HeaderText = "Staff";
            this.Staff.Name = "Staff";
            // 
            // isInstalled
            // 
            this.isInstalled.HeaderText = "isInstalled";
            this.isInstalled.Name = "isInstalled";
            this.isInstalled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isInstalled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // salesOrderViewTitle
            // 
            this.salesOrderViewTitle.AutoSize = true;
            this.salesOrderViewTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrderViewTitle.ForeColor = System.Drawing.Color.White;
            this.salesOrderViewTitle.Location = new System.Drawing.Point(25, 32);
            this.salesOrderViewTitle.Name = "salesOrderViewTitle";
            this.salesOrderViewTitle.Size = new System.Drawing.Size(457, 48);
            this.salesOrderViewTitle.TabIndex = 31;
            this.salesOrderViewTitle.Text = "INSTALLATION MANAGEMENT";
            // 
            // DsaveBtn
            // 
            this.DsaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DsaveBtn.BackColor = System.Drawing.Color.White;
            this.DsaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DsaveBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsaveBtn.ForeColor = System.Drawing.Color.Black;
            this.DsaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.DsaveBtn.IconColor = System.Drawing.Color.Black;
            this.DsaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DsaveBtn.IconSize = 30;
            this.DsaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DsaveBtn.Location = new System.Drawing.Point(986, 105);
            this.DsaveBtn.Name = "DsaveBtn";
            this.DsaveBtn.Padding = new System.Windows.Forms.Padding(5);
            this.DsaveBtn.Size = new System.Drawing.Size(142, 50);
            this.DsaveBtn.TabIndex = 32;
            this.DsaveBtn.Text = "Save";
            this.DsaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DsaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DsaveBtn.UseVisualStyleBackColor = false;
            this.DsaveBtn.Click += new System.EventHandler(this.DsaveBtn_Click);
            // 
            // printExcel
            // 
            this.printExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printExcel.BackColor = System.Drawing.Color.White;
            this.printExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printExcel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printExcel.ForeColor = System.Drawing.Color.Black;
            this.printExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.printExcel.IconColor = System.Drawing.Color.Black;
            this.printExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.printExcel.IconSize = 30;
            this.printExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printExcel.Location = new System.Drawing.Point(1141, 105);
            this.printExcel.Margin = new System.Windows.Forms.Padding(10);
            this.printExcel.Name = "printExcel";
            this.printExcel.Padding = new System.Windows.Forms.Padding(5);
            this.printExcel.Size = new System.Drawing.Size(204, 50);
            this.printExcel.TabIndex = 33;
            this.printExcel.Text = "Print Excel";
            this.printExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printExcel.UseVisualStyleBackColor = false;
            this.printExcel.Click += new System.EventHandler(this.printExcel_Click);
            // 
            // InstallServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 633);
            this.Controls.Add(this.printExcel);
            this.Controls.Add(this.DsaveBtn);
            this.Controls.Add(this.salesOrderViewTitle);
            this.Controls.Add(this.dataGridView_Installation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InstallServices";
            this.Text = "InstallService";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Installation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Installation;
        private System.Windows.Forms.Label salesOrderViewTitle;
        private FontAwesome.Sharp.IconButton DsaveBtn;
        private FontAwesome.Sharp.IconButton printExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInstalled;
    }
}