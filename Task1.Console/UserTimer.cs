using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Task1.Console
{
    class UserTimer
    {
        public UserTimer(TimerEvent newEv)
        {
            newEv.StopTimer+= TimerStart1;
        }

        public void TimerStart1(Object sender, TimeMessageEventArgs e)
        {
            System.Console.WriteLine("Class 1 passes event-message:\n"+ e.Message);
        }
    }
}
