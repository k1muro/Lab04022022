using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04022022.Clases
{
    class Result
    {
        public int Id { get; set; }

        public int OlympiadId { get; set; }
        public Olympiad Olympiad { get; set; }

        public int PartyinfoId { get; set; }
        public PartyInfo PartyInfo { get; set; }

        public int SportViewId { get; set; }
        public SportView SportView { get; set; }
        
         public string ResultName { get; set; }   
            
         public int Position { get; set; }
    }
}
