using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UAVsRelayChanGenTool
{
    public partial class ChanGenTool : Form
    {
        private const int maxRelayNum = 2;
        private string strDefaultPath = System.AppDomain.CurrentDomain.BaseDirectory;

        private void OutputPathShow(string strOutputDir)
        {
            Graphics graphics = CreateGraphics();
            SizeF sizeWorkPath = graphics.MeasureString(strOutputDir, lalOutputPath.Font);
            SizeF sizeDateNow = graphics.MeasureString(lblDateNow.Text, lblDateNow.Font);

            float fltExtraWords = sizeWorkPath.Width - lalOutputPath.Size.Width - lblDateNow.Size.Width + sizeDateNow.Width + 50;
            if (fltExtraWords > 0)
            {
                float fltWordWidth = sizeWorkPath.Width / strOutputDir.Length;
                int uintWordIdx = strOutputDir.Length - Convert.ToInt32(fltExtraWords / fltWordWidth);
                strOutputDir = strOutputDir.Substring(0, uintWordIdx) + "...";
            }
            lalOutputPath.Text = strOutputDir;
        }

        public ChanGenTool()
        {
            InitializeComponent();
        }

        private void ChanGenTool_Load(object sender, EventArgs e)
        {
            cboG2AEnv.SelectedIndex = 0;
            cboCarrierFre.SelectedIndex = 0;
            cboSampleFre.SelectedIndex = 0;

            lblDateNow.Text = DateTime.Now.ToString("yyyy年MM月dd日");

            //lalOutputPath.ToolTipText = strDefaultPath + "Output\\";
            lalOutputPath.ToolTipText = "C:\\Output\\";
            if (!Directory.Exists(lalOutputPath.ToolTipText))
                Directory.CreateDirectory(lalOutputPath.ToolTipText);
            OutputPathShow(lalOutputPath.ToolTipText);

            dgvGeneChan.RowCount = maxRelayNum;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCoverArea_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLaunRecvPos_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvGeneChan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            for (int ii = e.RowIndex; ii < e.RowIndex + e.RowCount; ii++)
            {
                dgv.Rows[ii].HeaderCell.Value = "中继节点" + (ii + 1).ToString();
            }
        }

        private void dgvGeneChan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            for (int ii = e.RowIndex; ii < dgvGeneChan.RowCount; ii++)
            {
                dgv.Rows[ii].HeaderCell.Value = "中继节点" + (ii + 1).ToString();
            }
        }

        private void dgvGeneChan_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.StateChanged == DataGridViewElementStates.ReadOnly)
            {
                if (e.Cell.ReadOnly)
                {
                    e.Cell.Style.ForeColor = Color.FromArgb(85, 85, 85);
                    e.Cell.Style.SelectionForeColor = Color.FromArgb(85, 85, 85);
                }
                else
                {
                    e.Cell.Style.ForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor;
                    e.Cell.Style.SelectionForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor;
                }
            }
        }

        private Form1 refBox = new Form1();
        private void cboG2AEnv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            string strRefEnv = cbo.SelectedItem.ToString();

            if (strRefEnv == "自定义")
            {
                if (DialogResult.OK != refBox.ShowDialog(this))
                {
                }
            }
        }
    }
}
