using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiss_Levente_Berek
{
    internal class Dolgozo
    {
        public string Nev { get; set; }
        public string Nem { get; set; }
        public string Reszleg { get; set;}
        public int BelepesEv { get; set; }
        public decimal Ber { get; set;}

        public Dolgozo(string s)
        {
            var v = s.Split(';');
            Nev = v[0];
            Nem = v[1];
            Reszleg = v[2];
            BelepesEv = int.Parse(v[3]);
            Ber = decimal.Parse(v[4]);
        }
    }
}
