using Business.Abstraction;
using Business.Abstraction.Services;
using Business.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IPingService _pingService;
        public PingController(IPingService pingService)
        {
            _pingService = pingService;
        }
        [HttpGet("GetAllPing")]
        public async Task<IActionResult> GetAll()
        {
            var model = await _pingService.GetAll();
            return Ok(model);
        }
    }
}
