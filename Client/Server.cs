using System;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    class Server
    {
        Stream stream;
        WebBrowser browser;
        string output;
        string meaning;
        int wordCount = 1;

        public void ConnectServer(WebBrowser webBrowser, string serverIP)
        {
            browser = webBrowser;
            try
            {
                IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Parse(serverIP), 9999);
                TcpClient tcpClient = new TcpClient();                
                tcpClient.Connect(ipEndpoint);
                stream = tcpClient.GetStream();
                Thread receiveData = new Thread(ReceiveData);
                receiveData.IsBackground = true;
                receiveData.Start();
                MessageBox.Show("Successfully Connected !");
            }
            catch
            {
                MessageBox.Show("Can't connect, please try again later !");
                return;
            }
        }

        public void SendData(ListView searchHistory, string message)
        {            
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            searchHistory.Items.Add(wordCount + ". " + message);
            wordCount++;
        }

        public void ReceiveData()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[102400];
                    stream.Read(data, 0, data.Length);
                    output = Encoding.UTF8.GetString(data).Replace("+ ", ": ").Replace("=", " ");                               
                    browser.DocumentText = output;
                }
            }
            catch
            {
                MessageBox.Show("Server has no response, please try again !");
            }

        }

        public string GetMeaning()
        {
            string[] splitter = { "<br />" }; 
            string[] temp = output.Split(splitter, StringSplitOptions.None);
            foreach (string item in temp)
            {
                if (item.Contains("-"))
                {
                    meaning = item;
                    break;
                }
            }
            return meaning;
        }
    }
}
