namespace Internet.Bll.Interfaces
{
    public interface IGenericReadService<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync(CancellationToken token);
        Task<TModel> GetByIdAsync(int id, CancellationToken token);
    }
}
