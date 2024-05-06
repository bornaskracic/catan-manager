using CatanManager.Services;
using CatanManager.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CatanManager.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class ResourceController : ControllerBase
    {
        private readonly IResourceService _resourceService;

        public ResourceController(IResourceService _resourceService)
        {
            this._resourceService = _resourceService;
        }

        [HttpGet]
       public IActionResult GetResources() {

            return Ok(_resourceService.GetResources());
        }
    }
}
