using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    [Serializable]
    public sealed class SayiTahminIcerik
    {
        private int sure;
        private int minBasamak;
        private int maxBasamak;
        private bool rakalmarFarkli;
        private bool gecmisiGoster;
        private int yanlisTahminSayisi;
        public SayiTahminIcerik()
        {
            sure = 0;
            minBasamak = maxBasamak = 4;
            rakalmarFarkli = false;
            gecmisiGoster = true;
        }

        [SayiTahmin("STI_ATT_SURE", "sayi_0-180")]
        public int Sure
        {
            get
            {
                return sure;
            }
            set
            {
                sure = value;
            }
        }
        [SayiTahmin("STI_ATT_MINBAS", "rakam_1-10")]
        public int MinBasamak
        {
            get
            {
                return minBasamak;
            }
            set
            {
                if (value <= 0) value = 1;
                minBasamak = value;
            }
        }
        [SayiTahmin("STI_ATT_MAXNBAS", "rakam_1-10")]
        public int MaxBasamak
        {
            get
            {
                return maxBasamak;
            }
            set
            {
                if (value <= 0) value = 1;
                if (value > 10) value = 10;
                maxBasamak = value;
            }
        }
        [SayiTahmin("STI_ATT_RAKAMFRKL", "EvetHayır")]
        public bool RakalmarFarkli
        {
            get
            {
                return rakalmarFarkli;
            }
            set
            {
                rakalmarFarkli = value;
            }
        }
        [SayiTahmin("STI_ATT_YANLISHAK", "sayi_0-20")]
        public int YanlisTahminSayisi
        {
            get
            {
                return yanlisTahminSayisi;
            }
            set
            {
                if (value <= 0) value = 0;
                yanlisTahminSayisi = value;
            }
        }
        [SayiTahmin("STI_ATT_THGECMIS", "EvetHayır")]
        public bool GecmisiGoster
        {
            get
            {
                return gecmisiGoster;
            }
            set
            {
                gecmisiGoster = value;
            }
        }
        public bool VectorelMode { get; set; }
    }
}
