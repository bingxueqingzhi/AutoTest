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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace 抓一批数据
{
    public partial class fmMain : Form
    {
        double start;
        double stop;
        string startStr;
        string stopStr;
        bool startReady = false;
        bool stopReady = false;
        string Path { set; get; }//csv文件路径
        TcpClient tc;
        public fmMain()
        {
            InitializeComponent();
        }
        public fmMain(string InstrId)
            : this()
        {
            this.Text = InstrId;
        }
        private void btnStartKHz_Click(object sender, EventArgs e)
        {
            int freqStart;
            if (int.TryParse(this.tbxStart.Text, out freqStart))
            {
                this.start = freqStart * 1000;
                this.lblStart.Text = this.startStr = freqStart.ToString() + "KHz";
                startReady = true;
            }
            else
            {
                startReady = false;
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnStartMHz_Click(object sender, EventArgs e)
        {
            int freqStart;
            if (int.TryParse(this.tbxStart.Text, out freqStart))
            {
                this.start = freqStart * 1000 * 1000;
                this.lblStart.Text = this.startStr = freqStart.ToString() + "MHz";
                this.startReady = true;
            }
            else
            {
                this.startReady = false;
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnStopKHz_Click(object sender, EventArgs e)
        {
            int freqStop;
            if (int.TryParse(this.tbxStop.Text, out freqStop))
            {
                this.stop = freqStop * 1000;
                this.lblStop.Text = this.stopStr = freqStop.ToString() + "KHz";
                this.stopReady = true;
            }
            else
            {
                this.stopReady = false;
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnStopMHz_Click(object sender, EventArgs e)
        {
            int freqStop;
            if (int.TryParse(this.tbxStop.Text, out freqStop))
            {
                this.stop = freqStop * 1000 * 1000;
                this.lblStop.Text = this.stopStr = freqStop.ToString() + "MHz";
                this.stopReady = true;
            }
            else
            {
                this.stopReady = false;
                MessageBox.Show("Invalid Input");
            }
        }
        /// <summary>
        /// 给网分设置Start&Stop, 设置csv文件位置, 加文件头BOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetFreq_Click(object sender, EventArgs e)
        {
            int sweepCount;
            if (int.TryParse(tbxPoints.Text, out sweepCount) && this.startReady && this.stopReady)
            {
                SendCMD("sense:frequency:start " + this.startStr);
                SendCMD("sense:frequency:stop " + this.stopStr);
                SendCMD("sweep:points " + sweepCount.ToString());
                MessageBox.Show("Frequency Set!");
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "csv File (*.csv)|*.csv";
                    sfd.RestoreDirectory = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        //this.path = sfd.FileName;
                        //if (!File.Exists(this.path))
                        //{
                        //    using (FileStream fs = new FileStream(this.path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        //    {
                        //        fs.Write(new byte[] { 0xff, 0xfe }, 0, 2);
                        //    }
                        //}
                    }
                    else
                    {
                        MessageBox.Show("File Name not Defined");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipadd = IPAddress.Parse(tbxIP.Text);
            IPEndPoint ipep = new IPEndPoint(ipadd, 5025);
            this.tc = new TcpClient();
            byte[] buffer = new byte[1024 * 1024];//1MB缓冲
            try
            {
                tc.Connect(ipep);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            //MessageBox.Show("Connected!");
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Please choose a work folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    this.Path = fbd.SelectedPath;
                    this.btnAddMemory.Enabled = true;
                    this.btnEditMemory.Enabled = true;
                    this.btnDelMemory.Enabled = true;
                    this.btnSettingsConfirm.Enabled = true;
                    this.btnScanSettings.Enabled = true;
                }
            }
        }
        /// <summary>
        /// 接收到数据后的响应
        /// </summary>
        /// <param name="iar"></param>
        private void TcRecHandler(IAsyncResult iar)
        {
            TcpClient tc = ((TcRecObj)iar.AsyncState).Tc;
            int n = tc.Client.EndReceive(iar);
            byte[] buffer = ((TcRecObj)iar.AsyncState).Buffer;
            string recStr = Encoding.ASCII.GetString(buffer, 0, n);
            //如果只要一部分数据, 这里要加一点数据处理
            //using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.ASCII))
            //{
            //    sw.Write(recStr);//返回的数据最后已经有一个换行符了
            //}
            MessageBox.Show("数据已经写到csv里了!");
            tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(this.TcRecHandler), new TcRecObj(buffer, tc));
        }
        private void SendCMD(string cmd)
        {
            this.tc.Client.Send(Encoding.ASCII.GetBytes(cmd + '\n'));
        }
        /// <summary>
        /// 向网分发送Raw数据
        /// </summary>
        /// <param name="cmd">指令</param>
        /// <param name="buffer">带头部的数据</param>
        private void SendData(string cmd, byte[] buffer)
        {
            List<byte> bufList = buffer.ToList();
            bufList.InsertRange(0, Encoding.ASCII.GetBytes(cmd));
            bufList.AddRange(Encoding.ASCII.GetBytes("\n"));
            this.tc.Client.Send(bufList.ToArray());
        }
        private void btnGetTraceData_Click(object sender, EventArgs e)
        {
            SendCMD("format:dexport:source fdata");
            SendCMD("trace:data? ch1data");
        }

        private void btnAddMemory_Click(object sender, EventArgs e)
        {
            using (fmSetRsNwa srn = new fmSetRsNwa())
            {
                srn.ShowDialog();
                if (srn.Wgbs != null)
                {
                    this.lbxSetup.Items.Add(srn.Wgbs);
                }
            }
        }

        private void btnSettingsConfirm_Click(object sender, EventArgs e)
        {
            foreach (WuGuiBanShan wgbs in this.lbxSetup.Items)
            {
                if (!wgbs.Initialize(this.tc))
                {
                    MessageBox.Show(wgbs.ToString() + "\tFailed");
                }
            }
            this.btnGetData.Enabled = true;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //  检查选中合法性
            if (this.lbxSetup.SelectedIndex == -1)
            {
                return;
            }
            string imageName = "";
            //  输入待测件的编号
            using (fmDeviceID dId = new fmDeviceID())
            {
                dId.ShowDialog();
                imageName = dId.DeviceID;
            }
            WuGuiBanShan wgbs = ((WuGuiBanShan)this.lbxSetup.SelectedItem);
            wgbs.GetData(this.ckbxReadFullData.Checked);
            //  不同的窗口保存到不同的CSV里
            using (StreamWriter sw = new StreamWriter(this.Path + '\\' + wgbs.MemoryName + ".csv", true, Encoding.ASCII))
            {
                for (int i = 0; i < wgbs.TraceName.Length; i++)
                {
                    sw.Write(imageName + '-' + wgbs.MemoryName + '-' + wgbs.Title[i] + ',' + Encoding.ASCII.GetString(wgbs.TraceData[i]));
                }
            }
            //  保存截图
            string p = this.Path + "\\" + wgbs.MemoryName + imageName + ".bmp";
            using (FileStream fs = new FileStream(p, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] imageBytes = wgbs.TraceData[wgbs.TraceData.Count - 1];
                fs.Write(imageBytes, 0, imageBytes.Length);
            }

        }

        private void btnScanSettings_Click(object sender, EventArgs e)
        {
            using (fmScanCurrentSettings fscs = new fmScanCurrentSettings(this.tc))
            {
                fscs.ShowDialog();
                this.lbxSetup.Items.AddRange(fscs.WGBS);
            }
            this.btnDelMemory.Enabled = false;
            this.btnAddMemory.Enabled = false;
            this.btnEditMemory.Enabled = false;
            this.btnSettingsConfirm.Enabled = false;
            this.btnGetData.Enabled = true;
        }

        private void btnLoadNwa_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.CheckPathExists = ofd.CheckFileExists = ofd.AddExtension = ofd.ValidateNames = ofd.RestoreDirectory = true;
                ofd.Filter = "nwa File (*.nwa)|*.nwa";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buffer = new byte[10 * 1024 * 1024];
                        int n = fs.Read(buffer, 0, buffer.Length);
                        byte[] b = RawDataResolver.GetAgilentBytes(buffer.ToList().GetRange(0, n).ToArray());//带头部的Raw数据
                        string fileName = System.IO.Path.GetFileName(ofd.FileName);
                        this.SendData("mmemory:data \"C:\\AutoTest\\" + fileName + "\",", b);
                        this.SendCMD("mmemory:load:nwanalyzer 1,\"C:\\AutoTest\\" + fileName + "\"");
                    }
                }
            }
            this.btnSettingsConfirm.Enabled = false;
        }
    }
}
