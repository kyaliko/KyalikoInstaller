using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace uwu_installer
{
    public partial class Form1 : Form
    {
        WebClient uwu = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }
        string zipdl = "whatever url";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient downloadstuffs = new WebClient();
            try
            {
                if (Directory.Exists(@"C:\Program Files\kyalikotest"))
                {
                    if (Directory.Exists(@"C:\Program Files\kyalikotest\Release"))
                    {
                        Uri uri = new Uri(zipdl);
                        downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\kyalikotest\kyaliko.zip");
                        guna2Button1.Text = "Downloading..";
                        downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\Program Files\kyalikotest\Release");
                        Uri uri = new Uri(zipdl);
                        downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\kyalikotest\kyaliko.zip");
                        guna2Button1.Text = "Downloading..";
                        downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"C:\Program Files\kyalikotest");
                    if (Directory.Exists(@"C:\Program Files\kyalikotest\Release"))
                    {
                        Uri uri = new Uri(zipdl);
                        downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\kyalikotest\kyaliko.zip");
                        guna2Button1.Text = "Downloading..";
                        downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\Program Files\kyalikotest\Release");
                        Uri uri = new Uri(zipdl);
                        downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\kyalikotest\kyaliko.zip");
                        guna2Button1.Text = "Downloading..";
                        downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable To Download\n\nException Error:\n{0}", ex.Message);
            }
        }

        private void FiledownloadComplete(object sender,AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory(@"C:\Program Files\kyalikotest\kat.zip", @"C:\Program Files\kyalikotest\Release");
            using (Process uwu = new Process())
            {
                uwu.StartInfo.UseShellExecute = false;
                uwu.StartInfo.FileName = @"C:\Program Files\kyalikotest\Release\Debug\uwu poggy woggy boy.exe";
                uwu.StartInfo.CreateNoWindow = true;
                uwu.StartInfo.RedirectStandardOutput = false;
                uwu.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                uwu.Start();
            }
            guna2Button1.Text = "Installed!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/kyaliko");
        }
    }
}
