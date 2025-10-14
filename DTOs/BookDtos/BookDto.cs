using System.ComponentModel.DataAnnotations;
using Library_Management_Case_Study.Data.Models;

namespace Library_Management_Case_Study.DTOs.BookDtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime PublishDate { get; set; }

        [Range(0, int.MaxValue)]
        public int Copies { get; set; }
        public List<CustomAuthorDto> Authors { get; set; } = new List<CustomAuthorDto>();
        public string Category { get; set; } = null!;
    }

    public class CustomAuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Bio { get; set; } = null!;
    }
}
