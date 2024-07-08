using System;
using System.Collections.Generic;
using System.Drawing;

namespace LineControl
{
    [Serializable]
    public class LineInfo
    {
        public Color LineColor { set; get; }

        public List<PointInfo> PointInfos = new List<PointInfo>();
    }
}
