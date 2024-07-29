using ScottPlot.WinForms;
using ScottPlot;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LineControl
{
    public class CommonUtility
    {
        /// <summary>
        /// 拷贝图片到剪贴板
        /// </summary>
        /// <param name="plotControl"></param>
        public static void CopyImageToClipboard(IPlotControl plotControl)
        {
            var lastRenderSize = plotControl.Plot.RenderManager.LastRender.FigureRect.Size;
            var bmp = plotControl.Plot.GetImage((int)lastRenderSize.Width, (int)lastRenderSize.Height);
            var bmpBytes = bmp.GetImageBytes();

            using (var ms = new MemoryStream())
            {
                ms.Write(bmpBytes, 0, bmpBytes.Length);
                var bmpImage = new Bitmap(ms);
                Clipboard.SetImage(bmpImage);
            }
        }

        /// <summary>
        /// 新窗体中打开曲线
        /// </summary>
        /// <param name="ctrl"></param>
        public static void OpenPlotInNewWindow(IPlotControl ctrl)
        {
            var fp = new FormsPlot() { Dock = DockStyle.Fill };
            fp.Reset(ctrl.Plot);

            var form = new Form();
            form.Controls.Add(fp);
            form.ShowDialog();
        }

        /// <summary>
        /// 获取到小时，分，秒，如果不是两位数, 默认在前面添加0
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string AddZeroBeforeTime(string val)
        {
            if (val.Length == 1)
                return "0" + val;
            else
                return val;
        }

    }
}
