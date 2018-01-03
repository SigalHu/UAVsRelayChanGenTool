using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAVsRelayChanGenTool
{
    public partial class ChanGenTool : Form
    {
        const float relayNetX = 4;
        const float relayNetY = 4;

        private void setRelayNet(float length)
        {
            List<float> x = new List<float>();
            List<float> y = new List<float>();
            for (float ii = length / 2; ii < relayNetX * length; ii += length)
            {
                for (float jj = length / 2; jj < relayNetY * length; jj += length)
                {
                    x.Add(ii);
                    y.Add(jj);
                }
            }
            chtRelayNet.Series[2].Points.DataBindXY(x, y);

            chtRelayNet.ChartAreas[0].AxisX.Interval = length;
            chtRelayNet.ChartAreas[0].AxisX.Minimum = 0;
            chtRelayNet.ChartAreas[0].AxisX.Maximum = relayNetX * length;

            chtRelayNet.ChartAreas[0].AxisY.Interval = length;
            chtRelayNet.ChartAreas[0].AxisY.Minimum = 0;
            chtRelayNet.ChartAreas[0].AxisY.Maximum = relayNetY * length;
        }

        private void setGroundNode(float x0, float y0, float x1, float y1)
        {
            float length = float.Parse(txtCoverArea.Text);

            chtRelayNet.Series[0].Points.DataBindXY(
                new float[] { x0 }, 
                new float[] { y0 });
            chtRelayNet.Series[1].Points.DataBindXY(
                new float[] { x1 },
                new float[] { y1 });

            List<float> commuLinkX = new List<float>();
            List<float> commuLinkY = new List<float>();
            commuLinkX.Add(x0);
            commuLinkY.Add(y0);

            float nowX = (float)Math.Floor((double)(x0 / length)) * length + length / 2;
            float nowY = (float)Math.Floor((double)(y0 / length)) * length + length / 2;
            commuLinkX.Add(nowX);
            commuLinkY.Add(nowY);

            float lastX = (float)Math.Floor((double)(x1 / length)) * length + length / 2;
            float lastY = (float)Math.Floor((double)(y1 / length)) * length + length / 2;

            float preX = 0, preY = 0, nextX = 0, nextY = 0, nextLength, tmp;
            int nextIdx;
            while (nowX != lastX || nowY != lastY)
            {
                nextLength = float.MaxValue;

                tmp = (nowX - length - x0) * (nowX - length - x0)
                    + (nowY - y0) * (nowY - y0)
                    + (nowX - length - x1) * (nowX - length - x1)
                    + (nowY - y1) * (nowY - y1);
                if (tmp < nextLength && ((nowX - length) != preX || nowY != preY))
                {
                    nextLength = tmp;
                    nextX = nowX - length;
                    nextY = nowY;
                }


                tmp = (nowX + length - x0) * (nowX + length - x0)
                    + (nowY - y0) * (nowY - y0)
                    + (nowX + length - x1) * (nowX + length - x1)
                    + (nowY - y1) * (nowY - y1);
                if (tmp < nextLength && ((nowX + length) != preX || nowY != preY))
                {
                    nextLength = tmp;
                    nextX = nowX + length;
                    nextY = nowY;
                }

                tmp = (nowX - x0) * (nowX - x0)
                    + (nowY - length - y0) * (nowY - length - y0)
                    + (nowX - x1) * (nowX - x1)
                    + (nowY - length - y1) * (nowY - length - y1);
                if (tmp < nextLength && (nowX != preX || (nowY - length) != preY))
                {
                    nextLength = tmp;
                    nextX = nowX;
                    nextY = nowY - length;
                }

                tmp = (nowX - x0) * (nowX - x0)
                    + (nowY + length - y0) * (nowY + length - y0)
                    + (nowX - x1) * (nowX - x1)
                    + (nowY + length - y1) * (nowY + length - y1);
                if (tmp < nextLength && (nowX != preX || (nowY + length) != preY))
                {
                    nextLength = tmp;
                    nextX = nowX;
                    nextY = nowY + length;
                }

                preX = nowX;
                preY = nowY;
                nowX = nextX;
                nowY = nextY;
                commuLinkX.Add(nowX);
                commuLinkY.Add(nowY);
            }

            commuLinkX.Add(x1);
            commuLinkY.Add(y1);
            chtRelayNet.Series[3].Points.DataBindXY(commuLinkX, commuLinkY);
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

            setRelayNet(float.Parse(txtCoverArea.Text));
            setGroundNode(float.Parse(txtLaunPosX.Text),
                float.Parse(txtLaunPosY.Text),
                float.Parse(txtRecvPosX.Text),
                float.Parse(txtRecvPosY.Text));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCoverArea_TextChanged(object sender, EventArgs e)
        {
            setRelayNet(float.Parse(txtCoverArea.Text));
        }

        private void txtLaunRecvPos_TextChanged(object sender, EventArgs e)
        {
            setGroundNode(float.Parse(txtLaunPosX.Text),
                float.Parse(txtLaunPosY.Text),
                float.Parse(txtRecvPosX.Text),
                float.Parse(txtRecvPosY.Text));
        }
    }
}
