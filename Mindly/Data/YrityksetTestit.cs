using System;
using System.Collections.Generic;

#nullable disable

namespace EF
{
    public partial class YrityksetTestit
    {
        public int YrityksetTestitTunnus { get; set; }
        public int YrityksetTunnus { get; set; }
        public int TestitTunnus { get; set; }

        public virtual Testit TestitTunnusNavigation { get; set; }
        public virtual Yritykset YrityksetTunnusNavigation { get; set; }
    }
}
