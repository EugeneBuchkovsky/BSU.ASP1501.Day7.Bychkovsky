using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TimeMessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public TimeMessageEventArgs()
        {
            this.Message = "Time is up!";
        }
    }
}
