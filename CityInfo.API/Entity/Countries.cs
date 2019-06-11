using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entity
{
    [Table("Countries")]
    public class Countries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryID { get; set; }
        [Required]
        [MaxLength(100)]
        //[Make country name unique]
        public string CountryName { get; set; }
        [MaxLength(255)]
        public string SomeDetails { get; set; }
    }
}
