using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {

            global::SayiTahminOyunu.ProfilSiniflar.UserProfileUtils.InitializeUserProfile();
            GlobalSettings.LoadSettings();
            GlobalVariants.PhraseList.LoadPhraseFromFile(GlobalSettings.PhraseFileName);
            GlobalVariants.PhraseList.LoadPhraseFromFile(GlobalSettings.PhraseStatsFileName);
            ProfilSiniflar.UserProfileUtils.LoadReservedSlotsFromFile(GlobalSettings.PhraseStatsFileName);
            bool hname = GlobalSettings.Settings.RebemmerChecked;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SayiTahmin());            
        }
    }
}
