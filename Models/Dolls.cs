using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbie_Dolls.Models
{
    public class Dolls
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public decimal Height { get; set; }
        

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string SetTheme { get; set; }
        public int AgeGroup { get; set; }
        public decimal Price { get; set; }

    }
}
