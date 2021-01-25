using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayiTahminOyunu.NumerikSiniflar;

namespace SayiTahminOyunu
{
    public class EnteredGuessEventArgs : EventArgs
    {
        public EnteredGuessEventArgs(string guess, NumberComparer guessResults)
        {
            Guess = guess;
            GuessResults = guessResults;
        }
        public string Guess { get; private set; }
        public NumberComparer GuessResults { get; private set; }
    }
}
