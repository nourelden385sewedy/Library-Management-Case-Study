using System.ComponentModel.DataAnnotations;

namespace Library_Management_Case_Study.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required] // Unique
        public string Title { get; set; } = null!;

        [MaxLength(300)]
        public string Description { get; set; } = null!;
        public DateTime PublishDate { get; set; }

        [Range(0, int.MaxValue)]
        public int Copies { get; set; }

        // Navigation Properties

        public List<Author> Authors { get; set; } = new List<Author>();
        public List<Borrowing> Borrowing { get; set; } = new List<Borrowing>();


        public int CategoryId { get; set; }
        public  Category Category { get; set; } = null!;
    }
}
