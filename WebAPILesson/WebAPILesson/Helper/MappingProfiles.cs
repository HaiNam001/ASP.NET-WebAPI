using AutoMapper;
using WebAPILesson.Data;
using WebAPILesson.Models;
using WebAPILesson.Services;

namespace WebAPILesson.Helper
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles() {
            CreateMap<Gears, GearModel>().ReverseMap();
            
        }
    }
}
