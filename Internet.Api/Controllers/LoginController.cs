using AutoMapper;
using Internet.API.ViewModels.Client;
using Internet.Bll.Interfaces;
using Internet.Bll.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Internet.API.Controllers
{
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IGenericReadService<ClientModel> _service;
        protected readonly IMapper _mapper;
        public LoginController(IGenericReadService<ClientModel> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("/login")]
        public async Task<LoginClientViewModel> Login(ShortClientViewModel clientVM, CancellationToken ct)
        {
            ClientViewModel clientDB = _mapper.Map<ClientViewModel>((await _service.GetAllAsync(ct)).First(c => c.Login == clientVM.Login));
            if (clientVM.Password == clientDB.Password)
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, clientDB.Login) };
                var jwt = new JwtSecurityToken();

                string token = new JwtSecurityTokenHandler().WriteToken(jwt);
                LoginClientViewModel loginClient = _mapper.Map<LoginClientViewModel>(clientVM);
                loginClient.Token = token;
                loginClient.AccountId = clientDB.AccountId;
                loginClient.Name = clientDB.Name;
                return loginClient;
            }
            else
                throw new UnauthorizedAccessException();
        }

        [Authorize]
        [HttpGet("/userinfo/")]
        public async Task<LoginClientViewModel> TokenCheck(CancellationToken ct)
        {
            return new LoginClientViewModel
            {
                Name = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value
            };
        }
    }
}
