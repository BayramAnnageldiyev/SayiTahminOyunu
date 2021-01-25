using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu.PhraseSiniflar
{
    [ProvideProperty("PhraseName", typeof(Control))]
    [ProvideProperty("PhraseNameTI", typeof(ToolStripItem))]

    public partial class PhraseComponent : Component, IExtenderProvider
    {
        public PhraseComponent()
        {
            InitializeComponent();
        }

        public PhraseComponent(IContainer container)
        {
            
            container.Add(this);
            InitializeComponent();
        }

        public bool CanExtend(object extendee)
        {
            return extendee != null;
        }
        /// <summary>
        /// Denetime bağlı Phrase ismini dönderir.
        /// </summary>
        /// <param name="control">Bağlantılı Denetim</param>
        /// <returns>yoksa boş döner</returns>
        [DefaultValue("")]
        public string GetPhraseName(Control control)
        {
            string text = GlobalVariants.PhraseList.GetControlPhraseName(control);
            if (text == null)
            {
                text = string.Empty;
            }
            return text;
        }
        /// <summary>
        /// Denetime phrase ismi bağlar.
        /// </summary>
        /// <param name="control">Bağlantı yapılacak denetim.</param>
        /// <param name="value">Phrase ismi</param>
        public void SetPhraseNameTI(ToolStripItem control, string value)
        {
            GlobalVariants.PhraseList.SetControlPhraseName(control, value, this);
        }
        [DefaultValue("")]
        public string GetPhraseNameTI(ToolStripItem control)
        {

            string text = GlobalVariants.PhraseList.GetControlPhraseName(control);
            if (text == null)
            {
                text = string.Empty;
            }
            return text;
        }
        /// <summary>
        /// Denetime phrase ismi bağlar.
        /// </summary>
        /// <param name="control">Bağlantı yapılacak denetim.</param>
        /// <param name="value">Phrase ismi</param>
        public void SetPhraseName(Control control, string value)
        {
            GlobalVariants.PhraseList.SetControlPhraseName(control, value, this);
        }
        /// <summary>
        /// Denetime bağlı phrase nin ciçeriğini dönderir.
        /// </summary>
        /// <param name="control">Bağlantılı denetim.</param>
        /// <returns>Eğer bağlanmadıysa veya yoksa null döner</returns>
        public string GetPhraseText(Control control)
        {
            return GlobalVariants.PhraseList.Get(control);
        }
        /// <summary>
        /// Denetime bağlı phrase nin ciçeriğini dönderir.
        /// </summary>
        /// <param name="control">Bağlantılı denetim.</param>
        /// <param name="obj">Format öğeleri</param>
        /// <returns>Eğer bağlanmadıysa veya yoksa null döner</returns>
        public string GetPhraseText(object control, params object[] obj)
        {
            return GlobalVariants.PhraseList.Get(control, obj);
        }
        /// <summary>
        /// Bağlantılı tüm cümle isimlerini Controllerden temizler.
        /// </summary>
        public void ClearAll()
        {
            GlobalVariants.PhraseList.ClearControlKeysBySender(this);
        }
        /// <summary>
        /// Bağlanmış tüm denetimlerin textlerini(Formatlı olmayan textler hariç) değiştirir.
        /// </summary>
        public void SetAllBindedControlText()
        {
            GlobalVariants.PhraseList.SetControlTextBySender(this);
        }
        /// <summary>
        /// Denetim ismi ile listede olan ve format biçimnde olmayan textleri denetimlere otomatik atar.(Eğer control bağlıysa bağlı olan değeri atar)
        /// <param name="controlparent"/>Tarama yapılacak Control</param>
        /// </summary>
        public void SetAllControlTextByName(Control controlparent)
        {
            GlobalVariants.PhraseList.SetAllControlTextByName(controlparent);
        }
        /// <summary>
        /// Denetime bağlı TExti değiştirir(mevcuts)
        /// </summary>
        /// <param name="item">Denetim veya ToolStripItem</param>
        /// <param name="obj">Parametre</param>
        public void SetItemText(object item, params object[] obj)
        {
            string sztext = GlobalVariants.PhraseList.Get(item, obj);
            if (sztext == null) return;
            Control ctrl = item as Control;
            if (ctrl != null)
            {
                ctrl.Text = sztext;
                return;
            }
            ToolStripItem tsi = item as ToolStripItem;
            if(tsi != null)
            {
                tsi.Text = sztext;
                return;
            }
        }
        
    }
}
