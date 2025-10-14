using Library_Management_Case_Study.Data.Models;
using Library_Management_Case_Study.Repos.GenericRepository;

namespace Library_Management_Case_Study.Repos.Interfaces
{
    public interface IBookRepo : IGenericRepo<Book>
    {
        Task<IEnumerable<Book>> GetAllAvailableBooksAsync();
    }
}
