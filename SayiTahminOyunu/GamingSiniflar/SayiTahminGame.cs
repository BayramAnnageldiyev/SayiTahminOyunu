using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayiTahminOyunu.GlobalSiniflar;
using SayiTahminOyunu.NumerikSiniflar;
using SayiTahminOyunu.ProfilSiniflar;

namespace SayiTahminOyunu
{
    public sealed class SayiTahminGame
    {
        public SayiTahminGame()
        {
            eventArgs = new EventArgs();
        }

        private Task guessTimerTask;
       
        private string activeNumber;
        private EventArgs eventArgs;
        private UserProfile GamerProfile { get; set; }
        public event EventHandler<EnteredGuessEventArgs> EnteredGuess;
        /// <summary>
        /// Oyun bittiğinde tetiklenir.
        /// </summary>
        public event EventHandler<GameFinishedEventArgs> GameFinished;
        /// <summary>
        /// Oyun başladığında tetiklenir.
        /// </summary>
        public event EventHandler<GameStartedEventArgs> GameStarted;
        /// <summary>
        /// Süre düşütüğünde tetiklenir.
        /// </summary>
        public event EventHandler TimeDecreased;
        /// <summary>
        /// Yanlış bilme hakkı düştüğünde tetiklenir.
        /// </summary>
        public event EventHandler LifeDecreased;
        /// <summary>
        /// Geçerli tahmin edilen sayıyı dönderir.
        /// </summary>
        public int TotalGuessCount { get; private set; }
        public int DifficultLevel { get; private set; }
        /// <summary>
        /// Oyunun başlatıldığı tarih
        /// </summary>
        public DateTime GameStartedAt { get; private set; }
        /// <summary>
        /// Toplam + puan
        /// </summary>
        public int TotalPlus { get; private set; }
        /// <summary>
        /// Toplam - puan
        /// </summary>
        public int TotalMinus { get; private set; }
        /// <summary>
        /// Geçerli oyun başlama verileri
        /// </summary>
        public SayiTahminIcerik SayiTahminData { get; private set; }
        /// <summary>
        /// Mevcut oluşturulan sayı
        /// </summary>
        public string ActiveNumber { get { return activeNumber; } }
        /// <summary>
        /// Kalan süreyi dönderir.
        /// </summary>
        public int TimeLeft { get; private set; }
        /// <summary>
        /// Kalan hakkı dönderir
        /// </summary>
        public int LifeLeft { get; private set; }
        /// <summary>
        /// Oyunun başlayıp başalamadığını dönderir.
        /// </summary>
        public bool IsGameStarted { get; private set; }
       /// <summary>
       /// Yeni bir oyun başlatır
       /// </summary>
       /// <param name="stgamedata">Başlatılacak oyun içeriğini tutan data</param>
        public void StartGame(SayiTahminIcerik stgamedata, UserProfile gamerProfile)
        {
            if (IsGameStarted)
            {
                throw new Exception(String.GetLangText("STG_ERR_NEWGAME_EXC"));
            }
            if(stgamedata == null)
            {
                throw new Exception(String.GetLangText("STG_ERR_NULL_EXC"));
            }
            SayiTahminData = stgamedata;
            GamerProfile = gamerProfile;
            StartGame(false);
              
        }
        /// <summary>
        /// Yeni bir oyun başlatır.
        /// </summary>
        private void StartGame(bool isrestart)
        {
            activeNumber = Factory.GenerateNumber(SayiTahminData.MinBasamak, SayiTahminData.MaxBasamak, SayiTahminData.RakalmarFarkli);
            //activeNumber = "6183468701";
            DifficultLevel = SayiTahminChecker.GetDifficultLevel(this.SayiTahminData);
            TimeLeft = SayiTahminData.Sure;
            LifeLeft = SayiTahminData.YanlisTahminSayisi;
            if (TimeLeft > 0 && SayiTahminData.VectorelMode)
            {
                TimeLeft += 20;
            }
            if (LifeLeft > 0 && SayiTahminData.VectorelMode)
            {
                LifeLeft += 3;
            }
            IsGameStarted = true;
            guessTimerTask = new Task(GuessTimer);
            guessTimerTask.Start();
            OnGameStarted(isrestart);
            GameStartedAt = DateTime.Now;
            TotalPlus = 0;
            TotalMinus = 0;
            TotalGuessCount = 0;
        }
        /// <summary>
        /// Mevcut oyunu bitirir.
        /// </summary>
        private void FinishGame(bool isWin, GameFinishType finishType, bool isAborted = false)
        {
            if (!IsGameStarted) return;
            IsGameStarted = false;
            OnGameFinished(isWin, finishType, isAborted);
        }
        /// <summary>
        /// Oyuna tahmin girişi yapar.
        /// </summary>
        /// <param name="guess">Tahmin.</param>
        public void EnterGuess(string guess)
        {
            if (!IsGameStarted) return;
            NumberComparer compareresults = NumberComparer.Compare(this.activeNumber, guess);
            TotalMinus += compareresults.MinusScore;
            TotalPlus += compareresults.PlusScore;
            TotalGuessCount++;
            if (compareresults.Success)
            {
                OnEnteredGuess(guess, compareresults);
                FinishGame(true, GameFinishType.GameFinish_Win);
                return;
            }
            else
            {
                if(this.LifeLeft > 0)
                {
                    if(--this.LifeLeft <= 0)
                    {
                        OnLifeDecreased();
                        OnEnteredGuess(guess, compareresults);
                        FinishGame(false, GameFinishType.GameFinish_LOseLifeOver);
                        return;
                    }
                    else
                    {
                        OnLifeDecreased();
                    }
                }
            }
            OnEnteredGuess(guess, compareresults);

        }
        /// <summary>
        /// GEçerli oyundan pes eder.
        /// </summary>
        public void Resign()
        {
            Resign(false);
        }
        /// <summary>
        /// Geçerli oyundan pes eder, fakat olayları tetiklemez.
        /// </summary>
        public void Abort()
        {
            Resign(true);
        }
        /// <summary>
        /// Oyunu baştan başladır(Mevcut oyunu kaybedilmiş sayar)
        /// </summary>
        public void RestartGame()
        {
            StartGame(true);
        }
        /// <summary>
        /// Geçerli oyundan pes eder
        /// </summary>
        /// <param name="isAborted">true olarak ayarlanırsa oyunun iptal edildiği bilgisi gönderilirir.</param>
        private void Resign(bool isAborted)
        {
            if (!IsGameStarted) return;
            FinishGame(false, GameFinishType.GameFinish_LoseResign, isAborted);
        }
        /// <summary>
        /// GameStarted olayını tetikler.
        /// </summary>
        private void OnGameStarted(bool isrestart)
        {
            GameStarted?.Invoke(this, new GameStartedEventArgs(isrestart));
        }
        /// <summary>
        /// Oyunun bitiş olayını tetiklettirir.
        /// </summary>
        private void OnGameFinished(bool isWin, GameFinishType finishType, bool isAborted)
        {
            GameFinished?.Invoke(this, new GameFinishedEventArgs(isWin, finishType, isAborted));
        }
        /// <summary>
        /// TimeDecreased olayını tetikler.
        /// </summary>
        private void OnTimeDecreased()
        {
            TimeDecreased?.Invoke(this, eventArgs);
        }
        /// <summary>
        /// LifeDecreased olayını tetikler.
        /// </summary>
       private void OnLifeDecreased()
        {
            LifeDecreased?.Invoke(this, eventArgs);
        }
        private void OnEnteredGuess(string guess, NumberComparer compareresults)
        {
            EnteredGuess?.Invoke(this, new EnteredGuessEventArgs(guess, compareresults));
        }
        private void GuessTimer()
        {
            if (!this.IsGameStarted) return;
            if (this.TimeLeft <= 0) return;
            while (true)
            {
                Task.Delay(1000).Wait();
                if (!this.IsGameStarted) return;
                if(this.TimeLeft > 0)
                {
                    
                    if(--this.TimeLeft <= 0)
                    {
                        OnTimeDecreased();
                        FinishGame(false, GameFinishType.GameFinish_LoseTimeOver);
                        return;
                    }
                    else
                    {
                        OnTimeDecreased();
                    }
                }
            }
        }

    }
}
