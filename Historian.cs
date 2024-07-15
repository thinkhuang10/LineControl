using CommonSnappableTypes;
using InfluxDB.Client;
using LineControl.Properties;
using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LineControl
{
    public partial class Historian: UserControl,IDCCEControl
    {
        #region 变量定义

        private readonly FormsPlot formsPlot = new FormsPlot() { Dock = DockStyle.Fill };
        private Plot plot;

        private const string ChartAreaName = "XYChartArea";
        private const string PointSeriesName = "XYPoint";
        private const string LineSeriesPrefixName = "XYLine";
        private const string SpecialSeriesName = "SpecialPointForLoad";
        private bool isInitSeriesInRunningStatus = false;

        private Save saveData = new Save();

        private string token = "n3rzVj62MZmpisZyy4VSlKaXc8IFMvHsWhQLzxsGXWZlRX5hzSVloAvCrLEacRDj1cS2x0uHUCGAhzR-lH99NQ==";

        private string orgID = "d726b22e0ead9045";

        private string projectGuid = "4B2DC4D9-38ED-42B8-6E2E-4665F0B54672";

        // 用于office测试
        //private static readonly string token = "NaoGum6B86URgxT9T5Pwyzn6w_O8wz1bPBEGF_pJQJ0oNCb0lEHX0uXRkNNQl8PvmL74T3RIaowshUpPzt-QCw==";
        //private string orgID = "9a08e84e2e95f668";

        #endregion

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

        #region 初始化

        public Historian()
        {
            InitializeComponent();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            InitPlot();
            InitDateTime();

            #region 用于测试

            isRuning = true;

            // 测试1
            //var width = formsPlot.Width;

            //DateTime start = new DateTime(2024, 1, 1);
            //double[] ys = Generate.RandomWalk(width);

            //var sig = formsPlot.Plot.Add.Signal(ys);
            //sig.Data.XOffset = start.ToOADate();
            //sig.Data.Period = 1.0; // one day between each point

            //formsPlot.Plot.Axes.DateTimeTicksBottom();

            // 测试2
            var count = 3;
            var minValues = new float[count];
            var maxValues = new float[count];
            var val = 0.0f;

            for (var i = 0; i < count; i++)
            {
                minValues[i] = val;
                maxValues[i] = val + 50;
                val++;

                if (val > 100)
                {
                    val = 0;
                }
            }

            for (var i = 0; i < count; i++)
            {
                var time = DateTime.Now + TimeSpan.FromSeconds(i);
                var line = plot.Add.Line(time.ToOADate(), minValues[i],
                    time.ToOADate(), maxValues[i]);
                line.LineColor = ScottPlot.Colors.White;

                if (i != count - 1)
                {
                    var timeMinAndMax = time + TimeSpan.FromSeconds(1);
                    var lineMinAndMax = plot.Add.Line(time.ToOADate(), maxValues[i],
                        timeMinAndMax.ToOADate(), minValues[i+1]);
                    lineMinAndMax.LineColor = ScottPlot.Colors.White;
                }
            }
            plot.Axes.DateTimeTicksBottom();

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

        private void InitDateTime()
        {
            startDtp.Value = DateTime.Now - TimeSpan.FromHours(1);
            endDtp.Value = DateTime.Now;
        }

        #endregion

        #region 设置曲线

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

            // 根据配置的曲线设置轴最大值和最小值
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

        #endregion

        #region 查询

        private async void btQuery_Click(object sender, EventArgs e)
        {
            if (!isRuning)
                return;

            if (startDtp.Value > endDtp.Value)
            {
                MessageBox.Show("起始时间大于结束时间.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 获取点的个数
            var count = 0;
            using (var influxDBClient = new InfluxDBClient("http://localhost:8086", token))
            {
                // TODO: 日期需要特殊处理,UTC既要带T，也要带Z
                var startTime = startDtp.Value.ToUniversalTime().ToString("s") + "Z";
                var endTime = endDtp.Value.ToUniversalTime().ToString("s") + "Z";

                // 获取表格的总行数
                var fluxCount = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] != \"quality\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"Tag7\")" + Environment.NewLine +
                    "|> count()";

                //var fluxCount = "import \"strings\"" + Environment.NewLine +
                //    "from(bucket: \"TestBucket\")" + Environment.NewLine +
                //    "|> range(start: 2022-01-01T08:00:00Z, stop: 2022-01-01T20:00:01Z)" + Environment.NewLine +
                //    "|> filter(fn: (r) => strings.containsStr(v: r.room, substr: \"Kit\") == true)" + Environment.NewLine +
                //    "|> toString()" + Environment.NewLine +
                //    "|> group(columns: [\"_measurement\"])" + Environment.NewLine +
                //    "|> count()";

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(fluxCount, orgID);
                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        int.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out count);
                    });
                });
            }

            // 获取控件的像素点数
            var plotWidth = formsPlot.Width;
            if (count > plotWidth)
            {
                var totalSeconds = (endDtp.Value - startDtp.Value).TotalSeconds;
                var gapSecond = ((int)totalSeconds) / plotWidth;
                RenderLineByOptimize(gapSecond);
            }
            else
            {
                RenderLineByNormal();
            }
        }

        private async void RenderLineByOptimize(double gapSecond)
        {
            var dateTimes = new List<DateTime>();
            var yMaxValues = new List<double>();
            var yMinValues = new List<double>();

            using (var influxDBClient = new InfluxDBClient("http://localhost:8086", token))
            {
                // TODO: 日期需要特殊处理,UTC既要带T，也要带Z
                var startTime = startDtp.Value.ToUniversalTime().ToString("s") + "Z";
                var endTime = endDtp.Value.ToUniversalTime().ToString("s") + "Z";

                var fluxMax = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] != \"quality\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"Tag7\")" + Environment.NewLine +
                    $"|> aggregateWindow(every: {gapSecond}s, fn: max)";

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(fluxMax, orgID);

                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);
                        double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out var yValue);

                        dateTimes.Add(dateTime);
                        yMaxValues.Add(yValue);
                    });
                });

                var fluxMin = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] != \"quality\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"Tag7\")" + Environment.NewLine +
                    $"|> aggregateWindow(every: {gapSecond}s, fn: min)";

                var fluxCountTableMin = await influxDBClient.GetQueryApi().QueryAsync(fluxMin, orgID);

                fluxCountTableMin.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);
                        double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out var yValue);

                        yMinValues.Add(yValue);
                    });
                });
            }

            plot.Clear();
            //var dateTimesArray = dateTimes.ToArray();
            //var yValuesArray = yMaxValues.ToArray();
            //for (int i = 0; i < dateTimes.Count; i++)
            //{
            //    //var line = plot.Add.Line(dateTimesArray[i].ToOADate(), yValuesArray[i], dateTimesArray[i].ToOADate(), yValuesArray[i]);
            //    var line = plot.Add.Line(dateTimesArray[i].ToOADate(), yValuesArray[i]-1, dateTimesArray[i].ToOADate(), yValuesArray[i]);
            //    line.LineColor = ScottPlot.Colors.White;
            //}
            ////plot.Axes.DateTimeTicksBottom();
            //formsPlot.Refresh();
        }

        private async void RenderLineByNormal()
        {
            var dateTimes = new List<DateTime>();
            var yValues = new List<double>();
            using (var influxDBClient = new InfluxDBClient("http://localhost:8086", token))
            {
                // TODO: 日期需要特殊处理,UTC既要带T，也要带Z
                var startTime = startDtp.Value.ToUniversalTime().ToString("s") + "Z";
                var endTime = endDtp.Value.ToUniversalTime().ToString("s") + "Z";

                var flux = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] != \"quality\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"Tag7\")";

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(flux, orgID);

                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);
                        double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out var yValue);

                        dateTimes.Add(dateTime);
                        yValues.Add(yValue);
                    });
                });
            }

            plot.Clear();
            var line = plot.Add.ScatterLine(dateTimes.ToArray(), yValues.ToArray());
            line.Color = ScottPlot.Colors.Green;
            line.LinePattern = LinePattern.Solid;

            plot.Axes.DateTimeTicksBottom();
            plot.Axes.Right.MinimumSize = 50;
            formsPlot.Refresh();
        }

        #endregion

    }
}
