using Internet.Api.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Internet.Api.Hubs
{
    [Authorize]
    public class ClientHub : Hub
    {
        public async Task Send(AccountViewModel account, string to)
        {
            await this.Clients.User(to).SendAsync("Receive", account);
        }
    }
}
