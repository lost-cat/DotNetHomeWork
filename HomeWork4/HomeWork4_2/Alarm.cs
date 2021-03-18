using System;

namespace HomeWork4_2
{
    public delegate void TickHandler(object sender, Alarm.TimeArgs tickArgs);

    public delegate void AlarmHandler(object sender, Alarm.TimeArgs eventArgs);


    public class Alarm
    {
        public event TickHandler Tick;
        public event AlarmHandler Clock;


        private void OnTick(TimeArgs tickArgs)
        {
            Tick?.Invoke(this, tickArgs);
        }

        private void OnClock(TimeArgs eventArgs)
        {
            Clock?.Invoke(this, eventArgs);
        }

        //每个一秒触发一次Tick事件
        //每个一分钟触发一次Clock事件
        public void Start(TimeArgs timeArgs)
        {
            //获取当前时间
            DateTime now = DateTime.Now;
            var eventArgs = new TimeArgs(now.Hour, now.Minute, now.Second);

            while (!eventArgs.Equals(timeArgs))
            {
                eventArgs.Seconds++;
                OnTick(eventArgs);
                System.Threading.Thread.Sleep(1000);
            }
            OnClock(eventArgs);
        }

        public class TimeArgs : EventArgs
        {
            private int _hours;


            private int _minutes;
            private int _seconds;

            public TimeArgs(int hour, int minute, int second)
            {
                _hours = hour;
                _minutes = minute;
                _seconds = second;
            }

            public TimeArgs()
            {
            }

            public int Hours
            {
                get => _hours;
                set
                {
                    _hours = value;
                    if (_hours == 24)
                    {
                        _hours = 0;
                    }
                }
            }


            public int Minutes
            {
                get => _minutes;
                set
                {
                    _minutes = value;
                    if (_minutes != 60) return;
                    _minutes = 0;
                    Hours++;
                }
            }


            public int Seconds
            {
                get => _seconds;
                set
                {
                    _seconds = value;
                    if (_seconds != 60) return;
                    _seconds = 0;
                    Minutes++;
                }
            }

            public override bool Equals(object obj)
            {
                TimeArgs timeArgs = obj as TimeArgs;
                if (timeArgs == null)
                {
                    return false;
                }

                return Hours == timeArgs.Hours &&
                       Minutes == timeArgs.Minutes &&
                       Seconds == timeArgs.Seconds;
            }
            
            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = Hours;
                    hashCode = (hashCode * 397) ^ Minutes;
                    hashCode = (hashCode * 397) ^ Seconds;
                    return hashCode;
                }
            }
        }
    }
}