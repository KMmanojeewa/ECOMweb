using System.ComponentModel.DataAnnotations;

namespace ECOMweb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        //has many series
        public List<Series> Serieses { get; set;}
    }
}
