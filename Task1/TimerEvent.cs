using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task1
{
    public delegate void NewEventHandler (object sender, TimeMessageEventArgs e);

    public class TimerEvent
    {
        public event NewEventHandler StopTimer;// (object sender, TimeMessageEventArgs args);

        protected virtual void OnStopTimer(Object sender, TimeMessageEventArgs args)
        {
            if (StopTimer != null)
                StopTimer(sender, args);
        }

        public void SimulateEvent(int time)
        {
            for (int i = 0; i < time; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("{0} seconds left", time - i);
            }
            OnStopTimer(this, new TimeMessageEventArgs());
        }
    }
}
