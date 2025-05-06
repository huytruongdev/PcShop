namespace PcShop.Domain.Interface;

public interface IRepository<T> where T : class, IEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
}
