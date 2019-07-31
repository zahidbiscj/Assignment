using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    class Property
    {
        private string Name;
        private bool hasNameChanged;

        public void setName(string n) {
            if (n != null)
            {
                Name = n;
            }
            else
                Name = string.Empty;
            hasNameChanged = true;
        }
        public string getName() {
            if (Name == null) { return string.Empty; }
            else return Name;
        }


    }
}
