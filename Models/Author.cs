namespace Georgea_Adina_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }  // Primary key
        public string FirstName { get; set; } = string.Empty;  // Ensure this is initialized
        public string LastName { get; set; } = string.Empty;  // Ensure this is initialized

        public ICollection<Book> Books { get; set; } = new List<Book>(); // Navigation property
    }
}
