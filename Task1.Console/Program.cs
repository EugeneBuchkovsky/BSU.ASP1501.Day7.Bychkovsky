using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Task1;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var timerE = new TimerEvent();
            var timer = new UserTimer(timerE);
            var timer2 = new UserTimer2(timerE);

            timerE.SimulateEvent(5);

            System.Console.ReadLine();
        }
    }
}
