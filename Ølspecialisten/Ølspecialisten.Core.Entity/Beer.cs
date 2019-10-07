using System;
using System.Collections.Generic;
using System.Text;

namespace Ølspecialisten.Core.Entity
{
    class Beer
    {

        public double Pris { get; set; }
        public string Beskrivelse { get; set; }
        public Nationalitet Nation { get; set; }
        public int Lager { get; set; }
        public string Navn { get; set; }
        public string BeskrivelseLang { get; set; }
        public double Alkohol { get; set; }
        public double Kapacitet { get; set; }

        public enum Nationalitet
        {
            Dansk,
            Norsk,
            Svensk
        }

        public enum TypeØl
        {
            Lys,
            Mørk
        }
    }
}
