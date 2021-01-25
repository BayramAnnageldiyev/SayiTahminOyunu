using SayiTahminOyunu.GlobalSiniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.NumerikSiniflar
{

    public class NumberComparer
    {
        //Sadece kendi içerisinde kurulabilir.
        private NumberComparer(string sourcetext, string targettext)
        {
            mSourceText = sourcetext;
            mTargetText = targettext;
        }

        private string mSourceText;
        private string mTargetText;
        private int mMinusScore;
        private int mPlusScore;
        private NumberCompareResults mSourceTextResults;
        private NumberCompareResults mTargetTextResults;
        public string SourceText
        {
            get
            {
                return mSourceText;
            }
        }
        /// <summary>
        /// Kaynak metin sonuç dizisi
        /// </summary>
        public NumberCompareResults SourceTextResults
        {
            get
            {
                return mSourceTextResults;
            }
        }
        public string TargetText
        {
            get
            {
                return mTargetText;
            }
        }
        /// <summary>
        /// Hedef metin sonuç dizisi
        /// </summary>
        public NumberCompareResults TargetTextResults
        {
            get
            {
                return mTargetTextResults;
            }
        }
        /// <summary>
        /// Artı skor(aynı basamkta eşit olan sayı sayısı)
        /// </summary>
        public int MinusScore
        {
            get
            {
                return mMinusScore;
            }
        }
        /// <summary>
        /// Eksi skor(farklı basamakta eşit olan sayı sayısı)
        /// </summary>
        public int PlusScore
        {
            get
            {
                return mPlusScore;
            }
        }
        /// <summary>
        /// Her iki metin tamamen eşleşiyorsa true diğer türlü false döner
        /// </summary>
        public bool Success
        {
            get
            {
                return PlusScore == TargetText.Length;
            }
        }
        public override string ToString()
        {
            return string.Format("Artı(+): {0} Eksi(-): {1}", PlusScore, MinusScore);
        }

        /// <summary>
        /// Girilen 2 sayıyı karşılaştırır.
        /// </summary>
        /// <param name="sourcetext">Kaynak sayı</param>
        /// <param name="targettext">Hedef(Karşılaştırma yapılacak) sayı</param>
        /// <returns>Bir hata yoksa NumberComparer sınıfı türünde dönüş yapar.</returns>
        public static NumberComparer Compare(string sourcetext, string targettext)
        {
            //Girilen değerlerdeki sıfırları ve boşlukları kırpıyoruz.
            sourcetext = sourcetext.Trim();
            sourcetext = sourcetext.TrimStart('0');
            targettext = targettext.Trim();
            targettext = targettext.TrimStart('0');
            //source veya target boş girilmişse hata verdirir.
            if (string.IsNullOrEmpty(sourcetext) || string.IsNullOrEmpty(targettext))
            {
                throw new Exception("NumberComparer, kaynak veya hedef alan boş girilemez.");
            }
            //source veya target numerik girilmemişse hata verdirir.
            if (!sourcetext.AllCharsIsDigits() || !targettext.AllCharsIsDigits())
            {
                throw new Exception("NumberComparer, kaynak ve metin içeriği bir sayı olmalıdır.");
            }
            //source veya target uzunlukları eşit değilse hata verdirir.
            if (sourcetext.Length != targettext.Length)
            {
                throw new Exception("NumberComparer, kaynak ve metin karakter boyutu birbirine eşit olmalıdır.");
            }
            //NumberComparer sınıfımızı kuruyoruz.
            NumberComparer numberComparer = new NumberComparer(sourcetext, targettext);
            List<char> sourcechars = sourcetext.ToList();
            List<char> targetchars = targettext.ToList();
            NumberCompareResults sourceResults = new NumberCompareResults(sourcechars.Count, sourcetext);
            NumberCompareResults targetResults = new NumberCompareResults(targetchars.Count, targettext);
            for (int i = 0; i < sourcechars.Count; i++)
            {
                //Geçerli karakterimizi source listemizden alıyorz.
                char curchar = sourcechars[i];
                //Eğer geçerli karakter daha önceki taramada eşleştirildiyse sonraki indexten devam edecek.
                if (curchar == '\0') continue;
                //Eğer geçerli source karakteriyle target karakteri birbirine eşit ise PlusScore değerini bir artırıp değerlerinin içini boşaltıyoruz.
                if(curchar == targetchars[i])
                {
                    numberComparer.mPlusScore++;
                    sourcechars[i] = '\0';
                    targetchars[i] = '\0';
                    //Her karakterin sonucu ayrı bir dizide tutulur.
                    //Eşit ve indexleri aynı ise bu değeri atar.
                    sourceResults.Add(new NumberCompareResult(curchar, i, NumberCompareResultEnum.Equals, i));
                    targetResults.Add(new NumberCompareResult(curchar, i, NumberCompareResultEnum.Equals, i));
                    continue;
                }
                //Source ve Targette indexleri aynı olan karakterler eşleşmiyorsa eğer diğer indexlerde olup olmadığını kontrol ettiriyoruz.
                int chrindex = targetchars.IndexOf(curchar);
                //Eğer aranan karakter diğer indexlerde yok veya bulunan target indexindeki karakter ile aynı indexteki source karakteri
                // eşleşiyorsa sonraki indexten devam et.
                if(chrindex < 0 || sourcechars[chrindex] == targetchars[chrindex])
                {
                    sourceResults.Add(new NumberCompareResult(curchar, i, NumberCompareResultEnum.NotEquals, -1));
                    //Hedef karakter önceden listeye eklenmediyse ekler.
                    if(chrindex >= 0 && targetchars[chrindex] != '\0')
                    {
                        targetResults.Add(new NumberCompareResult(targetchars[chrindex], chrindex, NumberCompareResultEnum.NotEquals, -1));
                        targetchars[chrindex] = '\0';
                    }
                   
                    continue;
                }
                //Farklı indexlerde eşleşiyorsa MinusScore değerini bir artırır geçerli ve hedef indexin içlerini boşaltıyoruz.
                numberComparer.mMinusScore++;
                sourcechars[i] = '\0';
                targetchars[chrindex] = '\0';
                //Her karakterin sonucunuda ayrı bir dizide tutuyoruz.
                //Eşit ancak indexleri farklı ise bu değeri atar.

                sourceResults.Add(new NumberCompareResult(curchar, i, NumberCompareResultEnum.EqualsOnDiffer, chrindex));
                targetResults.Add(new NumberCompareResult(curchar, chrindex, NumberCompareResultEnum.EqualsOnDiffer, i));

            }
            //Karakter dizi olarak tüm sonuçlarıda yerlerine atıyoruz.
            if(targetResults.Count != targettext.Length)
            {
                for (int i = 0; i < targettext.Length; i++)
                {
                    if (targetResults.IndexContains(i)) continue;
                    targetResults.Add(new NumberCompareResult(targettext[i], i, NumberCompareResultEnum.NotEquals, -1));
                }
            }
            numberComparer.mSourceTextResults = sourceResults;
            numberComparer.mTargetTextResults = targetResults;
            return numberComparer;
        }

    }
}
