using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu.PhraseSiniflar
{
    public sealed class Phrase
    {
        public Phrase(Phrases baseclass)
        {
            BaseClass = baseclass;
        }
        private string text;
        private bool isFormatted;
        public Phrases BaseClass { get; set; }
        public string Name { get; set; }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                isFormatted = false;
                if(text != null)
                {
                    isFormatted = text.IsFormattedText();
                }
            }
        }
        public bool IsFormatted
        {
            get
            {
                return isFormatted;
            }
        }
        //public Control BindedControl { get; set; }
        public string GetText(params object[] format)
        {
            return string.Format(this.Text, format);
        }
        public override bool Equals(object obj)
        {
            if(obj is string)
            {
                return this.Name == obj.ToString();
            }
            /*
            using(Control c = obj as Control)
            {
                if(c != null)
                {
                    return c == this.BindedControl;
                }
            }*/
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
