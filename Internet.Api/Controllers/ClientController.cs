using AutoMapper;
using Internet.Api.ViewModels.Client;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Internet.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ClientController : GenericReadController<ClientModel, ClientViewModel>
    {
        public ClientController(IGenericReadService<ClientModel> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
