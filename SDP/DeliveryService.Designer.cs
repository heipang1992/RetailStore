namespace SDP
{
    partial class DeliveryService
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Delivery = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deliveryTitle = new System.Windows.Forms.Label();
            this.printExcel = new FontAwesome.Sharp.IconButton();
            this.DsaveBtn = new FontAwesome.Sharp.IconButton();
            this.deliver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vehicle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isDelivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveryNoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryNoteBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryNoteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryNoteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryNoteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vanBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryNoteBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Delivery)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 32);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            // 
            // dataGridView_Delivery
            // 
            this.dataGridView_Delivery.AllowUserToAddRows = false;
            this.dataGridView_Delivery.AllowUserToDeleteRows = false;
            this.dataGridView_Delivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Delivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Delivery.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Delivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Delivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliver_id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.staffName,
            this.vehicle,
            this.isDelivered});
            this.dataGridView_Delivery.Location = new System.Drawing.Point(33, 170);
            this.dataGridView_Delivery.Name = "dataGridView_Delivery";
            this.dataGridView_Delivery.RowTemplate.Height = 27;
            this.dataGridView_Delivery.Size = new System.Drawing.Size(1312, 441);
            this.dataGridView_Delivery.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(535, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(317, 32);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(487, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 47);
            this.panel1.TabIndex = 13;
            // 
            // deliveryTitle
            // 
            this.deliveryTitle.AutoSize = true;
            this.deliveryTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTitle.ForeColor = System.Drawing.Color.White;
            this.deliveryTitle.Location = new System.Drawing.Point(25, 32);
            this.deliveryTitle.Name = "deliveryTitle";
            this.deliveryTitle.Size = new System.Drawing.Size(387, 48);
            this.deliveryTitle.TabIndex = 18;
            this.deliveryTitle.Text = "DELIVERY MANAGEMENT";
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
            this.printExcel.Location = new System.Drawing.Point(1141, 110);
            this.printExcel.Margin = new System.Windows.Forms.Padding(10);
            this.printExcel.Name = "printExcel";
            this.printExcel.Padding = new System.Windows.Forms.Padding(5);
            this.printExcel.Size = new System.Drawing.Size(204, 50);
            this.printExcel.TabIndex = 20;
            this.printExcel.Text = "Print Excel";
            this.printExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printExcel.UseVisualStyleBackColor = false;
            this.printExcel.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.DsaveBtn.Location = new System.Drawing.Point(986, 110);
            this.DsaveBtn.Name = "DsaveBtn";
            this.DsaveBtn.Padding = new System.Windows.Forms.Padding(5);
            this.DsaveBtn.Size = new System.Drawing.Size(142, 50);
            this.DsaveBtn.TabIndex = 21;
            this.DsaveBtn.Text = "Save";
            this.DsaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DsaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DsaveBtn.UseVisualStyleBackColor = false;
            this.DsaveBtn.Click += new System.EventHandler(this.DsaveBtn_Click);
            // 
            // deliver_id
            // 
            this.deliver_id.HeaderText = "Delivery No";
            this.deliver_id.Name = "deliver_id";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Session";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone";
            this.Column6.Name = "Column6";
            // 
            // staffName
            // 
            this.staffName.HeaderText = "Staff";
            this.staffName.Items.AddRange(new object[] {
            "Asher",
            "Dung",
            "Peter",
            "Pang",
            "Null"});
            this.staffName.Name = "staffName";
            this.staffName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vehicle
            // 
            this.vehicle.HeaderText = "Vehicle";
            this.vehicle.Items.AddRange(new object[] {
            "VV2751",
            "XM8851",
            "VTC40",
            "Null"});
            this.vehicle.Name = "vehicle";
            // 
            // isDelivered
            // 
            this.isDelivered.HeaderText = "Delivered";
            this.isDelivered.Name = "isDelivered";
            // 
            // deliveryNoteBindingSource1
            // 
            this.deliveryNoteBindingSource1.DataSource = typeof(SDP.DeliveryNote);
            // 
            // deliveryNoteBindingSource5
            // 
            this.deliveryNoteBindingSource5.DataSource = typeof(SDP.DeliveryNote);
            // 
            // deliveryNoteBindingSource4
            // 
            this.deliveryNoteBindingSource4.DataSource = typeof(SDP.DeliveryNote);
            // 
            // deliveryNoteBindingSource3
            // 
            this.deliveryNoteBindingSource3.DataSource = typeof(SDP.DeliveryNote);
            // 
            // vanBindingSource4
            // 
            this.vanBindingSource4.DataSource = typeof(SDP.Van);
            // 
            // deliveryNoteBindingSource2
            // 
            this.deliveryNoteBindingSource2.DataSource = typeof(SDP.DeliveryNote);
            // 
            // vanBindingSource3
            // 
            this.vanBindingSource3.DataSource = typeof(SDP.Van);
            // 
            // deliveryNoteBindingSource
            // 
            this.deliveryNoteBindingSource.DataSource = typeof(SDP.DeliveryNote);
            // 
            // vanBindingSource
            // 
            this.vanBindingSource.DataSource = typeof(SDP.Van);
            // 
            // vanBindingSource1
            // 
            this.vanBindingSource1.DataSource = typeof(SDP.Van);
            // 
            // vanBindingSource2
            // 
            this.vanBindingSource2.DataSource = typeof(SDP.Van);
            // 
            // vanBindingSource5
            // 
            this.vanBindingSource5.DataSource = typeof(SDP.Van);
            // 
            // deliveryNoteBindingSource6
            // 
            this.deliveryNoteBindingSource6.DataSource = typeof(SDP.DeliveryNote);
            // 
            // DeliveryService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 633);
            this.Controls.Add(this.DsaveBtn);
            this.Controls.Add(this.printExcel);
            this.Controls.Add(this.deliveryTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Delivery);
            this.Name = "DeliveryService";
            this.Text = "Arrangement of Delivery Service";
            this.Load += new System.EventHandler(this.DeliveryService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Delivery)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryNoteBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource;
        private System.Windows.Forms.BindingSource vanBindingSource;
        private System.Windows.Forms.BindingSource vanBindingSource1;
        private System.Windows.Forms.BindingSource vanBindingSource3;
        private System.Windows.Forms.BindingSource vanBindingSource2;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource2;
        private System.Windows.Forms.BindingSource vanBindingSource4;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource3;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource4;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource5;
        private System.Windows.Forms.BindingSource vanBindingSource5;
        private System.Windows.Forms.DataGridView dataGridView_Delivery;
        private System.Windows.Forms.BindingSource deliveryNoteBindingSource6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label deliveryTitle;
        private FontAwesome.Sharp.IconButton printExcel;
        private FontAwesome.Sharp.IconButton DsaveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn staffName;
        private System.Windows.Forms.DataGridViewComboBoxColumn vehicle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDelivered;
    }
}