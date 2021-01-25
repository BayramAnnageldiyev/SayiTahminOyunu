using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.StatisticSiniflar
{
    [Serializable]
    public class ProfileStatistic : IProfileStatistics
    {
        private string name;
        private object value;
        private ProfileStatistics stats;
        private IProfileStatistics parent;
        public bool IsBaseContainer => false;
        public ProfileStatistic(IProfileStatistics parent)
        {
            stats = new ProfileStatistics(this);
            this.Parent = parent;
        }
        /// <summary>
        /// İstatistik değerinin adı.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value != null)
                {
                    value = value.Trim();
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("İstatistik ismi boş olamaz.");
                }
                if (parent.StatContains(value))
                {
                    throw new Exception("Eklenmeye çalışılan istatistik listede mevcut.");
                }
                if (value.IndexOf('.') >= 0)
                {
                    throw new Exception("İstatistik ismi içerisinde '.' karakteri kullanılamaz.");
                }
                name = value;
            }
        }
        /// <summary>
        /// İstatistik değerinin değeri
        /// </summary>
        public object Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        /// <summary>
        /// Değeri string türünden dönüş yapar.
        /// </summary>
        public string ValueString
        {
            get
            {
                if (Value == null) return null;
                return Value.ToString();
            }
            set
            {
                Value = value;
            }
        }
        /// <summary>
        /// Değeri Integer cinsinden getirir, değer numerik değilse 0 olarak dönüş yapar.
        /// </summary>
        public int ValueInt
        {
            get
            {
                if(value.IsNumeric())
                {
                    return Convert.ToInt32(Value);
                }
                return 0;
            }
            set
            {
                Value = value;

            }
        }
        /// <summary>
        /// Değeri Float cinsinden getirir, değer numerik değilse 0 olarak dönüş yapar.
        /// </summary>
        public float ValueFloat
        {
            get
            {
                if (value.IsNumeric())
                {
                    return Convert.ToSingle(Value);
                }
                return 0;
            }
            set
            {
                Value = value;

            }
        }
        /// <summary>
        /// Değeri Double cinsinden getirir, değer numerik değilse 0 olarak dönüş yapar.
        /// </summary>
        public double ValueDouble
        {
            get
            {
                if (value.IsNumeric())
                {
                    return Convert.ToDouble(Value);
                }
                return 0;
            }
            set
            {
                Value = value;

            }
        }
        /// <summary>
        /// Değeri DateTime cinsinden getirir, değer numerik değilse günün değeri olarak dönüş yapar.
        /// </summary>
        public DateTime ValueDateTime
        {
            get
            {
                if (value.IsDateTime())
                {
                    return Convert.ToDateTime(Value);
                }
                return DateTime.Now;
            }
            set
            {
                Value = value;

            }
        }
        /// <summary>
        /// Alt istatistikler
        /// </summary>
        public ProfileStatistics Stats
        {
            get
            {
                return stats;
            }
        }
        /// <summary>
        /// Bağlı olduğu istatistik veya istatistik container'i
        /// </summary>
        public IProfileStatistics Parent
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
        /// <summary>
        /// İlgili isatistiğin kaçıncı derinlikte olduğunu verir.
        /// </summary>
        public int Depth
        {
            get
            {
                IProfileStatistics parent = this.Parent;
                int depth = 0;
                while (parent != null && !parent.IsBaseContainer)
                {
                    ProfileStatistic pstatistic = parent as ProfileStatistic;
                    parent = pstatistic.Parent;
                    depth++;
                }
                return depth;
            }
        }
        /// <summary>
        /// İstatistiğe bağlı  tüm istatistikleri getirir.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProfileStatistic> GetAllStats()
        {
            return GetAllStats(false);
        }
        /// <summary>
        /// İstatistiğe bağlı  tüm istatistikleri(alt istatistikleri ile birlikte) getirir.
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
        /// <summary>
        /// İlgili istatistiğin tam adını getirir.
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            StringBuilder SB = new StringBuilder();
            SB.Insert(0, this.Name);
            IProfileStatistics parent = this.Parent;
            while (parent != null && !parent.IsBaseContainer)
            {
                ProfileStatistic pstatistic = parent as ProfileStatistic;
                SB.Insert(0, pstatistic.Name + ".");
                parent = pstatistic.Parent;
            }
            return SB.ToString();
        }
        public override string ToString()
        {
            return GetFullName();
        }
        public bool StatContains(string statname)
        {
            return this.Stats.StatContains(statname);
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
        public ProfileStatistic this[int index]
        {
            get
            {
                return this.Stats[index];
            }
        }
        public ProfileStatistic this[string statname]
        {
            get
            {
                return this.Stats[statname];
            }
        }
        public IProfileStatistics BaseStatistic
        {
            get
            {
                IProfileStatistics parent = this.Parent;
                IProfileStatistics iprevparent = null;
                while (parent != null && !parent.IsBaseContainer)
                {
                    iprevparent = parent;
                    ProfileStatistic pstatistic = parent as ProfileStatistic;
                    parent = pstatistic.Parent;
                }
                return iprevparent;
            }
        }
    }
}
