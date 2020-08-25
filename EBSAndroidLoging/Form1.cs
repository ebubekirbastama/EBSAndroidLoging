using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace EBSAndroidLoging
{
    public partial class Form1 : Form
    {
        ProcessStartInfo ps = new ProcessStartInfo();
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.CreateNoWindow = true;
            ps.UseShellExecute = false;
            ps.RedirectStandardOutput = true;
        }
        Thread th; OpenFileDialog op;
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(bsl); th.Start();
        }
        private void bsl()
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.AppendText(Gtprt(log.komutlar[0].ToString()));
                    break;
                case 1:
                    richTextBox1.AppendText(Gtprt(log.komutlar[1].ToString()));
                    break;
                case 2:
                    richTextBox1.AppendText(Gtprt(log.komutlar[2].ToString()));
                    break;
                case 3:
                    richTextBox1.AppendText(Gtprt(log.komutlar[3].ToString()));
                    break;
                case 4:
                    richTextBox1.AppendText(Gtprt(log.komutlar[4].ToString()));
                    break;
                case 5:
                    richTextBox1.AppendText(Gtprt(log.komutlar[5].ToString()));
                    break;
                case 6:
                    richTextBox1.AppendText(Gtprt(log.komutlar[6].ToString()));
                    break;
                case 7:
                    richTextBox1.AppendText(Gtprt(log.komutlar[7].ToString()));
                    break;
                case 8:
                    richTextBox1.AppendText(Gtprt(log.komutlar[8].ToString()));
                    break;
                case 9:
                    richTextBox1.AppendText(Gtprt(log.komutlar[9].ToString()));
                    break;
                case 10:
                    richTextBox1.AppendText(Gtprt(log.komutlar[10].ToString()));
                    break;

                default:
                    break;
            }


        }
        public string Gtprt(string cml)
        {
            using (Process p = new Process())
            {
                ps.Arguments = cml;
                ps.FileName = "adb.exe";
                ps.UseShellExecute = false;
                ps.WindowStyle = ProcessWindowStyle.Hidden;
                ps.RedirectStandardInput = true;
                ps.RedirectStandardOutput = true;
                ps.RedirectStandardError = true;
                p.StartInfo = ps;
                p.Start();

                StreamReader stdOutput = p.StandardOutput;
                StreamReader stdError = p.StandardError;

                string content = stdOutput.ReadToEnd() + stdError.ReadToEnd();

                return content;
            }
        }
    }
}
