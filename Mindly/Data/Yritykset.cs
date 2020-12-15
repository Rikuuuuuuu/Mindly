using System;
using System.Collections.Generic;

#nullable disable

namespace EF
{
    public partial class Yritykset
    {
        public Yritykset()
        {
            YrityksetTestits = new HashSet<YrityksetTestit>();
        }

        public int YrityksetTunnus { get; set; }
        public string Nimi { get; set; }

        public virtual ICollection<YrityksetTestit> YrityksetTestits { get; set; }
    }
}
