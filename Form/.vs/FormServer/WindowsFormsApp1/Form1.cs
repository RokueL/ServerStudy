using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener;
        TcpClient tcpClient;
        NetworkStream ns;
        BinaryWriter bw;
        BinaryReader br;

        int intValue;
        float floatValue;
        string strValue;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary> 접속 버튼 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient = tcpListener.AcceptTcpClient();
            if (tcpClient.Connected)
            {
                textBox2.Text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).ToString();
            }
            ns = tcpClient.GetStream();
            bw = new BinaryWriter(ns);
            br = new BinaryReader(ns);
        }

        /// <summary> 스타트임 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(3000);
            tcpListener.Start();
            // 내 서버 아이피 불러오는 거
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = host.AddressList[i].ToString();
                    break;
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary> 송수신 버튼 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (tcpClient == null)
            {
                MessageBox.Show("접속자가 없습니다");
                return;
            }
            while (true)
            {
                if(tcpClient.Connected)
                {
                    if (DataReceive() == -1)
                    {
                        textBox2.Text = "";
                        AllClose();
                        break;
                    }
                    DataSend();
                }
                else 
                {
                    AllClose();
                    break;
                }
            }
        }

        private void AllClose()
        {
            if(bw != null){ bw.Close(); bw = null; }
            if (br != null) { br.Close(); br = null; }
            if (ns != null) { ns.Close(); ns = null; }
            if (tcpClient != null) { tcpClient.Close(); tcpClient = null; }
            MessageBox.Show("접속자가 접속을 종료했습니다.");
        }
        
        private int DataReceive()
        {
            intValue = br.ReadInt32();
            if (intValue == -1)
                return -1; 

            floatValue = br.ReadSingle();
            strValue = br.ReadString();
            string str = string.Format($"{intValue}\n{floatValue}\n{strValue}");
            MessageBox.Show(str);
            return 0;
        }

        private void DataSend()
        {
            bw.Write(intValue);
            bw.Write(floatValue);
            bw.Write(strValue);
            MessageBox.Show("보냈습니다");
        }
    }
}
