using Business.Abstraction;
using Business.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceRepositories _deviceRepositories;
        public DeviceController(IDeviceRepositories deviceRepositories)
        {
            _deviceRepositories = deviceRepositories;            
        }
        [HttpGet("GetAllDevice")]
        public IActionResult GetAll() 
        {
            var model = _deviceRepositories.GetAll();
            return Ok(model);
        }

    }
}
