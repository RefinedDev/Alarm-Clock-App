﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock_App
{
    public class WorldClockClass
    {
        public async static void GetTimeOfPlace(string place, Label exitbox, TextBox Input)
        {
            using (HttpClient client = new HttpClient())
            {
                string URL = string.Format("https://www.google.com/search?q=time+in+{0}", place.Replace(" ", "+"));
                
                HttpResponseMessage response = await client.GetAsync(URL);

                string content = await response.Content.ReadAsStringAsync();

                Regex rx = new Regex(@"\d+:\d+\s..", RegexOptions.Compiled); // \d+:\d+\s..
                Match m = rx.Match(content);

                if (m.Length == 0)
                {
                    exitbox.Text = "No Result Found";
                }
                else
                {
                    exitbox.Text = string.Format("Time in {0}: {1}", Input.Text, m.ToString());
                }
            }
        }

    }
}
