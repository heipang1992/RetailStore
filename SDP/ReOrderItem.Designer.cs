namespace SDP
{
    partial class ReOrderItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReOrderItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_reorderLevel = new System.Windows.Forms.TextBox();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reorderview = new System.Windows.Forms.DataGridView();
            this.p_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderTitle = new System.Windows.Forms.Label();
            this.printExcel = new FontAwesome.Sharp.IconButton();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closeAccountMenu = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.txt_productPrice = new System.Windows.Forms.Label();
            this.txt_productModel = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.Label();
            this.createBtn = new FontAwesome.Sharp.IconButton();
            this.clearBtn = new FontAwesome.Sharp.IconButton();
            this.addItemBtn = new FontAwesome.Sharp.IconButton();
            this.txt_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderView = new System.Windows.Forms.DataGridView();
            this.orderProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.purchaseMenu = new System.Windows.Forms.Timer(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reorderview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Product List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(319, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Reorder Level";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1028, 110);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Set Reorder Level";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_reorderLevel
            // 
            this.txt_reorderLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_reorderLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_reorderLevel.Location = new System.Drawing.Point(1194, 74);
            this.txt_reorderLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_reorderLevel.Name = "txt_reorderLevel";
            this.txt_reorderLevel.Size = new System.Drawing.Size(151, 25);
            this.txt_reorderLevel.TabIndex = 4;
            // 
            // txt_productID
            // 
            this.txt_productID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_productID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productID.Location = new System.Drawing.Point(1194, 38);
            this.txt_productID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(151, 25);
            this.txt_productID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1023, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reorder Level:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1023, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reorderview
            // 
            this.reorderview.AllowUserToAddRows = false;
            this.reorderview.AllowUserToDeleteRows = false;
            this.reorderview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reorderview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reorderview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reorderview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reorderview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_ID,
            this.p_Name,
            this.p_model,
            this.Column3,
            this.Column5,
            this.p_price,
            this.Quantity_,
            this.ReorderLevel_});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reorderview.DefaultCellStyle = dataGridViewCellStyle2;
            this.reorderview.Location = new System.Drawing.Point(33, 162);
            this.reorderview.Margin = new System.Windows.Forms.Padding(4);
            this.reorderview.Name = "reorderview";
            this.reorderview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reorderview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.reorderview.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reorderview.RowTemplate.Height = 24;
            this.reorderview.Size = new System.Drawing.Size(1312, 408);
            this.reorderview.TabIndex = 9;
            this.reorderview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reorderview_CellDoubleClick);
            // 
            // p_ID
            // 
            this.p_ID.HeaderText = "ProductID";
            this.p_ID.Name = "p_ID";
            this.p_ID.ReadOnly = true;
            // 
            // p_Name
            // 
            this.p_Name.HeaderText = "Product Name";
            this.p_Name.Name = "p_Name";
            this.p_Name.ReadOnly = true;
            // 
            // p_model
            // 
            this.p_model.HeaderText = "Model";
            this.p_model.Name = "p_model";
            this.p_model.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Category";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // p_price
            // 
            this.p_price.HeaderText = "Price";
            this.p_price.Name = "p_price";
            this.p_price.ReadOnly = true;
            // 
            // Quantity_
            // 
            this.Quantity_.HeaderText = "Quantity";
            this.Quantity_.Name = "Quantity_";
            this.Quantity_.ReadOnly = true;
            // 
            // ReorderLevel_
            // 
            this.ReorderLevel_.HeaderText = "Reorder Level";
            this.ReorderLevel_.Name = "ReorderLevel_";
            this.ReorderLevel_.ReadOnly = true;
            // 
            // reOrderTitle
            // 
            this.reOrderTitle.AutoSize = true;
            this.reOrderTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reOrderTitle.ForeColor = System.Drawing.Color.White;
            this.reOrderTitle.Location = new System.Drawing.Point(25, 32);
            this.reOrderTitle.Name = "reOrderTitle";
            this.reOrderTitle.Size = new System.Drawing.Size(387, 48);
            this.reOrderTitle.TabIndex = 29;
            this.reOrderTitle.Text = "REORDER MANAGEMENT";
            // 
            // printExcel
            // 
            this.printExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printExcel.BackColor = System.Drawing.Color.White;
            this.printExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printExcel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printExcel.ForeColor = System.Drawing.Color.Black;
            this.printExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.printExcel.IconColor = System.Drawing.Color.Black;
            this.printExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.printExcel.IconSize = 30;
            this.printExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printExcel.Location = new System.Drawing.Point(1141, 584);
            this.printExcel.Margin = new System.Windows.Forms.Padding(10);
            this.printExcel.Name = "printExcel";
            this.printExcel.Padding = new System.Windows.Forms.Padding(5);
            this.printExcel.Size = new System.Drawing.Size(204, 50);
            this.printExcel.TabIndex = 30;
            this.printExcel.Text = "Print Excel";
            this.printExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printExcel.UseVisualStyleBackColor = false;
            this.printExcel.Click += new System.EventHandler(this.printExcel_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.price.Location = new System.Drawing.Point(35, 224);
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
            this.quantity.Location = new System.Drawing.Point(35, 277);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(83, 25);
            this.quantity.TabIndex = 12;
            this.quantity.Text = "Quantity:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.model.Location = new System.Drawing.Point(35, 170);
            this.model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(65, 25);
            this.model.TabIndex = 10;
            this.model.Text = "Model:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productName.Location = new System.Drawing.Point(35, 116);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(129, 25);
            this.productName.TabIndex = 9;
            this.productName.Text = "Product Name:";
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.ForeColor = System.Drawing.Color.White;
            this.MenuTitle.Location = new System.Drawing.Point(28, 35);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(246, 41);
            this.MenuTitle.TabIndex = 27;
            this.MenuTitle.Text = "PURCHASE ORDER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(37, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(35, 324);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 5);
            this.panel5.TabIndex = 35;
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
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.Panel.Controls.Add(this.txt_productPrice);
            this.Panel.Controls.Add(this.txt_productModel);
            this.Panel.Controls.Add(this.txt_productName);
            this.Panel.Controls.Add(this.IDText);
            this.Panel.Controls.Add(this.createBtn);
            this.Panel.Controls.Add(this.clearBtn);
            this.Panel.Controls.Add(this.addItemBtn);
            this.Panel.Controls.Add(this.txt_total);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.orderView);
            this.Panel.Controls.Add(this.txt_qty);
            this.Panel.Controls.Add(this.closeAccountMenu);
            this.Panel.Controls.Add(this.panel5);
            this.Panel.Controls.Add(this.panel3);
            this.Panel.Controls.Add(this.MenuTitle);
            this.Panel.Controls.Add(this.productName);
            this.Panel.Controls.Add(this.model);
            this.Panel.Controls.Add(this.quantity);
            this.Panel.Controls.Add(this.price);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel.Location = new System.Drawing.Point(1381, 0);
            this.Panel.MaximumSize = new System.Drawing.Size(500, 5000);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1, 653);
            this.Panel.TabIndex = 35;
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.AutoSize = true;
            this.txt_productPrice.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_productPrice.Location = new System.Drawing.Point(215, 224);
            this.txt_productPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(48, 25);
            this.txt_productPrice.TabIndex = 61;
            this.txt_productPrice.Text = "------";
            // 
            // txt_productModel
            // 
            this.txt_productModel.AutoSize = true;
            this.txt_productModel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_productModel.Location = new System.Drawing.Point(215, 170);
            this.txt_productModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_productModel.Name = "txt_productModel";
            this.txt_productModel.Size = new System.Drawing.Size(48, 25);
            this.txt_productModel.TabIndex = 60;
            this.txt_productModel.Text = "------";
            // 
            // txt_productName
            // 
            this.txt_productName.AutoSize = true;
            this.txt_productName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_productName.Location = new System.Drawing.Point(215, 116);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(48, 25);
            this.txt_productName.TabIndex = 59;
            this.txt_productName.Text = "------";
            // 
            // IDText
            // 
            this.IDText.AutoSize = true;
            this.IDText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDText.Location = new System.Drawing.Point(294, 48);
            this.IDText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(0, 25);
            this.IDText.TabIndex = 58;
            this.IDText.Visible = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.White;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.Black;
            this.createBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.createBtn.IconColor = System.Drawing.Color.Black;
            this.createBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createBtn.IconSize = 30;
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(322, 348);
            this.createBtn.Margin = new System.Windows.Forms.Padding(10);
            this.createBtn.Name = "createBtn";
            this.createBtn.Padding = new System.Windows.Forms.Padding(5);
            this.createBtn.Size = new System.Drawing.Size(153, 55);
            this.createBtn.TabIndex = 57;
            this.createBtn.Text = "Create";
            this.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.clearBtn.IconColor = System.Drawing.Color.Black;
            this.clearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearBtn.IconSize = 30;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(172, 348);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(10);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(5);
            this.clearBtn.Size = new System.Drawing.Size(139, 55);
            this.clearBtn.TabIndex = 56;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.addItemBtn.Location = new System.Drawing.Point(30, 348);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(10);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Padding = new System.Windows.Forms.Padding(5);
            this.addItemBtn.Size = new System.Drawing.Size(132, 55);
            this.addItemBtn.TabIndex = 55;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_total.ForeColor = System.Drawing.Color.White;
            this.txt_total.Location = new System.Drawing.Point(389, 632);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(60, 25);
            this.txt_total.TabIndex = 54;
            this.txt_total.Text = "--------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 632);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Total:";
            // 
            // orderView
            // 
            this.orderView.AllowUserToAddRows = false;
            this.orderView.AllowUserToDeleteRows = false;
            this.orderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Impact", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderProductID,
            this.Column7,
            this.Column8,
            this.orderPrice,
            this.orderQty});
            this.orderView.Location = new System.Drawing.Point(30, 417);
            this.orderView.Margin = new System.Windows.Forms.Padding(4);
            this.orderView.Name = "orderView";
            this.orderView.ReadOnly = true;
            this.orderView.RowTemplate.Height = 24;
            this.orderView.Size = new System.Drawing.Size(447, 203);
            this.orderView.TabIndex = 52;
            // 
            // orderProductID
            // 
            this.orderProductID.HeaderText = "Product ID";
            this.orderProductID.Name = "orderProductID";
            this.orderProductID.ReadOnly = true;
            this.orderProductID.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Model";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
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
            this.orderQty.ReadOnly = true;
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_qty.Location = new System.Drawing.Point(220, 275);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(180, 32);
            this.txt_qty.TabIndex = 37;
            this.txt_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // purchaseMenu
            // 
            this.purchaseMenu.Interval = 1;
            this.purchaseMenu.Tick += new System.EventHandler(this.purchaseMenu_Tick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SDP.Product);
            // 
            // ReOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.printExcel);
            this.Controls.Add(this.reOrderTitle);
            this.Controls.Add(this.reorderview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.txt_reorderLevel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReOrderItem";
            this.Text = "ReOrderItem";
            ((System.ComponentModel.ISupportInitialize)(this.reorderview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAccountMenu)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_reorderLevel;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView reorderview;
        private System.Windows.Forms.Label reOrderTitle;
        private FontAwesome.Sharp.IconButton printExcel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox closeAccountMenu;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private FontAwesome.Sharp.IconButton createBtn;
        private FontAwesome.Sharp.IconButton clearBtn;
        private FontAwesome.Sharp.IconButton addItemBtn;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.Label IDText;
        private System.Windows.Forms.Timer purchaseMenu;
        private System.Windows.Forms.Label txt_productPrice;
        private System.Windows.Forms.Label txt_productModel;
        private System.Windows.Forms.Label txt_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQty;
    }
}