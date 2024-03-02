using Core.Interface;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly BibliotecaContext _context;
    private IClientRepository _clientRepository;
    private IBookRepository _bookRepository;
    private IOrderRepository _orderRepository;

    public UnitOfWork(BibliotecaContext context)
    {
        _context = context;
    }

    public IClientRepository Client
    {
        get
        {
            if (_clientRepository == null)
            {
                _clientRepository = new ClientRepository(_context);
            }
            return _clientRepository;
        }
    }

    public IBookRepository Book
    {
        get
        {
            if (_bookRepository == null)
            {
                _bookRepository = new BookRepository(_context);
            }
            return _bookRepository;
        }
    }

    public IOrderRepository Order
    {
        get
        {
            if (_orderRepository == null)
            {
                _orderRepository = new OrderRepository(_context);
            }
            return _orderRepository;
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
