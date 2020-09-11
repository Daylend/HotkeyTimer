using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyTimer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TimerData> timers = LoadTimers();
            if (timers == null || timers.Count == 0)
            {
                loadDefaultTimers();
            }
            else
            {
                foreach(TimerData timer in timers)
                {
                    switch (timer.type)
                    {
                        case TimerData.TimerType.Timer:
                            flPanel.Controls.Add(new Timer(timer.timerName, timer.secondDuration, timer.key));
                            break;
                        case TimerData.TimerType.Stopwatch:
                            flPanel.Controls.Add(new Stopwatch(timer.timerName, timer.secondDuration, timer.key));
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer("New Timer", 60, Keys.F1);
            flPanel.Controls.Add(timer);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<TimerData> timers = new List<TimerData>();
            foreach (var control in flPanel.Controls)
            {
                if(control is Timer t)
                {
                    timers.Add(new TimerData(t.timerName, t.interval, t.registeredKey, TimerData.TimerType.Timer));
                }
                else if(control is Stopwatch s)
                {
                    timers.Add(new TimerData(s.timerName, s.interval, s.registeredKey, TimerData.TimerType.Stopwatch));
                }
            }
            SaveTimers(timers);
        }

        void SaveTimers(List<TimerData> timers)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, timers);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                Properties.Settings.Default.Timers = Convert.ToBase64String(buffer);
                Properties.Settings.Default.Save();
            }
        }

        List<TimerData> LoadTimers()
        {
            string timers = Properties.Settings.Default.Timers;
            if (timers != "")
            {
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.Timers)))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return (List<TimerData>)bf.Deserialize(ms);
                }
            }
            return null;
        }

        private void loadDefaultTimers()
        {
            flPanel.Controls.Add(new Stopwatch("Stopwatch", 0, Keys.F9));
            flPanel.Controls.Add(new Timer("PA 1", 150, Keys.F1));
            flPanel.Controls.Add(new Timer("PA 2", 150, Keys.F2));
            flPanel.Controls.Add(new Timer("Draught", 900, Keys.D7));
        }

        private void loadDefaultTimersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            loadDefaultTimers();
        }

        private void addTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer("New Timer", 60, Keys.F1);
            flPanel.Controls.Add(timer);
        }

        private void addStopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stopwatch s = new Stopwatch("Stopwatch", 0, Keys.F1);
            flPanel.Controls.Add(s);
        }
    }
}
