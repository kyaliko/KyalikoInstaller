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

namespace uwu_installer
{
    public partial class Form1 : Form
    {
        WebClient uwu = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient downloadstuffs = new WebClient();
            if (Directory.Exists(@"C:\Program Files\KME"))
            {
                if (Directory.Exists(@"C:\Program Files\KME\Release"))
                {
                    Uri uri = new Uri("https://github.com/TSSKake/KakesMediaExplorer/archive/refs/heads/main.zip");
                    downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\KME\githubmain.zip");
                    guna2Button1.Text = "Downloading..";
                    downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                }
                else
                {
                    Directory.CreateDirectory(@"C:\Program Files\KME\Release");
                    Uri uri = new Uri("https://github.com/TSSKake/KakesMediaExplorer/archive/refs/heads/main.zip");
                    downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\KME\githubmain.zip");
                    guna2Button1.Text = "Downloading..";
                    downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                }
            }
            else
            {
                Directory.CreateDirectory(@"C:\Program Files\KME");
                if (Directory.Exists(@"C:\Program Files\KME\Release"))
                {
                    Uri uri = new Uri("https://github.com/TSSKake/KakesMediaExplorer/archive/refs/heads/main.zip");
                    downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\KME\githubmain.zip");
                    guna2Button1.Text = "Downloading..";
                    downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                }
                else
                {
                    Directory.CreateDirectory(@"C:\Program Files\KME\Release");
                    Uri uri = new Uri("https://github.com/TSSKake/KakesMediaExplorer/archive/refs/heads/main.zip");
                    downloadstuffs.DownloadFileAsync(uri, @"C:\Program Files\KME\githubmain.zip");
                    guna2Button1.Text = "Downloading..";
                    downloadstuffs.DownloadFileCompleted += new AsyncCompletedEventHandler(FiledownloadComplete);
                }
            }

        }

        private void FiledownloadComplete(object sender,AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory(@"C:\Program Files\uwu\kat.zip", @"C:\Program Files\uwu");
            File.Open(@"C:\Program Files\uwu\uwu poggy woggy boy.exe", FileMode.Open);
        }
    }
}
