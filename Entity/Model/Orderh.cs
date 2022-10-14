using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity.Model
{
    public class Orderh
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string doc_no { get; set; }
        public DateTime doc_date { get; set; }
        public double amount { get; set; }
        public double vat { get; set; }
        public double net_amount { get; set; }
        [ForeignKey("customerid")]
        public int customerid { get; set; }
        public customer customer { get; set; }
    }
}
