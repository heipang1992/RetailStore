namespace SDP
{
    partial class PurchaseListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listview = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_purchaseid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listview)).BeginInit();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.AllowUserToAddRows = false;
            this.listview.AllowUserToDeleteRows = false;
            this.listview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productModel,
            this.productPrice,
            this.qty});
            this.listview.Location = new System.Drawing.Point(33, 112);
            this.listview.Margin = new System.Windows.Forms.Padding(4);
            this.listview.Name = "listview";
            this.listview.ReadOnly = true;
            this.listview.Size = new System.Drawing.Size(599, 281);
            this.listview.TabIndex = 0;
            this.listview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listview_CellContentClick);
            // 
            // productID
            // 
            this.productID.HeaderText = "ProductID";
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
            // productModel
            // 
            this.productModel.HeaderText = "Model";
            this.productModel.Name = "productModel";
            this.productModel.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Impact", 24F);
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(25, 32);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(216, 48);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Purchase ID";
            this.idLabel.Click += new System.EventHandler(this.txt_purchaseid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Price:";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.White;
            this.txt_total.Location = new System.Drawing.Point(278, 406);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(54, 25);
            this.txt_total.TabIndex = 3;
            this.txt_total.Text = "-------";
            // 
            // txt_purchaseid
            // 
            this.txt_purchaseid.AutoSize = true;
            this.txt_purchaseid.Font = new System.Drawing.Font("Impact", 24F);
            this.txt_purchaseid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(88)))), ((int)(((byte)(87)))));
            this.txt_purchaseid.Location = new System.Drawing.Point(325, 32);
            this.txt_purchaseid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_purchaseid.Name = "txt_purchaseid";
            this.txt_purchaseid.Size = new System.Drawing.Size(129, 48);
            this.txt_purchaseid.TabIndex = 4;
            this.txt_purchaseid.Text = "#0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Create Date:";
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.ForeColor = System.Drawing.Color.White;
            this.txt_date.Location = new System.Drawing.Point(278, 445);
            this.txt_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(54, 25);
            this.txt_date.TabIndex = 6;
            this.txt_date.Text = "-------";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.White;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(495, 35);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(137, 45);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PurchaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(660, 502);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_purchaseid);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.listview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseListForm";
            this.Load += new System.EventHandler(this.PurchaseListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listview;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label txt_purchaseid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
    }
}