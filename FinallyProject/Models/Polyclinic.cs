using System.ComponentModel.DataAnnotations.Schema;
using FinallyProject.Models.BaseModels;

namespace FinallyProject.Models
{
    public class Polyclinic : NamedBaseEnity
    {
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

        public string Address { get; set; }
        public int Number { get; set; }

        //public string Image { get; set; }
    }
}
