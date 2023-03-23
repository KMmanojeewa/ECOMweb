using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOMweb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public Series Series { get; set; }

        public int SeriesId { get; set; }

        public ProductConfig ProductConfig { get; set; }

        //public int ProductConfigId { get; set; }
    }
}
