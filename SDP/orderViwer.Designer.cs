namespace SDP
{
    partial class orderViwer
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
            this.orderViewerTitle = new System.Windows.Forms.Label();
            this.orderIDTag = new System.Windows.Forms.Label();
            this.orderProducts = new System.Windows.Forms.DataGridView();
            this.orderStatus = new System.Windows.Forms.Label();
            this.picPanel = new System.Windows.Forms.Panel();
            this.picAccess = new System.Windows.Forms.Label();
            this.picName = new System.Windows.Forms.Label();
            this.picLabel = new System.Windows.Forms.Label();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderTotal = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.orderTimeText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderCreateText = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cusPhoneText = new System.Windows.Forms.Label();
            this.cusPhone = new System.Windows.Forms.Label();
            this.cusNameText = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.customerTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remarkText = new System.Windows.Forms.Label();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.streetText = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.flatText = new System.Windows.Forms.Label();
            this.flatLabel = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.orderDefectProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDefect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_return = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderChargeLabel = new System.Windows.Forms.Label();
            this.orderCharge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderProducts)).BeginInit();
            this.picPanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDefectProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // orderViewerTitle
            // 
            this.orderViewerTitle.AutoSize = true;
            this.orderViewerTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderViewerTitle.ForeColor = System.Drawing.Color.White;
            this.orderViewerTitle.Location = new System.Drawing.Point(25, 32);
            this.orderViewerTitle.Name = "orderViewerTitle";
            this.orderViewerTitle.Size = new System.Drawing.Size(266, 48);
            this.orderViewerTitle.TabIndex = 29;
            this.orderViewerTitle.Text = "ORDER NUMBER";
            this.orderViewerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderIDTag
            // 
            this.orderIDTag.AutoSize = true;
            this.orderIDTag.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(88)))), ((int)(((byte)(87)))));
            this.orderIDTag.Location = new System.Drawing.Point(375, 32);
            this.orderIDTag.Name = "orderIDTag";
            this.orderIDTag.Size = new System.Drawing.Size(129, 48);
            this.orderIDTag.TabIndex = 30;
            this.orderIDTag.Text = "#0000";
            this.orderIDTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderProducts
            // 
            this.orderProducts.AllowUserToAddRows = false;
            this.orderProducts.AllowUserToDeleteRows = false;
            this.orderProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.qty,
            this.price,
            this.total});
            this.orderProducts.Location = new System.Drawing.Point(33, 112);
            this.orderProducts.Name = "orderProducts";
            this.orderProducts.ReadOnly = true;
            this.orderProducts.RowTemplate.Height = 27;
            this.orderProducts.Size = new System.Drawing.Size(863, 143);
            this.orderProducts.TabIndex = 31;
            this.orderProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderProducts_CellDoubleClick);
            // 
            // orderStatus
            // 
            this.orderStatus.AutoSize = true;
            this.orderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            this.orderStatus.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.orderStatus.Location = new System.Drawing.Point(510, 37);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(172, 41);
            this.orderStatus.TabIndex = 33;
            this.orderStatus.Text = "Processing";
            this.orderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPanel
            // 
            this.picPanel.Controls.Add(this.picAccess);
            this.picPanel.Controls.Add(this.picName);
            this.picPanel.Controls.Add(this.picLabel);
            this.picPanel.Location = new System.Drawing.Point(926, 112);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(475, 102);
            this.picPanel.TabIndex = 34;
            // 
            // picAccess
            // 
            this.picAccess.AutoSize = true;
            this.picAccess.Font = new System.Drawing.Font("Impact", 14F);
            this.picAccess.ForeColor = System.Drawing.Color.White;
            this.picAccess.Location = new System.Drawing.Point(273, 54);
            this.picAccess.Name = "picAccess";
            this.picAccess.Size = new System.Drawing.Size(62, 29);
            this.picAccess.TabIndex = 37;
            this.picAccess.Text = "-------";
            this.picAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picName
            // 
            this.picName.AutoSize = true;
            this.picName.Font = new System.Drawing.Font("Impact", 14F);
            this.picName.ForeColor = System.Drawing.Color.White;
            this.picName.Location = new System.Drawing.Point(5, 54);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(62, 29);
            this.picName.TabIndex = 36;
            this.picName.Text = "-------";
            this.picName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLabel
            // 
            this.picLabel.AutoSize = true;
            this.picLabel.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picLabel.ForeColor = System.Drawing.Color.White;
            this.picLabel.Location = new System.Drawing.Point(3, 3);
            this.picLabel.Name = "picLabel";
            this.picLabel.Size = new System.Drawing.Size(160, 37);
            this.picLabel.TabIndex = 35;
            this.picLabel.Text = "PIC Details";
            this.picLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.orderCharge);
            this.orderPanel.Controls.Add(this.orderChargeLabel);
            this.orderPanel.Controls.Add(this.orderTotal);
            this.orderPanel.Controls.Add(this.orderTotalLabel);
            this.orderPanel.Controls.Add(this.orderTimeText);
            this.orderPanel.Controls.Add(this.label2);
            this.orderPanel.Controls.Add(this.orderCreateText);
            this.orderPanel.Controls.Add(this.orderDateLabel);
            this.orderPanel.Controls.Add(this.orderLabel);
            this.orderPanel.Location = new System.Drawing.Point(926, 236);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(475, 231);
            this.orderPanel.TabIndex = 38;
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Font = new System.Drawing.Font("Impact", 14F);
            this.orderTotal.ForeColor = System.Drawing.Color.White;
            this.orderTotal.Location = new System.Drawing.Point(305, 149);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(62, 29);
            this.orderTotal.TabIndex = 41;
            this.orderTotal.Text = "-------";
            this.orderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.orderTotalLabel.ForeColor = System.Drawing.Color.White;
            this.orderTotalLabel.Location = new System.Drawing.Point(4, 149);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(66, 29);
            this.orderTotalLabel.TabIndex = 40;
            this.orderTotalLabel.Text = "Total:";
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderTimeText
            // 
            this.orderTimeText.AutoSize = true;
            this.orderTimeText.Font = new System.Drawing.Font("Impact", 14F);
            this.orderTimeText.ForeColor = System.Drawing.Color.White;
            this.orderTimeText.Location = new System.Drawing.Point(305, 102);
            this.orderTimeText.Name = "orderTimeText";
            this.orderTimeText.Size = new System.Drawing.Size(62, 29);
            this.orderTimeText.TabIndex = 39;
            this.orderTimeText.Text = "-------";
            this.orderTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Order Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderCreateText
            // 
            this.orderCreateText.AutoSize = true;
            this.orderCreateText.Font = new System.Drawing.Font("Impact", 14F);
            this.orderCreateText.ForeColor = System.Drawing.Color.White;
            this.orderCreateText.Location = new System.Drawing.Point(305, 55);
            this.orderCreateText.Name = "orderCreateText";
            this.orderCreateText.Size = new System.Drawing.Size(62, 29);
            this.orderCreateText.TabIndex = 37;
            this.orderCreateText.Text = "-------";
            this.orderCreateText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.orderDateLabel.ForeColor = System.Drawing.Color.White;
            this.orderDateLabel.Location = new System.Drawing.Point(4, 55);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(154, 29);
            this.orderDateLabel.TabIndex = 36;
            this.orderDateLabel.Text = "Order Created:";
            this.orderDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.White;
            this.orderLabel.Location = new System.Drawing.Point(3, 3);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(222, 37);
            this.orderLabel.TabIndex = 35;
            this.orderLabel.Text = "Order Summary";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cusPhoneText);
            this.panel1.Controls.Add(this.cusPhone);
            this.panel1.Controls.Add(this.cusNameText);
            this.panel1.Controls.Add(this.cusName);
            this.panel1.Controls.Add(this.customerTitle);
            this.panel1.Location = new System.Drawing.Point(926, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 154);
            this.panel1.TabIndex = 42;
            // 
            // cusPhoneText
            // 
            this.cusPhoneText.AutoSize = true;
            this.cusPhoneText.Font = new System.Drawing.Font("Impact", 14F);
            this.cusPhoneText.ForeColor = System.Drawing.Color.White;
            this.cusPhoneText.Location = new System.Drawing.Point(291, 102);
            this.cusPhoneText.Name = "cusPhoneText";
            this.cusPhoneText.Size = new System.Drawing.Size(62, 29);
            this.cusPhoneText.TabIndex = 39;
            this.cusPhoneText.Text = "-------";
            this.cusPhoneText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cusPhone
            // 
            this.cusPhone.AutoSize = true;
            this.cusPhone.Font = new System.Drawing.Font("Impact", 14F);
            this.cusPhone.ForeColor = System.Drawing.Color.White;
            this.cusPhone.Location = new System.Drawing.Point(4, 102);
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(162, 29);
            this.cusPhone.TabIndex = 38;
            this.cusPhone.Text = "Phone Number:";
            this.cusPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cusNameText
            // 
            this.cusNameText.AutoSize = true;
            this.cusNameText.Font = new System.Drawing.Font("Impact", 14F);
            this.cusNameText.ForeColor = System.Drawing.Color.White;
            this.cusNameText.Location = new System.Drawing.Point(291, 55);
            this.cusNameText.Name = "cusNameText";
            this.cusNameText.Size = new System.Drawing.Size(62, 29);
            this.cusNameText.TabIndex = 37;
            this.cusNameText.Text = "-------";
            this.cusNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.Font = new System.Drawing.Font("Impact", 14F);
            this.cusName.ForeColor = System.Drawing.Color.White;
            this.cusName.Location = new System.Drawing.Point(4, 55);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(174, 29);
            this.cusName.TabIndex = 36;
            this.cusName.Text = "Customer Name:";
            this.cusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerTitle
            // 
            this.customerTitle.AutoSize = true;
            this.customerTitle.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTitle.ForeColor = System.Drawing.Color.White;
            this.customerTitle.Location = new System.Drawing.Point(3, 3);
            this.customerTitle.Name = "customerTitle";
            this.customerTitle.Size = new System.Drawing.Size(244, 37);
            this.customerTitle.TabIndex = 35;
            this.customerTitle.Text = "Customer Details";
            this.customerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remarkText);
            this.panel2.Controls.Add(this.remarkLabel);
            this.panel2.Controls.Add(this.streetText);
            this.panel2.Controls.Add(this.streetLabel);
            this.panel2.Controls.Add(this.flatText);
            this.panel2.Controls.Add(this.flatLabel);
            this.panel2.Controls.Add(this.addressText);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(33, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 277);
            this.panel2.TabIndex = 43;
            // 
            // remarkText
            // 
            this.remarkText.AutoSize = true;
            this.remarkText.Font = new System.Drawing.Font("Impact", 12F);
            this.remarkText.ForeColor = System.Drawing.Color.Gainsboro;
            this.remarkText.Location = new System.Drawing.Point(5, 237);
            this.remarkText.Name = "remarkText";
            this.remarkText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.remarkText.Size = new System.Drawing.Size(54, 25);
            this.remarkText.TabIndex = 43;
            this.remarkText.Text = "-------";
            this.remarkText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.remarkLabel.ForeColor = System.Drawing.Color.White;
            this.remarkLabel.Location = new System.Drawing.Point(5, 195);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(94, 29);
            this.remarkLabel.TabIndex = 42;
            this.remarkLabel.Text = "Remark:";
            this.remarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetText
            // 
            this.streetText.AutoSize = true;
            this.streetText.Font = new System.Drawing.Font("Impact", 14F);
            this.streetText.ForeColor = System.Drawing.Color.White;
            this.streetText.Location = new System.Drawing.Point(243, 149);
            this.streetText.Name = "streetText";
            this.streetText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.streetText.Size = new System.Drawing.Size(62, 29);
            this.streetText.TabIndex = 41;
            this.streetText.Text = "-------";
            this.streetText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.streetLabel.ForeColor = System.Drawing.Color.White;
            this.streetLabel.Location = new System.Drawing.Point(5, 149);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(77, 29);
            this.streetLabel.TabIndex = 40;
            this.streetLabel.Text = "Street:";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flatText
            // 
            this.flatText.AutoSize = true;
            this.flatText.Font = new System.Drawing.Font("Impact", 14F);
            this.flatText.ForeColor = System.Drawing.Color.White;
            this.flatText.Location = new System.Drawing.Point(243, 102);
            this.flatText.Name = "flatText";
            this.flatText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flatText.Size = new System.Drawing.Size(62, 29);
            this.flatText.TabIndex = 39;
            this.flatText.Text = "-------";
            this.flatText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.flatLabel.ForeColor = System.Drawing.Color.White;
            this.flatLabel.Location = new System.Drawing.Point(4, 102);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(53, 29);
            this.flatLabel.TabIndex = 38;
            this.flatLabel.Text = "Flat:";
            this.flatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressText
            // 
            this.addressText.AutoSize = true;
            this.addressText.Font = new System.Drawing.Font("Impact", 14F);
            this.addressText.ForeColor = System.Drawing.Color.White;
            this.addressText.Location = new System.Drawing.Point(243, 55);
            this.addressText.Name = "addressText";
            this.addressText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressText.Size = new System.Drawing.Size(62, 29);
            this.addressText.TabIndex = 37;
            this.addressText.Text = "-------";
            this.addressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(4, 55);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(141, 29);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "Address Line:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 37);
            this.label6.TabIndex = 35;
            this.label6.Text = "Deilvery And Other";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.cancelBtn.IconColor = System.Drawing.Color.Black;
            this.cancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBtn.IconSize = 30;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(1230, 38);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Size = new System.Drawing.Size(165, 50);
            this.cancelBtn.TabIndex = 44;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // orderDefectProduct
            // 
            this.orderDefectProduct.AllowUserToAddRows = false;
            this.orderDefectProduct.AllowUserToDeleteRows = false;
            this.orderDefectProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDefectProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDefectProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDefectProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDefect,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.is_return});
            this.orderDefectProduct.Location = new System.Drawing.Point(33, 309);
            this.orderDefectProduct.Name = "orderDefectProduct";
            this.orderDefectProduct.RowTemplate.Height = 27;
            this.orderDefectProduct.Size = new System.Drawing.Size(863, 143);
            this.orderDefectProduct.TabIndex = 45;
            this.orderDefectProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDefectProduct_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Defect Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Visible = false;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // productIDDefect
            // 
            this.productIDDefect.HeaderText = "ProductID";
            this.productIDDefect.Name = "productIDDefect";
            this.productIDDefect.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // is_return
            // 
            this.is_return.HeaderText = "Returned";
            this.is_return.Name = "is_return";
            this.is_return.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_return.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // orderChargeLabel
            // 
            this.orderChargeLabel.AutoSize = true;
            this.orderChargeLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.orderChargeLabel.ForeColor = System.Drawing.Color.White;
            this.orderChargeLabel.Location = new System.Drawing.Point(5, 193);
            this.orderChargeLabel.Name = "orderChargeLabel";
            this.orderChargeLabel.Size = new System.Drawing.Size(105, 29);
            this.orderChargeLabel.TabIndex = 42;
            this.orderChargeLabel.Text = "Charged: ";
            this.orderChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderCharge
            // 
            this.orderCharge.AutoSize = true;
            this.orderCharge.Font = new System.Drawing.Font("Impact", 14F);
            this.orderCharge.ForeColor = System.Drawing.Color.White;
            this.orderCharge.Location = new System.Drawing.Point(305, 193);
            this.orderCharge.Name = "orderCharge";
            this.orderCharge.Size = new System.Drawing.Size(62, 29);
            this.orderCharge.TabIndex = 43;
            this.orderCharge.Text = "-------";
            this.orderCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1413, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDefectProduct);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.picPanel);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.orderProducts);
            this.Controls.Add(this.orderIDTag);
            this.Controls.Add(this.orderViewerTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1431, 800);
            this.Name = "orderViwer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderViwer";
            this.Load += new System.EventHandler(this.orderViwer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderProducts)).EndInit();
            this.picPanel.ResumeLayout(false);
            this.picPanel.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDefectProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderViewerTitle;
        private System.Windows.Forms.Label orderIDTag;
        private System.Windows.Forms.DataGridView orderProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label orderStatus;
        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.Label picAccess;
        private System.Windows.Forms.Label picName;
        private System.Windows.Forms.Label picLabel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label orderCreateText;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label orderTimeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cusPhoneText;
        private System.Windows.Forms.Label cusPhone;
        private System.Windows.Forms.Label cusNameText;
        private System.Windows.Forms.Label cusName;
        private System.Windows.Forms.Label customerTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.Label streetText;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label flatText;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.Label addressText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label remarkText;
        private FontAwesome.Sharp.IconButton cancelBtn;
        private System.Windows.Forms.DataGridView orderDefectProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDefect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_return;
        private System.Windows.Forms.Label orderCharge;
        private System.Windows.Forms.Label orderChargeLabel;
    }
}