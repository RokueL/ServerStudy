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
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        TcpListener tcpListener;

        int intValue;
        float floatValue;
        string strValue;

        public Form2()
        {
            InitializeComponent();
        }

        // 클라 받는 부분
        private void AcceptClient()
        {
           while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                if (client.Connected)
                {
                    string str = ((IPEndPoint)client.Client.RemoteEndPoint).ToString();
                    listBox1.Items.Add(str);
                }
                EchoServer echoServer = new EchoServer(client);
                Thread th = new Thread(new ThreadStart(echoServer.Process));
                th.IsBackground = true;
                th.Start();
            }

        }

        /// <summary> 서버 시작 버튼 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("서버를 실행했습니다");
            Thread th = new Thread(new ThreadStart(AcceptClient));
            th.IsBackground = true;
            th.Start();
        }

        /// <summary> 스타트임 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
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


        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }
    }
}
class EchoServer
{
    TcpClient RefClient;
    private BinaryReader Reader = null;
    private BinaryWriter Writer = null;
    int intValue;
    float floatValue;
    string strValue;

    public EchoServer(TcpClient client)
    {
        RefClient = client;
    }

    public void Process()
    {
        NetworkStream ns = RefClient.GetStream();
        try
        {
            Reader = new BinaryReader(ns);
            Writer = new BinaryWriter(ns);
            while (true)
            {
                intValue = Reader.ReadInt32();
                floatValue = Reader.ReadSingle();
                strValue = Reader.ReadString();

                Writer.Write(intValue);
                Writer.Write(floatValue);
                Writer.Write(strValue);
            }
        }
        catch (SocketException error)
        {
            Reader.Close();
            Writer.Close();
            ns.Close();
            ns = null;
            RefClient.Close();
            MessageBox.Show(error.Message);
            Thread.CurrentThread.Abort();
        }
        catch(IOException error)
        {
            // 연결이 끊어져서 읽을 수가 없을 때 처리
            Reader.Close();
            Writer.Close();
            ns.Close();
            ns = null;
            RefClient.Close();
            Thread.CurrentThread.Abort();
        }
    }
}
