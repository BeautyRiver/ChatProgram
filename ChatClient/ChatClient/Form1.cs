using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient _client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            _client = new TcpClient();
            _client.Connect(IPAddress.Parse("127.0.0.1"), 8080);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream stream = _client.GetStream();
            string testMsg = "Client: Hello! This is testMessage";
            byte[] messageBuffer = Encoding.UTF8.GetBytes(testMsg);
            stream.Write(messageBuffer, 0, messageBuffer.Length);

            byte[] buffer = new byte[1024];
            int readByte = stream.Read(buffer, 0, buffer.Length);

            string message = Encoding.UTF8.GetString(buffer, 0, readByte);
            MessageBox.Show(message);
        }
    }
}
