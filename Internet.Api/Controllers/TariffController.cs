using AutoMapper;
using Internet.API.ViewModels;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Internet.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TariffController : GenericReadController<TariffModel, TariffViewModel>
    {
        public TariffController(IGenericReadService<TariffModel> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
