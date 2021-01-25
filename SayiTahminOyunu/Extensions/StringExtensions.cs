using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public static class StringExtensions
    {
        /// <summary>
        /// Verilen metindeki tüm harflerin numerik olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="txtnumber">Tarama yapılacak metin</param>
        /// <returns>Tüm harfler numerikse true, diğer türlü false döner</returns>
        public static bool AllCharsIsDigits(this string txtnumber)
        {
            if (string.IsNullOrEmpty(txtnumber)) return false;
            foreach (var singlechar in txtnumber)
            {
                if (!char.IsDigit(singlechar))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verilen metnin numara olup olmadığını dönüş yapar.
        /// </summary>
        /// <param name="variant"></param>
        /// <returns>Numerikse true diğer türlü false dönüş yapar.</returns>
        public static bool IsNumeric(this string variant)
        {
            double outnumber;
            return double.TryParse(variant, out outnumber);
        }
        /// <summary>
        /// Girilen metnin tarih biçimde olup olmadığını kontrol eeder.
        /// </summary>
        /// <param name="variant"></param>
        /// <returns>Tarih biçimindeyse true diğer türlü false dönüş yapar.</returns>
        public static bool IsDateTime(this string variant)
        {
            DateTime outnumber;
            return DateTime.TryParse(variant, out outnumber);
        }
        /// <summary>
        /// Geçerli metnin format biçimnde olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="variant"></param>
        /// <returns></returns>
        public static bool IsFormattedText(this string variant)
        {
            int itotaladdd = 0;
            foreach (var chr in variant)
            {
                if(chr == '{')
                {
                    itotaladdd++;
                }
                else
                {
                    if ((itotaladdd % 2) == 1) return true;
                }
            }
            return  (itotaladdd % 2 == 1);
        }
    }

}
