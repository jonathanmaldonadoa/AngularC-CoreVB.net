using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.Api.Application.Contracts.Services;
using Solution.Api.Business.Models;
using Solution.Api.DataAccess.Mappers;

namespace SolutionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _IPersonaService;
        public PersonaController(IPersonaService iPersonaService)
        {
            _IPersonaService = iPersonaService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaModel>>> Get()
        {
            var list = await _IPersonaService.GetAll();
            return list.ToList();
        }

    }
}
