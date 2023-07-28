using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebAPILesson.Data;
using WebAPILesson.Models;

namespace WebAPILesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearController : ControllerBase
    {
        private readonly MyDbContext _context;
        public GearController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public  IActionResult GetAll()
        {
            var gears = _context.Gears.ToList();
            return Ok(gears);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id) {
            var gear = _context.Gears.SingleOrDefault(x=>x.gear_id==id);
            if(gear !=null)
            {
                return Ok(gear);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Add(GearModel model) {
            try
            {
                var gear = new Gears
                {
                    grear_name = model.grear_name,
                    description = model.description,
                    price = model.price,
                    image_url = model.image_url,
                    quantity = model.quantity
                };
                _context.Gears.Add(gear);
                _context.SaveChanges();
                return Ok(gear);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(GearModel model,int id)
        {
            try
            {
                var gear = _context.Gears.SingleOrDefault(x => x.gear_id == id);
                if(gear != null)
                {
                    gear.grear_name = model.grear_name;
                    gear.description = model.description;
                    gear.price = model.price;
                    gear.image_url = model.image_url;
                    gear.quantity = model.quantity;
                }
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

    }
}
