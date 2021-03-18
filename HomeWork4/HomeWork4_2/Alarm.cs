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
        public void Start()
        {
            var eventArgs = new TimeArgs {Seconds = 0, Hours = 0, Minutes = 0};
            while (eventArgs.Seconds <= 300)
            {
                eventArgs.Seconds++;
                OnTick(eventArgs);
                if (eventArgs.Seconds == 0)
                {
                    OnClock(eventArgs);
                }

                System.Threading.Thread.Sleep(1000);
            }
        }
        
    public class TimeArgs : EventArgs
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

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
    }

   
    }
}