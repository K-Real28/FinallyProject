using FinallyProject.Dto.Polyclinics;
using FinallyProject.Models;

namespace FinallyProject.Dto.Cities
{
    public class CityDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public List<PolyclinicDto> Polyclinics { get; set; } = new();

    }
}
