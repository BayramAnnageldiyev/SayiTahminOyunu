using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public static class String
    {
        public static string GetLangText(string name, params object[] format)
        {
            return GlobalVariants.PhraseList[name]?.GetText(format);
        }
        public static string GetLangTextOrDefault(string name, string defaultvalue, params object[] format)
        {
            PhraseSiniflar.Phrase phs = GlobalVariants.PhraseList[name];
            if (phs == null)
            {
                phs = GlobalVariants.PhraseList[defaultvalue];
               
            }
            if(phs == null)
            {
                return defaultvalue;
            }
            else
            {
                return phs.GetText(format);
            }
        }
    }
}
