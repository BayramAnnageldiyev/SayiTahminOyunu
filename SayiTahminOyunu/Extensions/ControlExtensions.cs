using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SayiTahminOyunu.PhraseSiniflar;

namespace SayiTahminOyunu
{
    public static class ControlExtensions
    {
        public static IEnumerable<Control> GetAllControls( this Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                                      .Concat(controls);
        }
        /// <summary>
        /// Cümle listesinde veya birleştirme listesinde varsa Textini değiştirir.
        /// </summary>
        /// <param name="control">Hedef control</param>
        public static void SetText(this Control control, params object[] format)
        {
            Phrase phs = GlobalVariants.PhraseList[control];
            if (phs == null)
            {
                phs = GlobalVariants.PhraseList[control.Name];
                if (phs == null) return;
            }
            control.Text = phs.GetText(format);
        }
    }

}
