namespace SDP
{
    partial class StaticViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.deliveryTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salesOrder2 = new System.Windows.Forms.Label();
            this.salesOrderText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deliveryText2 = new System.Windows.Forms.Label();
            this.deliveryText = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.installationText2 = new System.Windows.Forms.Label();
            this.installationText = new System.Windows.Forms.Label();
            this.changeMode = new System.Windows.Forms.ComboBox();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.changeChartMode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryTitle
            // 
            this.deliveryTitle.AutoSize = true;
            this.deliveryTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTitle.ForeColor = System.Drawing.Color.White;
            this.deliveryTitle.Location = new System.Drawing.Point(25, 32);
            this.deliveryTitle.Name = "deliveryTitle";
            this.deliveryTitle.Size = new System.Drawing.Size(213, 48);
            this.deliveryTitle.TabIndex = 19;
            this.deliveryTitle.Text = "DASHBOARD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salesOrder2);
            this.groupBox1.Controls.Add(this.salesOrderText);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Orders";
            // 
            // salesOrder2
            // 
            this.salesOrder2.AutoSize = true;
            this.salesOrder2.Location = new System.Drawing.Point(21, 86);
            this.salesOrder2.Name = "salesOrder2";
            this.salesOrder2.Size = new System.Drawing.Size(48, 25);
            this.salesOrder2.TabIndex = 1;
            this.salesOrder2.Text = "------";
            // 
            // salesOrderText
            // 
            this.salesOrderText.AutoSize = true;
            this.salesOrderText.Location = new System.Drawing.Point(21, 44);
            this.salesOrderText.Name = "salesOrderText";
            this.salesOrderText.Size = new System.Drawing.Size(48, 25);
            this.salesOrderText.TabIndex = 0;
            this.salesOrderText.Text = "------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deliveryText2);
            this.groupBox2.Controls.Add(this.deliveryText);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(295, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 138);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery";
            // 
            // deliveryText2
            // 
            this.deliveryText2.AutoSize = true;
            this.deliveryText2.Location = new System.Drawing.Point(21, 86);
            this.deliveryText2.Name = "deliveryText2";
            this.deliveryText2.Size = new System.Drawing.Size(48, 25);
            this.deliveryText2.TabIndex = 2;
            this.deliveryText2.Text = "------";
            // 
            // deliveryText
            // 
            this.deliveryText.AutoSize = true;
            this.deliveryText.Location = new System.Drawing.Point(21, 44);
            this.deliveryText.Name = "deliveryText";
            this.deliveryText.Size = new System.Drawing.Size(48, 25);
            this.deliveryText.TabIndex = 0;
            this.deliveryText.Text = "------";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.installationText2);
            this.groupBox3.Controls.Add(this.installationText);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(562, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 138);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Installation";
            // 
            // installationText2
            // 
            this.installationText2.AutoSize = true;
            this.installationText2.Location = new System.Drawing.Point(21, 86);
            this.installationText2.Name = "installationText2";
            this.installationText2.Size = new System.Drawing.Size(48, 25);
            this.installationText2.TabIndex = 3;
            this.installationText2.Text = "------";
            // 
            // installationText
            // 
            this.installationText.AutoSize = true;
            this.installationText.Location = new System.Drawing.Point(21, 44);
            this.installationText.Name = "installationText";
            this.installationText.Size = new System.Drawing.Size(48, 25);
            this.installationText.TabIndex = 0;
            this.installationText.Text = "------";
            // 
            // changeMode
            // 
            this.changeMode.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMode.FormattingEnabled = true;
            this.changeMode.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
            this.changeMode.Location = new System.Drawing.Point(608, 47);
            this.changeMode.Name = "changeMode";
            this.changeMode.Size = new System.Drawing.Size(154, 33);
            this.changeMode.TabIndex = 22;
            this.changeMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SalesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Data";
            this.SalesChart.Legends.Add(legend1);
            this.SalesChart.Location = new System.Drawing.Point(33, 341);
            this.SalesChart.Name = "SalesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Delivery";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Installation";
            this.SalesChart.Series.Add(series1);
            this.SalesChart.Series.Add(series2);
            this.SalesChart.Series.Add(series3);
            this.SalesChart.Size = new System.Drawing.Size(729, 300);
            this.SalesChart.TabIndex = 23;
            this.SalesChart.Text = "chart1";
            // 
            // changeChartMode
            // 
            this.changeChartMode.Font = new System.Drawing.Font("Impact", 12F);
            this.changeChartMode.FormattingEnabled = true;
            this.changeChartMode.Items.AddRange(new object[] {
            "Column",
            "Bar",
            "SplineArea",
            "Spline",
            "Point"});
            this.changeChartMode.Location = new System.Drawing.Point(608, 298);
            this.changeChartMode.Name = "changeChartMode";
            this.changeChartMode.Size = new System.Drawing.Size(154, 33);
            this.changeChartMode.TabIndex = 24;
            this.changeChartMode.SelectedIndexChanged += new System.EventHandler(this.changeChartMode_SelectedIndexChanged);
            // 
            // StaticViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.changeChartMode);
            this.Controls.Add(this.SalesChart);
            this.Controls.Add(this.changeMode);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deliveryTitle);
            this.Name = "StaticViewer";
            this.Text = "StaticViewer";
            this.Load += new System.EventHandler(this.StaticViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deliveryTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label salesOrderText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label deliveryText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label installationText;
        private System.Windows.Forms.ComboBox changeMode;
        private System.Windows.Forms.Label salesOrder2;
        private System.Windows.Forms.Label deliveryText2;
        private System.Windows.Forms.Label installationText2;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        private System.Windows.Forms.ComboBox changeChartMode;
    }
}