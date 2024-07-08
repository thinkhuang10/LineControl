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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.panelQuery.Controls.Add(this.dateTimePicker1);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuery.Location = new System.Drawing.Point(0, 839);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(1200, 61);
            this.panelQuery.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 26);
            this.dateTimePicker1.TabIndex = 0;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
