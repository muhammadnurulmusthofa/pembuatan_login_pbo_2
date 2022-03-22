using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_4
{
    class kucing : pet

    {
        public kucing() { }

        public kucing(int action, string nama, string owner) : base(nama, owner, action) { }

        public string Act ()
        {
            string Act = "diam";
            if (Action == 1) Act = "makan";
            if (Action == 2) Act = "mandi";

            return Act;
        }
         
        public string Care()
        {
            if (Action == 1) return "A";
            if (Action == 2) return "B";
            return "ajar";
        }
    }
}
