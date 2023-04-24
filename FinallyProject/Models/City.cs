using FinallyProject.Models.BaseModels;

namespace FinallyProject.Models
{
    public class City : NamedBaseEnity
    {
        public List<Polyclinic> Polyclinics { get; set; } = new();
    }
}
