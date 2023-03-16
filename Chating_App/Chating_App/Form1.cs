using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chating_App
{
    public partial class Form1 : Form
    {
        Socket Skt;
        EndPoint epLocal, epRemote;
        public Form1()
        {
            InitializeComponent();
            Skt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Skt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtIPC1.Text = GetLocalIP();
            txtIPC2.Text = GetLocalIP();
        }

        private string GetLocalIP() {
            IPHostEntry Host;
            Host = Dns.GetHostEntry(Dns.GetHostName());
            
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    return IP.ToString();}
                
            }
            return "119.159.101.106";
        }
        private void MsgCallBack(IAsyncResult aResult) {
            try
            {
                int size = Skt.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0) {
                    byte[] receiveData = new byte[1464];
                    receiveData = (byte[]) aResult.AsyncState;
                    ASCIIEncoding ECoding = new ASCIIEncoding();
                    string receivedMsg = ECoding.GetString(receiveData);
                    ListMsg.Items.Add("Client 2: " + receivedMsg);

                }
                byte[] buffer = new byte[1500];
                Skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MsgCallBack), buffer);


            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtIPC1.Text), Convert.ToInt32(txtProtC1.Text));
                Skt.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(txtIPC2.Text), Convert.ToInt32(txtPORTC2.Text));
                Skt.Connect(epRemote);

                byte[] buffer = new byte[1500];
                Skt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MsgCallBack), buffer);
                btnStart.Text = "Connected";
                btnStart.Enabled = false;
                btnSend.Enabled = true;
                txtMsg.Focus();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtMsg.Text);
                Skt.Send(msg);
                ListMsg.Items.Add("Cleint 1: "+txtMsg.Text);
                txtMsg.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
