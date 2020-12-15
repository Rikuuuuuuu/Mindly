using System;
using System.Collections.Generic;

#nullable disable

namespace EF
{
    public partial class Vastaukset
    {
        public int YrityksetTestitTunnus { get; set; }
        public int Vastaus1 { get; set; }
        public int Vastaus2 { get; set; }

        public virtual YrityksetTestit YrityksetTestitTunnusNavigation { get; set; }
    }
}
