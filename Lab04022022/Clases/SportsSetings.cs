using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04022022.Clases
{
    class SportsSetings
    {
        public int Id { get; set; }

        public int CountSports { get; set; }

        ICollection<PartyInfo> PartyInfos { get; set; }
        public SportsSetings()
        {
            PartyInfos = new List<PartyInfo>();
        }
        public int ResultId { get; set; }
        public Result Result { get; set; }
    }
}
