namespace LineControl
{
    partial class SetForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxLegend = new System.Windows.Forms.ComboBox();
            this.checkBoxLegend = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.YAxisTitleForeColor = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.YAxisTitleSize = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.XAxisTitleForeColor = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.XAxisTitleSize = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ChartTitleColor = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ChartTitleSize = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.YAxisTitle = new System.Windows.Forms.TextBox();
            this.XAxisTitle = new System.Windows.Forms.TextBox();
            this.ChartTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VerticalGridCount = new System.Windows.Forms.TextBox();
            this.HorizonalGridCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AxisLabelColor = new System.Windows.Forms.Label();
            this.GridColor = new System.Windows.Forms.Label();
            this.ChartBackColor = new System.Windows.Forms.Label();
            this.ChartForeColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxVar = new System.Windows.Forms.ListBox();
            this.DeleteLineButton = new System.Windows.Forms.Button();
            this.AddLineButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbModifyLineTooltip = new System.Windows.Forms.Label();
            this.btModifyLine = new System.Windows.Forms.Button();
            this.LineColor = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbLineWidth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbLineDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUpperLimitValue = new System.Windows.Forms.TextBox();
            this.tbLowerLimitValue = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(510, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxLegend);
            this.groupBox3.Controls.Add(this.checkBoxLegend);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "曲线标注";
            // 
            // comboBoxLegend
            // 
            this.comboBoxLegend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLegend.FormattingEnabled = true;
            this.comboBoxLegend.Items.AddRange(new object[] {
            "上方",
            "右侧"});
            this.comboBoxLegend.Location = new System.Drawing.Point(180, 23);
            this.comboBoxLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLegend.Name = "comboBoxLegend";
            this.comboBoxLegend.Size = new System.Drawing.Size(87, 20);
            this.comboBoxLegend.TabIndex = 3;
            // 
            // checkBoxLegend
            // 
            this.checkBoxLegend.AutoSize = true;
            this.checkBoxLegend.Location = new System.Drawing.Point(20, 25);
            this.checkBoxLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLegend.Name = "checkBoxLegend";
            this.checkBoxLegend.Size = new System.Drawing.Size(72, 16);
            this.checkBoxLegend.TabIndex = 2;
            this.checkBoxLegend.Text = "显示标注";
            this.checkBoxLegend.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "标注位置";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.YAxisTitleForeColor);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.YAxisTitleSize);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.XAxisTitleForeColor);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.XAxisTitleSize);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.ChartTitleColor);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.ChartTitleSize);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.YAxisTitle);
            this.groupBox4.Controls.Add(this.XAxisTitle);
            this.groupBox4.Controls.Add(this.ChartTitle);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(3, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 126);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标题/显示信息";
            // 
            // YAxisTitleForeColor
            // 
            this.YAxisTitleForeColor.BackColor = System.Drawing.Color.Gray;
            this.YAxisTitleForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.YAxisTitleForeColor.Font = new System.Drawing.Font("宋体", 12F);
            this.YAxisTitleForeColor.Location = new System.Drawing.Point(291, 89);
            this.YAxisTitleForeColor.Name = "YAxisTitleForeColor";
            this.YAxisTitleForeColor.Size = new System.Drawing.Size(56, 20);
            this.YAxisTitleForeColor.TabIndex = 22;
            this.YAxisTitleForeColor.Text = "     ";
            this.YAxisTitleForeColor.Click += new System.EventHandler(this.YAxisTitleForeColor_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(232, 93);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 21;
            this.label31.Text = "字体颜色";
            // 
            // YAxisTitleSize
            // 
            this.YAxisTitleSize.Location = new System.Drawing.Point(413, 89);
            this.YAxisTitleSize.Name = "YAxisTitleSize";
            this.YAxisTitleSize.Size = new System.Drawing.Size(63, 21);
            this.YAxisTitleSize.TabIndex = 20;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(354, 93);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 19;
            this.label32.Text = "字体大小";
            // 
            // XAxisTitleForeColor
            // 
            this.XAxisTitleForeColor.BackColor = System.Drawing.Color.Gray;
            this.XAxisTitleForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.XAxisTitleForeColor.Font = new System.Drawing.Font("宋体", 12F);
            this.XAxisTitleForeColor.Location = new System.Drawing.Point(291, 56);
            this.XAxisTitleForeColor.Name = "XAxisTitleForeColor";
            this.XAxisTitleForeColor.Size = new System.Drawing.Size(56, 20);
            this.XAxisTitleForeColor.TabIndex = 18;
            this.XAxisTitleForeColor.Text = "     ";
            this.XAxisTitleForeColor.Click += new System.EventHandler(this.XAxisTitleForeColor_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(232, 60);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 17;
            this.label28.Text = "字体颜色";
            // 
            // XAxisTitleSize
            // 
            this.XAxisTitleSize.Location = new System.Drawing.Point(413, 56);
            this.XAxisTitleSize.Name = "XAxisTitleSize";
            this.XAxisTitleSize.Size = new System.Drawing.Size(63, 21);
            this.XAxisTitleSize.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(354, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 15;
            this.label29.Text = "字体大小";
            // 
            // ChartTitleColor
            // 
            this.ChartTitleColor.BackColor = System.Drawing.Color.Gray;
            this.ChartTitleColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChartTitleColor.Font = new System.Drawing.Font("宋体", 12F);
            this.ChartTitleColor.Location = new System.Drawing.Point(291, 23);
            this.ChartTitleColor.Name = "ChartTitleColor";
            this.ChartTitleColor.Size = new System.Drawing.Size(56, 20);
            this.ChartTitleColor.TabIndex = 14;
            this.ChartTitleColor.Text = "     ";
            this.ChartTitleColor.Click += new System.EventHandler(this.ChartTitleColor_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(232, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 13;
            this.label23.Text = "字体颜色";
            // 
            // ChartTitleSize
            // 
            this.ChartTitleSize.Location = new System.Drawing.Point(413, 23);
            this.ChartTitleSize.Name = "ChartTitleSize";
            this.ChartTitleSize.Size = new System.Drawing.Size(63, 21);
            this.ChartTitleSize.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(354, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 10;
            this.label24.Text = "字体大小";
            // 
            // YAxisTitle
            // 
            this.YAxisTitle.Location = new System.Drawing.Point(60, 89);
            this.YAxisTitle.Name = "YAxisTitle";
            this.YAxisTitle.Size = new System.Drawing.Size(157, 21);
            this.YAxisTitle.TabIndex = 1;
            // 
            // XAxisTitle
            // 
            this.XAxisTitle.Location = new System.Drawing.Point(60, 56);
            this.XAxisTitle.Name = "XAxisTitle";
            this.XAxisTitle.Size = new System.Drawing.Size(157, 21);
            this.XAxisTitle.TabIndex = 1;
            // 
            // ChartTitle
            // 
            this.ChartTitle.Location = new System.Drawing.Point(60, 23);
            this.ChartTitle.Name = "ChartTitle";
            this.ChartTitle.Size = new System.Drawing.Size(157, 21);
            this.ChartTitle.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Y信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "X信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "标题";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VerticalGridCount);
            this.groupBox2.Controls.Add(this.HorizonalGridCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网格数";
            // 
            // VerticalGridCount
            // 
            this.VerticalGridCount.Location = new System.Drawing.Point(370, 24);
            this.VerticalGridCount.Name = "VerticalGridCount";
            this.VerticalGridCount.Size = new System.Drawing.Size(63, 21);
            this.VerticalGridCount.TabIndex = 1;
            // 
            // HorizonalGridCount
            // 
            this.HorizonalGridCount.Location = new System.Drawing.Point(137, 24);
            this.HorizonalGridCount.Name = "HorizonalGridCount";
            this.HorizonalGridCount.Size = new System.Drawing.Size(63, 21);
            this.HorizonalGridCount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "目标垂直网格";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "目标水平网格";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AxisLabelColor);
            this.groupBox1.Controls.Add(this.GridColor);
            this.groupBox1.Controls.Add(this.ChartBackColor);
            this.groupBox1.Controls.Add(this.ChartForeColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色";
            // 
            // AxisLabelColor
            // 
            this.AxisLabelColor.BackColor = System.Drawing.Color.Gray;
            this.AxisLabelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AxisLabelColor.Location = new System.Drawing.Point(410, 27);
            this.AxisLabelColor.Name = "AxisLabelColor";
            this.AxisLabelColor.Size = new System.Drawing.Size(56, 20);
            this.AxisLabelColor.TabIndex = 7;
            this.AxisLabelColor.Text = "     ";
            this.AxisLabelColor.Click += new System.EventHandler(this.AxisLabelColor_Click);
            // 
            // GridColor
            // 
            this.GridColor.BackColor = System.Drawing.Color.Gray;
            this.GridColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridColor.Location = new System.Drawing.Point(286, 27);
            this.GridColor.Name = "GridColor";
            this.GridColor.Size = new System.Drawing.Size(56, 20);
            this.GridColor.TabIndex = 6;
            this.GridColor.Text = "     ";
            this.GridColor.Click += new System.EventHandler(this.GridColor_Click);
            // 
            // ChartBackColor
            // 
            this.ChartBackColor.BackColor = System.Drawing.Color.Gray;
            this.ChartBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChartBackColor.Location = new System.Drawing.Point(170, 27);
            this.ChartBackColor.Name = "ChartBackColor";
            this.ChartBackColor.Size = new System.Drawing.Size(56, 20);
            this.ChartBackColor.TabIndex = 5;
            this.ChartBackColor.Text = "     ";
            this.ChartBackColor.Click += new System.EventHandler(this.ChartBackColor_Click);
            // 
            // ChartForeColor
            // 
            this.ChartForeColor.BackColor = System.Drawing.Color.Gray;
            this.ChartForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChartForeColor.Font = new System.Drawing.Font("宋体", 12F);
            this.ChartForeColor.Location = new System.Drawing.Point(50, 27);
            this.ChartForeColor.Name = "ChartForeColor";
            this.ChartForeColor.Size = new System.Drawing.Size(56, 20);
            this.ChartForeColor.TabIndex = 4;
            this.ChartForeColor.Text = "     ";
            this.ChartForeColor.Click += new System.EventHandler(this.ChartForeColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "轴标记";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "网格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "背景";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "前景";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxVar);
            this.tabPage2.Controls.Add(this.DeleteLineButton);
            this.tabPage2.Controls.Add(this.AddLineButton);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(510, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxVar
            // 
            this.listBoxVar.FormattingEnabled = true;
            this.listBoxVar.ItemHeight = 12;
            this.listBoxVar.Location = new System.Drawing.Point(12, 13);
            this.listBoxVar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxVar.Name = "listBoxVar";
            this.listBoxVar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxVar.Size = new System.Drawing.Size(233, 316);
            this.listBoxVar.TabIndex = 4;
            this.listBoxVar.SelectedIndexChanged += new System.EventHandler(this.listBoxVar_SelectedIndexChanged);
            // 
            // DeleteLineButton
            // 
            this.DeleteLineButton.Location = new System.Drawing.Point(131, 332);
            this.DeleteLineButton.Name = "DeleteLineButton";
            this.DeleteLineButton.Size = new System.Drawing.Size(107, 23);
            this.DeleteLineButton.TabIndex = 3;
            this.DeleteLineButton.Text = "删除曲线";
            this.DeleteLineButton.UseVisualStyleBackColor = true;
            this.DeleteLineButton.Click += new System.EventHandler(this.DeleteLineButton_Click);
            // 
            // AddLineButton
            // 
            this.AddLineButton.Location = new System.Drawing.Point(19, 332);
            this.AddLineButton.Name = "AddLineButton";
            this.AddLineButton.Size = new System.Drawing.Size(107, 23);
            this.AddLineButton.TabIndex = 3;
            this.AddLineButton.Text = "添加曲线";
            this.AddLineButton.UseVisualStyleBackColor = true;
            this.AddLineButton.Click += new System.EventHandler(this.AddLineButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbUnit);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lbModifyLineTooltip);
            this.groupBox6.Controls.Add(this.btModifyLine);
            this.groupBox6.Controls.Add(this.LineColor);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.tbLineWidth);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.tbLineDescription);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.tbUpperLimitValue);
            this.groupBox6.Controls.Add(this.tbLowerLimitValue);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(257, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(228, 323);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "范围";
            // 
            // lbModifyLineTooltip
            // 
            this.lbModifyLineTooltip.AutoSize = true;
            this.lbModifyLineTooltip.Location = new System.Drawing.Point(83, 241);
            this.lbModifyLineTooltip.Name = "lbModifyLineTooltip";
            this.lbModifyLineTooltip.Size = new System.Drawing.Size(59, 12);
            this.lbModifyLineTooltip.TabIndex = 10;
            this.lbModifyLineTooltip.Text = "修改成功.";
            // 
            // btModifyLine
            // 
            this.btModifyLine.Location = new System.Drawing.Point(54, 210);
            this.btModifyLine.Name = "btModifyLine";
            this.btModifyLine.Size = new System.Drawing.Size(107, 23);
            this.btModifyLine.TabIndex = 5;
            this.btModifyLine.Text = "修改";
            this.btModifyLine.UseVisualStyleBackColor = true;
            this.btModifyLine.Click += new System.EventHandler(this.btModifyLine_Click);
            // 
            // LineColor
            // 
            this.LineColor.BackColor = System.Drawing.Color.Gray;
            this.LineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineColor.Location = new System.Drawing.Point(76, 80);
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(56, 20);
            this.LineColor.TabIndex = 9;
            this.LineColor.Text = "     ";
            this.LineColor.Click += new System.EventHandler(this.LineColor_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 8;
            this.label19.Text = "线条颜色";
            // 
            // tbLineWidth
            // 
            this.tbLineWidth.Location = new System.Drawing.Point(72, 111);
            this.tbLineWidth.Name = "tbLineWidth";
            this.tbLineWidth.Size = new System.Drawing.Size(98, 21);
            this.tbLineWidth.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "线条宽度";
            // 
            // tbLineDescription
            // 
            this.tbLineDescription.Location = new System.Drawing.Point(72, 144);
            this.tbLineDescription.Name = "tbLineDescription";
            this.tbLineDescription.Size = new System.Drawing.Size(98, 21);
            this.tbLineDescription.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "描述";
            // 
            // tbUpperLimitValue
            // 
            this.tbUpperLimitValue.Location = new System.Drawing.Point(74, 48);
            this.tbUpperLimitValue.Name = "tbUpperLimitValue";
            this.tbUpperLimitValue.Size = new System.Drawing.Size(98, 21);
            this.tbUpperLimitValue.TabIndex = 1;
            // 
            // tbLowerLimitValue
            // 
            this.tbLowerLimitValue.Location = new System.Drawing.Point(74, 23);
            this.tbLowerLimitValue.Name = "tbLowerLimitValue";
            this.tbLowerLimitValue.Size = new System.Drawing.Size(98, 21);
            this.tbLowerLimitValue.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "量程上限";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "量程下限";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(337, 520);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "确定";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(427, 520);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(72, 171);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(98, 21);
            this.tbUnit.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "单位";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 555);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.Load += new System.EventHandler(this.XYSetForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox VerticalGridCount;
        private System.Windows.Forms.TextBox HorizonalGridCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox YAxisTitle;
        private System.Windows.Forms.TextBox XAxisTitle;
        private System.Windows.Forms.TextBox ChartTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbUpperLimitValue;
        private System.Windows.Forms.TextBox tbLowerLimitValue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button AddLineButton;
        private System.Windows.Forms.Button DeleteLineButton;
        private System.Windows.Forms.Label ChartForeColor;
        private System.Windows.Forms.Label ChartBackColor;
        private System.Windows.Forms.Label AxisLabelColor;
        private System.Windows.Forms.Label GridColor;
        private System.Windows.Forms.Label ChartTitleColor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox ChartTitleSize;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label YAxisTitleForeColor;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox YAxisTitleSize;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label XAxisTitleForeColor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox XAxisTitleSize;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListBox listBoxVar;
        private System.Windows.Forms.TextBox tbLineDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLineWidth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LineColor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxLegend;
        private System.Windows.Forms.ComboBox comboBoxLegend;
        private System.Windows.Forms.Button btModifyLine;
        private System.Windows.Forms.Label lbModifyLineTooltip;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label9;
    }
}