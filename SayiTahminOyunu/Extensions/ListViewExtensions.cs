using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public static class ListViewExtensions
    {
        /// <summary>
        /// İçeriğindeki tüm sütunların taglarını cümle listesinde isimle eşleştirir mevcutsa atama yapar(Biçimli metin hariç).
        /// </summary>
        /// <param name="listview">Listview</param>
        public static void SetAllColumnsText(this ListView listview)
        {
            foreach (ColumnHeader column in listview.Columns)
            {
                PhraseSiniflar.Phrase phrase = GlobalVariants.PhraseList[column.Tag?.ToString()];
                if (phrase == null || phrase.IsFormatted) continue;
                column.Text = phrase.Text;
            }
        }
    }
}
