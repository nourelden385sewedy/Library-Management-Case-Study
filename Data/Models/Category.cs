using System.ComponentModel.DataAnnotations;

namespace Library_Management_Case_Study.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required] // Unqiue
        public string Name { get; set; } = null!;

        public List<Book> Books { get; set; } = new List<Book>();


    }
}
