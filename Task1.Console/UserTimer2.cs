using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task1.Console
{
    class UserTimer2
    {
        public UserTimer2(TimerEvent newEv)
        {
            newEv.StopTimer+= TimerStart2;
        }

        public void TimerStart2(Object sender, TimeMessageEventArgs e)
        {
            Thread.Sleep(1000);
            System.Console.WriteLine("Class 2 passes event-message:\n"+ e.Message);
        }
    }
}
