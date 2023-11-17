using LMS.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AccountController(IAuthenticationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async ValueTask<IActionResult> Login()
        {
            return Ok(await _service.TokenGenerateAsync());
        }
    }
}
