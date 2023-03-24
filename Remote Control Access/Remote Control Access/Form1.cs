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
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Net;
using AudioSwitcher.AudioApi.CoreAudio;


namespace Remote_Control_Access
{
    public partial class mainForm : Form
    {
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber;

        private readonly Thread GetData;

        CoreAudioDevice audioManager = new CoreAudioController().DefaultPlaybackDevice; //Creates manager to control the volume

        private static Image Desktop()
        {
            //Creating screenshot and sending it afterwards
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(screenshot);
            g.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);

            return screenshot;
        }

        public bool sendInfo = false;
        private void SendDesktop()
        {
            //Sending the desktop to the hosting machine:
            BinaryFormatter binFormat = new BinaryFormatter();
            mainStream = client.GetStream();
            if(sendInfo)
            {
                //Getting the IP address of the machine:
                string hostName = Dns.GetHostName();
                string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();

                //Sending the IP to the hosting machine:
                //byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("ip " + IP);

                //Getting the OS Version & Name
                //string OS = RuntimeInformation.OSDescription;

                //Sending the OS Info to the hosting machine:
                //bytesToSend = ASCIIEncoding.ASCII.GetBytes("os " + OS);

                //Getting amount of CPU Cores:
                //int coreCount = Environment.ProcessorCount;

                //Sending the amount of CPU Cores to the hosting machine:
                //bytesToSend = ASCIIEncoding.ASCII.GetBytes("cpu " + OS);


                //binFormat.Serialize(mainStream, Desktop());
                binFormat.Serialize(mainStream, Desktop());
            }
        }

        public mainForm()
        {
            //Starts receiving data
            GetData = new Thread(ReceiveData);

            InitializeComponent();
        }
        private void ReceiveData()
        {
            while (true)
            {
                if (mainStream != null)
                {
                    //Reading all bytes that we receive so we can check data
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = mainStream.Read(buffer, 0, client.ReceiveBufferSize);
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    //Splitting the commands so we can know what exactly we are searching for
                    List<string> commands = dataReceived?.Split(' ').ToList();

                    if (commands[0] == "msg")
                    {
                        //Getting the full message & removing "msg"
                        string fullMessage = "";

                        commands.RemoveAt(0);
                        foreach(string m in commands)
                        {
                            fullMessage += m + " ";
                        }

                        //Showing message box with the entered message to the computer
                        this.BeginInvoke((Action)(() => MessageBox.Show(fullMessage)));
                    }
                    else if(commands[0] == "desktop")
                    {
                        //Getting the desktop path and creating folder with the entered name
                        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string pathString = Path.Combine(desktop, commands[1]);
                        Directory.CreateDirectory(pathString);
                    }

                    else if (commands[0] == "web")
                    {
                        //Checking if the textbox url has these parameters
                        if (!dataReceived.Contains("http://www") || !dataReceived.Contains("https://www"))
                        {
                            //Opening the web page trough main browser
                            System.Diagnostics.Process.Start("https://www." + commands[1]);
                        }
                    }

                    else if (commands[0] == "setvolume")
                    {
                        //Checking if the textbox url has these parameters
                        audioManager.Volume = Int32.Parse(commands[1]);
                    }
                }
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(portTxt.Text);
            try
            {
                //Connecting the client to the IP & Port number
                client.Connect(ipTxt.Text, portNumber);
                sendInfo = true;
                MessageBox.Show("Connected Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect!");
            }
        }

        private void shareTimer_Tick(object sender, EventArgs e)
        {
            //Starting the sharing
            SendDesktop();
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            if (shareBtn.Text == "Share Screen")
            {
                shareTimer.Start();
                shareBtn.Text = "Sharing...";
            }
            else if (shareBtn.Text == "Sharing...")
            {
                shareTimer.Stop();
                shareBtn.Text = "Share Screen";
            }
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            //Enabling the Remote Control Panel
            new ScreenForm(int.Parse(portTxt2.Text)).Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Starting to gather data thread
            GetData.Start();
        }
    }
}
