using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu.PhraseSiniflar
{
    public sealed class PhraseControl : IEquatable<object>, IEquatable<Control>
    {
        public Control PControl { get; set; }
        public ToolStripItem TIControl { get; set; }
        public string PhraseName { get; set; }
        public object PSender { get; set; }
        public override string ToString()
        {
            return PhraseName;
        }
        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return this.PhraseName == obj.ToString();
            }
            Control c = obj as Control;
            if (c != null)
            {
                return c == this.PControl;
            }
            ToolStripItem tsc = obj as ToolStripItem;
            if (tsc != null)
            {
                return tsc == this.TIControl;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        bool IEquatable<Control>.Equals(Control other)
        {
            return Equals(other);
        }
        public Phrase PhrasePointer { get; set; }
    }
}
