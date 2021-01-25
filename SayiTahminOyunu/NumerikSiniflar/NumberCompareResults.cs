using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.NumerikSiniflar
{
    /// <summary>
    /// NumericCompare dizisinin tutulacağı sınıftır.
    /// </summary>
    public class NumberCompareResults : IEnumerable<NumberCompareResult>
    {
        private int maxchars = 0;
        private string baseString;

        List<NumberCompareResult> mNumbers;
        public NumberCompareResults(int maxchar, string basestring)
        {
            mNumbers = new List<NumberCompareResult>();
            maxchars = maxchar;
            baseString = basestring;
        }
        public int Count
        {
            get
            {
                return mNumbers.Count;
            }
        }
        public NumberCompareResult this[int index]
        {
            get
            {
                return mNumbers[index];
            }
        }
        public void Add(NumberCompareResult compareResults)
        {
            //Sonradan eklemeleri önlemek amacıyla aşağıdaki değişkeni atadık.
            if (mNumbers.Count >= maxchars)
            {
                return;
            }
            mNumbers.Add(compareResults);
            if(mNumbers.Count >= maxchars)
            {
                mNumbers.Sort(
                    (NumberCompareResult a, NumberCompareResult b) =>
                    {
                        if(a.Index > b.Index)
                        {
                            return 1;
                        }
                        else if(a.Index < b.Index)
                        {
                            return -1;
                        }
                        return 0;
                    }
                );
            }
        }
        public override string ToString()
        {
            return "Compare results of  " + baseString;
        }
        // For each kullanımının yapılabilmesi için gerekli fonksiyonlar.
        public IEnumerator<NumberCompareResult> GetEnumerator()
        {
            for (int i = 0; i < mNumbers.Count; i++)
            {
                yield return mNumbers[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < mNumbers.Count; i++)
            {
                yield return mNumbers[i];
            }
        }
        public bool IndexContains(int index)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Index == index) return true;
            }
            return false;
        }
    }
}
