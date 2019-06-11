using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entity
{
    [Table("Cities")]
    public class Cities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }
        [Required]
        [MaxLength(80)]
        public string CityName { get; set; }
        [MaxLength(255)]
        public string ShortDescription { get; set; }
        [ForeignKey("CountryID")]
        public int CountryID { get; set; }
        public Countries Coutries { get; set; }
    }
}
