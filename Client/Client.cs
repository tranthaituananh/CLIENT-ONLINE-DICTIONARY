using System;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;

namespace Client
{
    public partial class Client : Form
    {
        Server server = new Server();
        int wordCount = 1;

        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            server.ConnectServer(wbOutput, Ip.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            server.SendData(lvSearchHistory, rtbInput.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportExcel excel = new ExportExcel(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dictionary.xlsx"), 1);
                excel.Write(wordCount, 1, rtbInput.Text, server.GetMeaning());
                wordCount++;
                MessageBox.Show("Write successfully !");
            }
            catch
            {
                MessageBox.Show("File 'dictionary.xlsx' has not been created on your Desktop !");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizerObj;
            if (rtbInput.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.SpeakAsync(rtbInput.Text);
            }
        }
    }
}
