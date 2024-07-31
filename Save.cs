using System;
using System.Collections.Generic;
using System.Drawing;

namespace LineControl
{
    [Serializable]
    public class Save
    {
        // 曲线画板颜色
        public Color chartForeColor = Color.Black;

        // 曲线背景色
        public Color chartBackColor = Color.Gray;

        // 设置X轴标注颜色
        public Color axisLabelColor = Color.Black;

        // 网格颜色
        public Color gridColor = Color.White;

        // 水平网格数
        public int verticalGridCount = 5;

        // 垂直网格数
        public int horizonalGridCount = 5;

        // 设置曲线标题
        public string chartTitle = "";

        public Color chartTitleColor = Color.Black;

        public float chartTitleSize = 10.0f;

        public bool chartTitleIsBold = false;

        // 设置X轴
        public string xAxisTitle = "";

        public Color xAxisTitleForeColor = Color.Black;

        public float xAxisTitleSize = 10.0f;

        public bool xAxisTitleIsBold = false;

        // 设置表格的列
        public List<string> AllColumns = new List<string>() {
            CommonConstant.ColumnHeaderLineShow, CommonConstant.ColumnHeaderLineColor,
            CommonConstant.ColumnHeaderLineName, CommonConstant.ColumnHeaderLineDescription,
            CommonConstant.ColumnHeaderLineValue, CommonConstant.ColumnHeaderLineUnit,
            CommonConstant.ColumnHeaderLowerLimit, CommonConstant.ColumnHeaderUpperLimit,
            CommonConstant.ColumnHeaderDecimal,CommonConstant.ColumnLineWidth
        };

        // 游标
        public Color cursorColor = Color.Blue;

        public int cursorFontSize = 12;

        // 是否单轴显示
        public bool isSingleAxisShow = false;

        // TODO：方便测试
        //public Dictionary<string, LineInfo> lineInfos = new Dictionary<string, LineInfo>();

        public Dictionary<string, LineInfo> lineInfos = new Dictionary<string, LineInfo>() {
            {"Tag3", new LineInfo(){ Name="Tag3", LowerLimitValue = -20, UpperLimitValue = 20, LineColor = Color.Green, LineWidth =1,Decimal = 2,Unit ="摄氏度",Description="环境温度",YLabel =""} },
            {"Tag7", new LineInfo(){ Name="Tag7", LowerLimitValue = -30, UpperLimitValue = 30, LineColor = Color.Red, LineWidth =1,Decimal = 2, Unit ="安培",Description = "当前电流",YLabel=""} }
        };

    }
}
