using CommonSnappableTypes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using LineControl.Properties;
using ScottPlot;
using ScottPlot.WinForms;

namespace LineControl
{
    public partial class Historian: UserControl,IDCCEControl
    {
        private readonly FormsPlot formsPlot = new FormsPlot() { Dock = DockStyle.Fill };
        private Plot plot;

        private const string ChartAreaName = "XYChartArea";
        private const string PointSeriesName = "XYPoint";
        private const string LineSeriesPrefixName = "XYLine";
        private const string SpecialSeriesName = "SpecialPointForLoad";
        private bool isInitSeriesInRunningStatus = false;

        private Save saveData = new Save();

        #region 与组态的接口

        [Browsable(false)]
        public bool isRuning { set; get; }

        public event GetValue GetValueEvent;
        public event GetVarTable GetVarTableEvent;
#pragma warning disable CS0067
        public event SetValue SetValueEvent;
        public event GetDataBase GetDataBaseEvent;
        public event GetValue GetSystemItemEvent;
#pragma warning restore CS0067

        public static System.Drawing.Image GetLogoStatic()
        {
            ResourceManager resourceManager = new ResourceManager(typeof(Resource));
            return (Bitmap)resourceManager.GetObject("XY");
        }

        public Bitmap GetLogo()
        {
            var resourceManager = new ResourceManager(typeof(Resource));
            return (Bitmap)resourceManager.GetObject("XY");
        }

