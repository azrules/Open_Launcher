using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
namespace AZ_Launcher
{
   


    public partial class Form1 : Form
    {
        
        string[] appc = System.IO.File.ReadAllLines(@"c:\az\Current.txt");
        string[] appn = System.IO.File.ReadAllLines(@"c:\az\Names.txt");
        string[] appv = System.IO.File.ReadAllLines(@"c:\az\Versions.txt");
        string[] appst = System.IO.File.ReadAllLines(@"c:\az\Store.txt");
        string[] appg = System.IO.File.ReadAllLines(@"c:\az\Get.txt");
        string[] appurl = System.IO.File.ReadAllLines(@"c:\az\URL.txt");
        public Form1()
        {

            InitializeComponent();
           
              //apps.Items.Add(appc[]);
            for(int i = 0; i < Int32.Parse(appc[0]); i++){

                    apps.Items.Add(appn[i]);
                    WebView.Navigate("http://az-inc.com/");
                
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            WebClient client = new WebClient();

            for(int i = 0; i < Int32.Parse(appc[0]); i++){
               if(apps.GetSelected(i)){
                   
                    
               
                    client.DownloadFileAsync(new Uri(appg[i]), @appurl[i]);

                }
            }
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        private void apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            for (int i = 0; i < Int32.Parse(appc[0]); i++)
            {
                if (apps.GetSelected(i))
                {
                    WebView.Navigate(appurl[i]);
                    WebView.Refresh();

                }
            }
        }


    }
}
