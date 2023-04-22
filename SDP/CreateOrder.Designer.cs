namespace SDP
{
    partial class CreateOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productOrderView = new System.Windows.Forms.DataGridView();
            this.p_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createOrderTitle = new System.Windows.Forms.Label();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.modelText = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.qtyText = new System.Windows.Forms.NumericUpDown();
            this.addItemBtn = new FontAwesome.Sharp.IconButton();
            this.orderView = new System.Windows.Forms.DataGridView();
            this.orderProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDText = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clearBtn = new FontAwesome.Sharp.IconButton();
            this.createBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.SuspendLayout();
            // 
            // productOrderView
            // 
            this.productOrderView.AllowUserToAddRows = false;
            this.productOrderView.AllowUserToDeleteRows = false;
            this.productOrderView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productOrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_ID,
            this.p_name,
            this.p_model,
            this.p_price,
            this.p_brand,
            this.p_category,
            this.p_qty});
            this.productOrderView.Location = new System.Drawing.Point(33, 143);
            this.productOrderView.Name = "productOrderView";
            this.productOrderView.ReadOnly = true;
            this.productOrderView.RowTemplate.Height = 27;
            this.productOrderView.Size = new System.Drawing.Size(840, 478);
            this.productOrderView.TabIndex = 0;
            this.productOrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productOrderView_CellContentClick);
            // 
            // p_ID
            // 
            this.p_ID.HeaderText = "ID";
            this.p_ID.Name = "p_ID";
            this.p_ID.ReadOnly = true;
            this.p_ID.Visible = false;
            // 
            // p_name
            // 
            this.p_name.HeaderText = "Name";
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
            // p_brand
            // 
            this.p_brand.HeaderText = "Brand";
            this.p_brand.Name = "p_brand";
            this.p_brand.ReadOnly = true;
            // 
            // p_category
            // 
            this.p_category.HeaderText = "Category";
            this.p_category.Name = "p_category";
            this.p_category.ReadOnly = true;
            // 
            // p_qty
            // 
            this.p_qty.HeaderText = "Quantity";
            this.p_qty.Name = "p_qty";
            this.p_qty.ReadOnly = true;
            // 
            // createOrderTitle
            // 
            this.createOrderTitle.AutoSize = true;
            this.createOrderTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderTitle.ForeColor = System.Drawing.Color.White;
            this.createOrderTitle.Location = new System.Drawing.Point(25, 32);
            this.createOrderTitle.Name = "createOrderTitle";
            this.createOrderTitle.Size = new System.Drawing.Size(273, 48);
            this.createOrderTitle.TabIndex = 30;
            this.createOrderTitle.Text = "CREATE A ORDER";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.Black;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 30;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(706, 83);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.searchBtn.Size = new System.Drawing.Size(166, 55);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchLabel.Location = new System.Drawing.Point(28, 98);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(127, 25);
            this.searchLabel.TabIndex = 32;
            this.searchLabel.Text = "Name / Model:";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(210, 97);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(180, 32);
            this.searchText.TabIndex = 31;
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(893, 113);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 25);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "Name:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modelLabel.Location = new System.Drawing.Point(893, 160);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(65, 25);
            this.modelLabel.TabIndex = 35;
            this.modelLabel.Text = "Model:";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtyLabel.Location = new System.Drawing.Point(893, 254);
            this.qtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(83, 25);
            this.qtyLabel.TabIndex = 36;
            this.qtyLabel.Text = "Quantity:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(893, 207);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 25);
            this.priceLabel.TabIndex = 37;
            this.priceLabel.Text = "Price:";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameText.Location = new System.Drawing.Point(1023, 113);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(60, 25);
            this.nameText.TabIndex = 38;
            this.nameText.Text = "--------";
            // 
            // modelText
            // 
            this.modelText.AutoSize = true;
            this.modelText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modelText.Location = new System.Drawing.Point(1023, 160);
            this.modelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(60, 25);
            this.modelText.TabIndex = 39;
            this.modelText.Text = "--------";
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceText.Location = new System.Drawing.Point(1023, 207);
            this.priceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(60, 25);
            this.priceText.TabIndex = 40;
            this.priceText.Text = "--------";
            // 
            // qtyText
            // 
            this.qtyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtyText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyText.Location = new System.Drawing.Point(1028, 252);
            this.qtyText.Name = "qtyText";
            this.qtyText.Size = new System.Drawing.Size(120, 32);
            this.qtyText.TabIndex = 41;
            this.qtyText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyText.ValueChanged += new System.EventHandler(this.qtyText_ValueChanged);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.White;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.Black;
            this.addItemBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addItemBtn.IconColor = System.Drawing.Color.Black;
            this.addItemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addItemBtn.IconSize = 30;
            this.addItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addItemBtn.Location = new System.Drawing.Point(898, 313);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(10);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Padding = new System.Windows.Forms.Padding(5);
            this.addItemBtn.Size = new System.Drawing.Size(132, 55);
            this.addItemBtn.TabIndex = 42;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // orderView
            // 
            this.orderView.AllowUserToAddRows = false;
            this.orderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderProductID,
            this.orderName,
            this.orderModel,
            this.orderPrice,
            this.orderQty});
            this.orderView.Location = new System.Drawing.Point(898, 381);
            this.orderView.Name = "orderView";
            this.orderView.RowTemplate.Height = 27;
            this.orderView.Size = new System.Drawing.Size(445, 203);
            this.orderView.TabIndex = 43;
            this.orderView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderView_CellValueChanged);
            // 
            // orderProductID
            // 
            this.orderProductID.HeaderText = "ID";
            this.orderProductID.Name = "orderProductID";
            this.orderProductID.Visible = false;
            // 
            // orderName
            // 
            this.orderName.HeaderText = "Name";
            this.orderName.Name = "orderName";
            this.orderName.ReadOnly = true;
            // 
            // orderModel
            // 
            this.orderModel.HeaderText = "Model";
            this.orderModel.Name = "orderModel";
            this.orderModel.ReadOnly = true;
            // 
            // orderPrice
            // 
            this.orderPrice.HeaderText = "Price";
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.ReadOnly = true;
            // 
            // orderQty
            // 
            this.orderQty.HeaderText = "Quantity";
            this.orderQty.Name = "orderQty";
            // 
            // IDText
            // 
            this.IDText.AutoSize = true;
            this.IDText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDText.Location = new System.Drawing.Point(1023, 67);
            this.IDText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(0, 25);
            this.IDText.TabIndex = 44;
            this.IDText.Visible = false;
            // 
            // totalText
            // 
            this.totalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalText.Location = new System.Drawing.Point(1257, 596);
            this.totalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(60, 25);
            this.totalText.TabIndex = 46;
            this.totalText.Text = "--------";
            this.totalText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(893, 596);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 25);
            this.totalLabel.TabIndex = 45;
            this.totalLabel.Text = "Total:";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.clearBtn.IconColor = System.Drawing.Color.Black;
            this.clearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearBtn.IconSize = 30;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(1040, 313);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(10);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(5);
            this.clearBtn.Size = new System.Drawing.Size(139, 55);
            this.clearBtn.TabIndex = 47;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.BackColor = System.Drawing.Color.White;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.Black;
            this.createBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.createBtn.IconColor = System.Drawing.Color.Black;
            this.createBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createBtn.IconSize = 30;
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(1190, 313);
            this.createBtn.Margin = new System.Windows.Forms.Padding(10);
            this.createBtn.Name = "createBtn";
            this.createBtn.Padding = new System.Windows.Forms.Padding(5);
            this.createBtn.Size = new System.Drawing.Size(153, 55);
            this.createBtn.TabIndex = 48;
            this.createBtn.Text = "Create";
            this.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.orderView);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.createOrderTitle);
            this.Controls.Add(this.productOrderView);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.productOrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productOrderView;
        private System.Windows.Forms.Label createOrderTitle;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_qty;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label modelText;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.NumericUpDown qtyText;
        private FontAwesome.Sharp.IconButton addItemBtn;
        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.Label IDText;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQty;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Label totalLabel;
        private FontAwesome.Sharp.IconButton clearBtn;
        private FontAwesome.Sharp.IconButton createBtn;
    }
}