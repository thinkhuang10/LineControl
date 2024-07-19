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
            this.btPanningDown = new System.Windows.Forms.Button();
            this.btPanningUp = new System.Windows.Forms.Button();
            this.btPanningRight = new System.Windows.Forms.Button();
            this.btPanningLeft = new System.Windows.Forms.Button();
            this.btZoomOut = new System.Windows.Forms.Button();
            this.btZoomIn = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
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
            this.FrameTableLayoutPanel.Name = "FrameTableLayoutPanel";
            this.FrameTableLayoutPanel.RowCount = 2;
            this.FrameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.22222F));
            this.FrameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.777778F));
            this.FrameTableLayoutPanel.Size = new System.Drawing.Size(1200, 900);
            this.FrameTableLayoutPanel.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Margin = new System.Windows.Forms.Padding(0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1200, 839);
            this.panelChart.TabIndex = 0;
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.btPanningDown);
            this.panelQuery.Controls.Add(this.btPanningUp);
            this.panelQuery.Controls.Add(this.btPanningRight);
            this.panelQuery.Controls.Add(this.btPanningLeft);
            this.panelQuery.Controls.Add(this.btZoomOut);
            this.panelQuery.Controls.Add(this.btZoomIn);
            this.panelQuery.Controls.Add(this.btReset);
            this.panelQuery.Controls.Add(this.btPrintPreview);
            this.panelQuery.Controls.Add(this.btExport);
            this.panelQuery.Controls.Add(this.btPrint);
            this.panelQuery.Controls.Add(this.btQuery);
            this.panelQuery.Controls.Add(this.endDtp);
            this.panelQuery.Controls.Add(this.startDtp);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuery.Location = new System.Drawing.Point(0, 839);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(1200, 61);
            this.panelQuery.TabIndex = 1;
            // 
            // btPanningDown
            // 
            this.btPanningDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPanningDown.BackgroundImage")));
            this.btPanningDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPanningDown.Location = new System.Drawing.Point(970, 12);
            this.btPanningDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPanningDown.Name = "btPanningDown";
            this.btPanningDown.Size = new System.Drawing.Size(34, 38);
            this.btPanningDown.TabIndex = 12;
            this.btPanningDown.UseVisualStyleBackColor = true;
            this.btPanningDown.Click += new System.EventHandler(this.btPanningDown_Click);
            this.btPanningDown.MouseEnter += new System.EventHandler(this.btPanningDown_MouseEnter);
            // 
            // btPanningUp
            // 
            this.btPanningUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPanningUp.BackgroundImage")));
            this.btPanningUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPanningUp.Location = new System.Drawing.Point(928, 12);
            this.btPanningUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPanningUp.Name = "btPanningUp";
            this.btPanningUp.Size = new System.Drawing.Size(34, 38);
            this.btPanningUp.TabIndex = 11;
            this.btPanningUp.UseVisualStyleBackColor = true;
            this.btPanningUp.Click += new System.EventHandler(this.btPanningUp_Click);
            this.btPanningUp.MouseEnter += new System.EventHandler(this.btPanningUp_MouseEnter);
            // 
            // btPanningRight
            // 
            this.btPanningRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPanningRight.BackgroundImage")));
            this.btPanningRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPanningRight.Location = new System.Drawing.Point(886, 12);
            this.btPanningRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPanningRight.Name = "btPanningRight";
            this.btPanningRight.Size = new System.Drawing.Size(34, 38);
            this.btPanningRight.TabIndex = 10;
            this.btPanningRight.UseVisualStyleBackColor = true;
            this.btPanningRight.Click += new System.EventHandler(this.btPanningRight_Click);
            this.btPanningRight.MouseEnter += new System.EventHandler(this.btPanningRight_MouseEnter);
            // 
            // btPanningLeft
            // 
            this.btPanningLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPanningLeft.BackgroundImage")));
            this.btPanningLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPanningLeft.Location = new System.Drawing.Point(844, 12);
            this.btPanningLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPanningLeft.Name = "btPanningLeft";
            this.btPanningLeft.Size = new System.Drawing.Size(34, 38);
            this.btPanningLeft.TabIndex = 9;
            this.btPanningLeft.UseVisualStyleBackColor = true;
            this.btPanningLeft.Click += new System.EventHandler(this.btPanningLeft_Click);
            this.btPanningLeft.MouseEnter += new System.EventHandler(this.btPanningLeft_MouseEnter);
            // 
            // btZoomOut
            // 
            this.btZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btZoomOut.BackgroundImage")));
            this.btZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZoomOut.Location = new System.Drawing.Point(802, 12);
            this.btZoomOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btZoomOut.Name = "btZoomOut";
            this.btZoomOut.Size = new System.Drawing.Size(34, 38);
            this.btZoomOut.TabIndex = 8;
            this.btZoomOut.UseVisualStyleBackColor = true;
            this.btZoomOut.Click += new System.EventHandler(this.btZoomOut_Click);
            this.btZoomOut.MouseEnter += new System.EventHandler(this.btZoomOut_MouseEnter);
            // 
            // btZoomIn
            // 
            this.btZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btZoomIn.BackgroundImage")));
            this.btZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZoomIn.Location = new System.Drawing.Point(760, 12);
            this.btZoomIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btZoomIn.Name = "btZoomIn";
            this.btZoomIn.Size = new System.Drawing.Size(34, 38);
            this.btZoomIn.TabIndex = 7;
            this.btZoomIn.UseVisualStyleBackColor = true;
            this.btZoomIn.Click += new System.EventHandler(this.btZoomIn_Click);
            this.btZoomIn.MouseEnter += new System.EventHandler(this.btZoomIn_MouseEnter);
            // 
            // btReset
            // 
            this.btReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReset.BackgroundImage")));
            this.btReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReset.Location = new System.Drawing.Point(718, 12);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(34, 38);
            this.btReset.TabIndex = 6;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            this.btReset.MouseEnter += new System.EventHandler(this.btReset_MouseEnter);
            // 
            // btPrintPreview
            // 
            this.btPrintPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPrintPreview.BackgroundImage")));
            this.btPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrintPreview.Location = new System.Drawing.Point(614, 12);
            this.btPrintPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPrintPreview.Name = "btPrintPreview";
            this.btPrintPreview.Size = new System.Drawing.Size(34, 38);
            this.btPrintPreview.TabIndex = 5;
            this.btPrintPreview.UseVisualStyleBackColor = true;
            this.btPrintPreview.Click += new System.EventHandler(this.btPrintPreview_Click);
            this.btPrintPreview.MouseEnter += new System.EventHandler(this.btPrintPreview_MouseEnter);
            // 
            // btExport
            // 
            this.btExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExport.BackgroundImage")));
            this.btExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExport.Location = new System.Drawing.Point(568, 12);
            this.btExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(34, 38);
            this.btExport.TabIndex = 4;
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            this.btExport.MouseEnter += new System.EventHandler(this.btExport_MouseEnter);
            // 
            // btPrint
            // 
            this.btPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPrint.BackgroundImage")));
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrint.Location = new System.Drawing.Point(657, 12);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(34, 38);
            this.btPrint.TabIndex = 3;
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            this.btPrint.MouseEnter += new System.EventHandler(this.btPrint_MouseEnter);
            // 
            // btQuery
            // 
            this.btQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btQuery.BackgroundImage")));
            this.btQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuery.Location = new System.Drawing.Point(514, 12);
            this.btQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(34, 38);
            this.btQuery.TabIndex = 2;
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            this.btQuery.MouseEnter += new System.EventHandler(this.btQuery_MouseEnter);
            // 
            // endDtp
            // 
            this.endDtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDtp.Location = new System.Drawing.Point(280, 17);
            this.endDtp.Name = "endDtp";
            this.endDtp.Size = new System.Drawing.Size(218, 26);
            this.endDtp.TabIndex = 1;
            // 
            // startDtp
            // 
            this.startDtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDtp.Location = new System.Drawing.Point(22, 17);
            this.startDtp.Name = "startDtp";
            this.startDtp.Size = new System.Drawing.Size(240, 26);
            this.startDtp.TabIndex = 0;
            // 
            // Historian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FrameTableLayoutPanel);
            this.Name = "Historian";
            this.Size = new System.Drawing.Size(1200, 900);
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
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btZoomIn;
        private System.Windows.Forms.Button btZoomOut;
        private System.Windows.Forms.Button btPanningDown;
        private System.Windows.Forms.Button btPanningUp;
        private System.Windows.Forms.Button btPanningRight;
        private System.Windows.Forms.Button btPanningLeft;
    }
}
