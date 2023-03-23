using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOMweb.Models
{
    public class ProductConfig
    {
        [Key]
        public int Id { get; set; }

        public double TotalPrice { get; set; }

        public string Summary { get; set; }

        //has one relation
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //many many
        public List<ConfigItem> ConfigItems { get; set;}

    }
}
