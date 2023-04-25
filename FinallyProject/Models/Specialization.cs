using FinallyProject.Models.BaseModels;

namespace FinallyProject.Models
{
    public class Specialization : NamedBaseEnity
    {
        public List<SpecializationDoctor> SpecializationDoctors { get; set; } = new();
    }
}
