using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace UltherapyScraper
{
    class Engine
    {
        private string API_URL = "https://locator.merzusa.com/on/demandware.store/Sites-MerzNA-Site/default/Widget-GetData";

        public void ProcessItem(dynamic data, string outputPath)
        {
            string name, address, phone, city, state, country = "US", zipcode, website;

            name = null != data["name"] ? data["name"] : "";
            address = null != data["address"] ? data["address"] : "";
            phone = null != data["phone"] ? data["phone"] : "";
            city = null != data["city"] ? data["city"] : "";
            state = null != data["state"] ? data["state"] : "";
            zipcode = null != data["postalCode"] ? data["postalCode"] : "";
            website = null != data["practiceWebsite"] ? data["practiceWebsite"] : "";

            using (StreamWriter sw = File.AppendText(outputPath))
            {
                string line = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\"",
                    name, address, city, state, zipcode, country, phone, website);
                sw.WriteLine(line);
            }
        }

        public void Start(decimal latitude, decimal longitude, int maxDistance, string outputPath, ItemAdded callback)
        {
            string url = API_URL + "?scope=stores:" + latitude.ToString("0.000000") + "," +
                longitude.ToString("0.000000") + "," + maxDistance + "&brand=ultherapy";

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();

                if (HttpStatusCode.OK != rsp.StatusCode)
                    return;

                StreamReader reader = new StreamReader(rsp.GetResponseStream());
                string jsonString = reader.ReadToEnd();

                reader.Close();
                rsp.Close();

                dynamic data = Json.Decode(jsonString);
                foreach (dynamic item in data["stores"])
                {
                    ProcessItem(item, outputPath);
                    callback();
                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
