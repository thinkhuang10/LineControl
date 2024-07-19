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

        // 设置X轴和Y轴的标注颜色
        public Color axisLabelColor = Color.Red;

        // 网格颜色
        public Color gridColor = Color.White;

        // 水平网格数
        public int verticalGridCount = 5;

        // 垂直网格数
        public int horizonalGridCount = 5;

        // 设置标题
        public string chartTitle = "";

        public Color chartTitleColor = Color.Black;

        public float chartTitleSize = 10.0f;

        public bool chartTitleIsBold = false;

        // 设置X轴
        public string xAxisTitle = "";

        public Color xAxisTitleForeColor = Color.Black;

        public float xAxisTitleSize = 10.0f;

        public bool xAxisTitleIsBold = false;

        // 设置Y轴
        public string yAxisTitle = "";

        public Color yAxisTitleForeColor = Color.Black;

        public float yAxisTitleSize = 10.0f;

        public bool yAxisTitleIsBold = false;

        // 设置标注
        public bool isShowLegend = true;

        public string legendPosition = "上方";

        // TODO：方便测试
        public Dictionary<string, LineInfo> lineInfos = new Dictionary<string, LineInfo>() {
            {"Tag3", new LineInfo(){ Name="Tag3", LowerLimitValue = -20, UpperLimitValue = 20, LineColor = Color.Green, LineWidth =1} },
            {"Tag7", new LineInfo(){ Name="Tag7", LowerLimitValue = -20, UpperLimitValue = 20, LineColor = Color.Red, LineWidth =1} }
        };
    }
}
