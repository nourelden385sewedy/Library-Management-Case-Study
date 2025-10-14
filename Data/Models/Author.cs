using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_Case_Study.Data.Models
{
    [Table("Author")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [MaxLength(200)]
        public string Bio { get; set; } = null!;


        public List<Book> Books { get; set; } = new List<Book>();
    }
}
