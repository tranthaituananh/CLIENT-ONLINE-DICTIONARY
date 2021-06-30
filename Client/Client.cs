using System;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class Client : Form
    {
        int count = 2;
        Server server = new Server();

        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            server.Connect(wbOutput, count, Ip.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            server.Send(rtbSearchHistory, rtbInput.Text);   
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please create a 'report' file on your Desktop");
                var name = "report.xlsx";
                var dicrec = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var fullpath = Path.Combine(dicrec, name);
                ExportExcel excel = new ExportExcel(fullpath, 1);

                excel.WriteToCell(count, 1, rtbInput.Text, server.GetWordType(), server.GetMeaning());
                count++;
                excel.Save();
                excel.Close();
                MessageBox.Show("Write successfully !");
            }
            catch
            {
                MessageBox.Show("Make sure the file 'report' exists!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
