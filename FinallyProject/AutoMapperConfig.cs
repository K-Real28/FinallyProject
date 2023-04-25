using AutoMapper;
using FinallyProject.Dto.Cities;
using FinallyProject.Dto.Doctors;
using FinallyProject.Dto.Polyclinics;
using FinallyProject.Dto.Specializations;
using FinallyProject.Models;

namespace FinallyProject
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityDto>();
                cfg.CreateMap<Doctor, DoctorDto>();
                cfg.CreateMap<Polyclinic, PolyclinicDto>();
                cfg.CreateMap<Specialization, SpecializationDto>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper;
        }
    }
}
