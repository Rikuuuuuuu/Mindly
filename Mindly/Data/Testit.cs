using System;
using System.Collections.Generic;

#nullable disable

namespace EF
{
    public partial class Testit
    {
        public Testit()
        {
            YrityksetTestits = new HashSet<YrityksetTestit>();
        }

        public int TestitTunnus { get; set; }
        public string Kysymys1 { get; set; }
        public string Kysymys2 { get; set; }

        public virtual ICollection<YrityksetTestit> YrityksetTestits { get; set; }
    }
}
