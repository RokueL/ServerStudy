using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener = null;
        TcpClient tcpClient = null;
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
            tcpClient = new TcpClient(textBox1.Text, 3000);
            if (tcpClient.Connected)
            {
                ns = tcpClient.GetStream();
                bw = new BinaryWriter(ns);
                br = new BinaryReader(ns);
                MessageBox.Show("접속성공");
            }
            else
            {
                MessageBox.Show("접속실패");
            }
        }

        /// <summary> 스타트임 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

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
            bw.Write(int.Parse(textBox2.Text));
            bw.Write(float.Parse(textBox3.Text));
            bw.Write(textBox4.Text);

            intValue = br.ReadInt32();
            floatValue = br.ReadSingle();
            strValue = br.ReadString();

            string str = string.Format($"{intValue}\n{floatValue}\n{strValue}");
            MessageBox.Show(str);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bw != null)
            {
                bw.Write(-1);
                bw.Close();
                br.Close();
                ns.Close();
                tcpClient.Close();
            }
        }
    }
}
