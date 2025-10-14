using System.ComponentModel.DataAnnotations;
using Library_Management_Case_Study.Data.Models;

namespace Library_Management_Case_Study.DTOs.BookDtos
{
    public class CreateBookDto
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
        public int CategoryId { get; set; }
        public List<int> AuthorsIds { get; set; } = new List<int>();
    }
}
