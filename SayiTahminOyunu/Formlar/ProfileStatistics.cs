using CWMsgBox;
using SayiTahminOyunu.ProfilSiniflar;
using SayiTahminOyunu.StatisticSiniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class ProfileStatistics : Form
    {
        private UserProfile ActiveProfile { get; set; }
        public static void ShowStatistics(UserProfile uProfile)
        {
            ProfileStatistics PSts = new ProfileStatistics();
            PSts.ActiveProfile = uProfile;
            PSts.ShowDialog();
        }
        public ProfileStatistics()
        {
            InitializeComponent();
        }

        private async void ProfileStatistics_Load(object sender, EventArgs e)
        {
            this.SetText(ActiveProfile.ProfileName);
            GlobalVariants.PhraseList.SetAllControlTextByName(this);
            grpStats.SetText(ActiveProfile.ProfileName);
            await loadUserStatistics(); 
        }
        private Task loadUserStatistics()
        {
            return Task.Factory.StartNew<string>(
                () => {
                    string fmttext = "<b>{0}</b>: {1}";
                    string fmttext_num = "<b>{0}</b>: {1:0.##}";
                    string fmttextex = "<b>{0}</b>";
                    StringBuilder SB = new StringBuilder();
                    SB.AppendFormat(fmttext, String.GetLangText("STS_ACT_PRF"), ActiveProfile.ProfileName);
                    SB.AppendLine();
                    SB.AppendFormat(fmttext, String.GetLangText("STT_CREATE_DATE"), ActiveProfile.CreationDate);
                    SB.AppendLine();
                    SB.AppendFormat(fmttext, String.GetLangText("STT_LAST_ACTIVITY"), ActiveProfile.LastactivityDate);
                    SB.AppendLine();
                    IEnumerable<ProfileStatistic> allStatistics =ActiveProfile.Statistics.GetAllStats(true);
                    int prevdepth = 0;
                    IProfileStatistics nocontinue = null;
                    foreach (var statistic in allStatistics)
                    {
                        if (statistic == null) continue;
                        string gfmt = fmttext;
                        int currentdepth = statistic.Depth;
                        if (currentdepth < prevdepth)
                        {
                            for (int i = 0; i < prevdepth - currentdepth; i++)
                            {
                                SB.Append("</ol>");
                              
                            }
                            prevdepth = currentdepth;
                        }
                        if (nocontinue != null)
                        {
                            if (statistic.BaseStatistic != null && statistic.BaseStatistic == nocontinue)
                            {
                                //prevdepth = currentdepth;
                                continue;
                            }
                        }

                        if(statistic.SubStatsNullOrEmpty() && string.IsNullOrEmpty(statistic.ValueString))
                        {
                            nocontinue = statistic;
                            continue;
                        }
                        SB.AppendLine();

                        object svalue = "";
                        if(statistic.Value != null) svalue = statistic.Value;
                        //if(statistic.Stats.StatsCount > 0)
                        //{
                        //    svalue =null;
                        //}
                        //else

                        //{
                        //    svalue = statistic.Value;
                        //}
                        if(currentdepth > 0)
                        {
                            SB.Append("<li>");
                        }
                        //for (int i = 0; i < currentdepth; i++)
                        //{
                        //    SB.Append("--");
                        //}
                        //if (currentdepth > 0) SB.Append(">");
                        if (statistic.Stats.StatsCount > 0 && (statistic.Value == null || statistic.ValueString == "" || statistic.ValueString == "***"))
                        {

                            SB.AppendFormat(fmttextex, String.GetLangTextOrDefault(statistic.GetFullName(), statistic.Name));
                        }
                        else
                        {
                            if(svalue != null)
                            {
                                if(svalue.IsNumeric())
                                {
                                    gfmt = fmttext_num;
                                }
                            }
                            SB.AppendFormat(gfmt, String.GetLangTextOrDefault(statistic.GetFullName(), statistic.Name), svalue);
                        }
                        if (currentdepth > 0)
                        {
                            SB.Append("</li>");
                        }
                        prevdepth = currentdepth;

                        if (statistic.Stats.StatsCount > 0) SB.Append("<ol>");
                    }
                    return SB.ToString();
                }).ContinueWith((t) => {
                    string lastresults = t.Result;
                    ToRtf toRtf = new ToRtf();
                    toRtf.KaynakMetin = lastresults;
                    this.Invoke((MethodInvoker)delegate { rtbStats.Rtf = toRtf.HtmlToRtf(); });//toRtf.HtmlToRtf(); });
                });
        }
        
        private void btnCloseStats_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
            MesajSonuç Msonuc = Mesaj.mbox.Göster(String.GetLangText("STS_DEL_STS", ActiveProfile.ProfileName), String.GetLangText("STS_DEL_STS_CPT", ActiveProfile.ProfileName), MessageBoxButtons.YesNo);
            if (Msonuc.MesajCevap != DialogResult.Yes) return;
            UserProfileUtils.ResetUserStatistis(ActiveProfile);
            Mesaj.mbox.Göster(String.GetLangText("STS_DEL_STS_SCC"));
            btnResetStats.Enabled = false;
        }
    }
}