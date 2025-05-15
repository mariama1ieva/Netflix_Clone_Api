using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Person;
using Service.Services.Interface;

namespace Netflix.Areas.AdminPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PersonCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _personService.CreateAsync(request);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPeople()
        {

            return Ok(await _personService.GetALlPeople());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok(await _personService.GetByIdAsync(id));
        }

    }
}
