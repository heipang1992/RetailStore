namespace SDP
{
    partial class RetailStoreManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailStoreManage));
            this.productTitle = new System.Windows.Forms.Label();
            this.p_searchBtn = new FontAwesome.Sharp.IconButton();
            this.retailStoreView = new System.Windows.Forms.DataGridView();
            this.retailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.retailStoreMenu = new System.Windows.Forms.Timer(this.components);
            this.retailStorePanel = new System.Windows.Forms.Panel();
            this.storeSave = new System.Windows.Forms.Button();
            this.closeAccountMenu = new System.Windows.Forms.PictureBox();
            this.storeCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.retailIDText = new System.Windows.Forms.TextBox();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.loactionText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retailStoreView)).BeginInit();
            this.retailStorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTitle.ForeColor = System.Drawing.Color.White;
            this.productTitle.Location = new System.Drawing.Point(25, 32);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(451, 48);
            this.productTitle.TabIndex = 29;
            this.productTitle.Text = "RETAIL STORE MANAGEMENT";
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
            this.p_searchBtn.Location = new System.Drawing.Point(1027, 94);
            this.p_searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.p_searchBtn.Name = "p_searchBtn";
            this.p_searchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.p_searchBtn.Size = new System.Drawing.Size(166, 55);
            this.p_searchBtn.TabIndex = 40;
            this.p_searchBtn.Text = "Search";
            this.p_searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p_searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.p_searchBtn.UseVisualStyleBackColor = false;
            this.p_searchBtn.Click += new System.EventHandler(this.p_searchBtn_Click);
            // 
            // retailStoreView
            // 
            this.retailStoreView.AllowUserToAddRows = false;
            this.retailStoreView.AllowUserToDeleteRows = false;
            this.retailStoreView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retailStoreView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.retailStoreView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.retailStoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retailStoreView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.retailID,
            this.location,
            this.address,
            this.phone});
            this.retailStoreView.Location = new System.Drawing.Point(33, 153);
            this.retailStoreView.Margin = new System.Windows.Forms.Padding(4);
            this.retailStoreView.Name = "retailStoreView";
            this.retailStoreView.ReadOnly = true;
            this.retailStoreView.RowTemplate.Height = 24;
            this.retailStoreView.Size = new System.Drawing.Size(1312, 470);
            this.retailStoreView.TabIndex = 39;
            this.retailStoreView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.retailStoreView_CellDoubleClick);
            // 
            // retailID
            // 
            this.retailID.HeaderText = "Retail ID";
            this.retailID.Name = "retailID";
            this.retailID.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
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
            this.insertBtn.Location = new System.Drawing.Point(1213, 94);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(10);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Padding = new System.Windows.Forms.Padding(5);
            this.insertBtn.Size = new System.Drawing.Size(132, 55);
            this.insertBtn.TabIndex = 41;
            this.insertBtn.Text = "Add";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Location / Phone:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(238, 108);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(180, 32);
            this.txt_search.TabIndex = 37;
            // 
            // retailStoreMenu
            // 
            this.retailStoreMenu.Interval = 1;
            this.retailStoreMenu.Tick += new System.EventHandler(this.retailStoreMenu_Tick);
            // 
            // retailStorePanel
            // 
            this.retailStorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.retailStorePanel.Controls.Add(this.storeSave);
            this.retailStorePanel.Controls.Add(this.closeAccountMenu);
            this.retailStorePanel.Controls.Add(this.storeCreate);
            this.retailStorePanel.Controls.Add(this.panel3);
            this.retailStorePanel.Controls.Add(this.retailIDText);
            this.retailStorePanel.Controls.Add(this.MenuTitle);
            this.retailStorePanel.Controls.Add(this.loactionText);
            this.retailStorePanel.Controls.Add(this.phoneText);
            this.retailStorePanel.Controls.Add(this.addressText);
            this.retailStorePanel.Controls.Add(this.productName);
            this.retailStorePanel.Controls.Add(this.model);
            this.retailStorePanel.Controls.Add(this.price);
            this.retailStorePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.retailStorePanel.Location = new System.Drawing.Point(1381, 0);
            this.retailStorePanel.MaximumSize = new System.Drawing.Size(500, 5000);
            this.retailStorePanel.Name = "retailStorePanel";
            this.retailStorePanel.Size = new System.Drawing.Size(1, 653);
            this.retailStorePanel.TabIndex = 42;
            // 
            // storeSave
            // 
            this.storeSave.BackColor = System.Drawing.Color.White;
            this.storeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeSave.Location = new System.Drawing.Point(141, 435);
            this.storeSave.Name = "storeSave";
            this.storeSave.Size = new System.Drawing.Size(219, 43);
            this.storeSave.TabIndex = 36;
            this.storeSave.Text = "Update Retail";
            this.storeSave.UseVisualStyleBackColor = false;
            this.storeSave.Click += new System.EventHandler(this.storeSave_Click);
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
            // storeCreate
            // 
            this.storeCreate.BackColor = System.Drawing.Color.White;
            this.storeCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeCreate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeCreate.Location = new System.Drawing.Point(141, 435);
            this.storeCreate.Name = "storeCreate";
            this.storeCreate.Size = new System.Drawing.Size(219, 43);
            this.storeCreate.TabIndex = 35;
            this.storeCreate.Text = "Create Product";
            this.storeCreate.UseVisualStyleBackColor = false;
            this.storeCreate.Click += new System.EventHandler(this.storeCreate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(37, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 28;
            // 
            // retailIDText
            // 
            this.retailIDText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.retailIDText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retailIDText.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.retailIDText.Location = new System.Drawing.Point(239, 45);
            this.retailIDText.Margin = new System.Windows.Forms.Padding(4);
            this.retailIDText.Name = "retailIDText";
            this.retailIDText.ReadOnly = true;
            this.retailIDText.Size = new System.Drawing.Size(180, 31);
            this.retailIDText.TabIndex = 33;
            this.retailIDText.Visible = false;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.ForeColor = System.Drawing.Color.White;
            this.MenuTitle.Location = new System.Drawing.Point(28, 35);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(255, 41);
            this.MenuTitle.TabIndex = 27;
            this.MenuTitle.Text = "Add A Retail Store";
            // 
            // loactionText
            // 
            this.loactionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loactionText.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loactionText.Location = new System.Drawing.Point(220, 112);
            this.loactionText.Margin = new System.Windows.Forms.Padding(4);
            this.loactionText.Name = "loactionText";
            this.loactionText.Size = new System.Drawing.Size(180, 31);
            this.loactionText.TabIndex = 2;
            // 
            // phoneText
            // 
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneText.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.phoneText.Location = new System.Drawing.Point(220, 161);
            this.phoneText.Margin = new System.Windows.Forms.Padding(4);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(180, 31);
            this.phoneText.TabIndex = 3;
            // 
            // addressText
            // 
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressText.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addressText.Location = new System.Drawing.Point(40, 263);
            this.addressText.Margin = new System.Windows.Forms.Padding(4);
            this.addressText.Multiline = true;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(365, 136);
            this.addressText.TabIndex = 4;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productName.Location = new System.Drawing.Point(35, 112);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(81, 25);
            this.productName.TabIndex = 9;
            this.productName.Text = "Location";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.model.Location = new System.Drawing.Point(35, 167);
            this.model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(66, 25);
            this.model.TabIndex = 10;
            this.model.Text = "Phone:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Location = new System.Drawing.Point(35, 218);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(81, 25);
            this.price.TabIndex = 11;
            this.price.Text = "Address:";
            // 
            // RetailStoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.retailStorePanel);
            this.Controls.Add(this.p_searchBtn);
            this.Controls.Add(this.retailStoreView);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.productTitle);
            this.Name = "RetailStoreManage";
            this.Text = "RetailStoreManage";
            ((System.ComponentModel.ISupportInitialize)(this.retailStoreView)).EndInit();
            this.retailStorePanel.ResumeLayout(false);
            this.retailStorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productTitle;
        private FontAwesome.Sharp.IconButton p_searchBtn;
        private System.Windows.Forms.DataGridView retailStoreView;
        private FontAwesome.Sharp.IconButton insertBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Timer retailStoreMenu;
        private System.Windows.Forms.Panel retailStorePanel;
        private System.Windows.Forms.Button storeSave;
        private System.Windows.Forms.PictureBox closeAccountMenu;
        private System.Windows.Forms.Button storeCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox retailIDText;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.TextBox loactionText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label price;
    }
}