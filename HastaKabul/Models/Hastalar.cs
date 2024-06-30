using System.ComponentModel.DataAnnotations;

namespace HastaKabul.Models
{
    public class Hastalar
    {
        [Key]
        public int HastaId { get; set; }
        public int HastaTc { get; set; }
        public String HastaAd { get; set; }
        public int HastaYas { get; set; }
        public String HastaEmail { get; set; }
        public String HastaPassword { get; set; }
    }
}
