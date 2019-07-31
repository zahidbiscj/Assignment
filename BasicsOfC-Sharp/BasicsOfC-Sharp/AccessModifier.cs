using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    public class AccessModifier
    {
        public int x;
        private int y;
        protected int z;
        internal int a;
        public void Example() {
            int j = x + y + z + a;
        }
    }

    public class ForProtected : AccessModifier {
        public void New() {
            x = 21;
            /// y is private , so can't access it from other class
            z = 22;/// Protected can only get by inherit it 
            a = 23;
        }
    }
}
