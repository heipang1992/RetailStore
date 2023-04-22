namespace SDP
{
    partial class SalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            this.billBtn = new FontAwesome.Sharp.IconButton();
            this.deliveryBtn = new FontAwesome.Sharp.IconButton();
            this.deliverPanel = new System.Windows.Forms.Panel();
            this.deliverySText = new System.Windows.Forms.ComboBox();
            this.deliverySLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeText = new System.Windows.Forms.DateTimePicker();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.remarkText = new System.Windows.Forms.TextBox();
            this.castText = new System.Windows.Forms.TextBox();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.finishBtn = new FontAwesome.Sharp.IconButton();
            this.changeText = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.chargeLabel = new System.Windows.Forms.Label();
            this.castLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.installationBox = new System.Windows.Forms.CheckBox();
            this.deliverPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.White;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.billBtn.IconColor = System.Drawing.Color.Black;
            this.billBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.billBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billBtn.Location = new System.Drawing.Point(31, 42);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(178, 59);
            this.billBtn.TabIndex = 0;
            this.billBtn.Text = "Billing";
            this.billBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // deliveryBtn
            // 
            this.deliveryBtn.BackColor = System.Drawing.Color.White;
            this.deliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliveryBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryBtn.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.deliveryBtn.IconColor = System.Drawing.Color.Black;
            this.deliveryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deliveryBtn.Location = new System.Drawing.Point(231, 42);
            this.deliveryBtn.Name = "deliveryBtn";
            this.deliveryBtn.Size = new System.Drawing.Size(185, 59);
            this.deliveryBtn.TabIndex = 1;
            this.deliveryBtn.Text = "Delivery";
            this.deliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deliveryBtn.UseVisualStyleBackColor = false;
            this.deliveryBtn.Click += new System.EventHandler(this.deliveryBtn_Click);
            // 
            // deliverPanel
            // 
            this.deliverPanel.Controls.Add(this.installationBox);
            this.deliverPanel.Controls.Add(this.deliverySText);
            this.deliverPanel.Controls.Add(this.deliverySLabel);
            this.deliverPanel.Controls.Add(this.DeliveryTimeText);
            this.deliverPanel.Controls.Add(this.deliveryTimeLabel);
            this.deliverPanel.Controls.Add(this.label1);
            this.deliverPanel.Controls.Add(this.addressText);
            this.deliverPanel.Controls.Add(this.phoneText);
            this.deliverPanel.Controls.Add(this.nameText);
            this.deliverPanel.Controls.Add(this.addressLabel);
            this.deliverPanel.Controls.Add(this.phoneLabel);
            this.deliverPanel.Controls.Add(this.nameLabel);
            this.deliverPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deliverPanel.Location = new System.Drawing.Point(0, 0);
            this.deliverPanel.Name = "deliverPanel";
            this.deliverPanel.Size = new System.Drawing.Size(439, 423);
            this.deliverPanel.TabIndex = 2;
            this.deliverPanel.Visible = false;
            // 
            // deliverySText
            // 
            this.deliverySText.FormattingEnabled = true;
            this.deliverySText.Items.AddRange(new object[] {
            "Morning (9:00am – 12:00pm)",
            "Afternoon (1:00pm – 5:00pm)",
            "Evening (6:00pm – 10:00pm)"});
            this.deliverySText.Location = new System.Drawing.Point(230, 256);
            this.deliverySText.Name = "deliverySText";
            this.deliverySText.Size = new System.Drawing.Size(185, 23);
            this.deliverySText.TabIndex = 10;
            // 
            // deliverySLabel
            // 
            this.deliverySLabel.AutoSize = true;
            this.deliverySLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverySLabel.ForeColor = System.Drawing.Color.White;
            this.deliverySLabel.Location = new System.Drawing.Point(25, 254);
            this.deliverySLabel.Name = "deliverySLabel";
            this.deliverySLabel.Size = new System.Drawing.Size(149, 25);
            this.deliverySLabel.TabIndex = 9;
            this.deliverySLabel.Text = "Delivery Session:";
            // 
            // DeliveryTimeText
            // 
            this.DeliveryTimeText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryTimeText.Location = new System.Drawing.Point(30, 333);
            this.DeliveryTimeText.Name = "DeliveryTimeText";
            this.DeliveryTimeText.Size = new System.Drawing.Size(385, 32);
            this.DeliveryTimeText.TabIndex = 8;
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTimeLabel.ForeColor = System.Drawing.Color.White;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(25, 296);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(123, 25);
            this.deliveryTimeLabel.TabIndex = 7;
            this.deliveryTimeLabel.Text = "Delivery Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Hint: Address Line, Flat, Street";
            // 
            // addressText
            // 
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressText.Location = new System.Drawing.Point(30, 149);
            this.addressText.Multiline = true;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(385, 59);
            this.addressText.TabIndex = 5;
            // 
            // phoneText
            // 
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneText.Location = new System.Drawing.Point(230, 68);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(185, 25);
            this.phoneText.TabIndex = 4;
            this.phoneText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneText_KeyDown);
            // 
            // nameText
            // 
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Location = new System.Drawing.Point(230, 20);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(185, 25);
            this.nameText.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(25, 112);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 25);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(25, 68);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(133, 25);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(25, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Customer Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pricePanel);
            this.panel2.Controls.Add(this.deliverPanel);
            this.panel2.Location = new System.Drawing.Point(1, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 775);
            this.panel2.TabIndex = 3;
            // 
            // pricePanel
            // 
            this.pricePanel.Controls.Add(this.remarkText);
            this.pricePanel.Controls.Add(this.castText);
            this.pricePanel.Controls.Add(this.remarkLabel);
            this.pricePanel.Controls.Add(this.cancelBtn);
            this.pricePanel.Controls.Add(this.finishBtn);
            this.pricePanel.Controls.Add(this.changeText);
            this.pricePanel.Controls.Add(this.totalText);
            this.pricePanel.Controls.Add(this.chargeLabel);
            this.pricePanel.Controls.Add(this.castLabel);
            this.pricePanel.Controls.Add(this.totalLabel);
            this.pricePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pricePanel.Location = new System.Drawing.Point(0, 423);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(439, 317);
            this.pricePanel.TabIndex = 3;
            // 
            // remarkText
            // 
            this.remarkText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remarkText.Location = new System.Drawing.Point(30, 179);
            this.remarkText.Multiline = true;
            this.remarkText.Name = "remarkText";
            this.remarkText.Size = new System.Drawing.Size(385, 59);
            this.remarkText.TabIndex = 12;
            // 
            // castText
            // 
            this.castText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.castText.Location = new System.Drawing.Point(265, 65);
            this.castText.Name = "castText";
            this.castText.Size = new System.Drawing.Size(111, 25);
            this.castText.TabIndex = 13;
            this.castText.TextChanged += new System.EventHandler(this.castText_TextChanged);
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkLabel.ForeColor = System.Drawing.Color.White;
            this.remarkLabel.Location = new System.Drawing.Point(25, 142);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(88, 25);
            this.remarkLabel.TabIndex = 11;
            this.remarkLabel.Text = "Remarks:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelBtn.IconColor = System.Drawing.Color.Black;
            this.cancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(59, 261);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(134, 44);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.BackColor = System.Drawing.Color.White;
            this.finishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.finishBtn.IconColor = System.Drawing.Color.Black;
            this.finishBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.finishBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finishBtn.Location = new System.Drawing.Point(244, 261);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(134, 44);
            this.finishBtn.TabIndex = 4;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // changeText
            // 
            this.changeText.AutoSize = true;
            this.changeText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeText.ForeColor = System.Drawing.Color.White;
            this.changeText.Location = new System.Drawing.Point(286, 106);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(54, 25);
            this.changeText.TabIndex = 11;
            this.changeText.Text = "-------";
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.ForeColor = System.Drawing.Color.White;
            this.totalText.Location = new System.Drawing.Point(286, 24);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(54, 25);
            this.totalText.TabIndex = 10;
            this.totalText.Text = "-------";
            // 
            // chargeLabel
            // 
            this.chargeLabel.AutoSize = true;
            this.chargeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargeLabel.ForeColor = System.Drawing.Color.White;
            this.chargeLabel.Location = new System.Drawing.Point(168, 106);
            this.chargeLabel.Name = "chargeLabel";
            this.chargeLabel.Size = new System.Drawing.Size(77, 25);
            this.chargeLabel.TabIndex = 8;
            this.chargeLabel.Text = "Change:";
            // 
            // castLabel
            // 
            this.castLabel.AutoSize = true;
            this.castLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castLabel.ForeColor = System.Drawing.Color.White;
            this.castLabel.Location = new System.Drawing.Point(168, 65);
            this.castLabel.Name = "castLabel";
            this.castLabel.Size = new System.Drawing.Size(52, 25);
            this.castLabel.TabIndex = 7;
            this.castLabel.Text = "Cast:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(168, 24);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 25);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // installationBox
            // 
            this.installationBox.AutoSize = true;
            this.installationBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installationBox.ForeColor = System.Drawing.Color.White;
            this.installationBox.Location = new System.Drawing.Point(29, 381);
            this.installationBox.Name = "installationBox";
            this.installationBox.Size = new System.Drawing.Size(191, 29);
            this.installationBox.TabIndex = 12;
            this.installationBox.Text = "Installation Service";
            this.installationBox.UseVisualStyleBackColor = true;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(440, 863);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deliveryBtn);
            this.Controls.Add(this.billBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOrder";
            this.deliverPanel.ResumeLayout(false);
            this.deliverPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton billBtn;
        private FontAwesome.Sharp.IconButton deliveryBtn;
        private System.Windows.Forms.Panel deliverPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pricePanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label castLabel;
        private FontAwesome.Sharp.IconButton finishBtn;
        private System.Windows.Forms.Label changeText;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Label chargeLabel;
        private FontAwesome.Sharp.IconButton cancelBtn;
        private System.Windows.Forms.TextBox castText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DeliveryTimeText;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox deliverySText;
        private System.Windows.Forms.Label deliverySLabel;
        private System.Windows.Forms.TextBox remarkText;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.CheckBox installationBox;
    }
}