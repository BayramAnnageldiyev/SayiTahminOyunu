using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    public class SayiTahminAttribute : Attribute
    {
        public SayiTahminAttribute(string ItemDescription, string Group)
        {
            this.description = ItemDescription;
            this.group = Group;
        }
        private string description;

        private string group;

        public string Description { get { return description; } }
        public string Group { get { return group; } }

    }
}
