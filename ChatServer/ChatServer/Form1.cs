using ChatLib.Models;
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
        private async void btnListen_Click(object sender, EventArgs e)
        {
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            _listener.Start(); // 서버 시작

            while (true)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                _ = HandleClient(client);
            }
        }

        private async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();

            byte[] sizeBuffer = new byte[4];
            int read;
            while (true)
            {
                read = await stream.ReadAsync(sizeBuffer, 0, sizeBuffer.Length);
                if (read == 0)
                    break;
                int size = BitConverter.ToInt32(sizeBuffer);
                byte[] buffer = new byte[size];

                read = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (read == 0)
                    break;

                string message = Encoding.UTF8.GetString(buffer, 0, read);

                var hub = ChatHub.Parse(message);
                listBox1.Items.Add($"RoomId: {hub.RoomId}, UserId: {hub.UserId}, " +
                                   $"UserName: {hub.UserName}, Message: {hub.Message}");

                var messageBuffer = Encoding.UTF8.GetBytes($"Server : {message}");
                stream.Write(messageBuffer, 0, messageBuffer.Length);
                txtCount.Text = listBox1.Items.Count.ToString();
            }
        }

        
    }
}
