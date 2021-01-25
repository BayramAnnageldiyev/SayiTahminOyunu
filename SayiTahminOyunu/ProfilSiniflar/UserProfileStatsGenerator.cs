using SayiTahminOyunu.NumerikSiniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.ProfilSiniflar
{
    public sealed class UserProfileStatsGenerator
    {
        public UserProfile GamerProfile { get; private set; }
        public SayiTahminGame ActiveGame { get; private set; }

        private bool EventsBinded { get; set; }
        private void RemoveEvent()
        {
            if (!EventsBinded) return;
            ActiveGame.EnteredGuess -= ActiveGame_EnteredGuess;
            ActiveGame.GameStarted -= ActiveGame_GameStarted;
            ActiveGame.LifeDecreased -= ActiveGame_LifeDecreased;
            ActiveGame.TimeDecreased -= ActiveGame_TimeDecreased;
            ActiveGame.GameFinished -= ActiveGame_GameFinished;
        }
        private void BindEvents()
        {
  
            ActiveGame.EnteredGuess += ActiveGame_EnteredGuess;
            ActiveGame.GameStarted += ActiveGame_GameStarted;
            ActiveGame.LifeDecreased += ActiveGame_LifeDecreased;
            ActiveGame.TimeDecreased += ActiveGame_TimeDecreased;
            ActiveGame.GameFinished += ActiveGame_GameFinished;
            EventsBinded = true;
        }
        public void SetProfileAndGame(UserProfile activeProfile, SayiTahminGame sayiTahminGame)
        {
            RemoveEvent();
            GamerProfile = activeProfile;
            ActiveGame = sayiTahminGame;
            BindEvents();
        }
        private void ActiveGame_GameStarted(object sender, GameStartedEventArgs e)
        {
            string sznumformat = "digitstats.digit{0}{1}";
            for (int i = 0; i < ActiveGame.ActiveNumber.Length; i++)
            {
                GamerProfile.Statistics[string.Format(sznumformat, ActiveGame.ActiveNumber[i], ".digitasked"), true].ValueInt++;
            }
            GamerProfile.Statistics["last.guess", true].Value = "";
            if (!GamerProfile.FirstPlayed)
            {
                GamerProfile.Statistics.SetStatByName("first.playedtime", DateTime.Now);
                GamerProfile.Statistics.SetStatByName("first.askedguess", ActiveGame.ActiveNumber);
                GamerProfile.Statistics["first.difficult", true].ValueInt = ActiveGame.DifficultLevel;
            }
            GamerProfile.Statistics.SetStatByName("last.playedtime", DateTime.Now);
            GamerProfile.Statistics.SetStatByName("last.askedguess", ActiveGame.ActiveNumber);
            GamerProfile.Statistics["total.totalplayed", true].ValueInt++;
            GamerProfile.Statistics["total.totalplayed.level" + ActiveGame.DifficultLevel, true].ValueInt++;
            GamerProfile.Statistics["last.difficult", true].ValueInt = ActiveGame.DifficultLevel;
        }

        private void ActiveGame_GameFinished(object sender, GameFinishedEventArgs e)
        {
            if (e.IsWin)
            {
                GamerProfile.Statistics["total.totalwin", true].ValueInt++;
                GamerProfile.Statistics["total.totalplayed.level" + ActiveGame.DifficultLevel + ".win", true].ValueInt++;
            }
            else
            {
                GamerProfile.Statistics["total.totallose", true].ValueInt++;
                GamerProfile.Statistics["total.totalplayed.level" + ActiveGame.DifficultLevel + ".lose", true].ValueInt++;
                switch (e.FinishType)
                {
                    case GameFinishType.GameFinish_LoseResign:
                        GamerProfile.Statistics["total.totallose.resign", true].ValueInt++;
                        break;
                    case GameFinishType.GameFinish_LoseTimeOver:
                        GamerProfile.Statistics["total.totallose.losetime", true].ValueInt++;
                        break;
                    case GameFinishType.GameFinish_LOseLifeOver:
                        GamerProfile.Statistics["total.totallose.lifeleft", true].ValueInt++;
                        break;
                }
            }
            double tplayedsec = (DateTime.Now - ActiveGame.GameStartedAt).TotalSeconds;
            if (!GamerProfile.FirstPlayed)
            {
                GamerProfile.Statistics["first.guesscount", true].Value = ActiveGame.TotalGuessCount;
                GamerProfile.Statistics["first.pluscount", true].Value = ActiveGame.TotalPlus;
                GamerProfile.Statistics["first.minuscount", true].Value = ActiveGame.TotalMinus;
                GamerProfile.Statistics["first.playedsec", true].ValueDouble = tplayedsec;
                GamerProfile.FirstPlayed = true;
            }
            GamerProfile.Statistics["last.guesscount", true].Value = ActiveGame.TotalGuessCount;
            GamerProfile.Statistics["last.pluscount", true].Value = ActiveGame.TotalPlus;
            GamerProfile.Statistics["last.minuscount", true].Value = ActiveGame.TotalMinus;
            GamerProfile.Statistics["last.playedsec", true].ValueDouble = tplayedsec;
            GamerProfile.Statistics["playedtime.totalplayedsec", true].ValueDouble += tplayedsec;
            if (tplayedsec > GamerProfile.Statistics["playedtime.longplayedsec", true].ValueDouble)
            {
                GamerProfile.Statistics["playedtime.longplayedsec", true].ValueDouble = tplayedsec;
                GamerProfile.Statistics["playedtime.longplayedtime", true].Value = DateTime.Now;
            }
            if (GamerProfile.Statistics["playedtime.shortplayedsec", true].ValueDouble <= 0)
            {
                GamerProfile.Statistics["playedtime.shortplayedsec", true].ValueDouble = tplayedsec;
                GamerProfile.Statistics["playedtime.shortplayedtime", true].Value = DateTime.Now;
            }
            else
            {
                if (tplayedsec < GamerProfile.Statistics["playedtime.shortplayedsec", true].ValueDouble)
                {
                    GamerProfile.Statistics["playedtime.shortplayedsec", true].ValueDouble = tplayedsec;
                    GamerProfile.Statistics["playedtime.shortplayedtime", true].Value = DateTime.Now;
                }
            }
        }
        private void ActiveGame_EnteredGuess(object sender, EnteredGuessEventArgs e)
        {
            string sznumformat = "digitstats.digit{0}{1}";
            //profile.Statistics.InitializeStatistic(string.Format(sznumformat, i, ".digitguesscount.digitguessfail"));
            foreach (var ncritem in e.GuessResults.SourceTextResults)
            {
                switch (ncritem.CompareResults)
                {
                    case NumberCompareResultEnum.Equals:
                        GamerProfile.Statistics[string.Format(sznumformat, ncritem.NumValue, ".digitguesscount.digitguesssuccess"), true].ValueInt++;
                        break;
                    case NumberCompareResultEnum.EqualsOnDiffer:
                        GamerProfile.Statistics[string.Format(sznumformat, ncritem.NumValue, ".digitguesscount.digitguessdiffer"), true].ValueInt++;
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < e.Guess.Length; i++)
            {
                int inum = int.Parse(e.Guess[i].ToString());
                GamerProfile.Statistics[string.Format(sznumformat, inum, ".digitguesscount"), true].ValueInt++;
                if (e.GuessResults.TargetTextResults.SingleOrDefault((c) => (c.Index == i)) == null)
                {
                    GamerProfile.Statistics[string.Format(sznumformat, inum, ".digitguesscount.digitguessfail"), true].ValueInt++;
                }
            }
            GamerProfile.Statistics["total.totalguess", true].ValueInt++;
            GamerProfile.Statistics["total.totalplus", true].ValueInt += e.GuessResults.PlusScore;
            GamerProfile.Statistics["total.totalminus", true].ValueInt += e.GuessResults.MinusScore;
            if (!GamerProfile.FirstPlayed)
            {
                if (string.IsNullOrEmpty(GamerProfile.Statistics["first.guess", true].ValueString))
                {
                    GamerProfile.Statistics["first.guess", true].Value = e.Guess;
                }
            }
            GamerProfile.Statistics["last.guess", true].Value = e.Guess;
        }
        private void ActiveGame_TimeDecreased(object sender, EventArgs e)
        {
            
        }

        private void ActiveGame_LifeDecreased(object sender, EventArgs e)
        {
          
        }

  
      


    }
}
