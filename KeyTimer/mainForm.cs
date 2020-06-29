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
                    flPanel.Controls.Add(new Timer(timer.timerName, timer.secondDuration, timer.key));
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
            foreach(Timer control in flPanel.Controls)
            {
                timers.Add(new TimerData(control.timerName, control.interval, control.registeredKey));
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
            flPanel.Controls.Add(new Timer("PA 1", 150, Keys.F1));
            flPanel.Controls.Add(new Timer("PA 2", 150, Keys.F2));
            flPanel.Controls.Add(new Timer("Draught", 900, Keys.D7));
        }

        private void loadDefaultTimersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            loadDefaultTimers();
        }
    }
}
