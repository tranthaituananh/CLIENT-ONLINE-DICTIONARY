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
        TcpClient tcpclient;
        Stream stream;
        string plainResult;
        string meaning;
        string type;
        WebBrowser browser;

        public void Connect(WebBrowser webBrowser, int counter, string serverIP)
        {
            //thiết lập IP mới và các thông số đầu vào cần thiết
            IPEndPoint ipendpoint;
            browser = webBrowser;

            try
            {
                //thực hiện kết nối
                tcpclient = new TcpClient();
                ipendpoint = new IPEndPoint(IPAddress.Parse(serverIP), 9999);
                tcpclient.Connect(ipendpoint);

                //tạo thread mới để truyền dữ liệu
                stream = tcpclient.GetStream();

                //nếu server trả về true thì connect, báo ra cho người dùng biết
                Thread recv = new Thread(Receive);
                recv.IsBackground = true;
                recv.Start();
                MessageBox.Show("Successfully Connected !");
            }
            catch
            {
                //nếu có bất kỳ lỗi nào, báo ra rằng không thể kết nối
                MessageBox.Show("Can't connect, please try again later !");
                return;
            }
        }

        public void Send(ListView searchedList, string message)
        {
            //gửi đata đi 
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);

            //hiện lên trên danh sách những từ đã tìm kiếm
            searchedList.Items.Add("- " + message);
        }

        public void Receive()
        {
            try
            {
                while (true)
                {
                    //nhận dữ liệu thô từ server
                    byte[] recv = new byte[1024];
                    stream.Read(recv, 0, recv.Length);
                    plainResult = Encoding.UTF8.GetString(recv);

                    //chia kết quả vào những thành phần phủ hợp để render ra giao diện
                    ResolveResult();
                }
            }
            catch
            {
                //nếu không thể nhận data được 
                MessageBox.Show("Server has no response, please try again !");
            }

        }

        public void ResolveResult()
        {
            //replace những thành phần thừa mà server trả về 
            plainResult = plainResult.Replace("+", ": ");
            plainResult = plainResult.Replace("=", " ");

            //dạng trả về là HTML, nên sẽ có những tag br. tag br ký hiệu cho xuống dòng 
            string[] splitter = { "<br />" };
            string[] temp = plainResult.Split(splitter, StringSplitOptions.None);

            //lặp qua mảng temp - nơi lưu dữ liệu đã được cắt thành từng dòng 
            //dấu * đầu dòng ký hiệu cho loại từ 
            //dấu - ký hiệu cho nghĩa của từ 
            foreach (string item in temp)
            {
                if (item.Contains("*"))
                {
                    type = item;
                }

                if (item.Contains("-"))
                {
                    meaning = item;
                    break;
                }
            }

            //hiển thị toàn bộ data ra browser 
            browser.DocumentText = plainResult;
        }

        public string GetMeaning()
        {
            return meaning;
        }

        public string GetWordType()
        {
            return type;
        }
    }
}
