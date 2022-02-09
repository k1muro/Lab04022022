using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04022022.Clases
{
    class Olympiad
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }


    }
}
