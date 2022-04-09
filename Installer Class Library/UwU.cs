using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InstallLib
{
    public class UwU
    {

        public string kat = "";
        public static void Unzip(string ZipPath, string DestinationPath)
        {
            //uwu
            ZipFile.CreateFromDirectory(ZipPath, DestinationPath);
        }
        public static void zip(string FolderPath, string ZipName, string ZipDestination)
        {
            ZipFile.CreateFromDirectory(FolderPath, ZipDestination + ZipName);
        }

        
        public static void InstallFile(Uri Url, string FileName)
        {
            try
            {
                using (WebClient install = new WebClient())
                {
                    install.DownloadFileAsync(Url, FileName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
