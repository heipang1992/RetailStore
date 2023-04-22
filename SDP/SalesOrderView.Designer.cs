namespace SDP
{
    partial class SalesOrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salesOrderViewTitle = new System.Windows.Forms.Label();
            this.salesView = new System.Windows.Forms.DataGridView();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesOrderViewTitle
            // 
            this.salesOrderViewTitle.AutoSize = true;
            this.salesOrderViewTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOrderViewTitle.ForeColor = System.Drawing.Color.White;
            this.salesOrderViewTitle.Location = new System.Drawing.Point(25, 32);
            this.salesOrderViewTitle.Name = "salesOrderViewTitle";
            this.salesOrderViewTitle.Size = new System.Drawing.Size(309, 48);
            this.salesOrderViewTitle.TabIndex = 30;
            this.salesOrderViewTitle.Text = "List All The Orders";
            // 
            // salesView
            // 
            this.salesView.AllowUserToAddRows = false;
            this.salesView.AllowUserToDeleteRows = false;
            this.salesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.customerNumber,
            this.staffName,
            this.totalPrice,
            this.charged,
            this.date,
            this.orderStatus,
            this.remark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesView.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesView.Location = new System.Drawing.Point(33, 168);
            this.salesView.Name = "salesView";
            this.salesView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salesView.RowTemplate.Height = 27;
            this.salesView.Size = new System.Drawing.Size(1312, 456);
            this.salesView.TabIndex = 31;
            this.salesView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesView_CellContentDoubleClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.Black;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 30;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(1179, 100);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.searchBtn.Size = new System.Drawing.Size(166, 55);
            this.searchBtn.TabIndex = 32;
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
            this.searchLabel.Location = new System.Drawing.Point(32, 124);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(148, 25);
            this.searchLabel.TabIndex = 34;
            this.searchLabel.Text = "Order ID / Phone:";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(245, 121);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(180, 32);
            this.searchText.TabIndex = 33;
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Order ID";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // customerNumber
            // 
            this.customerNumber.HeaderText = "Customer Number";
            this.customerNumber.Name = "customerNumber";
            this.customerNumber.ReadOnly = true;
            // 
            // staffName
            // 
            this.staffName.HeaderText = "Staff Name";
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // charged
            // 
            this.charged.HeaderText = "Charged";
            this.charged.Name = "charged";
            this.charged.ReadOnly = true;
            this.charged.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "Order Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Status";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // SalesOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.salesView);
            this.Controls.Add(this.salesOrderViewTitle);
            this.Name = "SalesOrderView";
            this.Text = "SalesOrderView";
            ((System.ComponentModel.ISupportInitialize)(this.salesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salesOrderViewTitle;
        private System.Windows.Forms.DataGridView salesView;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn charged;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}