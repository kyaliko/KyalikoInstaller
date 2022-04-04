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
            guna2TextBox1.Text = destinationpath;
        }
        /* 
            zipdl = The Zip URL
            filename = the file name you want to execute (optional)
            destinationpath = the path the executable is in
            zippath = the zip file download path
        */
        string zipdl = "https://";
        string filename = "uwu poggy woggy boy.exe";
        string destinationpath = @"C:\Program Files\kyalikotest\Release\Debug\";
        string zippath = @"C:\Program Files\kyalikotest\kat.zip";
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
                        downloadstuffs.DownloadFileAsync(uri, zippath);
                        guna2Button1.Text = "Downloading..";
                        downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\Program Files\kyalikotest\Release");
                        Uri uri = new Uri(zipdl);
                        downloadstuffs.DownloadFileAsync(uri, zippath);
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
                        downloadstuffs.DownloadFileAsync(uri, zippath);
                        guna2Button1.Text = "Downloading..";
                        downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                    }
                    else
                    {
                        Directory.CreateDirectory(@"C:\Program Files\kyalikotest\Release");
                        Uri uri = new Uri(zipdl);
                        downloadstuffs.DownloadFileAsync(uri, zippath);
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
            ZipFile.ExtractToDirectory(zippath, @"C:\Program Files\kyalikotest\Release");
            using (Process uwu = new Process())
            {
                uwu.StartInfo.UseShellExecute = true;
                uwu.StartInfo.FileName = destinationpath + filename;
                uwu.StartInfo.CreateNoWindow = false;
                uwu.StartInfo.RedirectStandardOutput = false;
                uwu.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
