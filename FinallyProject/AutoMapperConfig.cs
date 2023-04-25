using AutoMapper;
using FinallyProject.Dto.Cities;
using FinallyProject.Dto.Doctors;
using FinallyProject.Dto.Polyclinics;
using FinallyProject.Dto.Specializations;
using FinallyProject.Models;

namespace FinallyProject
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<City, CityDto>();             
            CreateMap<Doctor, DoctorDto>();             
            CreateMap<Polyclinic, PolyclinicDto>();             
            CreateMap<Specialization, SpecializationDto>();             
        }
    }
}
