using System.ComponentModel.DataAnnotations;

namespace Library_Management_Case_Study.DTOs.BookDtos
{
    public class RecommendedBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime PublishDate { get; set; }

        [Range(0, int.MaxValue)]
        public int Copies { get; set; }
        public string Category { get; set; } = null!;
    }
}
