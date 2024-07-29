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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historian));
            this.FrameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.cbQueryInterval = new System.Windows.Forms.ComboBox();
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
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.splitContainerFrame = new System.Windows.Forms.SplitContainer();
            this.dgvLines = new System.Windows.Forms.DataGridView();
            this.btSetting = new System.Windows.Forms.Button();
            this.FrameTableLayoutPanel.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFrame)).BeginInit();
            this.splitContainerFrame.Panel1.SuspendLayout();
            this.splitContainerFrame.Panel2.SuspendLayout();
            this.splitContainerFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLines)).BeginInit();
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
            this.FrameTableLayoutPanel.Size = new System.Drawing.Size(1500, 814);
            this.FrameTableLayoutPanel.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Margin = new System.Windows.Forms.Padding(0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1500, 758);
            this.panelChart.TabIndex = 0;
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.btSetting);
            this.panelQuery.Controls.Add(this.cbQueryInterval);
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
            this.panelQuery.Controls.Add(this.dtpEnd);
            this.panelQuery.Controls.Add(this.dtpStart);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuery.Location = new System.Drawing.Point(0, 758);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(1500, 56);
            this.panelQuery.TabIndex = 1;
            // 
            // cbQueryInterval
            // 
            this.cbQueryInterval.FormattingEnabled = true;
            this.cbQueryInterval.Location = new System.Drawing.Point(539, 12);
            this.cbQueryInterval.Name = "cbQueryInterval";
            this.cbQueryInterval.Size = new System.Drawing.Size(190, 28);
            this.cbQueryInterval.TabIndex = 15;
            this.cbQueryInterval.SelectedIndexChanged += new System.EventHandler(this.cbQueryInterval_SelectedIndexChanged);
            // 
            // btPanningDown
            // 
            this.btPanningDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPanningDown.BackgroundImage")));
            this.btPanningDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPanningDown.Location = new System.Drawing.Point(1007, 8);
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
            this.btPanningUp.Location = new System.Drawing.Point(965, 8);
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
            this.btPanningRight.Location = new System.Drawing.Point(778, 8);
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
            this.btPanningLeft.Location = new System.Drawing.Point(736, 6);
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
            this.btZoomOut.Location = new System.Drawing.Point(923, 8);
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
            this.btZoomIn.Location = new System.Drawing.Point(881, 8);
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
            this.btReset.Location = new System.Drawing.Point(1064, 8);
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
            this.btPrintPreview.Location = new System.Drawing.Point(1148, 8);
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
            this.btExport.Location = new System.Drawing.Point(1106, 8);
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
            this.btPrint.Location = new System.Drawing.Point(1189, 8);
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
            this.btQuery.Location = new System.Drawing.Point(473, 6);
            this.btQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(34, 38);
            this.btQuery.TabIndex = 2;
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            this.btQuery.MouseEnter += new System.EventHandler(this.btQuery_MouseEnter);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(243, 12);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(223, 26);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.Validated += new System.EventHandler(this.dtpEnd_Validated);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(12, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(223, 26);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.Validated += new System.EventHandler(this.dtpStart_Validated);
            // 
            // splitContainerFrame
            // 
            this.splitContainerFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFrame.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFrame.Name = "splitContainerFrame";
            this.splitContainerFrame.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFrame.Panel1
            // 
            this.splitContainerFrame.Panel1.Controls.Add(this.dgvLines);
            // 
            // splitContainerFrame.Panel2
            // 
            this.splitContainerFrame.Panel2.Controls.Add(this.FrameTableLayoutPanel);
            this.splitContainerFrame.Size = new System.Drawing.Size(1500, 1000);
            this.splitContainerFrame.SplitterDistance = 183;
            this.splitContainerFrame.SplitterWidth = 3;
            this.splitContainerFrame.TabIndex = 1;
            // 
            // dgvLines
            // 
            this.dgvLines.AllowUserToAddRows = false;
            this.dgvLines.AllowUserToDeleteRows = false;
            this.dgvLines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLines.Location = new System.Drawing.Point(0, 0);
            this.dgvLines.MultiSelect = false;
            this.dgvLines.Name = "dgvLines";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLines.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLines.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLines.RowTemplate.Height = 28;
            this.dgvLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLines.Size = new System.Drawing.Size(1500, 183);
            this.dgvLines.TabIndex = 0;
            this.dgvLines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLines_CellClick);
            this.dgvLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLines_CellContentClick);
            this.dgvLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLines_CellValueChanged);
            this.dgvLines.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLines_DataBindingComplete);
            this.dgvLines.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvLines_RowStateChanged);
            // 
            // btSetting
            // 
            this.btSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSetting.BackgroundImage")));
            this.btSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSetting.Location = new System.Drawing.Point(1231, 8);
            this.btSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(34, 38);
            this.btSetting.TabIndex = 16;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            this.btSetting.MouseEnter += new System.EventHandler(this.btSetting_MouseEnter);
            // 
            // Historian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerFrame);
            this.Name = "Historian";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.FrameTableLayoutPanel.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            this.splitContainerFrame.Panel1.ResumeLayout(false);
            this.splitContainerFrame.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFrame)).EndInit();
            this.splitContainerFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FrameTableLayoutPanel;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
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
        private System.Windows.Forms.SplitContainer splitContainerFrame;
        private System.Windows.Forms.DataGridView dgvLines;
        private System.Windows.Forms.ComboBox cbQueryInterval;
        private System.Windows.Forms.Button btSetting;
    }
}
