using Microsoft.EntityFrameworkCore.Storage;
using WebAPILesson.Models;

namespace WebAPILesson.Services
{
    public interface IGearRepository
    {
        public Task <List<GearModel>> GetAllGearsAsync();
        public Task<GearModel> GetGearAsync(int id);
        public Task AddGearAsync(GearModel gear);
        public Task UpdateGearAsync(GearModel gear,int id);
        public Task DeleteGearAsync(int id);
    }
}
