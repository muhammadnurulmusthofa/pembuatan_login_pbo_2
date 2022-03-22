using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_4
{
    class anjing : pet


    {
        public anjing(int action, String nama, String owner )   :base (nama,owner,action){ }

        public string Act ()
        {
            string Act = "diam";
            if (Action == 1) Act = "bermain";
            if (Action == 2) Act = "Tidur";

            return Act;
        }

        public string Care()
        {
            if (Action == 1) return "A";
            if (Action == 2) return "B";
            return "heru";

        }


      

    }
}
