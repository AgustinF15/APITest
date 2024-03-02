namespace Core.Interface
{
    public interface IUnitOfWork
    {
        public IClientRepository ClientRepository { get; }
        public IBookRepository BookRepository { get; }
        public IOrderRepository OrderRepository { get; }
        Task<int> SaveAsync();
    }
}
