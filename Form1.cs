using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace UltherapyScraper
{
    public delegate void ItemAdded();
    public partial class Form1 : MaterialForm
    {
        private readonly SynchronizationContext synchronizationContext;
        private int mItemCount;

        public Form1()
        {
            InitializeComponent();

            synchronizationContext = SynchronizationContext.Current;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );


        }

        private void btnSelInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();

            sfd.Filter = "Text Format|*.txt";

            if (DialogResult.OK != sfd.ShowDialog())
                return;

            leInputPath.Text = sfd.FileName;
        }

        private void btnSelOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV Format|*.csv";

            if (DialogResult.OK != sfd.ShowDialog())
                return;

            leOutputPath.Text = sfd.FileName;
        }

        private decimal[] getLocationInfo(string zipcode)
        {
            string url = "https://public.opendatasoft.com/api/records/1.0/search/?dataset=us-zip-code-latitude-and-longitude&q=zip=\"" + zipcode + "\"";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();

                if (HttpStatusCode.OK != rsp.StatusCode)
                    return new decimal[]{};

                StreamReader reader = new StreamReader(rsp.GetResponseStream());
                string jsonString = reader.ReadToEnd();

                reader.Close();
                rsp.Close();

                dynamic data = Json.Decode(jsonString);
                if ( null != data["records"] && data["records"].Length > 0)
                {
                    return new decimal[]
                    {
                        data["records"][0]["fields"]["latitude"],
                        data["records"][0]["fields"]["longitude"],
                    };
                }
            }
            catch (Exception ex)
            {

            }

            return new decimal[] { };
        }


        private async void btnStart_Click(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12;

            string outputPath = leOutputPath.Text;
            string inputPath = leInputPath.Text;

            if ("" == inputPath)
            {
                MessageBox.Show("Select zipcode file.");
                return;
            }

            if ("" == outputPath)
            {
                MessageBox.Show("Select file to save.");
                return;
            }

            string processedPath = "processed.txt";
            List<string> processedList;

            if (File.Exists(processedPath))
                processedList = File.ReadAllLines(processedPath).ToList<string>();
            else
                processedList = new List<string>();

            btnStart.Enabled = false;
            btnStart.Text = "Processing";

            await Task.Run(() =>
            {
                mItemCount = 0;
                Engine engine = new Engine();
                string[] zipCodes = File.ReadAllLines(inputPath);

                for (int i = 0; i < zipCodes.Length; ++ i)
                {
                    string zipcode = zipCodes[i];

                    if (processedList.Contains(zipcode))
                        continue;

                    decimal[] geoLoc = getLocationInfo(zipcode);

                    if (geoLoc.Length < 2)
                    {
                        synchronizationContext.Post(new SendOrPostCallback(o =>
                        {
                            leStatus.Text = "Get Location Failed: " + zipcode;
                        }), null);
                        continue;
                    }

                    synchronizationContext.Post(new SendOrPostCallback(o =>
                    {
                        leStatus.Text = "Processing : " + zipcode;
                    }), null);

                    engine.Start(geoLoc[0], geoLoc[1], 100, outputPath, onNewItemAdded);

                    processedList.Add(zipcode);
                    using (StreamWriter sw = File.AppendText(processedPath))
                    {
                        sw.WriteLine(zipcode);
                    }
                }

            });

            btnStart.Enabled = true;
            btnStart.Text = "Start";
        }

        private void onNewItemAdded()
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                btnStart.Text = o + " Results Found";
            }), ++mItemCount);
        }
    }
}
