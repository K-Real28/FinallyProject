using FinallyProject.Models.BaseModels;

namespace FinallyProject.Models
{
    public class Doctor : NamedBaseEnity
    {
        public IList<Specialization> Specializations { get; set; } = new List<Specialization>();
        public IList<Polyclinic> Polyclinics { get; set; } = new List<Polyclinic>();
        public string Short_info { get; set; }
        public string Full_info { get; set; }
    }
}
