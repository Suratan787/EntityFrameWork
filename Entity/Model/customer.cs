using System.ComponentModel.DataAnnotations;

namespace Entity.Model
{
    public class customer
    {
        [Key]
        public int id { get; set; }

        [MaxLength(100)]
        public string name1 { get; set; }

        [MaxLength(100)]
        public string name2 { get; set; }
        [MaxLength(1)]

        public string sex { get; set; }
        public int age { get; set; }
        
    }
}
