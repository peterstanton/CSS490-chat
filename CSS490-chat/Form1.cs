using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace CSS490_chat
{
    public partial class Form1 : Form
    {
        Socket sckCommunication;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
            GetLocalIP();
            sckCommunication = new Socket(AddressFamily.InterNetwork,
                    SocketType.Dgram, ProtocolType.Udp);
            sckCommunication.SetSocketOption(SocketOptionLevel.Socket,
                                SocketOptionName.ReuseAddress, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(myIP.Text),
                          Convert.ToInt32(myPort.Text));
            sckCommunication.Bind(epLocal);

            // connect to remote ip and port
            epRemote = new IPEndPoint(IPAddress.Parse(otherIP.Text),
                                    Convert.ToInt32(friendPort.Text));
            sckCommunication.Connect(epRemote);

            // starts to listen to an specific port
            buffer = new byte[1464];
            sckCommunication.BeginReceiveFrom(buffer, 0, buffer.Length,
                                     SocketFlags.None, ref epRemote,
                            new AsyncCallback(OperatorCallBack), buffer);

            // release button to send message
            sendButton.Enabled = true;

        }

        private void GetLocalIP()
        {
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                List<System.Net.IPAddress> blah = new List<System.Net.IPAddress>();
                blah = (from ip in host.AddressList where !IPAddress.IsLoopback(ip) select ip).ToList();
                StringBuilder sigh = new StringBuilder();
                sigh.Append("Select your network assigned IP address from the list below " +
                    "and enter it into the my IP box. " + Environment.NewLine + Environment.NewLine);
                for (int i = 0; i < blah.Count; i++)
                {
                    sigh.Append(blah[i]);
                    sigh.Append(Environment.NewLine);
                }
                ipBox.Text = sigh.ToString();
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // converts from string to byte[]
            System.Text.ASCIIEncoding enc =
                    new System.Text.ASCIIEncoding();
            byte[] msg = new byte[1464];
            msg = enc.GetBytes(outBox.Text);

            // sending the message
            sckCommunication.Send(msg);

            // add to listbox
            bigTextBox.Items.Add("You: " + outBox.Text);

            // clear txtMessage
            outBox.Clear();

        }

        private void OperatorCallBack(IAsyncResult ar)
        {
            try
            {
                int size = sckCommunication.EndReceiveFrom(ar, ref epRemote);

                // check if theres actually information
                if (size > 0)
                {
                    // used to help us on getting the data
                    byte[] aux = new byte[1464];

                    // gets the data
                    aux = (byte[])ar.AsyncState;

                    // converts from data[] to string
                    System.Text.ASCIIEncoding enc =
                                            new System.Text.ASCIIEncoding();
                    string msg = enc.GetString(aux);

                    // adds to listbox
                    bigTextBox.Items.Add("Friend: " + msg);
                }

                // starts to listen again
                buffer = new byte[1464];
                sckCommunication.BeginReceiveFrom(buffer, 0,
                                    buffer.Length, SocketFlags.None,
                    ref epRemote, new AsyncCallback(OperatorCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

    }
}

