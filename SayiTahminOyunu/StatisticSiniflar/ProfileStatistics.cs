using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.StatisticSiniflar
{
    [Serializable]
    public class ProfileStatistics: IEnumerable<ProfileStatistic>
    {
        private List<ProfileStatistic> allStatistics;
        private IProfileStatistics parent;
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
        public ProfileStatistic this[int index]
        {
            get
            {
                return allStatistics[index];
            }
        }
        public ProfileStatistic this[string statname]
        {
            get
            {
                return GetStatByName(statname);
            }
        }
        public int StatsCount
        {
            get
            {
                return allStatistics.Count;
            }
        }
        public ProfileStatistics(IProfileStatistics parent)
        {
            allStatistics = new List<ProfileStatistic>();
            this.Parent = parent;
        }
        public bool StatContains(string statname)
        {
            return GetStatByName(statname) != null;
        }
        ProfileStatistic GetStatByNameSingle(string statname)
        {
            for (int i = 0; i < this.StatsCount; i++)
            {
                if (this[i].Name == statname) return this[i];
            }
            return null;
        }
        ProfileStatistic GetStatByName(string statname)
        {
            string[] splittedstr = statname.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (splittedstr.Length == 0) return null;
            ProfileStatistic currentstat = GetStatByNameSingle(splittedstr[0]);
            if (currentstat == null)
            {
                return null;
            }
            for (int i = 1; i < splittedstr.Length; i++)
            {
                currentstat = currentstat.Stats[splittedstr[i]];
                if (currentstat == null)
                {
                    return null;
                }
            }
            return currentstat;
        }
        public ProfileStatistic  AddStatictic(string name, object value)
        {
            ProfileStatistic newstatistic = new ProfileStatistic(this.Parent) { Name = name, Value = value };
            allStatistics.Add(newstatistic);
            return newstatistic;
        }

        public IEnumerator<ProfileStatistic> GetEnumerator()
        {
            for (int i = 0; i < allStatistics.Count; i++)
            {
                yield return allStatistics[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < allStatistics.Count; i++)
            {
                yield return allStatistics[i];
            }
        }
        public void Clear()
        {
            this.allStatistics.Clear();
        }
        public void Remove(ProfileStatistic statistic)
        {
            this.allStatistics.Remove(statistic);
        }
        public void RemoveAt(int index)
        {
            this.allStatistics.RemoveAt(index);
        }
        public void Remove(string statname)
        {
            ProfileStatistic pstat = GetStatByName(statname);
            if (pstat != null)
            {
                pstat.Parent.Stats.Remove(pstat);
            }
        }
    }
}
