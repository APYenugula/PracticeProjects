using System.ComponentModel.DataAnnotations;

namespace codefirstEF.Models
{
    public class studenttable
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int standard { get; set; }
    }
}
