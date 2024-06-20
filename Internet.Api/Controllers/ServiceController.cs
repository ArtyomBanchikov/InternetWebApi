using AutoMapper;
using Internet.Api.ViewModels;
using Internet.Bll.Models;
using Internet.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Internet.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ServiceController : GenericReadController<ServiceModel, ServiceViewModel>
    {
        public ServiceController(IGenericReadService<ServiceModel> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
