namespace SDP
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.supplierID = new System.Windows.Forms.Label();
            this.productCategeory = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.txt_categoryID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.retail_search_text = new System.Windows.Forms.ComboBox();
            this.retailLabel = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productSave = new System.Windows.Forms.Button();
            this.closeAccountMenu = new System.Windows.Forms.PictureBox();
            this.productCreate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.txt_supplierID = new System.Windows.Forms.ComboBox();
            this.txt_active = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p_searchBtn = new FontAwesome.Sharp.IconButton();
            this.productTitle = new System.Windows.Forms.Label();
            this.productView = new System.Windows.Forms.DataGridView();
            this.p_productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_supplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.insertBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.productMenu = new System.Windows.Forms.Timer(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_productName
            // 
            this.txt_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_productName.Location = new System.Drawing.Point(220, 250);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(180, 31);
            this.txt_productName.TabIndex = 2;
            // 
            // txt_model
            // 
            this.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_model.Location = new System.Drawing.Point(220, 303);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(180, 31);
            this.txt_model.TabIndex = 3;
            // 
            // txt_price
            // 
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_price.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_price.Location = new System.Drawing.Point(220, 360);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(180, 31);
            this.txt_price.TabIndex = 4;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quantity.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_quantity.Location = new System.Drawing.Point(158, 442);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(180, 31);
            this.txt_quantity.TabIndex = 5;
            // 
            // supplierID
            // 
            this.supplierID.AutoSize = true;
            this.supplierID.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supplierID.Location = new System.Drawing.Point(32, 118);
            this.supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(83, 25);
            this.supplierID.TabIndex = 7;
            this.supplierID.Text = "Supplier:";
            // 
            // productCategeory
            // 
            this.productCategeory.AutoSize = true;
            this.productCategeory.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategeory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productCategeory.Location = new System.Drawing.Point(32, 171);
            this.productCategeory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCategeory.Name = "productCategeory";
            this.productCategeory.Size = new System.Drawing.Size(89, 25);
            this.productCategeory.TabIndex = 8;
            this.productCategeory.Text = "Category:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productName.Location = new System.Drawing.Point(35, 250);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(129, 25);
            this.productName.TabIndex = 9;
            this.productName.Text = "Product Name:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.model.Location = new System.Drawing.Point(35, 304);
            this.model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(65, 25);
            this.model.TabIndex = 10;
            this.model.Text = "Model:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Location = new System.Drawing.Point(35, 360);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(58, 25);
            this.price.TabIndex = 11;
            this.price.Text = "Price:";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantity.Location = new System.Drawing.Point(35, 442);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(83, 25);
            this.quantity.TabIndex = 12;
            this.quantity.Text = "Quantity:";
            // 
            // txt_categoryID
            // 
            this.txt_categoryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_categoryID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_categoryID.FormattingEnabled = true;
            this.txt_categoryID.Location = new System.Drawing.Point(159, 171);
            this.txt_categoryID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categoryID.Name = "txt_categoryID";
            this.txt_categoryID.Size = new System.Drawing.Size(180, 28);
            this.txt_categoryID.TabIndex = 15;
            this.txt_categoryID.Text = "Select Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.retail_search_text);
            this.panel1.Controls.Add(this.retailLabel);
            this.panel1.Controls.Add(this.productPanel);
            this.panel1.Controls.Add(this.p_searchBtn);
            this.panel1.Controls.Add(this.productTitle);
            this.panel1.Controls.Add(this.productView);
            this.panel1.Controls.Add(this.insertBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 653);
            this.panel1.TabIndex = 0;
            // 
            // retail_search_text
            // 
            this.retail_search_text.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retail_search_text.FormattingEnabled = true;
            this.retail_search_text.Location = new System.Drawing.Point(601, 105);
            this.retail_search_text.Name = "retail_search_text";
            this.retail_search_text.Size = new System.Drawing.Size(180, 33);
            this.retail_search_text.TabIndex = 36;
            this.retail_search_text.SelectedIndexChanged += new System.EventHandler(this.retail_search_text_SelectedIndexChanged);
            // 
            // retailLabel
            // 
            this.retailLabel.AutoSize = true;
            this.retailLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retailLabel.Location = new System.Drawing.Point(446, 106);
            this.retailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.retailLabel.Name = "retailLabel";
            this.retailLabel.Size = new System.Drawing.Size(110, 25);
            this.retailLabel.TabIndex = 35;
            this.retailLabel.Text = "Retail Store:";
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.productPanel.Controls.Add(this.productSave);
            this.productPanel.Controls.Add(this.closeAccountMenu);
            this.productPanel.Controls.Add(this.productCreate);
            this.productPanel.Controls.Add(this.panel5);
            this.productPanel.Controls.Add(this.panel4);
            this.productPanel.Controls.Add(this.panel3);
            this.productPanel.Controls.Add(this.txt_productID);
            this.productPanel.Controls.Add(this.MenuTitle);
            this.productPanel.Controls.Add(this.txt_supplierID);
            this.productPanel.Controls.Add(this.supplierID);
            this.productPanel.Controls.Add(this.txt_categoryID);
            this.productPanel.Controls.Add(this.productCategeory);
            this.productPanel.Controls.Add(this.txt_productName);
            this.productPanel.Controls.Add(this.txt_model);
            this.productPanel.Controls.Add(this.txt_price);
            this.productPanel.Controls.Add(this.txt_quantity);
            this.productPanel.Controls.Add(this.txt_active);
            this.productPanel.Controls.Add(this.label3);
            this.productPanel.Controls.Add(this.productName);
            this.productPanel.Controls.Add(this.model);
            this.productPanel.Controls.Add(this.quantity);
            this.productPanel.Controls.Add(this.price);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.productPanel.Location = new System.Drawing.Point(1381, 0);
            this.productPanel.MaximumSize = new System.Drawing.Size(500, 5000);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1, 653);
            this.productPanel.TabIndex = 34;
            // 
            // productSave
            // 
            this.productSave.BackColor = System.Drawing.Color.White;
            this.productSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSave.Location = new System.Drawing.Point(141, 573);
            this.productSave.Name = "productSave";
            this.productSave.Size = new System.Drawing.Size(219, 43);
            this.productSave.TabIndex = 36;
            this.productSave.Text = "Update Product";
            this.productSave.UseVisualStyleBackColor = false;
            this.productSave.Click += new System.EventHandler(this.productSave_Click);
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
            // productCreate
            // 
            this.productCreate.BackColor = System.Drawing.Color.White;
            this.productCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productCreate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCreate.Location = new System.Drawing.Point(141, 573);
            this.productCreate.Name = "productCreate";
            this.productCreate.Size = new System.Drawing.Size(219, 43);
            this.productCreate.TabIndex = 35;
            this.productCreate.Text = "Create Product";
            this.productCreate.UseVisualStyleBackColor = false;
            this.productCreate.Click += new System.EventHandler(this.productCreate_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(35, 413);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 5);
            this.panel5.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(35, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 5);
            this.panel4.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(37, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 28;
            // 
            // txt_productID
            // 
            this.txt_productID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_productID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_productID.Location = new System.Drawing.Point(239, 45);
            this.txt_productID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.ReadOnly = true;
            this.txt_productID.Size = new System.Drawing.Size(180, 31);
            this.txt_productID.TabIndex = 33;
            this.txt_productID.Visible = false;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.ForeColor = System.Drawing.Color.White;
            this.MenuTitle.Location = new System.Drawing.Point(28, 35);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(202, 41);
            this.MenuTitle.TabIndex = 27;
            this.MenuTitle.Text = "Add A Product";
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_supplierID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_supplierID.FormattingEnabled = true;
            this.txt_supplierID.Location = new System.Drawing.Point(159, 118);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(180, 28);
            this.txt_supplierID.TabIndex = 25;
            this.txt_supplierID.Text = "Select Supplier";
            // 
            // txt_active
            // 
            this.txt_active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_active.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_active.FormattingEnabled = true;
            this.txt_active.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.txt_active.Location = new System.Drawing.Point(158, 500);
            this.txt_active.Margin = new System.Windows.Forms.Padding(4);
            this.txt_active.Name = "txt_active";
            this.txt_active.Size = new System.Drawing.Size(180, 28);
            this.txt_active.TabIndex = 22;
            this.txt_active.Text = "Select Yes / No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Active:";
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
            this.p_searchBtn.TabIndex = 29;
            this.p_searchBtn.Text = "Search";
            this.p_searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p_searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.p_searchBtn.UseVisualStyleBackColor = false;
            this.p_searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // productTitle
            // 
            this.productTitle.AutoSize = true;
            this.productTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTitle.ForeColor = System.Drawing.Color.White;
            this.productTitle.Location = new System.Drawing.Point(25, 32);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(391, 48);
            this.productTitle.TabIndex = 28;
            this.productTitle.Text = "PRODUCT MANAGEMENT";
            // 
            // productView
            // 
            this.productView.AllowUserToAddRows = false;
            this.productView.AllowUserToDeleteRows = false;
            this.productView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_productId,
            this.p_supplierId,
            this.p_categoryId,
            this.p_name,
            this.p_model,
            this.p_price,
            this.p_qty,
            this.p_active});
            this.productView.Location = new System.Drawing.Point(33, 150);
            this.productView.Margin = new System.Windows.Forms.Padding(4);
            this.productView.Name = "productView";
            this.productView.ReadOnly = true;
            this.productView.RowTemplate.Height = 24;
            this.productView.Size = new System.Drawing.Size(1312, 470);
            this.productView.TabIndex = 27;
            this.productView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productview_CellDoubleClick);
            // 
            // p_productId
            // 
            this.p_productId.HeaderText = "Product";
            this.p_productId.Name = "p_productId";
            this.p_productId.ReadOnly = true;
            // 
            // p_supplierId
            // 
            this.p_supplierId.HeaderText = "Supplier";
            this.p_supplierId.Name = "p_supplierId";
            this.p_supplierId.ReadOnly = true;
            // 
            // p_categoryId
            // 
            this.p_categoryId.HeaderText = "Category";
            this.p_categoryId.Name = "p_categoryId";
            this.p_categoryId.ReadOnly = true;
            // 
            // p_name
            // 
            this.p_name.HeaderText = "Product Name";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // p_model
            // 
            this.p_model.HeaderText = "Model";
            this.p_model.Name = "p_model";
            this.p_model.ReadOnly = true;
            // 
            // p_price
            // 
            this.p_price.HeaderText = "Price";
            this.p_price.Name = "p_price";
            this.p_price.ReadOnly = true;
            // 
            // p_qty
            // 
            this.p_qty.HeaderText = "Quantity";
            this.p_qty.Name = "p_qty";
            this.p_qty.ReadOnly = true;
            // 
            // p_active
            // 
            this.p_active.HeaderText = "Active";
            this.p_active.Name = "p_active";
            this.p_active.ReadOnly = true;
            this.p_active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.p_active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.insertBtn.TabIndex = 31;
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
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name / Model:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(210, 105);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(180, 32);
            this.txt_search.TabIndex = 17;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // productMenu
            // 
            this.productMenu.Interval = 1;
            this.productMenu.Tick += new System.EventHandler(this.productMenu_Tick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SDP.Product);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Products";
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label supplierID;
        private System.Windows.Forms.Label productCategeory;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.ComboBox txt_categoryID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox txt_active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_supplierID;
        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label productTitle;
        private FontAwesome.Sharp.IconButton p_searchBtn;
        private FontAwesome.Sharp.IconButton insertBtn;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer productMenu;
        private System.Windows.Forms.Button productCreate;
        private System.Windows.Forms.PictureBox closeAccountMenu;
        private System.Windows.Forms.Button productSave;
        private System.Windows.Forms.Label retailLabel;
        private System.Windows.Forms.ComboBox retail_search_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_supplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_qty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn p_active;
    }
}