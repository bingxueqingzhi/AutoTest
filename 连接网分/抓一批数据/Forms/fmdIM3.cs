using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace 抓一批数据.Forms
{
    public partial class fmdIM3 : Form
    {
        fmSetRsSg Sg1 { set; get; }
        fmSetRsSg Sg2 { set; get; }
        fmSetRsSa Sa { set; get; }
        string path { set; get; }
        public fmdIM3()
        {
            InitializeComponent();
            this.pbxDiagram.Image = 抓一批数据.Properties.Resources.dIM3_Cal;
        }

        private void btnSg1Conn_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(this.tbxSg1Ip.Text, out ip))
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
            this.Sg1 = new fmSetRsSg(tc.Client);
            this.btnSg1Conn.Enabled = false;
            this.tbxSg1Ip.Enabled = false;
        }

        private void btnSg2Conn_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(this.tbxSg2Ip.Text, out ip))
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
            this.Sg2 = new fmSetRsSg(tc.Client);
            this.btnSg2Conn.Enabled = false;
            this.tbxSg2Ip.Enabled = false;
        }

        private void btnSaConn_Click(object sender, EventArgs e)
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
            this.btnSaConn.Enabled = false;
            this.tbxSaIp.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if ((this.btnSg1Conn.Enabled == false) && (this.btnSg2Conn.Enabled == false) && (this.btnSaConn.Enabled == false))
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
                        sw.Write("DUT ID,dIM3 (dB)" + Environment.NewLine);
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

        private void btnStartCal_Click(object sender, EventArgs e)
        {
            Int64 calFreq1, calFreq2;
            double calpower = 100;
            if (string.IsNullOrWhiteSpace(this.tbxFreq1.Text) || !Int64.TryParse(this.tbxFreq1.Text, out calFreq1) || string.IsNullOrWhiteSpace(this.tbxFreq2.Text) || !Int64.TryParse(this.tbxFreq2.Text, out calFreq2))
            {
                return;
            }
            if (calFreq1 < 9000 || calFreq1 > 3600000000 || calFreq2 < 9000 || calFreq2 > 3600000000)
            {
                MessageBox.Show("Invalid Frequency");
                return;
            }
            //设置信号发生器1
            this.Sg1.Reset();//Reset
            this.Sg1.SetFreq(calFreq1);//设置校准频率
            this.Sg1.SetPowerUnit(PowerUnit.dBuV);//设置校准单位
            this.Sg1.SetPowerOffset(0);//偏差清零
            this.Sg1.SetPower(calpower, PowerUnit.dBuV);//设置校准功率
            this.Sg1.RfOn(true);//打开输出
            //设置信号发生器2
            this.Sg2.Reset();//Reset
            this.Sg2.SetFreq(calFreq2);//设置校准频率
            this.Sg2.SetPowerUnit(PowerUnit.dBuV);//设置校准单位
            this.Sg2.SetPowerOffset(0);//偏差清零
            this.Sg2.SetPower(calpower, PowerUnit.dBuV);//设置校准功率
            this.Sg2.RfOn(true);//打开输出
            //设置频谱分析仪
            this.Sa.Reset();
            this.Sa.SetModeSpectrum();
            this.Sa.DisplayUpdate(true);
            this.Sa.SetFreqSpan(Math.Abs((calFreq1 + calFreq2) / 2).ToString(), (Math.Abs(calFreq1 - calFreq2) * 10).ToString());//中心频率
            this.Sa.SetRBW((Math.Abs(calFreq1 - calFreq2) / 100).ToString());//RBW
            this.Sa.PreAmpOn(false);//关预放
            this.Sa.SetSweepType(SaSweepType.SWE);//Sweep
            this.Sa.SetAttenuation(40);//Attenuator
            this.Sa.SetRefLevel(137, PowerUnit.dBuV);//Ref Level
            this.Sa.SetPowerUnit(PowerUnit.dBuV);//功率单位
            this.Sa.ContinuousSweep(false);//关持续扫描
            this.Sa.SetSweepCount(5);//扫描5次取平均
            this.Sa.AllMarkerOff();//关闭所有Marker
            this.Sa.MarkerControl(1, true);//设置marker
            this.Sa.SetMarkerX(1, calFreq1);
            this.Sa.MarkerControl(2, true);
            this.Sa.SetMarkerX(2, calFreq2);
            //校准1
            int sweepCount = this.Sa.GetSweepCount();
            double sweepTime = this.Sa.GetSweepTime();
            double levelOffset = 0;
            this.Sa.SingleSweep();
            Thread.Sleep((int)(sweepCount * sweepTime) + 200);
            while (Math.Abs(this.Sa.GetMarkerY(1) - calpower) > 0.05)
            {
                levelOffset += Math.Round(this.Sa.GetMarkerY(1) - calpower, 1);
                this.Sg1.SetPowerOffset(levelOffset);
                this.Sg1.SetPower(calpower, PowerUnit.dBuV);
                this.Sa.SingleSweep();
                Thread.Sleep((int)(sweepCount * sweepTime) + 200);
            }
            //校准2
            levelOffset = 0;
            this.Sa.SingleSweep();
            Thread.Sleep((int)(sweepCount * sweepTime) + 200);
            while (Math.Abs(this.Sa.GetMarkerY(2) - calpower) > 0.05)
            {
                levelOffset += Math.Round(this.Sa.GetMarkerY(2) - calpower, 1);
                this.Sg2.SetPowerOffset(levelOffset);
                this.Sg2.SetPower(calpower, PowerUnit.dBuV);
                this.Sa.SingleSweep();
                Thread.Sleep((int)(sweepCount * sweepTime) + 200);
            }
            Int64 freq_im3_1 = calFreq1 * 2 - calFreq2;
            Int64 freq_im3_2 = calFreq2 * 2 - calFreq1;
            this.Sa.MarkerControl(3, true);
            this.Sa.MarkerControl(4, true);
            this.Sa.SetMarkerX(3, freq_im3_1);
            this.Sa.SetMarkerX(4, freq_im3_2);
            this.Sa.MarkerControl(5, true);
            this.Sa.SetMarkerX(5, (calFreq1 + calFreq2) / 2);
            MessageBox.Show("Calibration Finished.");
            this.tbxFreq1.Visible = this.tbxFreq2.Visible = this.btnSkipCal.Visible = this.btnStartCal.Visible = false;
            this.pbxDiagram.Image = 抓一批数据.Properties.Resources.dIM3_Test;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //double _y4 = this.Sa.GetMarkerY(4);
            //double y5 = this.Sa.GetMarkerY(5);
            //int att = this.Sa.GetAttenuation();
            this.Sa.SingleSweep();
            Thread.Sleep((int)(this.Sa.GetSweepCount() * this.Sa.GetSweepTime()) + 200);
            while (((this.Sa.GetMarkerY(4) - this.Sa.GetMarkerY(5)) < 10) && ((this.Sa.GetMarkerY(3) - this.Sa.GetMarkerY(5)) < 10) && (this.Sa.GetAttenuation() != 0))
            {
                this.Sa.SingleSweep();
                Thread.Sleep((int)(this.Sa.GetSweepCount() * this.Sa.GetSweepTime()) + 200);
                //int att = this.Sa.GetAttenuation();
                this.Sa.SetAttenuation(this.Sa.GetAttenuation() - 5);
            }
            string id = "";
            if (!this.ckbxOneTimeMode.Checked)
            {
                fmDeviceID fmID = new fmDeviceID();
                fmID.ShowDialog();
                id = fmID.DeviceID;
            }
            int sweepCount = this.Sa.GetSweepCount();
            double sweepTime = this.Sa.GetSweepTime();
            this.Sa.SingleSweep();
            Thread.Sleep((int)(sweepCount * sweepTime) + 200);
            Int64 freq1 = this.Sg1.GetFreq();
            Int64 freq2 = this.Sg2.GetFreq();
            //Int64 freq_im3_1 = freq1 * 2 - freq2;
            //Int64 freq_im3_2 = freq2 * 2 - freq1;
            //this.Sa.MarkerControl(3, true);
            //this.Sa.MarkerControl(4, true);
            //this.Sa.SetMarkerX(3, freq_im3_1);
            //this.Sa.SetMarkerX(4, freq_im3_2);
            double y1 = this.Sa.GetMarkerY(1);
            double y3 = this.Sa.GetMarkerY(3);
            double y4 = this.Sa.GetMarkerY(4);
            double dim3;
            if (y1 - y3 > y1 - y4)
            {
                dim3 = y1 - y4;
            }
            else
            {
                dim3 = y1 - y3;
            }
            //TBD
            if (this.ckbxOneTimeMode.Checked)
            {
                MessageBox.Show("dIM3:   " + dim3 + "dB");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.ASCII))
                {
                    sw.WriteLine(id + ',' + dim3.ToString());
                }
            }
        }
    }
}
