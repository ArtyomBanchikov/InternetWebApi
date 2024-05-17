using Microsoft.AspNetCore.SignalR;

namespace Internet.BLL.Services
{
    public class CustomClientIdProvider : IUserIdProvider
    {
        public string? GetUserId(HubConnectionContext connection)
        {
            string newId = connection.User.Identity.Name;
            return newId;
        }
    }
}
