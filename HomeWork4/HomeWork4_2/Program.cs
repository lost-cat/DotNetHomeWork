using System;

namespace HomeWork4_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            alarm.Tick += ShowTime;
            alarm.Clock += Clock;
            alarm.Start(new Alarm.TimeArgs(4,44,0));
        }

        private static void ShowTime(object sender, Alarm.TimeArgs eventArgs)
        {
            Console.WriteLine("过了一秒了，现在的时间是" +
                              $"{eventArgs.Hours}点{eventArgs.Minutes}分{eventArgs.Seconds}秒");
        }

        private static void Clock(object sender, Alarm.TimeArgs eventArgs)
        {
            Console.WriteLine("您设定闹钟已到点");
        }
    }
}