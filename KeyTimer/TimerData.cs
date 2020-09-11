using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyTimer
{
    [Serializable()]
    public class TimerData
    {
        public string timerName;
        public int secondDuration;
        public Keys key;
        public TimerType type;
        public enum TimerType
        {
            Timer,
            Stopwatch
        }

        public TimerData(string timerName, int secondDuration, Keys key, TimerType type)
        {
            this.timerName = timerName;
            this.secondDuration = secondDuration;
            this.key = key;
            this.type = type;
        }
    }
}
