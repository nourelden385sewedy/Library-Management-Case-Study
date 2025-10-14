using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.DTOs.BookDtos;
using Library_Management_Case_Study.Repos.Interfaces;

namespace Library_Management_Case_Study.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepo _bookRepo;
        private readonly IAuthorRepo _authorRepo;

        public BookController(IBookRepo bookRepo, IAuthorRepo authorRepo)
        {
            _bookRepo = bookRepo;
            _authorRepo = authorRepo;
        }

        [HttpGet] // Done
        public async Task<IActionResult> GetAllBooks()
        {
            var b = await _bookRepo.GetAllAvailableBooksAsync();

            if (b.Count() == 0)
                return NotFound();

            var books = b.Select(b => new BookDto
            {
                Id = b.Id,
                Title = b.Title,
                Description = b.Description,
                PublishDate = b.PublishDate,
                Copies = b.Copies,
                Category = b.Category.Name,
                Authors = b.Authors.Select(a => new CustomAuthorDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    Bio = a.Bio
                }).ToList()
            }).ToList();

            return Ok(books);
        }


        [HttpGet("/recommended/{id}")]
        public async Task<IActionResult> GetRecommendedBooks(int id)
        {
            var recommended = await _bookRepo.GetRecommendedBooksAsync(id);

            if (recommended.Count() == 0)
                return NotFound("There isn't any");

            var RecBooks = recommended.Select(b => new RecommendedBookDto
            {
                Id = b.Id,
                Title = b.Title,
                Description = b.Description,
                PublishDate = b.PublishDate,
                Copies = b.Copies,
                Category = b.Category.Name
            }).ToList();

            return Ok(RecBooks);
        }


        [HttpPost] // Done
        public async Task<IActionResult> CreateBook(CreateBookDto dto)
        {
            if (dto == null)
                return NotFound();

            var AllAuthors = await _authorRepo.GetAllAsync();

            var existingAuthors = AllAuthors.Where(a => dto.AuthorsIds.Contains(a.Id)).ToList();

            var Book = new Book()
            {
                Title = dto.Title,
                Description = dto.Description,
                PublishDate = dto.PublishDate,
                Copies = dto.Copies,
                CategoryId = dto.CategoryId,
                Authors = existingAuthors
            };

            await _bookRepo.AddAsync(Book);
            await _bookRepo.SaveChangesAsync();

            return Ok(dto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook()
        {

            return Ok();
        }

        
        //[HttpPost]
        //public async Task<IActionResult> GetAllBooks()
        //{

        //    return Ok();
        //}
        //[HttpPost]
        //public async Task<IActionResult> GetAllBooks()
        //{

        //    return Ok();
        //}
    }
}
