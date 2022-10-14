using System.ComponentModel.DataAnnotations;

namespace Entity.Model
{
    public class product
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string code { get; set; }
        [MaxLength(255)]
        public string name1 { get; set; }
        [MaxLength(255)]
        public string name2 { get; set; }
        public double price { get; set; }
    }
}
