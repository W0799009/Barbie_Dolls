using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barbie_Dolls.Models
{
    public class Doll
    {
        public int ID { get; set; }

        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Material { get; set; }


        [Range(1, 40  )]
        public decimal Height { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(20)]
        public string SetTheme { get; set; }

        [Range(0, 15)]

        public int AgeGroup { get; set; }

        

        [Range(1, 40)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Range(1, 5)]
        public int Rating { get; set; }

    }
}
