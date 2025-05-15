using Microsoft.AspNetCore.Mvc;
using Netflix.Service.DTOs.Plan;
using Service.DTOs.Plan;
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
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlans()
        {
            return Ok(await _service.GetAllPlans());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdPlan([FromRoute] int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePlan([FromRoute] int id)
        {
            return Ok(await _service.DeletePlanAsync(id));
        }
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] int id, PlanEditDto request)
        {
            var result = await _service.UpdatePlanEditAsync(request);
            return Ok(result);
        }
    }
}
