using System;
using System.Collections.Generic;
using System.Text;

namespace Ølspecialisten.Core.Entity
{
    public class Filter
    {
        public Beer.TypeBeer Type { get; set; }
        public Beer.Nationalitet Land { get; set; }
        public Selector Selcect { get; set; }

        public enum Selector
        {
            Top3,
            Alle
        }

    }
}
