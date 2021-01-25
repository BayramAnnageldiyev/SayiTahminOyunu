using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu.ProfilSiniflar
{
    public static class UserProfileUtils
    {
        private static List<string> mReservedSlots = new List<string>();


        /// <summary>
        /// Profil dosyalarının kaydedildiği dosyanın adını verir.
        /// </summary>
        /// <param name="profilename">Profil adı(null veya boş girilirse klasör yolunu dönderir)</param>
        /// <returns>Klasör veya dosya konumunu dönderir</returns>
        public static string GetProfileFolderPath(string profilename)
        {
            if(string.IsNullOrEmpty(profilename))
            {
                return Path.Combine(Application.StartupPath, UserProfileFolderName);
            }
            return Path.Combine(Application.StartupPath, UserProfileFolderName, profilename + ".prf");
        }
        /// <summary>
        /// Profil dosyalarının kaydedildiği klasörün adını verir.
        /// </summary>
        /// <returns>Klasör konumunu dönderir</returns>
        public static string GetProfileFolderPath()
        {
            return GetProfileFolderPath(null);
        }
        /// <summary>
        /// Varsayılan kullanıcı profillerini içeren klasörün yolu.
        /// </summary>
        public const string UserProfileFolderName = "profiles";
        /// <summary>
        /// Dosya isminde yazılamayacak karakterler
        /// </summary>
        public static readonly char[] FileNameErroredChars = { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };
        /// <summary>
        /// Girilen profil isminin dosya ismine uygun olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="pname">Profil ismi</param>
        /// <returns>Dosya ismine uymayacak karakterleri içeriyiorsa false diğer türlü true döner</returns>
        public static bool IsValidProfileName(string pname)
        {
            if (pname == null) pname = "";
            pname = pname.Trim();
            if (string.IsNullOrEmpty(pname)) return false;
            if(pname.IndexOfAny(FileNameErroredChars) >= 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Sorgulanan profil isminin var olup olmadığını denetler.
        /// </summary>
        /// <param name="pname">Sorgulanacak profil ismi</param>
        /// <returns>Profil isminde dosya mevcutsa true diğer türlü false döer</returns>
        public static bool ProfileExists(string pname)
        {
            string profilefilepath = Path.Combine(Application.StartupPath, UserProfileFolderName, pname + ".prf");
            return File.Exists(profilefilepath);
        }
        /// <summary>
        /// Geçerli profil ismiyle profil kurulup kurulamayacağı sonucunu ve hata mesajını dönderir.
        /// </summary>
        /// <param name="pname">Profil ismi</param>
        /// <param name="perrormsg">Hata mesajı çıktısı</param>
        /// <returns>Profil ismi hatalı ise false diğer türlü true döner</returns>
        public static bool CanCreateUserProfile(string pname, out string perrormsg)
        {
            perrormsg = null;
            if (pname != null)
            {
                pname = pname.Trim();
            }
            if (string.IsNullOrEmpty(pname))
            {
                perrormsg = "Profil ismi boş olamaz.";
                return false;
            }
            if (!UserProfileUtils.IsValidProfileName(pname))
            {
                perrormsg = string.Format("Profil ismi bu karakterleri içeremez: {0}", string.Join(",", UserProfileUtils.FileNameErroredChars));
                return false;
            }
            if (UserProfileUtils.ProfileExists(pname))
            {
                perrormsg = "Bu isimde bir profil önceden tanımlanmış: " + pname;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Yeni profil oluşturmak için kullanılır
        /// </summary>
        /// <param name="profilename">Oluşturulacak profil ismi</param>
        /// <returns>UserProfile türünde dönüş yapar.</returns>
        public static UserProfile CreateUserProfile(string profilename)
        {
            string ProfilePath = GetProfileFolderPath(profilename);
            UserProfile UProfil = new UserProfile();
            UProfil.ProfileName = profilename;
            UProfil.CreationDate = DateTime.Now;
            FileStream FS = new FileStream(ProfilePath, FileMode.OpenOrCreate);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, UProfil);
            FS.Close();
            GlobalVariants.ExistingProfiles.Add(profilename);
            return UProfil;
        }
        /// <summary>
        /// Klasörüde bulunan *.prf uzantılı dosyaları getirir.
        /// </summary>
        /// <returns>string dizisi olarak döner</returns>
        public static string[] GetProfileList()
        {
            return Directory.GetFiles(GetProfileFolderPath(), "*.prf");
        }
        /// <summary>
        /// Kullanıcı profilini siler.
        /// </summary>
        /// <param name="profilename">Silinecek profil adı</param>
        public static void DeleteUserProfile(string profilename)
        {
            string profilepath = GetProfileFolderPath(profilename);
            GlobalVariants.ExistingProfiles.Remove(profilename);
            if (!File.Exists(profilepath)) return;
            File.Delete(profilepath);
        }
        /// <summary>
        /// İsmi vazılan kullanıcı profilini yükler
        /// </summary>
        /// <param name="profilename">Yüklenecek profilin adı</param>
        /// <returns>Yükleme yanlış ise null diğer türlü UserProfile türünden dönüş yapar.</returns>
        public static UserProfile LoadUserProfile(string profilename)
        {
            UserProfile UProf = null;
            string profilepath = GetProfileFolderPath(profilename);
            if (!File.Exists(profilepath)) return null;
            FileStream FS = new FileStream(profilepath, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            try
            {
                UProf = BF.Deserialize(FS) as UserProfile;
            } catch { }
            FS.Close();
            if (UProf != null) InitializeStatistics(UProf);
            return UProf;
        }
        /// <summary>
        /// Kullanıcı profilini dosyaya kaydeder.
        /// </summary>
        /// <param name="profile">Kaydedilecek profil</param>
        public static void SaveUserProfile(UserProfile profile)
        {
            if (profile == null) return;
            string profilepath = GetProfileFolderPath(profile.ProfileName);
            FileStream FS = new FileStream(profilepath, FileMode.OpenOrCreate);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, profile);
            FS.Close();
        }
        /// <summary>
        /// Kullanıcı profiline ait çoğu istatistikleri temizler.
        /// </summary>
        /// <param name="profile">Hedef profil</param>
        public static void ResetUserStatistis(UserProfile profile)
        {
            if (profile == null) return;
            profile.FirstPlayed = false;
            profile.Statistics.Clear();
            InitializeStatistics(profile);


        }
        /// <summary>
        /// Yeni oluşturlan profil için istatistik sıralamasını dosyadan yükler.
        /// </summary>
        /// <param name="filename"></param>
        public static void LoadReservedSlotsFromFile(string filename)
        {
           mReservedSlots.Clear();
           string[] allines = File.ReadAllLines(filename);
            foreach (var line in allines)
            {
                if (line.Length <= 0 || line.StartsWith(";")) continue;
                var splitted = line.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (splitted.Length < 1) continue;
                if (splitted[0].Trim() == "") continue;
                mReservedSlots.Add(splitted[0].Trim());
            }
        }
        /// <summary>
        /// Başlıca istatistiklerin ilk sıralarda çıkması için.
        /// </summary>
        /// <param name="profile">Hedef profil</param>
        public static void InitializeStatistics(UserProfile profile)
        {
            if (profile == null) return;
            for (int i = 0; i < mReservedSlots.Count; i++)
            {
                profile.Statistics.InitializeStatistic(mReservedSlots[i]);
            }
            string sznumformat = "digitstats.digit{0}{1}";
            for (int i = 0; i < 10; i++)
            {
                profile.Statistics.InitializeStatistic(string.Format(sznumformat, i, ".digitasked"));
                profile.Statistics.InitializeStatistic(string.Format(sznumformat, i, ".digitguesscount.digitguesssuccess"));
                profile.Statistics.InitializeStatistic(string.Format(sznumformat, i, ".digitguesscount.digitguessdiffer"));
                profile.Statistics.InitializeStatistic(string.Format(sznumformat, i, ".digitguesscount.digitguessfail"));
            }
        }
        /// <summary>
        /// Program ilk çalıştığı zaman çağırılacak void.
        /// </summary>
        public static void InitializeUserProfile()
        {
            //kullanıcı profillerini tutan klasör mevcut değilse oluşturur.
            if(!Directory.Exists(GetProfileFolderPath()))
            {
                Directory.CreateDirectory(GetProfileFolderPath());
            }
            //Klasördeki dosyaları aşağıdaki listeye yüklettiriyoruz.
            GlobalVariants.ExistingProfiles.AddRange(ProfilSiniflar.UserProfileUtils.GetProfileList());
        }
    }
}
