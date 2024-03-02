using Core.Entities;
using Core.Interface;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(BibliotecaContext context) : base(context)
    {
        
    }
}
