namespace Internet.Dal.Interfaces
{
    public interface IGenericReadRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token);
        Task<TEntity?> GetByIdAsync(int id, CancellationToken token);
    }
}
