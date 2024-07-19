using System;
using System.Drawing;

namespace LineControl
{
    [Serializable]
    public class LineInfo
    {
        public string Name { set; get; }

        public double LowerLimitValue { set; get; } = 0;

        public double UpperLimitValue { set; get; } = 100;

        public Color LineColor { set; get; } = Color.Blue;

        public int LineWidth { get; set; } = 1;

        public string Description { set; get; } = string.Empty;
    }
}
