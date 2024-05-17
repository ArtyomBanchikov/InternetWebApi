using AutoMapper;
using Internet.API.Hubs;
using Internet.API.ViewModels;
using Internet.BLL.Interfaces;
using Internet.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Internet.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AccountController : GenericReadController<AccountModel, AccountViewModel>
    {
        private readonly IGenericReadService<ClientModel> _clientService;
        private readonly IHubContext<ClientHub> _hubContext;
        public AccountController(IGenericReadService<AccountModel> service,
            IGenericReadService<ClientModel> clientService,
            IMapper mapper,
            IHubContext<ClientHub> hubContext) : base(service, mapper)
        {
            _hubContext = hubContext;
            _clientService = clientService;
        }

        [HttpPut]
        public async Task UpdateAsync(int id, [FromBody] AccountViewModel account, CancellationToken cancellationToken)
        {
            var clients = await _clientService.GetAllAsync(cancellationToken);
            var client = clients.FirstOrDefault(client => client.AccountId == account.Id);
            if (client != null)
                await _hubContext.Clients.User(client.Login).SendAsync("Receive", account, cancellationToken);
        }
    }
}
