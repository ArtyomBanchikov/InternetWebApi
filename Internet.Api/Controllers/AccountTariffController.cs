using AutoMapper;
using Internet.API.ViewModels;
using Internet.Bll.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Internet.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class AccountTariffController : Controller
    {
        private readonly IAccountTariffService _service;

        protected readonly IMapper _mapper;

        public AccountTariffController(IAccountTariffService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountTariffViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var accountModels = await _service.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<AccountTariffViewModel>>(accountModels);
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<AccountTariffViewModel>> GetAllByAccountAsync(int id, CancellationToken cancellationToken)
        {
            var accountModels = await _service.GetAllByAccountAsync(id, cancellationToken);

            return _mapper.Map<IEnumerable<AccountTariffViewModel>>(accountModels);
        }
    }
}
