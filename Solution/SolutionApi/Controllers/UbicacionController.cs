using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Solution.Api.Application.Contracts.Services;
using Solution.Api.Business.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UbicacionController : ControllerBase
    {
        private readonly IUBICACIONService _IUBICACIONService;

        public UbicacionController(IUBICACIONService iUBICACIONService)
        {
            _IUBICACIONService = iUBICACIONService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UbicacionModel>>> Get()
        {
            var list = await _IUBICACIONService.GetAll();

            return list.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<UbicacionModel>> Post( UbicacionModel obj)
        {
            var name = await _IUBICACIONService.Add(obj);
            if (name == null)
            {
                return NotFound();
            }
            return name;
        }
    }
}
