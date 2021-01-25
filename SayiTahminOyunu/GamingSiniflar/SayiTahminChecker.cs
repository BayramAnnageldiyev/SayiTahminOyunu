using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public sealed class SayiTahminChecker
    {
        public static int GetDifficultLevel(SayiTahminIcerik sticerik)
        {
            int dpoints = 100;
            int ibasorta = (sticerik.MaxBasamak + sticerik.MinBasamak) / 2;
            if (ibasorta <= 3)
            {
                dpoints -= 30;
            }
            else
            {
                dpoints -= (30 - ibasorta * 3);
            }
            int isure = sticerik.Sure / 10;
            if(isure == 0 || isure > 20)
            {
                dpoints -= 20;
            }
            else if(isure< 20)
            {
                dpoints -= isure;
            }
            if(sticerik.RakalmarFarkli)
            {
                dpoints -= 15;
            }
            if(sticerik.GecmisiGoster && !sticerik.VectorelMode)
            {
                dpoints -= 10;
            }
            if(sticerik.YanlisTahminSayisi <= 0 || sticerik.YanlisTahminSayisi > 20)
            {
                dpoints -= 20;
            }
            else
            {
                dpoints -= sticerik.YanlisTahminSayisi;
            }
            if (dpoints <= 10) return 0;
            if (dpoints >= 90) return 6;
            float fpoint = (float)dpoints;
            float fsonuc = fpoint / 100f * 6f;
            return (int) Math.Round(fsonuc);

        }
    }
}
