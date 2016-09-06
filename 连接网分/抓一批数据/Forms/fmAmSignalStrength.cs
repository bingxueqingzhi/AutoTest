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
using System.Diagnostics;
using 抓一批数据.Class;

namespace 抓一批数据.Forms
{
    public partial class fmAmSignalStrength : Form
    {
        public fmAmSignalStrength()
        {
            InitializeComponent();
        }
        fmSetRsSa Sa { set; get; }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipaddr;
            if (!IPAddress.TryParse(this.tbxSaIp.Text, out ipaddr))
            {
                return;
            }
            IPEndPoint rep = new IPEndPoint(ipaddr, 5025);
            TcpClient tc = new TcpClient();
            try
            {
                tc.Connect(rep);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            this.Sa = new fmSetRsSa(tc.Client);
            this.lblStatus.Text = "Connected";
            this.btnConnect.Enabled = this.tbxSaIp.Enabled = false;
            this.btnStart.Enabled = true;
        }
        public string workFolder { set; get; }
        public List<int> FreqList = new List<int>(0);//频率表 kHz
        public List<List<double>> StrengthList = new List<List<double>>(0);//功率表:[][]
        public int PointCount { set; get; }//一共测多少个点
        public int TotalTime { set; get; }//转一圈的时间, 单位s
        public int PointOrder = 1;
        /// <summary>
        /// 测量AM信号强度
        /// </summary>
        /// <param name="sa"></param>
        /// <returns></returns>
        public int MeasureAmStrength(fmSetRsSa sa)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            delLbl lbl = this.UpdateLbl;
            lbl(lblStatus, "Measureing Point " + this.PointOrder + "...");
            sa.ContinuousSweep(false);
            sa.SingleSweep();
            float[] traceData = sa.GetTrace();//请求Trace数据
            while (traceData == null)//如果没有拿到则循环请求数据
            {
                traceData = sa.GetTrace();
            }
            for (int i = 0; i < FreqList.Count; i++)
            {
                this.StrengthList[i].Add(traceData[this.FreqList[i] - 500]);
            }
            Image img = Bitmap.FromStream(new MemoryStream(sa.GetScreenShot()));
            this.pbxImage.Image = img;
            this.PointOrder++;
            sw.Stop();
            lbl(this.lblStatus, this.PointOrder + " Finished\t" + sw.ElapsedMilliseconds);
            if (this.PointOrder > this.PointCount)
            {
                lbl(lblStatus, "Measureing Completed");
                return -1;//扫完最后一个点就返回-1
            }
            else
            {
                return (int)sw.ElapsedMilliseconds;//还没扫完就返回所用的时间
            }
        }
        public void MeaAmStrCallBack(IAsyncResult iar)
        {
            int time = ((MeaAmStrengthStatusObj)iar.AsyncState).Dmas.EndInvoke(iar);
            if (time == -1)
            {
                return;//扫完了就不要继续了
            }
            fmSetRsSa sa = ((MeaAmStrengthStatusObj)iar.AsyncState).Sa;
            Thread.Sleep(this.TotalTime * 1000 / (PointCount - 1) - time);
            delMeasAmStrength meaAm = this.MeasureAmStrength;
            iar = meaAm.BeginInvoke(sa, new AsyncCallback(this.MeaAmStrCallBack), new MeaAmStrengthStatusObj(meaAm, sa));
        }
        private void UpdateLbl(Label lbl, string txt)
        {
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new delLbl(this.UpdateLbl), new object[] { lbl, txt });
            }
            else
            {
                lbl.Text = txt;
            }
        }
        private void AppendTbx(TextBox tbx, string txt)
        {
            if (tbx.InvokeRequired)
            {
                tbx.Invoke(new delTbx(AppendTbx), new object[] { tbx, txt });
            }
            else
            {
                tbx.AppendText(txt + Environment.NewLine);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            //读测试频率
            try
            {
                this.PointCount = int.Parse(tbxPointsCount.Text);
                this.tbxPointsCount.Enabled = false;
                this.TotalTime = int.Parse(tbxTotalTime.Text);
                this.tbxTotalTime.Enabled = false;
                string[] freq = this.tbxFreq.Text.Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < freq.Length; i++)
                {
                    this.FreqList.Add(int.Parse(freq[i]));
                }
                for (int i = 0; i < freq.Length; i++)
                {
                    this.StrengthList.Add(new List<double>());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                this.btnStart.Enabled = this.tbxPointsCount.Enabled = this.tbxTotalTime.Enabled = true;
                return;
            }
            //设置频谱
            this.Sa.Reset();
            this.Sa.SetModeSpectrum();
            this.Sa.DisplayUpdate(true);
            this.Sa.PreAmpOn(false);
            this.Sa.SetFreq("9000", "2000000");
            this.Sa.SetAttenuation(20);
            this.Sa.SetRBW(1000);
            this.Sa.SetSweepType(SaSweepType.SWE);
            this.Sa.SetPowerUnit(PowerUnit.dBuV);
            this.Sa.SetRefLevel(100, PowerUnit.dBuV);
            this.Sa.SetSweepCount(3);
            this.Sa.SetSweepPoints(1992);//1501个点
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a empty folder";

                if ((fbd.ShowDialog() == DialogResult.OK) && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.workFolder = fbd.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Please check your input");
                    this.btnStart.Enabled = true;
                    return;
                }
            }
            delMeasAmStrength meaAM = this.MeasureAmStrength;
            MessageBox.Show("Press OK to Start", "Please Check SA", MessageBoxButtons.OK);
            IAsyncResult iar = meaAM.BeginInvoke(this.Sa, new AsyncCallback(this.MeaAmStrCallBack), new MeaAmStrengthStatusObj(meaAM, this.Sa));
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
        private void SaveImg(byte[] img)
        {

        }
    }
}
