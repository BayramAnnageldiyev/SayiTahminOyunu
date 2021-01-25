using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.NumerikSiniflar
{
    public class NumberCompareResult 
    {
        public NumberCompareResult(char curchar, int curindex, NumberCompareResultEnum compareresults, int equalindex)
        {
            CharValue = curchar;
            NumValue = int.Parse(curchar.ToString());
            Index = curindex;
            CompareResults = compareresults;
            EqualIndex = equalindex;

        }
        /// <summary>
        /// Karakterin integer cinsinden değeri
        /// </summary>
        public int NumValue { get; private set; }
        /// <summary>
        /// Karakterin  char cinsinden değeri
        /// </summary>
        public char CharValue { get; private set; }
        /// <summary>
        /// Eşleştirme sonucu
        /// </summary>
        public NumberCompareResultEnum CompareResults { get; private set; }
        /// <summary>
        /// Karşılaştırılan metinde eşleştiği index
        /// </summary>
        public int EqualIndex { get; private set; }
        /// <summary>
        /// Mevcut dizideki index
        /// </summary>
        public int Index { get; private set; }


        public override string ToString()
        {
            return "Results of " + CharValue.ToString();
        }
    }
}
