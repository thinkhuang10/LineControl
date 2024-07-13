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
            this.FrameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelQuery = new System.Windows.Forms.Panel();
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
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(472, 9);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 2;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
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
    }
}
