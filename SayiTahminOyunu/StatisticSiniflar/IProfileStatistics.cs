using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu.StatisticSiniflar
{
    public interface IProfileStatistics
    {
        /// <summary>
        /// Bağlı istatistikler
        /// </summary>
        ProfileStatistics Stats { get; }
        bool IsBaseContainer { get; }
        /// <summary>
        /// Tüm istatistikleri getirir.
        /// </summary>
        /// <returns>IEnumarable cinsinden dönüş yapar.</returns>
        IEnumerable<ProfileStatistic> GetAllStats();
        /// <summary>
        /// Tüm istatistikleri(alt istatistikleri ile baraber) getirir.
        /// </summary>
        /// <param name="includesubstats">Alt istatistiklerin dahil edilip edilmeyeceğini ayarlar</param>
        /// <returns>IEnumarable cinsinden dönüş yapar.</returns>
        IEnumerable<ProfileStatistic> GetAllStats(bool includesubstats);
        /// <summary>
        /// İstatistiğin mevcut olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="statname">İstatistik adı.</param>
        /// <returns>İstatistik mevcutsa true diğer türlü false döner.</returns>
        bool StatContains(string statname);
        /// <summary>
        /// İstatistiğin tüm alt üyelerinin boş veya null olup olmadığını sorgular.
        /// </summary>
        /// <returns>Null veya boş ise true diğer türlü false döner</returns>
        bool SubStatsNullOrEmpty();
    }
}
