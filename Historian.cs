using CommonSnappableTypes;
using InfluxDB.Client;
using LineControl.Properties;
using ScottPlot;
using ScottPlot.AxisPanels;
using ScottPlot.Panels;
using ScottPlot.Plottables;
using ScottPlot.TickGenerators;
using ScottPlot.TickGenerators.TimeUnits;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineControl
{
    public partial class Historian: UserControl,IDCCEControl
    {
        #region 变量定义

        private const string influxDBUrl = "http://localhost:8086";

        private const string token = "n3rzVj62MZmpisZyy4VSlKaXc8IFMvHsWhQLzxsGXWZlRX5hzSVloAvCrLEacRDj1cS2x0uHUCGAhzR-lH99NQ==";

        private const string orgID = "d726b22e0ead9045";

        private const string projectGuid = "4B2DC4D9-38ED-42B8-6E2E-4665F0B54672";

        private readonly FormsPlot formsPlot = new FormsPlot() { Dock = DockStyle.Fill };
        
        private Plot plot;

        private Save saveData = new Save();

        public DataTable dataTable;

        private Dictionary<string, List<object>> dicLine = new Dictionary<string, List<object>>();

        private Dictionary<string, LeftAxis> dicYAxis = new Dictionary<string, LeftAxis>();

        private AxisLine PlottableBeingDragged = null;

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
            ResourceManager resourceManager = new ResourceManager(typeof(Resources));
            return (Bitmap)resourceManager.GetObject("historian");
        }

        public Bitmap GetLogo()
        {
            var resourceManager = new ResourceManager(typeof(Resources));
            return (Bitmap)resourceManager.GetObject("historian");
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
        public new Cursor Cursor
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
            InitQueryGapType();
            InitPlot();
            InitPlotMenu();
            //TestSpan();
            InitDateTime();
            InitDatatable();
            //InitDoubleBuffer();
            SetDatatable();

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
            //var count = 1000;
            //var minValues = new float[count];
            //var maxValues = new float[count];
            //var val = 0.0f;
            //for (var i = 0; i < count; i++)
            //{
            //    minValues[i] = val;
            //    maxValues[i] = val + 50;
            //    val++;

            //    if (val > 100)
            //    {
            //        val = 0;
            //    }
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    var time = DateTime.Now + TimeSpan.FromSeconds(i);
            //    var line = plot.Add.Line(time.ToOADate(), minValues[i], time.ToOADate(), maxValues[i]);
            //    line.LineColor = ScottPlot.Colors.Red;

            //    if (i != count - 1)
            //    {
            //        var timeMinAndMax = time + TimeSpan.FromSeconds(1);
            //        var lineMinAndMax = plot.Add.Line(time.ToOADate(), maxValues[i], timeMinAndMax.ToOADate(), minValues[i + 1]);
            //        lineMinAndMax.LineColor = ScottPlot.Colors.Red;
            //    }
            //}
            //plot.Axes.DateTimeTicksBottom();

            #endregion

            SetPlotTitle();

            //// 注意函数顺序不能乱，渲染图形不正确
            //SetPlotBackground();
            //SetPlotGridColor();
            //SetXAxisTick();
            //SetYAxisTick();
            //SetXAxisTitle();
            //SetYAxisTitle();
            //SetTickStyle();
            //// SetLegend();

            //SetCursor();

            //RefreshPlot();

            // 测试
            ShowTestLine();

            // MouseTracker();
             //ShowValueOnHover();
        }

        private void InitQueryGapType()
        {
            cbQueryGapType.SelectedIndex = 0;
        }

        /// <summary>
        /// 开启双缓冲,减少表格的闪烁
        /// </summary>
        private void InitDoubleBuffer()
        {
            // 设置窗体的双缓冲
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            // 设置表格的双缓冲
            var type = dgvLines.GetType();
            var pi = type.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgvLines, true, null);
        }

        private void InitDatatable()
        {
            // 添加表格列并绑定数据源
            dataTable = new DataTable();
            dgvLines.DataSource = dataTable;

            // 添加所有列到表格中,并根据设置隐藏列
            for (var i = 0; i < saveData.AllColumns.Count; i++)
            {
                var columnName = saveData.AllColumns[i];

                if (columnName == CommonConstant.ColumnHeaderLineShow)
                {
                    var column = dataTable.Columns.Add(columnName, typeof(bool));
                    column.ReadOnly = false;
                }
                else
                {
                    var column = dataTable.Columns.Add(columnName);
                    if (columnName == CommonConstant.ColumnHeaderLineValue)
                    {
                        column.ReadOnly = false;
                    }
                    else
                    {
                        column.ReadOnly = true;
                    }
                }
            }

            // 设置列宽
            dgvLines.Columns[CommonConstant.ColumnHeaderLineColor].Width = 60;
            dgvLines.Columns[CommonConstant.ColumnHeaderLineName].Width = 200;
            dgvLines.Columns[CommonConstant.ColumnHeaderLineShow].Width = 80;
            dgvLines.Columns[CommonConstant.ColumnHeaderLineDescription].Width = 200;
            dgvLines.Columns[CommonConstant.ColumnHeaderLineUnit].Width = 60;
            dgvLines.Columns[CommonConstant.ColumnHeaderLowerLimit].Width = 80;
            dgvLines.Columns[CommonConstant.ColumnHeaderUpperLimit].Width = 80;

            // 禁止表格快速排序，避免bug
            for (var i = 0; i < dgvLines.Columns.Count; i++)
            {
                dgvLines.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 表格选中后的颜色设置
            dgvLines.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            dgvLines.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void SetDatatable()
        {
            foreach (var item in saveData.lineInfos)
            { 
                var dr = dataTable.NewRow();
                dr[CommonConstant.ColumnHeaderLineName] = item.Value.Name;
                dr[CommonConstant.ColumnHeaderLineShow] = true; // 默认显示
                dr[CommonConstant.ColumnHeaderLineDescription] = item.Value.Description;
                dr[CommonConstant.ColumnHeaderLineUnit] = item.Value.Unit;
                dr[CommonConstant.ColumnHeaderLowerLimit] = item.Value.LowerLimitValue;
                dr[CommonConstant.ColumnHeaderUpperLimit] = item.Value.UpperLimitValue;
                dataTable.Rows.Add(dr);
            }
        }

        private void dgvLines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLines.ClearSelection();
            for (var i = 0; i < dgvLines.Rows.Count; i++)
            {
                var lineName = dgvLines.Rows[i].Cells[CommonConstant.ColumnHeaderLineName].Value.ToString();

                if (!saveData.lineInfos.ContainsKey(lineName))
                    continue;

                dgvLines.Rows[i].Cells[CommonConstant.ColumnHeaderLineColor].Style.BackColor = saveData.lineInfos[lineName].LineColor;
            }
        }

        private void InitPlot()
        {
            plot = formsPlot.Plot;
            panelChart.Controls.Add(formsPlot);

            // 屏蔽ScottPlot自带的双击显示
            // 同时屏蔽掉放大,缩小，左右移动等操作
            formsPlot.Interaction.Disable();

            // 屏蔽ScottPlot自带的双击显示
            //PlotActions customActions = PlotActions.Standard();
            //customActions.ToggleBenchmark = delegate { };
            //formsPlot.Interaction.Enable(customActions);

            formsPlot.DoubleClick += chart_DoubleClick;

            //formsPlot.MouseMove += FormsPlot_MouseMove;
        }

        private void SetCursor()
        {
            // 添加游标
            var dataTime = (DateTime.Now - TimeSpan.FromMinutes(1)).ToOADate();
            var vl = formsPlot.Plot.Add.VerticalLine(dataTime);
            vl.IsDraggable = true;
            vl.Text = "";
            vl.LabelOppositeAxis = true;
            plot.Axes.Top.MinimumSize = 30;
            vl.LabelFontSize = 12;   // 设置游标显示的字体大小

            formsPlot.MouseDown += FormsPlot_MouseDown;
            formsPlot.MouseUp += FormsPlot_MouseUp;
            formsPlot.MouseMove += FormsPlot_MouseMove;
        }

        private void FormsPlot_MouseDown(object sender, MouseEventArgs e)
        {
            var lineUnderMouse = GetLineUnderMouse(e.X, e.Y);
            if (lineUnderMouse != null)
            {
                PlottableBeingDragged = lineUnderMouse;
            }
        }

        private void FormsPlot_MouseUp(object sender, MouseEventArgs e)
        {
            PlottableBeingDragged = null;
            formsPlot.Refresh();
        }

        private Callout callout;

        private void FormsPlot_MouseMove(object sender, MouseEventArgs e)
        {
            // this rectangle is the area around the mouse in coordinate units
            var rect = formsPlot.Plot.GetCoordinateRect(e.X, e.Y, radius: 10);
            if (PlottableBeingDragged is null)
            {
                // set cursor based on what's beneath the plottable
                var lineUnderMouse = GetLineUnderMouse(e.X, e.Y);
                if (lineUnderMouse is null) Cursor = Cursors.Default;
                else if (lineUnderMouse.IsDraggable && lineUnderMouse is VerticalLine) Cursor = Cursors.SizeWE;
                else if (lineUnderMouse.IsDraggable && lineUnderMouse is HorizontalLine) Cursor = Cursors.SizeNS;
            }
            else
            {
                // update the position of the plottable being dragged
                if (PlottableBeingDragged is VerticalLine vl)
                {
                    vl.X = rect.HorizontalCenter;
                    //vl.Text = $"{vl.X:0.00}";
                    vl.Text = DateTime.FromOADate(vl.X).ToString("yyyy-MM-dd HH:mm:ss");

                    var mousePixel = new Pixel(e.Location.X, e.Location.Y);
                    var mouseLocation = formsPlot.Plot.GetCoordinates(mousePixel);
                    var nearest = MyScatter.Data.GetNearestX(mouseLocation, formsPlot.Plot.LastRender);

                    // place the crosshair over the highlighted point
                    if (nearest.IsReal)
                    {
                        dataTable.Rows[0][CommonConstant.ColumnHeaderLineValue] = nearest.Y;

                        if (null == callout)
                        {
                            callout = plot.Add.Callout(nearest.Y.ToString(), mouseLocation, mouseLocation);
                        }
                        else
                        {
                            callout.Text = nearest.Y.ToString();
                            callout.TextCoordinates = mouseLocation;
                            callout.TipCoordinates = new Coordinates();
                        }
                    }
                }
                formsPlot.Refresh();
            }
        }

        private AxisLine GetLineUnderMouse(float x, float y)
        {
            var rect = formsPlot.Plot.GetCoordinateRect(x, y, radius: 10);
            foreach (AxisLine axLine in formsPlot.Plot.GetPlottables<AxisLine>().Reverse())
            {
                if (axLine.IsUnderMouse(rect))
                    return axLine;
            }

            return null;
        }

        private void InitPlotMenu()
        {
            // 清空右键菜单
            formsPlot.Menu.Clear();

            // 自定义右键菜单
            formsPlot.Menu.Add("导出图片", (formsplot) =>
            {
                btExport_Click(null,null);
            });

            formsPlot.Menu.Add("粘贴到剪贴板", (formsplot) =>
            {
                CopyImageToClipboard(formsplot);
            });

            formsPlot.Menu.Add("打开新窗口", (formsplot) =>
            {
                OpenInNewWindow(formsplot);
            });
        }

        private void OpenInNewWindow(IPlotControl ctrl)
        {
            var fp = new FormsPlot() { Dock = DockStyle.Fill };
            fp.Reset(ctrl.Plot);

            var form = new Form();
            form.Controls.Add(fp);
            form.ShowDialog();
        }

        private static void CopyImageToClipboard(IPlotControl plotControl)
        {
            var lastRenderSize = plotControl.Plot.RenderManager.LastRender.FigureRect.Size;
            var bmp = plotControl.Plot.GetImage((int)lastRenderSize.Width, (int)lastRenderSize.Height);
            byte[] bmpBytes = bmp.GetImageBytes();

            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(bmpBytes, 0, bmpBytes.Length);
                Bitmap bmpImage = new Bitmap(ms);
                Clipboard.SetImage(bmpImage);
            }
        }

        private void TestSpan()
        {
            var span = plot.Add.HorizontalSpan((DateTime.Now - TimeSpan.FromSeconds(60)).ToOADate(), 
                (DateTime.Now - TimeSpan.FromSeconds(30)).ToOADate());

            span.FillColor = Colors.LightYellow.WithOpacity(0.3) ;
            span.IsDraggable = true;
            span.IsResizable = true;
        }

        private void InitDateTime()
        {
            // TODO：测试,获取两分钟的数据
            dtpStart.Value = DateTime.Now - TimeSpan.FromMinutes(2);

            //startDtp.Value = DateTime.Now - TimeSpan.FromHours(1);
            dtpEnd.Value = DateTime.Now;
        }

        #endregion

        #region 设置曲线

        private void SetPlotTitle()
        {
            if (string.IsNullOrEmpty(saveData.chartTitle))
                return;

            plot.Title(saveData.chartTitle);                                // 设置标题文本
                                       
            plot.Axes.Title.Label.ForeColor = ScottPlot.Color.FromColor(saveData.chartTitleColor);   // 设置标题颜色
            plot.Axes.Title.Label.FontSize = saveData.chartTitleSize;       // 设置标题字体大小
            plot.Axes.Title.Label.Bold = saveData.chartTitleIsBold;         // 设置标题是否为粗体           
        }

        /// <summary>
        /// 注意渲染的先后顺序,需要放在后面
        /// 设置X轴Label信息
        /// </summary>
        private void SetXAxisTitle()
        {
            plot.Axes.Bottom.Label.Text = saveData.xAxisTitle;
            plot.Axes.Bottom.Label.ForeColor = ScottPlot.Color.FromColor(saveData.xAxisTitleForeColor);
            plot.Axes.Bottom.Label.FontSize = saveData.xAxisTitleSize;
        }

        /// <summary>
        /// 设置Y轴Label信息
        /// </summary>
        private void SetYAxisTitle()
        {
            plot.Axes.Left.Label.Text = saveData.yAxisTitle;
            plot.Axes.Left.Label.ForeColor = ScottPlot.Color.FromColor(saveData.yAxisTitleForeColor);
            plot.Axes.Left.Label.FontSize = saveData.yAxisTitleSize;
        }

        /// <summary>
        /// 设置背景色和前景色
        /// </summary>
        private void SetPlotBackground()
        {
            plot.FigureBackground.Color = ScottPlot.Color.FromColor(saveData.chartBackColor);
            plot.DataBackground.Color = ScottPlot.Color.FromColor(saveData.chartForeColor);
        }

        /// <summary>
        /// 设置网格颜色
        /// </summary>
        private void SetPlotGridColor()
        {
            plot.Grid.MajorLineColor = ScottPlot.Color.FromColor(saveData.gridColor).WithOpacity(.5);
            plot.Grid.MinorLineColor = ScottPlot.Color.FromColor(saveData.gridColor).WithOpacity(.5);
        }

        /// <summary>
        /// 设置X轴网格间隔
        /// 特殊处理：添加曲线，为了在非运行状态下画出X轴
        /// </summary>
        private void SetXAxisTick()
        {
            //// 严格分割网格
            //var dateDoubles = new DateTime[saveData.verticalGridCount];
            //double[] valueDoubles = new double[saveData.verticalGridCount];
            //var startTime = startDtp.Value;
            //var endTime = endDtp.Value;
            //var timeGap = endTime.Subtract(startTime).TotalSeconds / saveData.verticalGridCount;
            //for (int i = 0; i < saveData.verticalGridCount; i++)
            //{
            //    dateDoubles[i] = startTime + TimeSpan.FromSeconds(i * timeGap);
            //    valueDoubles[i] = 0;
            //}
            //var line = plot.Add.Scatter(dateDoubles, valueDoubles);
            //line.Color = Colors.Transparent;    // 曲线设置为看不见

            //plot.Axes.SetLimitsX(startTime.ToOADate(), endTime.ToOADate());
            //var dtx = plot.Axes.DateTimeTicksBottom();
            //dtx.TickGenerator = new DateTimeFixedInterval(new Second(), (int)timeGap);

            // 自动化分割网格
            var startTime = dtpStart.Value;
            var endTime = dtpEnd.Value;
            
            var dtx = plot.Axes.DateTimeTicksBottom();
            var timeGap = endTime.Subtract(startTime).TotalSeconds / saveData.verticalGridCount;
            dtx.TickGenerator = new DateTimeFixedInterval(new Second(), (int)timeGap);
            plot.Axes.SetLimitsX(startTime.ToOADate(), endTime.ToOADate());

            // 设置日期的格式
            plot.RenderManager.RenderStarting += (s, e) =>
            {
                Tick[] ticks = plot.Axes.Bottom.TickGenerator.Ticks;
                for (int i = 0; i < ticks.Length; i++)
                {
                    var dt = DateTime.FromOADate(ticks[i].Position);
                    var label = $"{dt:   HH:mm:ss}" + Environment.NewLine + $"{dt:yyyy-MM-dd}";
                    ticks[i] = new Tick(ticks[i].Position, label);
                }
            };
        }

        /// <summary>
        /// 设置Y轴网格间隔
        /// 没有设置曲线,Y轴最大最小范围为0~100
        /// </summary>
        private void SetYAxisTick()
        {
            //// 严格分割网格
            //if (saveData.lineInfos.Count == 0)
            //{
            //    plot.Axes.Left.TickGenerator = new NumericFixedInterval(100 / saveData.horizonalGridCount);
            //    plot.Axes.SetLimitsY(0, 100);
            //}
            //else
            //{
            //    var max = saveData.lineInfos.Values.Max(x => x.UpperLimitValue);
            //    var min = saveData.lineInfos.Values.Min(x => x.LowerLimitValue);
            //    var interval = (int)((max - min) / saveData.horizonalGridCount);
            //    plot.Axes.Left.TickGenerator = new NumericFixedInterval(interval);
            //    plot.Axes.SetLimitsY(min, max);
            //}

            // 自动化分割网格
            //plot.Axes.Left.TickGenerator = new NumericAutomatic
            //{
            //    TargetTickCount = saveData.horizonalGridCount,
            //};
            //if (saveData.lineInfos.Count == 0)
            //{
            //    plot.Axes.SetLimitsY(0, 100);
            //}
            //else
            //{
            //    var max = saveData.lineInfos.Values.Max(x => x.UpperLimitValue);
            //    var min = saveData.lineInfos.Values.Min(x => x.LowerLimitValue);
            //    plot.Axes.SetLimitsY(min, max);
            //}

            //if (0 != dgvLines.Rows.Count)
            //{ 
            //
            //}


            //if (saveData.isSingleAxisShow)
            {
                #region 单轴显示

                //plot.Axes.Remove(Edge.Left);
                //var yAxes = plot.Axes.AddLeftAxis();
                //yAxes.TickGenerator = new NumericAutomatic
                //{
                //    TargetTickCount = saveData.horizonalGridCount,
                //};

                //if (saveData.lineInfos.Count == 0)
                //{
                //    plot.Axes.SetLimitsY(0, 100);
                //}
                //else
                //{
                //    var max = saveData.lineInfos.First().Value.UpperLimitValue;
                //    var min = saveData.lineInfos.First().Value.LowerLimitValue;
                //    plot.Axes.SetLimitsY(min, max);
                //}

                //// 添加轴信息
                //foreach (var item in saveData.lineInfos)
                //{
                //    var lineName = item.Value.Name;
                //    if (!dicYAxis.ContainsKey(lineName))
                //    {
                //        dicYAxis.Add(lineName, yAxes);
                //    }
                //    else
                //    {
                //        dicYAxis[lineName] = yAxes;
                //    }
                //}

                #endregion
            }
            //else 
            {
                #region 多轴显示

                plot.Axes.Remove(Edge.Left);
                for (var i = 0; i < dgvLines.Rows.Count; i++)
                {
                    var lineName = dgvLines.Rows[i].Cells[CommonConstant.ColumnHeaderLineName].Value.ToString();

                    if (!saveData.lineInfos.ContainsKey(lineName))
                        continue;

                    var lineInfo = saveData.lineInfos[lineName];
                    if (!dicYAxis.ContainsKey(lineName))
                    {
                        dicYAxis.Add(lineName, plot.Axes.AddLeftAxis());
                    }
                    else
                    {
                        dicYAxis[lineName] = plot.Axes.AddLeftAxis();
                    }

                    var yAxis = dicYAxis[lineName];
                    yAxis.TickGenerator = new NumericAutomatic
                    {
                        TargetTickCount = saveData.horizonalGridCount,
                    };

                    yAxis.MinorTickStyle.Color = ScottPlot.Color.FromColor(lineInfo.LineColor);
                    yAxis.MajorTickStyle.Color = ScottPlot.Color.FromColor(lineInfo.LineColor);
                    yAxis.FrameLineStyle.Color = ScottPlot.Color.FromColor(lineInfo.LineColor);
                    yAxis.TickLabelStyle.ForeColor = ScottPlot.Color.FromColor(lineInfo.LineColor);

                    var max = lineInfo.UpperLimitValue;
                    var min = lineInfo.LowerLimitValue;

                    yAxis.Min = min;
                    yAxis.Max = max;
                }

                // 控制轴的显示和隐藏
                if (saveData.isSingleAxisShow)
                {
                    foreach (var item in dicYAxis.Values)
                    { 
                        item.IsVisible = false;  
                    }

                    dicYAxis.FirstOrDefault().Value.IsVisible = true;
                }

                #endregion
            }

            //var axes = plot.Axes.GetAxes();
            //var axesCount = axes.Count();
        }

        /// <summary>
        /// 设置标注颜色
        /// </summary>
        private void SetTickStyle()
        {
            plot.Axes.Bottom.MinorTickStyle.Color = ScottPlot.Color.FromColor(saveData.axisLabelColor);
            plot.Axes.Bottom.MajorTickStyle.Color = ScottPlot.Color.FromColor(saveData.axisLabelColor);
            plot.Axes.Bottom.FrameLineStyle.Color = ScottPlot.Color.FromColor(saveData.axisLabelColor);
            plot.Axes.Bottom.TickLabelStyle.ForeColor = ScottPlot.Color.FromColor(saveData.axisLabelColor);

            //plot.Axes.Left.MinorTickStyle.Color = ScottPlot.Color.FromColor(saveData.axisLabelColor);
            //plot.Axes.Left.MajorTickStyle.Color = ScottPlot.Color.FromColor(saveData.axisLabelColor);
            //plot.Axes.Left.FrameLineStyle.Color = ScottPlot.Color.FromColor(saveData.axisLabelColor);
            //plot.Axes.Left.TickLabelStyle.ForeColor = ScottPlot.Color.FromColor(saveData.axisLabelColor);
        }

        private LegendPanel rightLegend;

        private void SetLegend()
        {
            plot.HideLegend();
            if (!saveData.isShowLegend)
            {
                plot.HideLegend();
                return;
            }

            var legendItems = new List<LegendItem>();
            foreach (var lineName in saveData.lineInfos.Keys)
            { 
                var lineInfo = saveData.lineInfos[lineName];
                var item = new LegendItem()
                {
                    LineColor = ScottPlot.Color.FromColor(lineInfo.LineColor),
                    MarkerFillColor = ScottPlot.Color.FromColor(lineInfo.LineColor),
                    MarkerLineColor = ScottPlot.Color.FromColor(lineInfo.LineColor),
                    LineWidth = lineInfo.LineWidth,
                    LabelText = lineName
                };
                legendItems.Add(item);
            }

            var panel = plot.ShowLegend(legendItems);
            if (saveData.legendPosition == "上方")
            {
                panel.Alignment = Alignment.UpperCenter;
                panel.Orientation = ScottPlot.Orientation.Horizontal;
            }
            else 
            {
                panel.Alignment = Alignment.LowerRight;
                panel.Orientation = ScottPlot.Orientation.Vertical;
            }
        }

        private void chart_DoubleClick(object sender, EventArgs e)
        {
            var form = new SetForm(saveData);
            form.GetVarTableEvent += GetVarTableEvent;
            if (DialogResult.OK != form.ShowDialog())
                return;

            SetPlotTitle();

            // 注意函数顺序不能乱，渲染图形不正确
            SetPlotBackground();
            SetPlotGridColor();
            SetXAxisTick();
            SetYAxisTick();
            SetXAxisTitle();
            SetYAxisTitle();
            SetTickStyle();
            //SetLegend();

            RefreshPlot();
        }

        private void RefreshPlot()
        {
            plot.Font.Automatic();// 避免中文字符显示乱码
            formsPlot.Refresh();
        }

        #endregion

        #region 查询

        private async void btQuery_Click(object sender, EventArgs e)
        {
            // TODO: 用于测试的曲线
            ShowTestLine();

            #region 使用时间段的方式



            #endregion

            #region 使用起始时间和结束时间的方式

            //// 实际查询曲线
            //if (!isRuning)
            //    return;

            //if (dtpStart.Value > dtpEnd.Value)
            //{
            //    MessageBox.Show("起始时间大于结束时间.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (saveData.lineInfos.Count == 0)
            //    return;

            //plot.Clear();

            //foreach (var tagName in saveData.lineInfos.Keys)
            //{
            //    var lineInfo = saveData.lineInfos[tagName];
            //    var linePointCount = await GetLinePointCount(tagName);

            //    // 一定要等待曲线绘制完成
            //    await RenderLines(lineInfo, linePointCount);
            //}

            //SetPlotBackground();
            //SetPlotGridColor();

            //SetXAxisTick();
            //SetYAxisTick();
            //SetXAxisTitle();
            //SetYAxisTitle();

            //SetTickStyle();
            //SetLegend();

            //RefreshPlot();

            #endregion
        }

        private void ShowTestLine()
        {
            plot.Clear();

            SetPlotBackground();
            SetPlotGridColor();

            SetXAxisTick();
            SetYAxisTick();

            //TestLine1();
            //TestLine2();

            TestLine1_Optimize();
            TestLine2_Optimize();

            SetXAxisTitle();
            SetYAxisTitle();

            SetTickStyle();
            //SetLegend();

            SetCursor();

            RefreshPlot();
        }

        private void TestLine1_Optimize()
        {
            var count = 1000;
            var minValues = new float[count];
            var maxValues = new float[count];
            var val = -15.0f;
            for (var i = 0; i < count; i++)
            {
                minValues[i] = val;
                maxValues[i] = val + 1;
                val++;

                if (val > 15)
                {
                    val = -15;
                }
            }

            // 添加曲线1
            var lineName = "Tag3";
            if (!dicLine.ContainsKey(lineName))
            {
                dicLine.Add(lineName, new List<object>());
            }
            else
            {
                dicLine[lineName] = new List<object>();
            }

            var xDoubles = new List<double>();
            var yDoubles = new List<double>();
            for (int i = 0; i < count; i++)
            {
                var time = (dtpStart.Value + TimeSpan.FromSeconds(i)).ToOADate();
                xDoubles.Add(time);
                yDoubles.Add(minValues[i]);

                xDoubles.Add(time);
                yDoubles.Add(maxValues[i]);
            }

            var line = plot.Add.ScatterLine(xDoubles.ToArray(), yDoubles.ToArray());
            line.Axes.YAxis = dicYAxis[lineName];
            line.LineColor = ScottPlot.Colors.Green;
            dicLine[lineName].Add(line);

            MyScatter = line;
        }

        private void TestLine2_Optimize()
        {
            var count = 1000;
            var minValues = new float[count];
            var maxValues = new float[count];
            var val = 120.0f;
            for (var i = 0; i < count; i++)
            {
                minValues[i] = val;
                maxValues[i] = val + 1;
                val++;

                if (val > 180)
                {
                    val = 120;
                }
            }

            // 添加曲线7
            var lineName = "Tag7";
            if (!dicLine.ContainsKey(lineName))
            {
                dicLine.Add(lineName, new List<object>());
            }
            else
            {
                dicLine[lineName] = new List<object>();
            }

            var xDoubles = new List<double>();
            var yDoubles = new List<double>();
            for (int i = 0; i < count; i++)
            {
                var time = (dtpStart.Value + TimeSpan.FromSeconds(i)).ToOADate();
                xDoubles.Add(time);
                yDoubles.Add(minValues[i]);

                xDoubles.Add(time);
                yDoubles.Add(maxValues[i]);
            }

            var line = plot.Add.SignalXY(xDoubles.ToArray(), yDoubles.ToArray());
            line.Axes.YAxis = dicYAxis[lineName];
            line.LineColor = ScottPlot.Colors.Red;
            dicLine[lineName].Add(line);
        }

        private void TestLine1()
        {
            var count = 1000;
            var minValues = new float[count];
            var maxValues = new float[count];
            var val = -15.0f;
            for (var i = 0; i < count; i++)
            {
                minValues[i] = val;
                maxValues[i] = val + 1;
                val++;

                if (val > 15)
                {
                    val = -15;
                }
            }

            
            var lineName1 = "Tag3";

            // 添加Y轴1
            //dicYAxis.Add(lineName1, plot.Axes.AddLeftAxis());
            
            // 添加曲线1
            if (!dicLine.ContainsKey(lineName1))
            {
                dicLine.Add(lineName1, new List<object>());
            }
            else
            {
                dicLine[lineName1] = new List<object>();
            }

            for (int i = 0; i < count; i++)
            {
                var time = dtpStart.Value + TimeSpan.FromSeconds(i);
                var line = plot.Add.Line(time.ToOADate(), minValues[i], time.ToOADate(), maxValues[i]);
                line.LineColor = ScottPlot.Colors.Green;

                line.Axes.YAxis = dicYAxis[lineName1]; // custom Y axis
                dicLine[lineName1].Add(line);

                if (i != count - 1)
                {
                    var timeMinAndMax = time + TimeSpan.FromSeconds(1);
                    var lineMinAndMax = plot.Add.Line(time.ToOADate(), maxValues[i], timeMinAndMax.ToOADate(), minValues[i + 1]);
                    lineMinAndMax.LineColor = ScottPlot.Colors.Green;

                    lineMinAndMax.Axes.YAxis = dicYAxis[lineName1]; // custom Y axis
                    dicLine[lineName1].Add(lineMinAndMax);
                }
            }
        }

        private void TestLine2()
        {
            var count = 1000;
            var minValues = new float[count];
            var maxValues = new float[count];
            var val = 120.0f;
            for (var i = 0; i < count; i++)
            {
                minValues[i] = val;
                maxValues[i] = val + 1;
                val++;

                if (val > 180)
                {
                    val = 120;
                }
            }

            var lineName1 = "Tag7";

            // 添加Y轴7
            //dicYAxis.Add(lineName1, plot.Axes.AddLeftAxis());

            // 添加曲线7
            if (!dicLine.ContainsKey(lineName1))
            {
                dicLine.Add(lineName1, new List<object>());
            }
            else
            {
                dicLine[lineName1] = new List<object>();
            }

            for (int i = 0; i < count; i++)
            {
                var time = dtpStart.Value + TimeSpan.FromSeconds(i);
                var line = plot.Add.Line(time.ToOADate(), minValues[i], time.ToOADate(), maxValues[i]);
                line.LineColor = ScottPlot.Colors.Red;

                line.Axes.YAxis = dicYAxis[lineName1]; // custom Y axis
                dicLine[lineName1].Add(line);

                if (i != count - 1)
                {
                    var timeMinAndMax = time + TimeSpan.FromSeconds(1);
                    var lineMinAndMax = plot.Add.Line(time.ToOADate(), maxValues[i], timeMinAndMax.ToOADate(), minValues[i + 1]);
                    lineMinAndMax.LineColor = ScottPlot.Colors.Red;

                    lineMinAndMax.Axes.YAxis = dicYAxis[lineName1]; // custom Y axis
                    dicLine[lineName1].Add(lineMinAndMax);
                }
            }
        }

        private async Task RenderLines(LineInfo lineInfo,int linePointCount)
        {
            var plotWidth = formsPlot.Width;     // 获取控件的像素点数
            if (linePointCount > plotWidth)
            {
                var totalSeconds = (dtpEnd.Value - dtpStart.Value).TotalSeconds;
                var gapSecond = ((int)totalSeconds) / plotWidth;
                await RenderLineByOptimize(lineInfo.Name, gapSecond, lineInfo);
            }
            else
            {
                await RenderLineByNormal(lineInfo);
            }
        }

        private async Task<int> GetLinePointCount(string tagName)
        {
            var count = 0;
            using (var influxDBClient = new InfluxDBClient(influxDBUrl, token))
            {
                // TODO: 日期需要特殊处理,UTC既要带T，也要带Z
                var startTime = dtpStart.Value.ToUniversalTime().ToString("s") + "Z";
                var endTime = dtpEnd.Value.ToUniversalTime().ToString("s") + "Z";

                // 获取表格的总行数
                var fluxCount = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] != \"quality\")" + Environment.NewLine +
                    $"|> filter(fn: (r) => r[\"name\"] == \"{tagName}\")" + Environment.NewLine +
                    "|> count()";

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

            return count;
        }

        private async Task RenderLineByOptimize(string tagName, double gapSecond,LineInfo lineInfo)
        {
            var dateTimes = new List<DateTime>();
            var yMaxValues = new List<double>();
            var yMinValues = new List<double>();

            using (var influxDBClient = new InfluxDBClient(influxDBUrl, token))
            {
                // TODO: 日期需要特殊处理,UTC既要带T，也要带Z
                var startTime = dtpStart.Value.ToUniversalTime().ToString("s") + "Z";
                var endTime = dtpEnd.Value.ToUniversalTime().ToString("s") + "Z";

                var fluxMax = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] == \"ivalue\" or r[\"_field\"] == \"bvalue\" or r[\"_field\"] == \"dvalue\")" + Environment.NewLine +
                    $"|> filter(fn: (r) => r[\"name\"] == \"{tagName}\")" + Environment.NewLine +
                    $"|> aggregateWindow(every: {gapSecond}s, fn: max)";

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(fluxMax, orgID);
                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);
                        
                        double yValue = 0;
                        if (null != fluxRecord.GetValueByKey("_value"))
                        {
                            double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out yValue);
                        }

                        dateTimes.Add(dateTime);
                        yMaxValues.Add(yValue);
                    });
                });

                var fluxMin = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] == \"ivalue\" or r[\"_field\"] == \"bvalue\" or r[\"_field\"] == \"dvalue\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"Tag7\")" + Environment.NewLine +
                    $"|> aggregateWindow(every: {gapSecond}s, fn: min)";

                var fluxCountTableMin = await influxDBClient.GetQueryApi().QueryAsync(fluxMin, orgID);

                fluxCountTableMin.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);

                        double yValue = 0;
                        if (null != fluxRecord.GetValueByKey("_value"))
                        {
                            double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out yValue);
                        }

                        yMinValues.Add(yValue);
                    });
                });
            }

            // 清空曲线重新添加
            if (!dicLine.ContainsKey(tagName))
            {
                dicLine.Add(tagName, new List<object>());
            }
            else
            {
                dicLine[tagName] = new List<object>();
            }

            var count = dateTimes.Count;
            for (var i = 0; i < count; i++)
            {
                var line = plot.Add.Line(dateTimes[i].ToOADate(), yMinValues[i], 
                    dateTimes[i].ToOADate(), yMaxValues[i]);
                line.LineColor = ScottPlot.Color.FromColor(lineInfo.LineColor);
                line.LineWidth = lineInfo.LineWidth;

                dicLine[tagName].Add(line); // 添加到字典中便于显示和隐藏

                if (i != count - 1)
                {
                    var lineMinAndMax = plot.Add.Line(dateTimes[i].ToOADate(), yMaxValues[i], 
                        dateTimes[i+1].ToOADate(), yMinValues[i + 1]);
                    lineMinAndMax.LineColor = ScottPlot.Color.FromColor(lineInfo.LineColor);
                    lineMinAndMax.LineWidth = lineInfo.LineWidth;

                    dicLine[tagName].Add(lineMinAndMax);// 添加到字典中便于显示和隐藏
                }

            }
        }

        private async Task RenderLineByNormal(LineInfo lineInfo)
        {
            var dateTimes = new List<DateTime>();
            var yValues = new List<double>();
            using (var influxDBClient = new InfluxDBClient(influxDBUrl, token))
            {
                // TODO: 日期需要特殊处理,UTC既要带T，也要带Z
                var startTime = dtpStart.Value.ToUniversalTime().ToString("s") + "Z";
                var endTime = dtpEnd.Value.ToUniversalTime().ToString("s") + "Z";

                var flux = $"from(bucket: \"RealTime_{projectGuid}\")" + Environment.NewLine +
                    $"|> range(start: {startTime}, stop: {endTime})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] == \"ivalue\" or r[\"_field\"] == \"bvalue\" or r[\"_field\"] == \"dvalue\")" + Environment.NewLine +
                    $"|> filter(fn: (r) => r[\"name\"] == \"{lineInfo.Name}\")";

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(flux, orgID);
                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);

                        double yValue =0;
                        if (null != fluxRecord.GetValueByKey("_value"))
                        {
                            double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out yValue);
                        }

                        dateTimes.Add(dateTime);
                        yValues.Add(yValue);
                    });
                });
            }

            var line = plot.Add.ScatterLine(dateTimes.ToArray(), yValues.ToArray());
            line.Color = ScottPlot.Color.FromColor(lineInfo.LineColor);
            line.LineWidth = lineInfo.LineWidth;

            // 曲线加入数据字典中, 便于显示和隐藏
            var lineName = lineInfo.Name;
            if (!dicLine.ContainsKey(lineName))
            {
                dicLine.Add(lineName, new List<object>());
            }
            else
            {
                dicLine[lineName] = new List<object>();
            }
            dicLine[lineInfo.Name].Add(line);
        }

        #endregion

        #region 刷新

        /// <summary>
        /// 放大后刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRefresh_Click(object sender, EventArgs e)
        {
            // 获取到当前时间戳并重新查询
            var min = plot.Axes.GetAxes(Edge.Bottom).First().Min;
            var max = plot.Axes.GetAxes(Edge.Bottom).First().Max;
            var minDateTime = DateTime.FromOADate(min);
            var maxDateTime = DateTime.FromOADate(max);

            // 点击刷新会更改控件的日期范围并自动触发刷新
            dtpStart.Value = minDateTime;
            dtpEnd.Value = maxDateTime;

            btQuery_Click(null,null);
        }

        #endregion

        #region 放大缩小

        private void btReset_Click(object sender, EventArgs e)
        {
            btQuery_Click(null, null);
        }

        private void btZoomIn_Click(object sender, EventArgs e)
        {
            // 放大倍数，目前是默认同时上下左右放大1.1倍
            plot.Axes.ZoomIn(1, 1.1);
            formsPlot.Refresh();
        }

        private void btZoomOut_Click(object sender, EventArgs e)
        {
            // 放大倍数，目前是默认同时上下左右缩小1.1倍
            plot.Axes.ZoomOut(1, 1.1);
            formsPlot.Refresh();
        }

        private void btPanningLeft_Click(object sender, EventArgs e)
        {
            // TODO: 固定向左偏移,固定30秒
            // 获取到当前时间戳并重新查询
            var minDate = plot.Axes.GetAxes(Edge.Bottom).First().Min;
            var minDateTime = DateTime.FromOADate(minDate);
            var expectedDate = minDateTime.AddSeconds(30).ToOADate();

            var offset = new CoordinateOffset(minDate - expectedDate, 0);
            plot.Axes.Pan(offset);
            formsPlot.Refresh();
        }

        private void btPanningRight_Click(object sender, EventArgs e)
        {
            // TODO: 固定向右偏移,固定30秒
            // 获取到当前时间戳并重新查询
            var maxDate = plot.Axes.GetAxes(Edge.Bottom).First().Max;
            var maxDateTime = DateTime.FromOADate(maxDate);
            var expectedDate = maxDateTime.AddSeconds(30).ToOADate();

            var offset = new CoordinateOffset(expectedDate - maxDate, 0);
            plot.Axes.Pan(offset);
            formsPlot.Refresh();
        }

        private void btPanningUp_Click(object sender, EventArgs e)
        {
            // TODO: 固定向上偏移10
            var offset = new CoordinateOffset(0, 10);
            plot.Axes.Pan(offset);
            formsPlot.Refresh();
        }

        private void btPanningDown_Click(object sender, EventArgs e)
        {
            // TODO: 固定向下偏移10
            var offset = new CoordinateOffset(0, -10);
            plot.Axes.Pan(offset);
            formsPlot.Refresh();
        }

        #endregion

        #region 导出图片

        private void btExport_Click(object sender, EventArgs e)
        {
            if (!isRuning)
                return;

            var dialog = new SaveFileDialog
            {
                Filter = "Png 图片|*.png",
                FilterIndex = 0,
                RestoreDirectory = true,    //保存对话框是否记忆上次打开的目录
                CheckPathExists = true      //检查目录
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
                
            plot.SavePng(dialog.FileName, formsPlot.Width, formsPlot.Height);
            //MessageBox.Show("图片保存成功.", "信息提示");
        }

        #endregion

        #region 打印

        private void btPrintPreview_Click(object sender, EventArgs e)
        {
            if (!isRuning)
                return;

            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            var printDialog = new PrintPreviewDialog { Document = printDocument };
            printDialog.ShowDialog();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (!isRuning)
                return;

            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            var printDialog = new PrintDialog { Document = printDocument };
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Determine how large you want the plot to be on the page and resize accordingly
            int width = e.MarginBounds.Width;
            int height = (int)(e.MarginBounds.Width * .5);

            // Render the plot as a Bitmap and draw it onto the page
            var image = plot.GetImage(width, height);
            e.Graphics.DrawImage(image.GetBitmap(), e.MarginBounds.Left, e.MarginBounds.Top);
        }

        #endregion

        #region 按钮提示

        private void btQuery_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btQuery, "查询");
        }

        private void btExport_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btExport, "导出图片");
        }

        private void btPrintPreview_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btPrintPreview, "打印预览");
        }

        private void btPrint_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btPrint, "打印");
        }

        private void btReset_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btReset, "重置");
        }

        private void btZoomIn_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btZoomIn, "放大");
        }

        private void btZoomOut_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btZoomOut, "缩小");
        }

        private void btPanningLeft_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btPanningLeft, "左移");
        }

        private void btPanningRight_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btPanningRight, "右移");
        }

        private void btPanningUp_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btPanningUp, "上移");
        }

        private void btPanningDown_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btPanningDown, "下移");
        }

        private void btRefresh_MouseEnter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btRefresh, "刷新");
        }

        #endregion

        private void dgvLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLines.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var checkCell = (DataGridViewCheckBoxCell)dgvLines.Rows[e.RowIndex].Cells[CommonConstant.ColumnHeaderLineShow];
            var isChecked = !(bool)checkCell.Value;

            var textBoxCell =(DataGridViewTextBoxCell)dgvLines.Rows[e.RowIndex].Cells[CommonConstant.ColumnHeaderLineName];
            var lineName = textBoxCell.Value.ToString();

            if (dicLine.ContainsKey(lineName))
            {
                foreach (var item in dicLine[lineName])
                {
                    // 判断是否为LinePlot
                    var linePlot = item as LinePlot;
                    if (null != linePlot)
                    {
                        if (isChecked)
                            linePlot.IsVisible = false;
                        else
                            linePlot.IsVisible = true;

                        continue;
                    }

                    // 判断是否为Scatter
                    var scatter = item as Scatter;
                    if (null != scatter)
                    {
                        if (isChecked)
                            scatter.IsVisible = false;
                        else
                            scatter.IsVisible = true;

                        continue;
                    }
                }

                formsPlot.Refresh();
            }
        }

        private void dgvLines_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // 显示行号
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dgvLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            if (saveData.isSingleAxisShow)
            {
                foreach (var item in dicYAxis.Values)
                {
                    item.IsVisible = false;
                }

                var lineName = dgvLines.Rows[rowIndex].Cells[CommonConstant.ColumnHeaderLineName].Value.ToString();

                if (dicYAxis.ContainsKey(lineName))
                {
                    dicYAxis[lineName].IsVisible = true;
                }
            }
        }

        #region 便于调试的代码

        private Scatter MyScatter;
        public void ShowValueOnHover()
        {
            formsPlot.MouseMove += (s, e) =>
            {
                // determine where the mouse is and get the nearest point
                var mousePixel = new Pixel(e.Location.X, e.Location.Y);
                var mouseLocation = formsPlot.Plot.GetCoordinates(mousePixel);
                var nearest = MyScatter.Data.GetNearestX(mouseLocation, formsPlot.Plot.LastRender);

                // place the crosshair over the highlighted point
                if (nearest.IsReal)
                {
                    labelTest.Text = $"Index={nearest.Index}, X={nearest.X:0.##}, Y={nearest.Y:0.##}";
                }
                else
                {
                    labelTest.Text = $"No point selected";
                }
            };
        }

        public void MouseTracker()
        {
            var CH = formsPlot.Plot.Add.Crosshair(0, 0);
            CH.TextColor = Colors.White;
            CH.TextBackgroundColor = CH.HorizontalLine.Color;

            formsPlot.Refresh();

            formsPlot.MouseMove += (s, e) =>
            {
                Pixel mousePixel = new Pixel(e.X, e.Y);
                Coordinates mouseCoordinates = formsPlot.Plot.GetCoordinates(mousePixel);
                this.Text = $"X={mouseCoordinates.X:N3}, Y={mouseCoordinates.Y:N3}";
                CH.Position = mouseCoordinates;
                CH.VerticalLine.Text = $"{mouseCoordinates.X:N3}";
                CH.HorizontalLine.Text = $"{mouseCoordinates.Y:N3}";

                dataTable.Rows[0][CommonConstant.ColumnHeaderLineValue] = mouseCoordinates.Y;

                formsPlot.Refresh();
            };

            formsPlot.MouseDown += (s, e) =>
            {
                Pixel mousePixel = new Pixel(e.X, e.Y);
                Coordinates mouseCoordinates = formsPlot.Plot.GetCoordinates(mousePixel);
                labelTest.Text = $"X={mouseCoordinates.X:N3}, Y={mouseCoordinates.Y:N3} (mouse down)";
            };
        }

        #endregion

    }
}
