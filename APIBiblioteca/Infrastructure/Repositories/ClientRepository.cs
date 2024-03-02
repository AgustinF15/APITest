using Core.Entities;
using Core.Interface;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    public ClientRepository(BibliotecaContext context) : base(context)
    {
        
    }
}
