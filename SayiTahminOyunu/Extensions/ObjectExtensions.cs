using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Verilen metnin numara olup olmadığını dönüş yapar.
        /// </summary>
        /// <param name="variant"></param>
        /// <returns>Numerikse true diğer türlü false dönüş yapar.</returns>
        public static bool IsNumeric(this object variant)
        {
            if (variant == null) return false;
            return variant.ToString().IsNumeric();
        }
        /// <summary>
        /// Girilen metnin tarih biçimde olup olmadığını kontrol eeder.
        /// </summary>
        /// <param name="variant"></param>
        /// <returns>Tarih biçimindeyse true diğer türlü false dönüş yapar.</returns>
        public static bool IsDateTime(this object variant)
        {
            if (variant == null) return false;
            return variant.ToString().IsDateTime();
        }
    }
}
