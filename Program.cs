using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
namespace AZ_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.IO.Directory.CreateDirectory(@"C:/AZ/");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://192.168.0.9/Current.txt", @"c:\az\Current.txt");
            webClient.DownloadFile("http://192.168.0.9/Get.txt", @"c:\az\Get.txt");
            webClient.DownloadFile("http://192.168.0.9/Names.txt", @"c:\az\Names.txt");
            webClient.DownloadFile("http://192.168.0.9/Store.txt", @"c:\az\Store.txt");
            webClient.DownloadFile("http://192.168.0.9/Versions.txt", @"c:\az\Versions.txt");
            webClient.DownloadFile("http://192.168.0.9/URL.txt", @"c:\az\URL.txt");
            Application.Run(new Form1());
          
        }
    }
}
