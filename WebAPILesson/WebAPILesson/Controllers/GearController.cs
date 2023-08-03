using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebAPILesson.Data;
using WebAPILesson.Models;
using WebAPILesson.Services;

namespace WebAPILesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearController : ControllerBase
    {
        private readonly IGearRepository _gearRepository;
        public GearController(IGearRepository gearRepository)
        {
            _gearRepository = gearRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGears()
        {
            try
            {
                return Ok( await _gearRepository.GetAllGearsAsync());
            }
            catch (Exception)
            {

               return BadRequest();
            }

        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetGearById(int id) {
            var gear = await _gearRepository.GetGearAsync(id);
            return gear == null? NotFound() : Ok(gear);
        }
        [HttpPost]
        public async Task<IActionResult> Add(GearModel model) {
            await _gearRepository.AddGearAsync(model);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(GearModel model,int id)
        {
            await _gearRepository.UpdateGearAsync(model,id);
            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _gearRepository.DeleteGearAsync(id);
            return Ok();
        }
    }
}
