using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.GlobalSiniflar
{
    public sealed class Factory
    {
        /// <summary>
        /// Birbirinden farklı 4 basamaklı sayı üretir.
        /// </summary>
        /// <returns></returns>
        public static string GenerateNumber()
        {
            return GenerateNumber(4, 4, true);
        }
        /// <summary>
        /// Girilen basamak kadar birbirinden farklı sayı üretir.
        /// </summary>
        /// <param name="digits">Basamak sayısı</param>
        /// <returns></returns>
        public static string GenerateNumber(int digits)
        {
            return GenerateNumber(digits, digits, true);
        }
        /// <summary>
        /// Girilen basamak aralığında birbirinden farklı sayı üretir
        /// </summary>
        /// <param name="mindigits">Minimum basamak sayısı</param>
        /// <param name="maxdigits">Maxium basamak sayısı</param>
        /// <returns></returns>
        public static string GenerateNumber(int mindigits, int maxdigits)
        {
            return GenerateNumber(mindigits, maxdigits, true);
        }
        /// <summary>
        /// Rasgele sayı üretme fonksiyonu.
        /// </summary>
        /// <param name="mindigits">Minimum basamak sayısı</param>
        /// <param name="maxdigits">Maxium basamak sayısı</param>
        /// <param name="diffnumbers">Sayılar birbirinden farklı olup olmayacağını ayarlar</param>
        /// <returns>Girilen parametlere göre rasgele sayı dönderir.</returns>
        public static string GenerateNumber(int mindigits, int maxdigits, bool diffnumbers)
        {
            //Maximum basamak sayısı 1 den küçükse 1 yap.
            if (maxdigits < 1) maxdigits = 1;
            //Minimum basamak sayısı 1 den küçükse 1 yap.
            if (mindigits < 1) mindigits = 1;
            //Maxiumum basamak sayısı 1 den küçükse 1 yap.
            if (maxdigits > 10) maxdigits = 10;
            //Mininmum basamak sayısı maximum basamak sayısında büyükse eşit yap.
            if (mindigits > maxdigits) mindigits = maxdigits;
            //Random sayı tutacak sınıfımızı kuruyoruz.
            Random rnd = new Random();
            //Minimum basamak ve maximum basamak sayısı arasında random bir sayı tutturuyoruz.
            int digits = rnd.Next(mindigits, maxdigits);
            //Üretilecek sayıları bir listede tutuyoruz.
            //diffnumbers parametresi true olarak işaretlendiyse atanan sayı listeden silinecek.
            List<int> digitlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string createddigits = "";
            while (createddigits.Length < digits)
            {
                int numindex = 0;
                //Birinci basamak 0 olamayacağı için bu denetimi yaptık.
                if (createddigits.Length == 0)
                {
                    numindex = rnd.Next(1, digitlist.Count - 1);
                }
                else
                {
                    numindex = rnd.Next(0, digitlist.Count - 1);
                }
                createddigits += digitlist[numindex];
                //Eğer rakamlar birbirinden ayrı olacaksa tutulan sayı listeden silinir.
                if (diffnumbers)
                {
                    digitlist.RemoveAt(numindex);
                }
            }
            //Oluşturulan metni sayıya çevirip dönüş yaptırıyoruz.
            return createddigits;
        }
    }
}
