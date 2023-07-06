using System.ComponentModel.DataAnnotations;

namespace webapisample1
{
    public class employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
