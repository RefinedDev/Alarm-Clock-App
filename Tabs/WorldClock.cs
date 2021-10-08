using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock_App.Tabs
{
    public partial class WorldClock : Form
    {
        public WorldClock()
        {
            InitializeComponent();
        }

        private void setLocalTime()
        {
            result.Text = string.Format("Local Time: {0} {1}", 
                DateTime.Now.ToString("hh:mm"),
                DateTime.Now.ToString("tt", CultureInfo.InvariantCulture).ToLower());
        }

        private void WorldClock_Load(object sender, EventArgs e)
        {
            setLocalTime();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length == 0)
            {
                setLocalTime();
                return;
            }

            WorldClockClass.GetTimeOfPlace(inputBox.Text, result, inputBox);
        }
    }
}
