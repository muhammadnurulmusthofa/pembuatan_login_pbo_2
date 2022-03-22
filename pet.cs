using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_4
{
    class pet
    {
        string nama, owner;
        int action;

        public pet() { }

        public pet(string nama, string owner, int action)
        {
            this.Nama = nama;
            this.Owner = owner;
            this.Action = action;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Owner { get => owner; set => owner = value; }
        public int Action { get => action; set => action = value; }
    }
}
