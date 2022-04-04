using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Installer_Class_Library
{
    public class UwU
    {
        public static void Unzip(string ZipPath, string DestinationPath)
        {
            ZipFile.CreateFromDirectory(ZipPath, DestinationPath);
        }
        public static void InstallFile(Uri Url, string FileName)
        {
            using(WebClient install = new WebClient())
            {
                install.DownloadFileAsync(Url, FileName);
            }
        }
    }
}
