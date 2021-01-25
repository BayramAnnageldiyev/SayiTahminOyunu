using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using System.ComponentModel;

namespace SayiTahminOyunu
{
    /// <summary>
    /// Uygulamanın genel ayarlarını kaydını tutacak olup dışarıdan ctor işlemi yapılamaz.
    /// </summary>
    [Serializable]
    public sealed class GlobalSettings
    {
        public const string SaveFileName = "sayitahminayar.set";
        public const string PhraseFileName = "sayitahmincumleler.ini";
        public const string PhraseStatsFileName = "sayitahminstats.ini";
        private GlobalSettings()
        {

        }
        ///Aşağıdaki değişken serileştirilmeyecek.
        [NonSerialized]
        private static GlobalSettings settings = new GlobalSettings();
        public static GlobalSettings Settings { get { return settings; } }
        public bool RebemmerChecked { get; set; }
        public string RebemmerName { get; set; }
        /// <summary>
        /// Ayarları dosyadan yükler.
        /// </summary>
        public static void LoadSettings()
        {
            string sfpath = Path.Combine(Application.StartupPath, SaveFileName);
            if (!File.Exists(sfpath)) return;
            FileStream FS = new FileStream(sfpath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                GlobalSettings gstetings = formatter.Deserialize(FS) as GlobalSettings;
                settings = gstetings;
            }
            catch
            {
            }
            FS.Close();
        }
        /// <summary>
        /// Ayarları dosyaya kaydeder.
        /// </summary>
        public static void SaveSettings()
        {
            string sfpath = Path.Combine(Application.StartupPath, SaveFileName);
            FileStream FS = new FileStream(sfpath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(FS, Settings);
            FS.Close();
        }
        /// <summary>
        /// Ayar dosyasını siler.
        /// </summary>
        public static void DeleteSettings()
        {
            string sfpath = Path.Combine(Application.StartupPath, SaveFileName);
            if (!File.Exists(sfpath)) return;
            File.Delete(sfpath);
        }
    }
}
