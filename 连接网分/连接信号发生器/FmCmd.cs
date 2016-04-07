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
using Keysight.Visa;
using Ivi.Visa;

namespace 连接信号发生器
{
    public partial class FmCmd : Form
    {
        Action SendCmd { set; get; }
        IMessageBasedRawIO Mrio { set; get; }
        public FmCmd()
        {
            InitializeComponent();
        }
        public FmCmd(Action sendCmd)
            : this()
        {
            this.SendCmd = sendCmd;
        }
        public FmCmd(IMessageBasedRawIO mrio)
            : this()
        {
            this.Mrio = mrio;
        }
        private void BtnSendCmd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbxCmd.Text))
            {
                try
                {
                    Mrio.Write(Encoding.ASCII.GetBytes(TbxCmd.Text));//发送指令
                    TbxReturn.AppendText(TbxCmd.Text + Environment.NewLine);
                    TbxCmd.Clear();
                    byte[] buffer = Mrio.Read();//读取响应
                    TbxReturn.AppendText(Encoding.ASCII.GetString(buffer) + Environment.NewLine);
                    if (chkbxSaveCsv.Checked)//如果需要保存返回数据到csv
                    {
                        string strReturn = Encoding.ASCII.GetString(buffer);//处理返回数据
                        string[] str = strReturn.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        strReturn = string.Join(",\n", str);
                        using (SaveFileDialog sfd = new SaveFileDialog())//写csv文件
                        {
                            sfd.Filter = "csv File (*.csv)|*.csv";
                            sfd.RestoreDirectory = true;
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                                {
                                    TbxReturn.AppendText("Saving .csv File......");
                                    fs.Write(Encoding.Unicode.GetBytes(strReturn), 0, Encoding.Unicode.GetBytes(strReturn).Length);
                                    TbxReturn.AppendText("Done." + Environment.NewLine);
                                }
                            }
                        }
                    }
                }
                catch (Exception err)//看看报什么错
                {
                    TbxReturn.AppendText("ERR: " + err.Message + Environment.NewLine);
                }
            }
        }
    }
}
