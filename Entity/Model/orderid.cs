using System.ComponentModel.DataAnnotations;

namespace Entity.Model
{
    public class orderid
    {
        [Key]
        public int id { get; set; }

        public int orderhid { get; set; }

        public int itemid { get; set; }
        [MaxLength(255)]
        public string item_desc { get; set; }
        public double price { get; set; }
        public double qty { get; set; }
        public double vat { get; set; }
        public double net_amount { get; set; }

    }
}
