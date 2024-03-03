namespace Core.Interface
{
    public interface IUnitOfWork
    {
        public IClientRepository Client { get; }
        public IBookRepository Book { get; }
        public IOrderRepository Order { get; }
        Task<int> SaveAsync();
    }
}
