using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyTimer
{
    public partial class Stopwatch : UserControl
    {
        bool waitingForKey = false;
        public Keys registeredKey = Keys.MediaPlayPause;
        public int interval;
        public string timerName;
        int time;

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public Stopwatch(string timerName, int secondDuration, Keys key)
        {
            InitializeComponent();
            interval = secondDuration;
            time = interval;
            registeredKey = key;
            this.timerName = timerName;
            btnHotkey.Text = registeredKey.ToString();
            labelName.Text = timerName;
            labelTime.Text = TimeSpan.FromSeconds(time).ToString(@"hh\:mm\:ss");
            timerTimer.Stop();
            Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //Dock = DockStyle.Fill;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void btnHotkey_Click(object sender, EventArgs e)
        {
            waitingForKey = true;
            btnHotkey.Text = "...";
            timerKeyListener.Start();
        }

        private void timerTimer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = TimeSpan.FromSeconds(time).ToString(@"hh\:mm\:ss");

            if(time++ > 99999999)
            {
                timerTimer.Stop();
            }
        }

        private void timerKeyListener_Tick(object sender, EventArgs e)
        {
            if (!waitingForKey)
            {
                if (registeredKey != Keys.MediaPlayPause)
                {
                    if (keyPressed(registeredKey))
                    {
                        restartTimer();
                    }
                }
            }
            else
            {
                foreach(Keys key in (Keys[])Enum.GetValues(typeof(Keys)))
                {
                    bool isPressed = keyPressed(key);
                    if (isPressed && key != Keys.Escape && key != Keys.MediaPlayPause && key != Keys.LButton)
                    {
                        registeredKey = key;
                        btnHotkey.Text = key.ToString();
                        waitingForKey = false;
                        btnHotkey.Text = registeredKey.ToString();
                        break;
                    }
                }
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            string newName = Prompt.ShowDialog("New Name", "Enter a new name");
            if (newName != "")
            {
                timerName = newName;
                labelName.Text = timerName;
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            int newTime = int.Parse(Prompt.ShowDialog("New Time in Seconds", "Enter a new time in seconds"));
            if (newTime > 0)
            {
                interval = newTime;
                time = interval;
                labelTime.Text = TimeSpan.FromSeconds(time).ToString(@"hh\:mm\:ss");
            }
        }

        private void restartTimer()
        {
            time = interval;
            timerTimer.Stop();
            timerTimer.Start();
            //colorBox.BackColor = Color.Firebrick;
        }

        private bool keyPressed(Keys key)
        {
            return 0 != (GetAsyncKeyState((int)key) & 0x8000);
        }
    }
}
