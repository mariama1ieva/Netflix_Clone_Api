using Microsoft.AspNetCore.Mvc;
using Netflix.Service.DTOs.Plan;
using Service.Services.Interface;

namespace Netflix.Areas.AdminPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _service;

        public PlanController(IPlanService service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PlanCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _service.CreateAsync(request);
            //return CreatedAtAction(nameof(Create), new { reponse = "Success" });
            return Ok();
        }
    }
}
