using System.ComponentModel.DataAnnotations;

namespace Georgea_Adina_Lab2.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; } = string.Empty;
        public ICollection<Book>? Books { get; set; } = new List<Book>();
    }
}
