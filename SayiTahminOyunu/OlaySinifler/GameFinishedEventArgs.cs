using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public enum GameFinishType
    {
        GameFinish_Win,
        GameFinish_LoseResign,
        GameFinish_LoseTimeOver,
        GameFinish_LOseLifeOver
    }
    public class GameFinishedEventArgs : EventArgs
    {

        public GameFinishedEventArgs(bool isWin, GameFinishType finishType, bool isAborted)
        {
            this.IsWin = isWin;
            this.FinishType = finishType;
            this.IsAborted = isAborted;
        }
        public bool IsAborted { get; private set; }
        public bool IsWin { get; private set; }
        public GameFinishType FinishType { get; private set; }
      
    }
}
