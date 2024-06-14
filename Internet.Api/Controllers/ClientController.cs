using AutoMapper;
using Internet.API.ViewModels.Client;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Internet.API.Controllers
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
