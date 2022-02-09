using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04022022.Clases
{
    class PartyInfo
    {
        public int Id { get; set; }

        public  string FullName { get; set; }

        public ICollection<SportView> SportViews { get; set; }
        public PartyInfo()
        {
            SportViews = new List<SportView>();
        }

        public System.DateTime DateBirth { get; set; }

        public byte[] Photo { get; set; }

    }
}
