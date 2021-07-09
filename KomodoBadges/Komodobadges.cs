using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    public class Komodobadges
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess { get; set; }

        public Komodobadges() { }

        public Komodobadges(int badgeid, List<string> doorAccess)
        {
            BadgeID = badgeid;
            DoorAccess = doorAccess;
        }
    }
}
