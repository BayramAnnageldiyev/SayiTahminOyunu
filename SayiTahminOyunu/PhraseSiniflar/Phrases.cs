using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SayiTahminOyunu.PhraseSiniflar
{
    public class Phrases
    {
        public Phrases()
        {
            allphrases = new Dictionary<object, Phrase>();
            allControlKey = new List<PhraseControl>();
        }
        private Dictionary<object, Phrase> allphrases;
        private List<PhraseControl> allControlKey;
        /// <summary>
        /// Cümle ekler veya değiştirir.
        /// </summary>
        /// <param name="name">Cümle adı</param>
        /// <param name="text">Cümle içeriği</param>
        /// <param name="overwriteexisting">true ayarlanırsa girilen cümle mevcutsa değiştirir diğer türlü değiştirmez.</param>
        public void Set(string name, string text, bool overwriteexisting = true)
        {
            if(allphrases.ContainsKey(name))
            {
                if(!overwriteexisting)
                {
                    return;
                }
                allphrases.Remove(name);
            }
            Phrase phs = new Phrase(this) { Name = name, Text = text };
            PhraseControl pc = this.allControlKey.GetItem(name);
            if(pc != null)
            {
                pc.PhrasePointer = phs;
            }
            allphrases.Add(name, phs);
        }
        /// <summary>
        /// Denetim bağlamasını getirir.
        /// </summary>
        /// <param name="obj">Sorgulanan nesne</param>
        /// <returns>Bağlama yoksa null döner</returns>
        public PhraseControl GetControlItem(object obj)
        {
            return allControlKey.GetItem(obj);
        }


        /// <summary>
        /// Geriye phrase sınıfını dönderir.
        /// </summary>
        /// <param name="obj">Kontrol veya string</param>
        /// <returns>Bulunamaz null döner</returns>
        private Phrase GetItem(object obj)
        {
            Control ctrl = obj as Control;
            if (ctrl != null)
            {
                var findkey = allControlKey.GetItem(ctrl);
                return findkey?.PhrasePointer;
            }
            if (!allphrases.ContainsKey(obj))
            {
                return null;
            }
            return allphrases[obj];
        }
        /// <summary>
        /// Control e veya metne bağlı Phrase metnini dönderir.
        /// </summary>
        /// <param name="obj">Control veya metin</param>
        /// <returns>BUlunamazsa null döner</returns>
        public string Get(object obj)
        {
            return GetItem(obj)?.Text;
        }
        /// <summary>
        /// Control e veya metne bağlı Phrase metnini formatlı biçimde dönderir.
        /// </summary>
        /// <param name="obj">Control veya metin</param>
        /// <param name="format">Dönüş format parametreleri.</param>
        /// <returns></returns>
        public string Get(object obj, params object[] format)
        {
            return GetItem(obj)?.GetText(format);
        }

        /// <summary>
        /// Denetime bağlanmış Phrase ismini getirir.
        /// </summary>
        /// <param name="ctrl">Bağlanan kontrol</param>
        /// <returns>Bağlama yapılmadıysa null dönderir</returns>
        public string GetControlPhraseName(object ctrl)
        {
            return allControlKey.GetItem(ctrl)?.PhraseName;
        }
        /// <summary>
        /// Denetime Phrase ismini bağlar
        /// </summary>
        /// <param name="ctrl">Bağlanılacak denetim</param>
        /// <param name="pname">Bağlanılacak isim</param>
        /// <param name="senderitem">Denetimi gönderen öğe daha sonra bu öğeye bağlantılı itemler silinebilir</param>
        public void SetControlPhraseName(object ctrl, string pname, object senderitem = null)
        {
            if (allControlKey.Contains<object>(ctrl))
            {
                allControlKey.GetItem(ctrl).PhraseName = pname;
                allControlKey.GetItem(ctrl).PhrasePointer = GetItem(pname);
            }
            else
            {
                Control item = ctrl as Control;
                if(item != null)
                {
                    allControlKey.Add(new PhraseControl() { PControl = item, PhraseName = pname, PSender = senderitem, PhrasePointer = GetItem(pname) });
                }
                ToolStripItem tsi = ctrl as ToolStripItem;
                if(tsi != null)
                {
                    allControlKey.Add(new PhraseControl() { TIControl = tsi, PhraseName = pname, PSender = senderitem, PhrasePointer = GetItem(pname) });
                }

            }
        }
        /// <summary>
        /// Tüm cümleleri temizler
        /// </summary>
        public void Clear()
        {
            allControlKey.Clear();
            allphrases.Clear();
        }
        /// <summary>
        /// Denetimlere atanmış phrase nameleri gönderilen objeyeye göre temizler
        /// </summary>
        /// <param name="obj">Bağlantı yapan obje</param>
        public void ClearControlKeysBySender(object obj)
        {
            if (obj == null) return;
            for (int i = 0; i < this.allControlKey.Count; i++)
            {
                PhraseControl pControl = this.allControlKey[i];
                if(pControl.PSender == obj)
                {
                    this.allControlKey.RemoveAt(i);
                    i--;
                    continue;
                }
            }
        }
        /// <summary>
        /// Gönderilen obje tarafından atanmış olan denetimlerin textlerini otomatik değiştirir.(FOrmatlı biçimler hariç)
        /// </summary>
        /// <param name="obj">Bağlantı yapan obje</param>
        public void SetControlTextBySender(object obj)
        {
            if (obj == null) return;
            for (int i = 0; i < this.allControlKey.Count; i++)
            {
                PhraseControl pControl = this.allControlKey[i];
                if (pControl.PSender == obj)
                {
                    if (pControl.PhrasePointer == null || pControl.PhrasePointer.IsFormatted) continue;
                    if (pControl.PControl != null)
                    {
                        pControl.PControl.Text = pControl.PhrasePointer.Text;
                    }
                    if(pControl.TIControl != null)
                    {
                        pControl.TIControl.Text = pControl.PhrasePointer.Text;
                    } 
                }
            }
        }
        /// <summary>
        /// Cümle bloğunu dosyadan yükler.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="overwriteexisting">Mevcut cümlelerini çeriğini değiştirir veya değiştirmez</param>
        public void LoadPhraseFromFile(string filename, bool overwriteexisting = true)
        {
            if (!File.Exists(filename)) return;
            string[] allLines = File.ReadAllLines(filename);
            foreach (var line in allLines)
            {
                if (line == null) continue;
                string cline = line.Trim();
                if (cline == "" || cline.StartsWith(";") || cline.StartsWith("//")) continue;

                if (cline.IndexOf('=') < 0) continue;
                var splitted = cline.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (splitted.Length < 2) continue;
                string pname = splitted[0].Trim();
                string pvalue = splitted[1].Trim();
                if (string.IsNullOrEmpty(pname) || string.IsNullOrEmpty(pvalue)) continue;
                this.Set(pname, pvalue);
            }
        }
        /// <summary>
        /// Denetim ismi ile listede olan ve format biçimnde olmayan textleri denetimlere otomatik atar.(Eğer control bağlıysa bağlı olan değeri atar)
        /// <param name="controlparent"/>Tarama yapılacak Control</param>
        /// </summary>
        public void SetAllControlTextByName(Control controlparent)
        {
            if (controlparent == null) return;
            SetControlText(null, controlparent);
            IEnumerable<Control> Controls = controlparent.GetAllControls();
            foreach (var control in Controls)
            {
                SetControlText(controlparent, control);
            }
        }


        private void  SetControlText(Control controlparent, Control ctrl)
        {
            if (ctrl == null) return;
            PhraseControl pc = allControlKey.GetItem(ctrl);
            Phrase p = null;
            if (pc != null)
            {
                if (pc.PhrasePointer != null && !pc.PhrasePointer.IsFormatted)
                {
                    ctrl.Text = pc.PhrasePointer.Text;
                }
                return;
            }
            else
            {
                p = this[ctrl.Name];
                if(p == null && controlparent != null)
                {
                    p = this[string.Format("{0}.{1}", controlparent.Name, ctrl.Name)];
                }
                if (p != null && !p.IsFormatted)
                {
                    ctrl.Text = p.Text;
                }
            }
        }
        public Phrase this[object nameorcontrol]
        {
            get
            {
                return GetItem(nameorcontrol);
            }
        }

    }
}
