using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Alarm_Clock_App.Classes
{
    class Tag { public string tag_name { get; set; }  }

    public class VersionChecker
    {
        public static readonly double currentVersion = 0.1;
        private static readonly string URL = "https://api.github.com/repos/RefinedDev/Alarm-Clock-App/releases/latest";
        private static readonly string openURL = "https://github.com/RefinedDev/Alarm-Clock-App/releases";

        public async static void Check(double currentVersion)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", @"Mozilla/5.0 (Windows NT 10; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0");
                    HttpResponseMessage msg = await client.GetAsync(URL);
                    string c = await msg.Content.ReadAsStringAsync();

                    Tag tag = JsonConvert.DeserializeObject<Tag>(c);

                    if (currentVersion < double.Parse(tag.tag_name.Split('v')[1]))
                    {
                        DialogResult d = MessageBox.Show("A new version for ACA is available. Would you like to download it?", "New Version Available", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(openURL);
                        }

                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
          
        }
    }
}
