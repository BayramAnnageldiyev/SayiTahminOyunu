using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.StatisticSiniflar
{
    [Serializable]
    public class ProfileStatisticsContainer : IProfileStatistics, IEnumerable<ProfileStatistic>
    {
        private object parent;
        public object Parent
        {
            get
            {
                return parent;
            }
            set
            {
                parent = value;
            }
        }
        private ProfileStatistics stats;
        public ProfileStatistics Stats
        {
            get
            {
                return stats;
            }
        }
        public bool IsBaseContainer => true;

        public ProfileStatisticsContainer(object parent)
        {
            stats = new ProfileStatistics(this);
            this.Parent = parent;
        }
        public IEnumerator<ProfileStatistic> GetEnumerator()
        {
            for (int i = 0; i < Stats.StatsCount; i++)
            {
                yield return Stats[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Stats.StatsCount; i++)
            {
                yield return Stats[i];
            }
        }
        /// <summary>
        /// Tüm istatistikleri getirir.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProfileStatistic> GetAllStats()
        {
            return GetAllStats(false);
        }
        /// <summary>
        /// Alt istatistkileri ile beraber tüm istatistikleri getir.
        /// </summary>
        /// <param name="includesubstats">true olarak ayarlanırsa alt statslar ile birlikte dönüş yapar.</param>
        /// <returns></returns>
        public IEnumerable<ProfileStatistic> GetAllStats(bool includesubstats)
        {
            List<ProfileStatistic> profilestats = new List<ProfileStatistic>();
            for (int i = 0; i < this.Stats.StatsCount; i++)
            {
                profilestats.Add(this.Stats[i]);
                if(includesubstats) profilestats.AddRange(this.stats[i].GetAllStats(includesubstats));

            }
            return profilestats;
        }
        ProfileStatistic GetStatByName(string statname)
        {
            return GetStatByName(statname, false, null);
        }
        /// <summary>
        /// İsmi yazılan istatistik yoksa ekler, varsa dokunmaz
        /// </summary>
        /// <param name="statname"></param>
        public void InitializeStatistic(string statname, object statvalue = null)
        {
            if(GetStatByName(statname) != null)
            {
                return;
            }
            SetStatByName(statname, statvalue);
        }


        /// <summary>
        /// İsmi yazılan statları getirir . karakteri alt statları getirmek için kullanılır.
        /// </summary>
        /// <param name="statname">İstenilen istatistik değeri</param>
        /// <param name="createifnotexists">İstatistik yoksa yenisini ekler</param>
        /// <param name="statvalue">createifnotexists değeri true ise istatistik yoksa varsayılan olarak bu değeri atar.</param>
        /// <returns></returns>
        ProfileStatistic GetStatByName(string statname, bool createifnotexists = false, object statvalue = null)
        {
            string[] splittedstr = statname.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (splittedstr.Length == 0) return null;
            ProfileStatistic currentstat = this.Stats[splittedstr[0]];
            bool iscreated = false;
            if (currentstat == null)
            {
                if (!createifnotexists)
                {
                    return null;
                }
                currentstat = this.Stats.AddStatictic(splittedstr[0], null);
                iscreated = true;
            }
            ProfileStatistic prevstat = currentstat;
            for (int i = 1; i < splittedstr.Length; i++)
            {
                currentstat = currentstat.Stats[splittedstr[i]];
                if(currentstat == null)
                {
                    if (!createifnotexists)
                    {
                        return null;
                    }
                    currentstat = prevstat.Stats.AddStatictic(splittedstr[i], null);
                    iscreated = true;
                }
                prevstat = currentstat;
            }
            if(iscreated)
            {
                currentstat.Value = statvalue;
            }
            return currentstat;
        }
        public void SetStatByName(string statname, object svalue)
        {
            ProfileStatistic cstat = GetStatByName(statname, true, svalue);
            cstat.Value = svalue;
        }

        public bool StatContains(string statname)
        {
            return Stats.StatContains(statname);
        }

        public ProfileStatistic this[string statname]
        {
            get
            {
                return GetStatByName(statname);
            }
        }
        public ProfileStatistic this[string statname, bool createifnotexists]
        {
            get
            {
                return GetStatByName(statname, createifnotexists);
            }
        }
        public ProfileStatistic this[int index]
        {
            get
            {
                return Stats[index];
            }
        }
        public void Clear()
        {
            this.Stats.Clear();
        }

        public bool SubStatsNullOrEmpty()
        {
            IEnumerable<ProfileStatistic> allStats = this.GetAllStats(true);
            foreach (var stat in allStats)
            {
                if (!string.IsNullOrEmpty(stat?.ValueString)) return false;
            }
            return true;
        }
    }
}
