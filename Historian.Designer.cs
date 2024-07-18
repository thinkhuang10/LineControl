namespace LineControl
{
    partial class Historian
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historian));
            this.FrameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.btPrintPreview = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btQuery = new System.Windows.Forms.Button();
            this.endDtp = new System.Windows.Forms.DateTimePicker();
            this.startDtp = new System.Windows.Forms.DateTimePicker();
            this.FrameTableLayoutPanel.SuspendLayout();
            this.panelQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrameTableLayoutPanel
            // 
            this.FrameTableLayoutPanel.ColumnCount = 1;
            this.FrameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FrameTableLayoutPanel.Controls.Add(this.panelChart, 0, 0);
            this.FrameTableLayoutPanel.Controls.Add(this.panelQuery, 0, 1);
            this.FrameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrameTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FrameTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FrameTableLayoutPanel.Name = "FrameTableLayoutPanel";
            this.FrameTableLayoutPanel.RowCount = 2;
            this.FrameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.22222F));
            this.FrameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.777778F));
            this.FrameTableLayoutPanel.Size = new System.Drawing.Size(800, 540);
            this.FrameTableLayoutPanel.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Margin = new System.Windows.Forms.Padding(0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(800, 503);
            this.panelChart.TabIndex = 0;
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.btPrintPreview);
            this.panelQuery.Controls.Add(this.btExport);
            this.panelQuery.Controls.Add(this.btPrint);
            this.panelQuery.Controls.Add(this.btQuery);
            this.panelQuery.Controls.Add(this.endDtp);
            this.panelQuery.Controls.Add(this.startDtp);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuery.Location = new System.Drawing.Point(0, 503);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(800, 37);
            this.panelQuery.TabIndex = 1;
            // 
            // btPrintPreview
            // 
            this.btPrintPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPrintPreview.BackgroundImage")));
            this.btPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrintPreview.Location = new System.Drawing.Point(540, 8);
            this.btPrintPreview.Name = "btPrintPreview";
            this.btPrintPreview.Size = new System.Drawing.Size(23, 23);
            this.btPrintPreview.TabIndex = 5;
            this.btPrintPreview.UseVisualStyleBackColor = true;
            this.btPrintPreview.Click += new System.EventHandler(this.btPrintPreview_Click);
            this.btPrintPreview.MouseEnter += new System.EventHandler(this.btPrintPreview_MouseEnter);
            // 
            // btExport
            // 
            this.btExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExport.BackgroundImage")));
            this.btExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExport.Location = new System.Drawing.Point(511, 8);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(23, 23);
            this.btExport.TabIndex = 4;
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            this.btExport.MouseEnter += new System.EventHandler(this.btExport_MouseEnter);
            // 
            // btPrint
            // 
            this.btPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPrint.BackgroundImage")));
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrint.Location = new System.Drawing.Point(569, 8);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(23, 23);
            this.btPrint.TabIndex = 3;
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            this.btPrint.MouseEnter += new System.EventHandler(this.btPrint_MouseEnter);
            // 
            // btQuery
            // 
            this.btQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btQuery.BackgroundImage")));
            this.btQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuery.Location = new System.Drawing.Point(451, 8);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(23, 23);
            this.btQuery.TabIndex = 2;
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            this.btQuery.MouseEnter += new System.EventHandler(this.btQuery_MouseEnter);
            // 
            // endDtp
            // 
            this.endDtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDtp.Location = new System.Drawing.Point(237, 10);
            this.endDtp.Margin = new System.Windows.Forms.Padding(2);
            this.endDtp.Name = "endDtp";
            this.endDtp.Size = new System.Drawing.Size(209, 21);
            this.endDtp.TabIndex = 1;
            // 
            // startDtp
            // 
            this.startDtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDtp.Location = new System.Drawing.Point(15, 10);
            this.startDtp.Margin = new System.Windows.Forms.Padding(2);
            this.startDtp.Name = "startDtp";
            this.startDtp.Size = new System.Drawing.Size(209, 21);
            this.startDtp.TabIndex = 0;
            // 
            // Historian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FrameTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Historian";
            this.Size = new System.Drawing.Size(800, 540);
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.FrameTableLayoutPanel.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FrameTableLayoutPanel;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.DateTimePicker startDtp;
        private System.Windows.Forms.DateTimePicker endDtp;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btPrintPreview;
    }
}
