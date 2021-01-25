using SayiTahminOyunu.StatisticSiniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.ProfilSiniflar
{
    [Serializable]
    public class UserProfile
    {
        public UserProfile()
        {
            statistics = new ProfileStatisticsContainer(this);

        }
        private string profileName;
        private ProfileStatisticsContainer statistics;
        DateTime creationDate;
        DateTime lastactivityDate;
        /// <summary>
        /// Profil adı
        /// </summary>
        public string ProfileName
        {
            get
            {
                return profileName;
            }
            set
            {
                string errormsg = null;
                if(!ProfilSiniflar.UserProfileUtils.CanCreateUserProfile(value, out errormsg))
                {
                    throw new Exception(errormsg);
                }
                profileName = value;
            }
        }
        /// <summary>
        /// Profil istatistik verileri.
        /// </summary>
        public ProfileStatisticsContainer Statistics
        {
            get
            {
                return statistics;
            }
        }
        /// <summary>
        /// Profil oluşturma tarihi
        /// </summary>
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }
        /// <summary>
        /// Profil son erişim tarihi
        /// </summary>
        public DateTime LastactivityDate
        {
            get { return lastactivityDate; }
            set { lastactivityDate = value; }
        }
        /// <summary>
        /// Profilin ilk defa oyun oynayıp oynamadığını gösterir.
        /// </summary>

        public bool FirstPlayed { get; set; }
        /// <summary>
        /// En son oyun başlatma parameterleri
        /// </summary>
        public SayiTahminIcerik LastGameProp { get; set; }
        /// <summary>
        /// Uyarıların gösterilip gösterilmeyeceğini tutar.
        /// </summary>
        public bool DisableWarnings { get; set; }
    }
}
