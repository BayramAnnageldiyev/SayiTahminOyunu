using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public class GameStartedEventArgs : EventArgs
    {
        public GameStartedEventArgs(bool isrestart)
        {
            IsRestart = isrestart;
        }
        public bool IsRestart { get; private set; }
    }
}
