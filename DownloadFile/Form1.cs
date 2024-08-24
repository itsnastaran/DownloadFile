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
using System.IO;

namespace DownloadFile
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Random rnd = new Random();
            string aa=Path.GetExtension(txt_url.Text);
            if (folderBrowserDialog1.SelectedPath != "")
                txt_savedin.Text = folderBrowserDialog1.SelectedPath + "\\Download" + rnd.Next(1000, 9999) +aa;
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            if (txt_url.TextLength == 0 || txt_savedin.TextLength == 0)
                MessageBox.Show("تکست باکس ها خالی میباشند");
            else
            {
                Uri imaguri = new Uri(txt_url.Text);
                wc.DownloadFileAsync(imaguri, txt_savedin.Text);
            }
            
        }
        private void wc_DownloadProgressChanged(object sender,DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("فایل کامل دانلود شد","دانلود فایل",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
