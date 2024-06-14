using AutoMapper;
using Internet.Bll.Interfaces;
using Internet.Dal.Interfaces;

namespace Internet.Bll.Services
{
    public class GenericReadService<TModel, TEntity> : IGenericReadService<TModel>
        where TModel : class
        where TEntity : class
    {
        protected readonly IGenericReadRepository<TEntity> _repository;

        protected readonly IMapper _mapper;

        public GenericReadService(IGenericReadRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync(CancellationToken token)
        {
            var result = _mapper.Map<IEnumerable<TModel>>(await _repository.GetAllAsync(token));

            return result;
        }

        public virtual async Task<TModel> GetByIdAsync(int id, CancellationToken token)
        {
            var resultEntity = await _repository.GetByIdAsync(id, token);

            return _mapper.Map<TModel>(resultEntity);
        }
    }
}
