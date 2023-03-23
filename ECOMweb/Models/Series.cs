using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOMweb.Models
{
    public class Series
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        //has many products
        public List<Product> Products { get; set; }
    }
}
