namespace SDP
{
    partial class SupplierManage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierManage));
            this.label1 = new System.Windows.Forms.Label();
            this.supplierView = new System.Windows.Forms.DataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.p_searchBtn = new FontAwesome.Sharp.IconButton();
            this.supplierPanel = new System.Windows.Forms.Panel();
            this.closeAccountMenu = new System.Windows.Forms.PictureBox();
            this.supplierCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.supplierName_text = new System.Windows.Forms.TextBox();
            this.supplierPhone_text = new System.Windows.Forms.TextBox();
            this.supplierAddress_text = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.supplierMenu = new System.Windows.Forms.Timer(this.components);
            this.insertBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.supplierView)).BeginInit();
            this.supplierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPPLIER MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // supplierView
            // 
            this.supplierView.AllowUserToAddRows = false;
            this.supplierView.AllowUserToDeleteRows = false;
            this.supplierView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.supplierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.supplierName,
            this.supplierPhone,
            this.supplierAddress});
            this.supplierView.Location = new System.Drawing.Point(33, 164);
            this.supplierView.Margin = new System.Windows.Forms.Padding(4);
            this.supplierView.Name = "supplierView";
            this.supplierView.ReadOnly = true;
            this.supplierView.RowTemplate.Height = 24;
            this.supplierView.Size = new System.Drawing.Size(1312, 445);
            this.supplierView.TabIndex = 11;
            this.supplierView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierView_CellDoubleClick);
            // 
            // supplierID
            // 
            this.supplierID.HeaderText = "Supplier ID";
            this.supplierID.Name = "supplierID";
            this.supplierID.ReadOnly = true;
            // 
            // supplierName
            // 
            this.supplierName.HeaderText = "Supplier Name";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            // 
            // supplierPhone
            // 
            this.supplierPhone.HeaderText = "Supplier Phone";
            this.supplierPhone.Name = "supplierPhone";
            this.supplierPhone.ReadOnly = true;
            // 
            // supplierAddress
            // 
            this.supplierAddress.HeaderText = "Supplier Address";
            this.supplierAddress.Name = "supplierAddress";
            this.supplierAddress.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Supplier Name:";
            // 
            // txt_supplier
            // 
            this.txt_supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_supplier.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier.Location = new System.Drawing.Point(210, 105);
            this.txt_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(197, 32);
            this.txt_supplier.TabIndex = 13;
            // 
            // p_searchBtn
            // 
            this.p_searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_searchBtn.BackColor = System.Drawing.Color.White;
            this.p_searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p_searchBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_searchBtn.ForeColor = System.Drawing.Color.Black;
            this.p_searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.p_searchBtn.IconColor = System.Drawing.Color.Black;
            this.p_searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.p_searchBtn.IconSize = 30;
            this.p_searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p_searchBtn.Location = new System.Drawing.Point(1027, 91);
            this.p_searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.p_searchBtn.Name = "p_searchBtn";
            this.p_searchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.p_searchBtn.Size = new System.Drawing.Size(166, 55);
            this.p_searchBtn.TabIndex = 34;
            this.p_searchBtn.Text = "Search";
            this.p_searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p_searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.p_searchBtn.UseVisualStyleBackColor = false;
            this.p_searchBtn.Click += new System.EventHandler(this.p_searchBtn_Click);
            // 
            // supplierPanel
            // 
            this.supplierPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.supplierPanel.Controls.Add(this.closeAccountMenu);
            this.supplierPanel.Controls.Add(this.supplierCreate);
            this.supplierPanel.Controls.Add(this.panel3);
            this.supplierPanel.Controls.Add(this.MenuTitle);
            this.supplierPanel.Controls.Add(this.supplierName_text);
            this.supplierPanel.Controls.Add(this.supplierPhone_text);
            this.supplierPanel.Controls.Add(this.supplierAddress_text);
            this.supplierPanel.Controls.Add(this.productName);
            this.supplierPanel.Controls.Add(this.model);
            this.supplierPanel.Controls.Add(this.price);
            this.supplierPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.supplierPanel.Location = new System.Drawing.Point(1381, 0);
            this.supplierPanel.MaximumSize = new System.Drawing.Size(500, 5000);
            this.supplierPanel.Name = "supplierPanel";
            this.supplierPanel.Size = new System.Drawing.Size(1, 633);
            this.supplierPanel.TabIndex = 35;
            // 
            // closeAccountMenu
            // 
            this.closeAccountMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.closeAccountMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAccountMenu.Image = ((System.Drawing.Image)(resources.GetObject("closeAccountMenu.Image")));
            this.closeAccountMenu.Location = new System.Drawing.Point(449, 47);
            this.closeAccountMenu.Name = "closeAccountMenu";
            this.closeAccountMenu.Size = new System.Drawing.Size(28, 26);
            this.closeAccountMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeAccountMenu.TabIndex = 35;
            this.closeAccountMenu.TabStop = false;
            this.closeAccountMenu.Click += new System.EventHandler(this.closeAccountMenu_Click);
            // 
            // supplierCreate
            // 
            this.supplierCreate.BackColor = System.Drawing.Color.White;
            this.supplierCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierCreate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierCreate.Location = new System.Drawing.Point(153, 447);
            this.supplierCreate.Name = "supplierCreate";
            this.supplierCreate.Size = new System.Drawing.Size(219, 43);
            this.supplierCreate.TabIndex = 35;
            this.supplierCreate.Text = "Create Supplier";
            this.supplierCreate.UseVisualStyleBackColor = false;
            this.supplierCreate.Click += new System.EventHandler(this.supplierCreate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(37, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 28;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.ForeColor = System.Drawing.Color.White;
            this.MenuTitle.Location = new System.Drawing.Point(28, 35);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(211, 41);
            this.MenuTitle.TabIndex = 27;
            this.MenuTitle.Text = "Add A Supplier";
            // 
            // supplierName_text
            // 
            this.supplierName_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierName_text.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.supplierName_text.Location = new System.Drawing.Point(220, 129);
            this.supplierName_text.Margin = new System.Windows.Forms.Padding(4);
            this.supplierName_text.Name = "supplierName_text";
            this.supplierName_text.Size = new System.Drawing.Size(180, 31);
            this.supplierName_text.TabIndex = 2;
            // 
            // supplierPhone_text
            // 
            this.supplierPhone_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierPhone_text.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.supplierPhone_text.Location = new System.Drawing.Point(220, 182);
            this.supplierPhone_text.Margin = new System.Windows.Forms.Padding(4);
            this.supplierPhone_text.Name = "supplierPhone_text";
            this.supplierPhone_text.Size = new System.Drawing.Size(180, 31);
            this.supplierPhone_text.TabIndex = 3;
            // 
            // supplierAddress_text
            // 
            this.supplierAddress_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierAddress_text.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.supplierAddress_text.Location = new System.Drawing.Point(40, 292);
            this.supplierAddress_text.Margin = new System.Windows.Forms.Padding(4);
            this.supplierAddress_text.Multiline = true;
            this.supplierAddress_text.Name = "supplierAddress_text";
            this.supplierAddress_text.Size = new System.Drawing.Size(360, 114);
            this.supplierAddress_text.TabIndex = 4;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productName.Location = new System.Drawing.Point(35, 129);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(133, 25);
            this.productName.TabIndex = 9;
            this.productName.Text = "Supplier Name:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.model.Location = new System.Drawing.Point(35, 182);
            this.model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(137, 25);
            this.model.TabIndex = 10;
            this.model.Text = "Supplier Phone:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Location = new System.Drawing.Point(35, 243);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(152, 25);
            this.price.TabIndex = 11;
            this.price.Text = "Supplier Address:";
            // 
            // supplierMenu
            // 
            this.supplierMenu.Interval = 1;
            this.supplierMenu.Tick += new System.EventHandler(this.supplierMenu_Tick);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.BackColor = System.Drawing.Color.White;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.Black;
            this.insertBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.insertBtn.IconColor = System.Drawing.Color.Black;
            this.insertBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.insertBtn.IconSize = 30;
            this.insertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertBtn.Location = new System.Drawing.Point(1213, 91);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(10);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Padding = new System.Windows.Forms.Padding(5);
            this.insertBtn.Size = new System.Drawing.Size(132, 55);
            this.insertBtn.TabIndex = 36;
            this.insertBtn.Text = "Add";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // SupplierManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 633);
            this.Controls.Add(this.supplierPanel);
            this.Controls.Add(this.p_searchBtn);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supplierView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierManage";
            this.Text = "s";
            this.Load += new System.EventHandler(this.SupplierManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierView)).EndInit();
            this.supplierPanel.ResumeLayout(false);
            this.supplierPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView supplierView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_supplier;
        private FontAwesome.Sharp.IconButton p_searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddress;
        private System.Windows.Forms.Panel supplierPanel;
        private System.Windows.Forms.PictureBox closeAccountMenu;
        private System.Windows.Forms.Button supplierCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.TextBox supplierName_text;
        private System.Windows.Forms.TextBox supplierPhone_text;
        private System.Windows.Forms.TextBox supplierAddress_text;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Timer supplierMenu;
        private FontAwesome.Sharp.IconButton insertBtn;
    }
}