using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock_App.Tabs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            SettingsClass s = DatabaseConnection.LoadSettingsData();
            DTAOD.Checked = bool.Parse(s.DeleteTimersOnceDone);
            DAAOD.Checked = bool.Parse(s.DeleteAlarmsOnceDone);
        }

        private void DTAOD_Click(object sender, EventArgs e)
        {
            SettingsClass res = new SettingsClass();
            res.DeleteTimersOnceDone = DTAOD.Checked.ToString();
            DatabaseConnection.SaveSettingsData(res, "DeleteTimersOnceDone", "@DeleteTimersOnceDone");
        }

        private void DAAOD_Click(object sender, EventArgs e)
        {
            SettingsClass res = new SettingsClass();
            res.DeleteAlarmsOnceDone = DAAOD.Checked.ToString();
            DatabaseConnection.SaveSettingsData(res, "DeleteAlarmsOnceDone", "@DeleteAlarmsOnceDone");
        }
    }
}