        public byte[] Serialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, saveData);
            byte[] result = memoryStream.ToArray();
            memoryStream.Dispose();
            return result;
        }

        public void DeSerialize(byte[] bytes)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream(bytes);
            saveData = (Save)binaryFormatter.Deserialize(memoryStream);
            memoryStream.Dispose();
        }

        public void Stop()
        {

        }

        #endregion

        #region 屏蔽部分没必要显示的属性并修改部分显示属性的名称

        [Browsable(false)]
        public new System.Windows.Forms.Cursor Cursor
        {
            get
            {
                return base.Cursor;
            }
            set
            {
                base.Cursor = value;
            }
        }

        [Browsable(false)]
        public new System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get
            {
                return base.BorderStyle;
            }
            set
            {
                base.BorderStyle = value;
            }
        }

        [Browsable(false)]
        public new ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                base.BackgroundImageLayout = value;
            }
        }

        [Browsable(false)]
        public new System.Drawing.Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        [Browsable(false)]
        public new Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }

        [Browsable(false)]
        public new RightToLeft RightToLeft
        {
            get
            {
                return base.RightToLeft;
            }
            set
            {
                base.RightToLeft = value;
            }
        }

        [Browsable(false)]
        public new bool UseWaitCursor
        {
            get
            {
                return base.UseWaitCursor;
            }
            set
            {
                base.UseWaitCursor = value;
            }
        }

        [Browsable(false)]
        public new System.Drawing.Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        [ReadOnly(false)]
        [Description("控件左上角相对于其容器左上角的坐标")]
        [DisplayName("位置")]
        [Category("布局")]
        public new Point Location
        {
            get
            {
                return base.Location;
            }
            set
            {
                base.Location = value;
            }
        }

        [Description("控件的大小（以像素为单位）")]
        [Category("布局")]
        [DisplayName("大小")]
        [ReadOnly(false)]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;
            }
        }

        [Browsable(false)]
        public new AnchorStyles Anchor
        {
            get
            {
                return base.Anchor;
            }
            set
            {
                base.Anchor = value;
            }
        }

        [Browsable(false)]
        public new bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }

        [Browsable(false)]
        public new AutoSizeMode AutoSizeMode
        {
            get
            {
                return base.AutoSizeMode;
            }
            set
            {
                base.AutoSizeMode = value;
            }
        }

        [Browsable(false)]
        public new Padding Padding
        {
            get
            {
                return base.Padding;
            }
            set
            {
                base.Padding = value;
            }
        }

        [Browsable(false)]
        public new DockStyle Dock
        {
            get
            {
                return base.Dock;
            }
            set
            {
                base.Dock = value;
            }
        }

        [Browsable(false)]
        public new Padding Margin
        {
            get
            {
                return base.Margin;
            }
            set
            {
                base.Margin = value;
            }
        }

        [Browsable(false)]
        public new Size MaximumSize
        {
            get
            {
                return base.MaximumSize;
            }
            set
            {
                base.MaximumSize = value;
            }
        }

        [Browsable(false)]
        public new Size MinimumSize
        {
            get
            {
                return base.MinimumSize;
            }
            set
            {
                base.MinimumSize = value;
            }
        }

        [Browsable(false)]
        public new bool AutoScroll
        {
            get
            {
                return base.AutoScroll;
            }
            set
            {
                base.AutoScroll = value;
            }
        }

        [Browsable(false)]
        public new Size AutoScrollMargin
        {
            get
            {
                return base.AutoScrollMargin;
            }
            set
            {
                base.AutoScrollMargin = value;
            }
        }

        [Browsable(false)]
        public new Size AutoScrollMinSize
        {
            get
            {
                return base.AutoScrollMinSize;
            }
            set
            {
                base.AutoScrollMinSize = value;
            }
        }

        [Browsable(false)]
        public new bool CausesValidation
        {
            get
            {
                return base.CausesValidation;
            }
            set
            {
                base.CausesValidation = value;
            }
        }

        [Browsable(false)]
        public new string AccessibleName
        {
            get
            {
                return base.AccessibleName;
            }
            set
            {
                base.AccessibleName = value;
            }
        }

        [Browsable(false)]
        public new AccessibleRole AccessibleRole
        {
            get
            {
                return base.AccessibleRole;
            }
            set
            {
                base.AccessibleRole = value;
            }
        }

        [Browsable(false)]
        public new string AccessibleDescription
        {
            get
            {
                return base.AccessibleDescription;
            }
            set
            {
                base.AccessibleDescription = value;
            }
        }

        [Browsable(false)]
        public new object Tag
        {
            get
            {
                return base.Tag;
            }
            set
            {
                base.Tag = value;
            }
        }

        [Browsable(false)]
        public new ControlBindingsCollection DataBindings => base.DataBindings;

        [Browsable(false)]
        public new bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                base.Visible = value;
            }
        }

        [Browsable(false)]
        public new bool Enabled
        {
            get
            {
                return base.Enabled;
            }
            set
            {
                base.Enabled = value;
            }
        }

        [Browsable(false)]
        public new bool AllowDrop
        {
            get
            {
                return base.AllowDrop;
            }
            set
            {
                base.AllowDrop = value;
            }
        }

        [Browsable(false)]
        public new ContextMenuStrip ContextMenuStrip
        {
            get
            {
                return base.ContextMenuStrip;
            }
            set
            {
                base.ContextMenuStrip = value;
            }
        }

        [Browsable(false)]
        public new int TabIndex
        {
            get
            {
                return base.TabIndex;
            }
            set
            {
                base.TabIndex = value;
            }
        }

        [Browsable(false)]
        public new bool TabStop
        {
            get
            {
                return base.TabStop;
            }
            set
            {
                base.TabStop = value;
            }
        }

        [Browsable(false)]
        public new AutoValidate AutoValidate
        {
            get
            {
                return base.AutoValidate;
            }
            set
            {
                base.AutoValidate = value;
            }
        }

        [Browsable(false)]
        public new ImeMode ImeMode
        {
            get
            {
                return base.ImeMode;
            }
            set
            {
                base.ImeMode = value;
            }
        }

        #endregion

        public Historian()
        {
            InitializeComponent();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            InitPlot();

            #region 用于测试

            //DateTime start = new DateTime(2024, 1, 1);
            //double[] ys = Generate.RandomWalk(200);

            ////formsPlot1.Plot.Title("123");
            //var sig = formsPlot.Plot.Add.Signal(ys);
            //sig.Data.XOffset = start.ToOADate();
            //sig.Data.Period = 1.0; // one day between each point

            //formsPlot.Plot.Axes.DateTimeTicksBottom();

            #endregion

            SetTitle();
            SetChartArea();
            SetGridAndAxisInterval();
        }

        private void InitPlot()
        {
            plot = formsPlot.Plot;
            panelChart.DoubleClick += chart_DoubleClick;
            panelChart.Controls.Add(formsPlot);
        }

        private void SetTitle()
        {
            if (string.IsNullOrEmpty(saveData.chartTitle))
                return;

            plot.Title(saveData.chartTitle);                                // 设置标题文本
            plot.Font.Automatic();                                          // 避免中文字符显示乱码
            plot.Axes.Title.Label.ForeColor = ScottPlot.Color.FromColor(saveData.chartTitleColor);   // 设置标题颜色
            plot.Axes.Title.Label.FontSize = saveData.chartTitleSize;       // 设置标题字体大小
            plot.Axes.Title.Label.Bold = saveData.chartTitleIsBold;         // 设置标题是否为粗体           
        }

        private void SetChartArea()
        {
            plot.FigureBackground.Color = ScottPlot.Color.FromColor(saveData.chartBackColor);   // 设置背景色
            plot.DataBackground.Color = ScottPlot.Color.FromColor(saveData.chartForeColor);     // 设置前景色

            //chartArea.AxisX.Minimum = saveData.xAxisMin;        // 设置X轴最小值
            //chartArea.AxisX.Maximum = saveData.xAxisMax;        // 设置X轴最大值
            //chartArea.AxisY.Minimum = saveData.yAxisMin;        // 设置Y轴最小值
            //chartArea.AxisY.Maximum = saveData.yAxisMax;        // 设置Y轴最大值

            //// 设置标注颜色
            //chartArea.AxisX.LabelStyle = new LabelStyle { ForeColor = saveData.axisLabelColor };
            //chartArea.AxisY.LabelStyle = new LabelStyle { ForeColor = saveData.axisLabelColor };

            //chartArea.AxisX.Title = saveData.xAxisTitle;                    // 设置X信息
            //chartArea.AxisX.TitleForeColor = saveData.xAxisTitleForeColor;  // 设置X信息颜色
            //chartArea.AxisX.TitleFont = new Font(FontFamily.GenericSansSerif, 
            //    saveData.xAxisTitleSize,     // 设置X信息字体大小
            //    saveData.xAxisTitleIsBold ? FontStyle.Bold : FontStyle.Regular);    // 设置X信息是否为粗体

            //chartArea.AxisY.Title = saveData.yAxisTitle;                    // 设置Y信息
            //chartArea.AxisY.TitleForeColor = saveData.yAxisTitleForeColor;  // 设置Y信息颜色
            //chartArea.AxisY.TitleFont = new Font(FontFamily.GenericSansSerif, 
            //    saveData.yAxisTitleSize,     // 设置Y信息字体大小
            //    saveData.yAxisTitleIsBold ? FontStyle.Bold : FontStyle.Regular);    // 设置Y信息是否为粗体

            //xyChart.ChartAreas.Add(chartArea);
        }

        private void SetGridAndAxisInterval()
        {
            //xyChart.ChartAreas[ChartAreaName].AxisX.MajorGrid.Enabled = true;
            //xyChart.ChartAreas[ChartAreaName].AxisX.MajorGrid.LineColor = saveData.gridColor;
            //xyChart.ChartAreas[ChartAreaName].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            //xyChart.ChartAreas[ChartAreaName].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Number;
            //var xInterval = (saveData.xAxisMax - saveData.xAxisMin) / saveData.verticalGridCount;
            //xyChart.ChartAreas[ChartAreaName].AxisX.MajorGrid.Interval = xInterval;
            //xyChart.ChartAreas[ChartAreaName].AxisX.Interval = xInterval;

            //xyChart.ChartAreas[ChartAreaName].AxisY.MajorGrid.Enabled = true;
            //xyChart.ChartAreas[ChartAreaName].AxisY.MajorGrid.LineColor = saveData.gridColor;
            //xyChart.ChartAreas[ChartAreaName].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            //xyChart.ChartAreas[ChartAreaName].AxisY.MajorGrid.IntervalType = DateTimeIntervalType.Number;
            //var yInterval = (saveData.yAxisMax - saveData.yAxisMin) / saveData.horizonalGridCount;
            //xyChart.ChartAreas[ChartAreaName].AxisY.MajorGrid.Interval = yInterval;
            //xyChart.ChartAreas[ChartAreaName].AxisY.Interval = yInterval;
        }


        private void SetSeriesStyle()
        {
            //// 提前初始化曲线,定时器中不要周期执行
            //// TODO: 尝试提高曲线绘制效率
            //for (var i = 0; i < saveData.lineInfos.Count; i++)
            //{
            //    var series = xyChart.Series.Add($"{LineSeriesPrefixName}{i}");
            //    series.BorderWidth = saveData.seriesBorderWidth;    // 曲线宽度
            //    series.Color = saveData.lineInfos[i].LineColor;
            //    series.ChartArea = ChartAreaName;
            //    series.ChartType = SeriesChartType.Line;
            //}

            //var pointSeries = xyChart.Series.Add(PointSeriesName);
            //pointSeries.ChartArea = ChartAreaName;
            //pointSeries.ChartType = SeriesChartType.Point;
            //pointSeries.MarkerStyle = MarkerStyle.Circle;
            //pointSeries.MarkerSize = saveData.dynamicPointSize;
        }

        private void chart_DoubleClick(object sender, EventArgs e)
        {
            if (isRuning)
                return;

            var form = new SetForm(saveData);
            form.GetVarTableEvent += GetVarTableEvent;
            if (DialogResult.OK != form.ShowDialog())
                return;

            ClearChart();
            SetTitle();
            SetChartArea();
            SetGridAndAxisInterval();
        }

        private void ClearChart()
        {
            //xyChart.Series.Clear();
            //xyChart.ChartAreas.Clear();
            //xyChart.Titles.Clear();
        }

    }
}
