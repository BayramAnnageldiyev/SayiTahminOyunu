using SayiTahminOyunu.ProfilSiniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayiTahminOyunu.PhraseSiniflar;

namespace SayiTahminOyunu
{
    public static class GlobalVariants
    {
        public const string GameVersion = "1.0";
        private static List<string> existingProfiles = new List<string>();
        private static Phrases phraseList = new Phrases();
        /// <summary>
        /// Mevcut bulunan profiller.
        /// </summary>
        public static List<string> ExistingProfiles { get { return existingProfiles; } }
        /// <summary>
        /// Geçerli kullanıcı profili.
        /// </summary>
        public static UserProfile ActiveProfile { get; set; }
        /// <summary>
        /// Uygulamadaki yüklü cümleler listesini tutar.
        /// </summary>
        public static Phrases PhraseList { get { return phraseList; } }

    }
}
