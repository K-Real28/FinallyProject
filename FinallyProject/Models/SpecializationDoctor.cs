﻿using FinallyProject.Models.BaseModels;

namespace FinallyProject.Models
{
    public class SpecializationDoctor : BaseEntity
    {
        public int? SpecializitionId { get; set; }
        public Specialization? Specialization { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
