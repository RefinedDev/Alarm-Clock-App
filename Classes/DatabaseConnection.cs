using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace Alarm_Clock_App
{
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                cnn.Execute("CREATE TABLE IF NOT EXISTS TimerData (TS INTEGER NOT NULL, ID TEXT NOT NULL UNIQUE PRIMARY KEY, OGTime INTEGER NOT NULL, NameOfTimer TEXT NOT NULL)");
                cnn.Execute("CREATE TABLE IF NOT EXISTS Settings (DeleteTimersOnceDone TEXT NOT NULL, DeleteAlarmsOnceDone TEXT NOT NULL, amog INTEGER NOT NULL UNIQUE)");
                cnn.Execute("CREATE TABLE IF NOT EXISTS AlarmData (TS INTEGER NOT NULL, NameOfAlarm TEXT NOT NULL, IsOn TEXT NOT NULL, ID TEXT NOT NULL UNIQUE PRIMARY KEY)");
                cnn.Execute("CREATE TABLE IF NOT EXISTS WorldClockData (Place TEXT NOT NULL, ID INTEGER UNIQUE PRIMARY KEY AUTOINCREMENT)");
            }
        }

        // TIMER
        public static List<ACATimer> LoadTimerData()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                var data = cnn.Query<ACATimer>("SELECT * FROM TimerData", new DynamicParameters());

                return data.ToList();
            }
        }

        public static void SaveTimerData(ACATimer TimerData,bool isUpdate = false)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                if (isUpdate)
                {
                    cnn.Execute("UPDATE TimerData SET TS = @TS WHERE ID = @ID", TimerData);
                }
                else
                {
                    cnn.Execute("INSERT INTO TimerData VALUES (@TS,@ID,@OGTime,@NameOfTimer)", TimerData);
                }
                
            }
        }

        public static void RemoveTimerData(ACATimer TimerData)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                cnn.Execute("DELETE FROM TimerData WHERE ID = @ID", TimerData);
            }
        }

        // ALARM
        public static List<Classes.ACAAlarm> LoadAlarmData()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                var data = cnn.Query<Classes.ACAAlarm>("SELECT * FROM AlarmData", new DynamicParameters());

                return data.ToList();
            }
        }

        public static void SaveAlarmData(Classes.ACAAlarm AlarmData, bool isUpdate = false)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                if (isUpdate)
                {
                    cnn.Execute("UPDATE AlarmData SET TS = @TS, IsOn = @IsOn WHERE ID = @ID", AlarmData);
                }
                else
                {
                    cnn.Execute("INSERT INTO AlarmData VALUES (@TS,@NameOfAlarm,@IsOn,@ID)", AlarmData);
                }

            }
        }

        public static void RemoveAlarmData(Classes.ACAAlarm AlarmData)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                cnn.Execute("DELETE FROM AlarmData WHERE ID = @ID", AlarmData);
            }
        }

        // SETTINGS
        public static SettingsClass LoadSettingsData()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                try
                {
                    var data = cnn.Query<SettingsClass>("SELECT * FROM Settings", new DynamicParameters());

                    return data.ToList()[0];
                }
                catch
                {
                    cnn.Execute("INSERT INTO Settings VALUES ('False','False',1)");

                    var data = cnn.Query<SettingsClass>("SELECT * FROM Settings", new DynamicParameters());
                    return data.ToList()[0];
                }
               
            }
        }

        public static void SaveSettingsData(SettingsClass set, string columnName = "ur mom",string value = "ur dad")
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                cnn.Execute(string.Format("UPDATE Settings SET {0} = {1} WHERE amog = 1", columnName, value), set);
            }
        }

        // WORLD CLOCK
        public static List<WorldClockClass> LoadWorldClockData()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                var data = cnn.Query<WorldClockClass>("SELECT * FROM WorldClockData ORDER BY ID DESC", new DynamicParameters());

                return data.ToList();
            }
        }

        public static void SaveWorldClockItem(WorldClockClass w)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            {
                // SET
                cnn.Execute(string.Format("INSERT INTO WorldClockData (Place) VALUES ('{0}')", w.Place));

                // GET DATA FIRST AND DELETE IF TOO MUCH DATA
                List<WorldClockClass> data = cnn.Query<WorldClockClass>("SELECT * FROM WorldClockData ORDER BY ID ASC", new DynamicParameters()).ToList();

                if (data.Count > 7)
                {
                    for (int i = 0; i < data.Count - 7; i++)
                    {
                        cnn.Execute("DELETE FROM WorldClockData WHERE ID = @ID", data[i]);
                    }
                }
            }
        }

    }
}
