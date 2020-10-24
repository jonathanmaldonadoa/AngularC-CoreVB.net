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
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _IEmpresaService;
        public EmpresaController(IEmpresaService iEmpresaService)
        {
            _IEmpresaService = iEmpresaService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaModel>> Get(int id)
        {
            var name = await _IEmpresaService.Get(id);

            if (name == null)
            {
                return NotFound();
            }
            return name;
        }

        [HttpPost]
        public async Task<ActionResult<EmpresaModel>> Post(EmpresaModel EmpresaModel)
        {
            var name = await _IEmpresaService.Add(EmpresaModel);
            if (name == null)
            {
                return NotFound();
            }
            return name;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var name = await _IEmpresaService.Delte(id);
            if (name == false)
            {
                return NotFound();
            }

            return name;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpresaModel>>> Get()
        {
            var list = await _IEmpresaService.GetAll();
            return list.ToList();
        }
    }
}