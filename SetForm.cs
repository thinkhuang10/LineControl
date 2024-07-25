using CommonSnappableTypes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LineControl
{
    public partial class SetForm : Form
    {
        private readonly Save saveData;
        private readonly ColorDialog colorDialog = new ColorDialog();

        public event GetVarTable GetVarTableEvent;

        public SetForm(Save saveData)
        {
            InitializeComponent();
            this.saveData = saveData;
        }

        private void XYSetForm_Load(object sender, EventArgs e)
        {
            ChartForeColor.BackColor = saveData.chartForeColor;
            ChartBackColor.BackColor = saveData.chartBackColor;
            GridColor.BackColor = saveData.gridColor;
            AxisLabelColor.BackColor = saveData.axisLabelColor;

            HorizonalGridCount.Text = saveData.horizonalGridCount.ToString();
            VerticalGridCount.Text = saveData.verticalGridCount.ToString();

            ChartTitle.Text = saveData.chartTitle;
            ChartTitleColor.BackColor = saveData.chartTitleColor;
            ChartTitleSize.Text =  saveData.chartTitleSize.ToString();

            XAxisTitle.Text = saveData.xAxisTitle;
            XAxisTitleForeColor.BackColor = saveData.xAxisTitleForeColor;
            XAxisTitleSize.Text = saveData.xAxisTitleSize.ToString();

            YAxisTitle.Text = saveData.yAxisTitle;
            YAxisTitleForeColor.BackColor = saveData.yAxisTitleForeColor;
            YAxisTitleSize.Text = saveData.yAxisTitleSize.ToString();

            checkBoxLegend.Checked = saveData.isShowLegend;
            comboBoxLegend.SelectedItem = saveData.legendPosition;

            // 初始化曲线
            listBoxVar.Items.Clear();
            listBoxVar.Items.AddRange(saveData.lineInfos.Keys.ToArray());

            if (listBoxVar.Items.Count > 0)
            {
                listBoxVar.SelectedIndex = 0;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            #region 验证输入

            if (!int.TryParse(HorizonalGridCount.Text.Trim(), out int horizonalGridCount)
                || 0 == horizonalGridCount)
            {
                MessageBox.Show("请输入正确的水平网格数.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(VerticalGridCount.Text.Trim(), out int verticalGridCount)
                || 0 == verticalGridCount)
            {
                MessageBox.Show("请输入正确的垂直网格数.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ChartTitleSize.Text.Trim(), out int chartTitleSize)
                || chartTitleSize <= 0)
            {
                MessageBox.Show("请输入正确的标题字体大小.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(XAxisTitleSize.Text.Trim(), out int xAxisTitleSize)
                || xAxisTitleSize <= 0)
            {
                MessageBox.Show("请输入正确的X信息字体大小.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(YAxisTitleSize.Text.Trim(), out int yAxisTitleSize)
                || yAxisTitleSize <= 0)
            {
                MessageBox.Show("请输入正确的Y信息字体大小.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            #region 保存配置到序列化文件中

            saveData.chartForeColor = ChartForeColor.BackColor;
            saveData.chartBackColor = ChartBackColor.BackColor;
            saveData.gridColor = GridColor.BackColor;
            saveData.axisLabelColor = AxisLabelColor.BackColor;

            saveData.horizonalGridCount = horizonalGridCount;
            saveData.verticalGridCount = verticalGridCount;

            saveData.chartTitle = ChartTitle.Text.Trim();
            saveData.chartTitleColor = ChartTitleColor.BackColor;
            saveData.chartTitleSize = chartTitleSize;

            saveData.xAxisTitle = XAxisTitle.Text.Trim();
            saveData.xAxisTitleForeColor = XAxisTitleForeColor.BackColor;
            saveData.xAxisTitleSize = xAxisTitleSize;

            saveData.yAxisTitle = YAxisTitle.Text.Trim();
            saveData.yAxisTitleForeColor = YAxisTitleForeColor.BackColor;
            saveData.yAxisTitleSize = yAxisTitleSize;

            saveData.isShowLegend = checkBoxLegend.Checked;
            saveData.legendPosition = comboBoxLegend.SelectedItem.ToString();

            //saveData.lineInfos.Clear();

            #endregion

            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #region Tab - 常规

        private void ChartForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            ChartForeColor.BackColor = colorDialog.Color;
        }

        private void ChartBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            ChartBackColor.BackColor = colorDialog.Color;
        }

        private void GridColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            GridColor.BackColor = colorDialog.Color;
        }

        private void AxisLabelColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            AxisLabelColor.BackColor = colorDialog.Color;
        }

        private void ChartTitleColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            ChartTitleColor.BackColor = colorDialog.Color;
        }

        private void XAxisTitleForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            XAxisTitleForeColor.BackColor = colorDialog.Color;
        }

        private void YAxisTitleForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            YAxisTitleForeColor.BackColor = colorDialog.Color;
        }

        #endregion

        #region Tab - 数据

        private void AddLineButton_Click(object sender, EventArgs e)
        {
            //TODO: 获取变量的值
            var tagName = "TagTest";

            if (saveData.lineInfos.Keys.Contains(tagName))
                return;

            saveData.lineInfos.Add(tagName, new LineInfo());

            listBoxVar.ClearSelected();
            var index = listBoxVar.Items.Add(tagName);
            listBoxVar.SelectedIndex = index;
        }

        private void DeleteLineButton_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("确认删除选中的曲线？", "提示", MessageBoxButtons.OKCancel);
            if (dr != DialogResult.OK)
                return;

            foreach (string tagName in listBoxVar.SelectedItems)
            {
                if (!saveData.lineInfos.ContainsKey(tagName))
                    continue;

                saveData.lineInfos.Remove(tagName);
            }

            for (var i = listBoxVar.Items.Count - 1; i >= 0; i--)
            {
                listBoxVar.Items.Remove(listBoxVar.SelectedItem);
            }
        }

        #endregion

        private void listBoxVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == listBoxVar.SelectedItem)
                return;

            var tagName = listBoxVar.SelectedItem.ToString();

            if (!saveData.lineInfos.ContainsKey(tagName))
                return;

            var lineInfo = saveData.lineInfos[tagName];

            tbLowerLimitValue.Text = lineInfo.LowerLimitValue.ToString();
            tbUpperLimitValue.Text = lineInfo.UpperLimitValue.ToString();
            LineColor.BackColor = lineInfo.LineColor;
            tbLineWidth.Text = lineInfo.LineWidth.ToString();
            tbLineDescription.Text = lineInfo.Description;
            tbUnit.Text = lineInfo.Unit;

            // 隐藏修改成功的Tooltip
            lbModifyLineTooltip.Visible = false;
        }

        private void LineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            LineColor.BackColor = colorDialog.Color;
        }

        private void btModifyLine_Click(object sender, EventArgs e)
        {
            lbModifyLineTooltip.Visible= false;

            if (null == listBoxVar.SelectedItem)
                return;

            var tagName = listBoxVar.SelectedItem.ToString();
            if (!saveData.lineInfos.ContainsKey(tagName))
                return;

            if (!double.TryParse(tbLowerLimitValue.Text, out var lowerLimitValue))
            {
                MessageBox.Show("请输入正确的量程下限.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbUpperLimitValue.Text, out var upperLimitValue))
            {
                MessageBox.Show("请输入正确的量程上限.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbLineWidth.Text, out var lineWidth) || lineWidth <= 0) 
            {
                MessageBox.Show("请输入正确的曲线宽度.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lowerLimitValue > upperLimitValue)
            {
                MessageBox.Show("量程上限应该大于量程下限.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lineInfo = saveData.lineInfos[tagName];
            lineInfo.LowerLimitValue = lowerLimitValue;
            lineInfo.UpperLimitValue = upperLimitValue;
            lineInfo.LineColor = LineColor.BackColor;
            lineInfo.LineWidth = lineWidth;
            lineInfo.Description = tbLineDescription.Text;
            lineInfo.Unit = tbUnit.Text;

            lbModifyLineTooltip.Visible = true;
        }
    }
}
