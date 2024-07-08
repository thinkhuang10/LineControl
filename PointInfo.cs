using System;
using System.Drawing;

namespace LineControl
{
    [Serializable]
    public class PointInfo
    {
        public string XVar { set; get; }

        public string YVar { set; get; }

        public Color PointColor { set; get; }
    }
}
