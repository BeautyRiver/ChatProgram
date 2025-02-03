using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener _listener;
        private void btnListen_Click(object sender, EventArgs e)
        {
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            _listener.Start(); // 서버 시작

            TcpClient client = _listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int readByte = stream.Read(buffer, 0, buffer.Length);

            string message = Encoding.UTF8.GetString(buffer, 0, readByte);
            MessageBox.Show(message);

            var messageBuffer = Encoding.UTF8.GetBytes($"Server: {message}");
            stream.Write(messageBuffer, 0, messageBuffer.Length);   


        }
    }
}
