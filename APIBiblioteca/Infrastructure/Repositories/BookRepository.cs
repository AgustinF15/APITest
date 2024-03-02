using Core.Entities;
using Core.Interface;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BibliotecaContext context) : base(context) { }
    }
}
