using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    class Property
    {
        private string Name;
        private bool hasNameChanged;

        // get , set full elaboration

        public void setName(string n) {
            if (n != null)
            {
                Name = n;
            }
            else
            {
                Name = string.Empty;
            }
            hasNameChanged = true;
        }
        public string getName() {
            if (Name == null) { return string.Empty; }
            else return Name;
        }


        // get , set uses
        public string name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }


    }
}
