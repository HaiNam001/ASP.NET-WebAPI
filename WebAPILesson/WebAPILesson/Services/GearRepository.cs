using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using WebAPILesson.Data;
using WebAPILesson.Models;

namespace WebAPILesson.Services
{
    public class GearRepository : IGearRepository
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        public GearRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddGearAsync(GearModel gear)
        {
            var addgear = _mapper.Map<Gears>(gear);
            _context.Gears!.Add(addgear);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGearAsync(int id)
        {
            var deletegear = _context.Gears!.SingleOrDefault(g => g.gear_id == id);
            if(deletegear != null)
            {
                _context.Gears!.Remove(deletegear);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<List<GearModel>> GetAllGearsAsync()
        {
            var gears = await _context.Gears!.ToListAsync();
            return _mapper.Map<List<GearModel>>(gears);
        }

        public async Task<GearModel> GetGearAsync(int id)
        {
            var gear = await _context.Gears!.FindAsync(id);
            return _mapper.Map<GearModel>(gear);
        }

        public async Task UpdateGearAsync(GearModel gear, int id)
        {
              var updateGear = await _context.Gears!.FindAsync(id);
                updateGear.grear_name = gear.grear_name;
                updateGear.description = gear.description;
                updateGear.price = gear.price;
                updateGear.quantity = gear.quantity;
                updateGear.image_url = gear.image_url;
                await _context.SaveChangesAsync();
        }
    }
}
