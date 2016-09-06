using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace 抓一批数据.Forms
{
    public partial class fmP_1dB : Form
    {
        public fmP_1dB()
        {
            InitializeComponent();
            this.pbxCalDiagram.Image = 抓一批数据.Properties.Resources.P1dB_Cal;
        }
        fmSetRsSg Sg { set; get; }
        fmSetRsSa Sa { set; get; }
        string path { set; get; }
        string DUTID { set; get; }
        private void btnConnSa_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(this.tbxSaIp.Text, out ip))
            {
                MessageBox.Show("Invalid IP address!");
                return;
            }
            IPEndPoint ipep = new IPEndPoint(ip, 5025);
            TcpClient tc = new TcpClient();
            try
            {
                tc.Connect(ipep);
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return;
            }
            this.Sa = new fmSetRsSa(tc.Client);
            btnConnSa.Enabled = false;
            this.tbxSaIp.Enabled = false;
        }

        private void btnConnSg_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(this.tbxSgIp.Text, out ip))
            {
                MessageBox.Show("Invalid IP address!");
                return;
            }
            IPEndPoint ipep = new IPEndPoint(ip, 5025);
            TcpClient tc = new TcpClient();
            try
            {
                tc.Connect(ipep);
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return;
            }
            this.Sg = new fmSetRsSg(tc.Client);
            btnConnSg.Enabled = false;
            this.tbxSgIp.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int startPower = 0;
            int stopPower = 0;
            if ((!int.TryParse(tbxStartPower.Text, out startPower)) & (!int.TryParse(this.tbxStopPower.Text, out stopPower)))
            {
                MessageBox.Show("Invalid Power String!");
                return;
            }
            if (stopPower > 130 || startPower > 130 || stopPower <= 0 || startPower <= 0 || startPower > stopPower)
            {
                MessageBox.Show("Invalid Power!");
                return;
            }
            if (!this.ckbxOneTimeMode.Checked)
            {
                using (fmDeviceID id = new fmDeviceID())
                {
                    id.ShowDialog();
                    this.DUTID = id.DeviceID;
                }
            }
            this.Sg.SetPower(startPower, PowerUnit.dBuV);
            double sweepTime = this.Sa.GetSweepTime();//获取扫描时间
            int sweepCount = this.Sa.GetSweepCount();//获取扫描次数
            int sweepPoints = this.Sa.GetSweepPoints();
            this.Sa.ContinuousSweep(false);//关闭持续扫描
            this.Sa.SingleSweep();//开始一次单次扫描
            Thread.Sleep((int)(sweepCount * sweepTime + 1000));//等待扫描结束
            int freq = this.Sg.GetFreq();//获取工作频率
            this.Sa.AllMarkerOff();//关闭所有Marker
            this.Sa.MarkerControl(1, true);//打开Marker1
            this.Sa.SetMarkerX(1, freq);//设置Marker1频率
            double y1 = this.Sa.GetMarkerY(1);//起点输出功率
            //第一轮:循环个位
            double inputPower = this.Sg.GetPower();//起点输入功率
            double gain = y1 - inputPower;//计算起点增益
            while ((gain - (this.Sa.GetMarkerY(1) - this.Sg.GetPower()) < 1) && (this.Sg.GetPower() < stopPower))
            {
                this.Sg.SetPower(this.Sg.GetPower() + 1, PowerUnit.dBuV);
                this.Sa.ContinuousSweep(false);//关闭持续扫描
                this.Sa.SingleSweep();//开始一次单次扫描
                Thread.Sleep((int)(sweepCount * sweepTime + 200));//等待扫描结束
            }
            //第二轮:循环十分位
            //起点为第一轮的终点-1dB
            this.Sg.SetPower(this.Sg.GetPower() - 1, PowerUnit.dBuV);
            while (gain - (this.Sa.GetMarkerY(1) - this.Sg.GetPower()) < 1)
            {
                this.Sg.SetPower(this.Sg.GetPower() + 0.1, PowerUnit.dBuV);
                this.Sa.ContinuousSweep(false);//关闭持续扫描
                this.Sa.SingleSweep();//开始一次单次扫描
                Thread.Sleep((int)(sweepCount * sweepTime + 200));//等待扫描结束
            }
            if (this.ckbxOneTimeMode.Checked)
            {
                MessageBox.Show("P-1dB Get!" + Environment.NewLine + "Input Power: " + this.Sg.GetPower() + Environment.NewLine + "Output Power: " + this.Sa.GetMarkerY(1));
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.ASCII))
                {
                    string dataStr = this.DUTID + "," + this.Sg.GetPower() + "," + this.Sa.GetMarkerY(1);
                    sw.WriteLine(dataStr);
                }
            }

        }

        private void btnSkipCal_Click(object sender, EventArgs e)
        {
            this.btnStartCal.Hide();
            this.btnSkipCal.Hide();
            this.Sa.ContinuousSweep(true);
            this.pbxCalDiagram.Image = 抓一批数据.Properties.Resources.P1dB_Test;
            this.btnStartCal.Hide();
            this.btnSkipCal.Hide();
            this.label1.Hide();
            this.tbxCalFrequency.Hide();
            this.lblStartPower.Visible = true;
            this.lblStopPower.Visible = true;
            this.tbxStartPower.Visible = true;
            this.tbxStopPower.Visible = true;
            this.btnStart.Visible = true;
            this.tbxStartPower.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if ((this.btnConnSa.Enabled == false) && (this.btnConnSg.Enabled == false))
            {
                if (!this.ckbxOneTimeMode.Checked)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Title = "Save File to...";
                        sfd.Filter = "csv file|*.csv";
                        sfd.OverwritePrompt = true;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            this.path = sfd.FileName;
                        }
                        else
                        {
                            return;
                        }
                    }
                    using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.ASCII))
                    {
                        sw.Write("DUT ID,Input Power,Output Power" + Environment.NewLine);
                    }
                }
                this.btnSkipCal.Enabled = this.btnStartCal.Enabled = true;
                this.btnGo.Enabled = false;
                this.ckbxOneTimeMode.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please Connect to Instruments First.");
            }
        }
        /// <summary>
        /// SG=>SA校准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCal_Click(object sender, EventArgs e)
        {
            Int64 calFreq;
            double calpower = 100;
            if (string.IsNullOrWhiteSpace(this.tbxCalFrequency.Text) || !Int64.TryParse(this.tbxCalFrequency.Text, out calFreq))
            {
                return;
            }
            if (calFreq < 9000 || calFreq > 3600000000)
            {
                MessageBox.Show("Invalid Frequency");
                return;
            }
            //设置信号发生器
            this.Sg.Reset();//Reset
            this.Sg.SetFreq(calFreq);//设置校准频率
            this.Sg.SetPowerUnit(PowerUnit.dBuV);//设置校准单位
            this.Sg.SetPower(calpower, PowerUnit.dBuV);//设置校准功率
            this.Sg.SetPowerOffset(0);//偏差清零
            this.Sg.RfOn(true);//打开输出
            //设置频谱分析仪
            this.Sa.SetFreqSpan(this.tbxCalFrequency.Text, "200MHz");
            this.Sa.SetRBW(100000);
            this.Sa.PreAmpOn(false);
            this.Sa.SetSweepType(SaSweepType.SWE);
            this.Sa.SetAttenuation(40);
            this.Sa.SetRefLevel(137, PowerUnit.dBuV);
            this.Sa.SetPowerUnit(PowerUnit.dBuV);
            this.Sa.ContinuousSweep(false);
            this.Sa.SetSweepCount(5);
            this.Sa.AllMarkerOff();
            this.Sa.MarkerControl(1, true);
            this.Sa.SetMarkerX(1, calFreq);
            //开始校准
            int sweepCount = this.Sa.GetSweepCount();
            double sweepTime = this.Sa.GetSweepTime();
            double levelOffset = 0;
            this.Sa.SingleSweep();
            Thread.Sleep((int)(sweepCount * sweepTime) + 500);
            while (Math.Abs(this.Sa.GetMarkerY(1) - calpower) > 0.1)
            {
                levelOffset += Math.Round(this.Sa.GetMarkerY(1) - calpower, 1);
                this.Sg.SetPowerOffset(levelOffset);
                this.Sg.SetPower(calpower, PowerUnit.dBuV);
                this.Sa.SingleSweep();
                Thread.Sleep((int)(sweepCount * sweepTime) + 500);
            }
            this.Sa.ContinuousSweep(true);
            //校准结束
            this.pbxCalDiagram.Image = 抓一批数据.Properties.Resources.P1dB_Test;
            this.btnStartCal.Hide();
            this.btnSkipCal.Hide();
            this.label1.Hide();
            this.tbxCalFrequency.Hide();
            this.lblStartPower.Visible = true;
            this.lblStopPower.Visible = true;
            this.tbxStartPower.Visible = true;
            this.tbxStopPower.Visible = true;
            this.btnStart.Visible = true;
            this.tbxStartPower.Focus();
        }
    }
}
