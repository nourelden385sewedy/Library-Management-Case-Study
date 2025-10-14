using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_Case_Study.Data.Models
{
    //[Table("Category")]
    public class Category
    {
        public int Id { get; set; }

        [Required] // Unqiue
        public string Name { get; set; } = null!;

        public List<Book> Books { get; set; } = new List<Book>();


    }
}
