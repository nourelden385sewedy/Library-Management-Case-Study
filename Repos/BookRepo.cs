using Microsoft.EntityFrameworkCore;
using Library_Management_Case_Study.Data;
using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.Repos.GenericRepository;
using Library_Management_Case_Study.Repos.Interfaces;

namespace Library_Management_Case_Study.Repos
{
    public class BookRepo : GenericRepo<Book>, IBookRepo
    {
        public BookRepo(MyAppDbContext context) : base(context) { }

        public async Task<IEnumerable<Book>> GetAllAvailableBooksAsync()
        {
            return await _context.Books
                .Include(b => b.Category)
                .Include(b => b.Authors)
                .Where(b => b.Copies > 0)
                .OrderBy(b => b.PublishDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetRecommendedBooksAsync(int id)
        {

            var book = await _context.Books
                .FirstOrDefaultAsync(b => b.Id == id);

            var authorsIds = book.Authors
                .Select(v => v.Id).ToList();

            var recommended = await _context.Books
                .Include(b => b.Category)
                .Where(b => b.Id != id && (b.CategoryId == book.CategoryId || b.Authors.Any(x => authorsIds.Contains(x.Id))))
                .ToListAsync();

            return recommended;

                //var books = await _context.Books
                //.Include(b => b.Category)
                //.Include(b => b.Authors)

            
        }


    }
}
