using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.GlobalSiniflar
{
    public static class ReflectFunctions
    {
        /// <summary>
        /// Bir sınıfın elemanına doğrudan isimle yazdırmak için kullanacağımız fonksiyon.
        /// </summary>
        /// <param name="targetclass">Hedef sınıf</param>
        /// <param name="targetname">Değer yazılacak property adı</param>
        /// <param name="targetvalue">Property ye atanacak değer</param>
        public static void SetPropertyValueDirect(object targetclass, string targetname, object targetvalue, string YesText)
        {
            Type type = targetclass.GetType();
            PropertyInfo pInfo = type.GetProperty(targetname);
            if (pInfo == null) return;
            Type mtype = pInfo.PropertyType;
            TypeConverter tconvert = TypeDescriptor.GetConverter(mtype);
            string itemtext = targetvalue?.ToString();
            if (mtype == typeof(bool))
            {
                itemtext = (itemtext == YesText).ToString();
            }
            object obj = tconvert.ConvertFromString(itemtext);
            pInfo.SetValue(targetclass, obj);
        }
    }
}
