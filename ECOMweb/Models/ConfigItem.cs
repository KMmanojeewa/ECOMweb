using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOMweb.Models
{
    public class ConfigItem
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        //many many
        public List<ProductConfig> ProductConfigs { get; set; }

    }
}
