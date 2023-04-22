namespace SDP
{
    partial class SearchPurchaseForm
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
            this.purchaseview = new System.Windows.Forms.DataGridView();
            this.txt_SearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p_searchBtn = new FontAwesome.Sharp.IconButton();
            this.DsaveBtn = new FontAwesome.Sharp.IconButton();
            this.purchase_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approval = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.purchaseStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkGood = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isClaimed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseview)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseview
            // 
            this.purchaseview.AllowUserToAddRows = false;
            this.purchaseview.AllowUserToDeleteRows = false;
            this.purchaseview.AllowUserToOrderColumns = true;
            this.purchaseview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_id,
            this.Column2,
            this.totalPrice,
            this.approval,
            this.purchaseStatus,
            this.checkGood,
            this.remark,
            this.isClaimed});
            this.purchaseview.Location = new System.Drawing.Point(33, 164);
            this.purchaseview.Margin = new System.Windows.Forms.Padding(4);
            this.purchaseview.Name = "purchaseview";
            this.purchaseview.RowTemplate.Height = 24;
            this.purchaseview.Size = new System.Drawing.Size(1312, 445);
            this.purchaseview.TabIndex = 0;
            this.purchaseview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txt_SearchText
            // 
            this.txt_SearchText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchText.Location = new System.Drawing.Point(97, 111);
            this.txt_SearchText.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchText.Name = "txt_SearchText";
            this.txt_SearchText.Size = new System.Drawing.Size(197, 32);
            this.txt_SearchText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIST ALL THE PURCHASE ORDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
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
            this.p_searchBtn.Location = new System.Drawing.Point(1024, 96);
            this.p_searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.p_searchBtn.Name = "p_searchBtn";
            this.p_searchBtn.Padding = new System.Windows.Forms.Padding(5);
            this.p_searchBtn.Size = new System.Drawing.Size(166, 50);
            this.p_searchBtn.TabIndex = 35;
            this.p_searchBtn.Text = "Search";
            this.p_searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p_searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.p_searchBtn.UseVisualStyleBackColor = false;
            this.p_searchBtn.Click += new System.EventHandler(this.p_searchBtn_Click);
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
            this.DsaveBtn.Location = new System.Drawing.Point(1203, 96);
            this.DsaveBtn.Name = "DsaveBtn";
            this.DsaveBtn.Padding = new System.Windows.Forms.Padding(5);
            this.DsaveBtn.Size = new System.Drawing.Size(142, 50);
            this.DsaveBtn.TabIndex = 36;
            this.DsaveBtn.Text = "Save";
            this.DsaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DsaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DsaveBtn.UseVisualStyleBackColor = false;
            this.DsaveBtn.Click += new System.EventHandler(this.DsaveBtn_Click);
            // 
            // purchase_id
            // 
            this.purchase_id.FillWeight = 150F;
            this.purchase_id.HeaderText = "Purchase ID";
            this.purchase_id.Name = "purchase_id";
            this.purchase_id.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.FillWeight = 150F;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // approval
            // 
            this.approval.FillWeight = 150F;
            this.approval.HeaderText = "Approval";
            this.approval.Name = "approval";
            this.approval.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.approval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // purchaseStatus
            // 
            this.purchaseStatus.FillWeight = 150F;
            this.purchaseStatus.HeaderText = "Purchase Status";
            this.purchaseStatus.Name = "purchaseStatus";
            this.purchaseStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // checkGood
            // 
            this.checkGood.FillWeight = 150F;
            this.checkGood.HeaderText = "Check Received goods";
            this.checkGood.Name = "checkGood";
            this.checkGood.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkGood.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // remark
            // 
            this.remark.FillWeight = 150F;
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            // 
            // isClaimed
            // 
            this.isClaimed.HeaderText = "Claimed";
            this.isClaimed.Name = "isClaimed";
            this.isClaimed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isClaimed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isClaimed.Visible = false;
            // 
            // SearchPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 633);
            this.Controls.Add(this.DsaveBtn);
            this.Controls.Add(this.p_searchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SearchText);
            this.Controls.Add(this.purchaseview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchPurchaseForm";
            this.Text = "SearchPurchaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchaseview;
        private System.Windows.Forms.TextBox txt_SearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private FontAwesome.Sharp.IconButton p_searchBtn;
        private FontAwesome.Sharp.IconButton DsaveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approval;
        private System.Windows.Forms.DataGridViewCheckBoxColumn purchaseStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isClaimed;
    }
}