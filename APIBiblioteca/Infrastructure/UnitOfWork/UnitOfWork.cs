using Core.Interface;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly BibliotecaContext _context;
    private IClientRepository _client;
    private IBookRepository _book;
    private IOrderRepository _order;

    public UnitOfWork(BibliotecaContext context)
    {
        _context = context;
    }

    public IClientRepository Client
    {
        get
        {
            if (_client == null)
            {
                _client = new ClientRepository(_context);
            }
            return _client;
        }
    }

    public IBookRepository Book
    {
        get
        {
            if (_book == null)
            {
                _book = new BookRepository(_context);
            }
            return _book;
        }
    }

    public IOrderRepository Order
    {
        get
        {
            if (_order == null)
            {
                _order = new OrderRepository(_context);
            }
            return _order;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
