using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MassageParlor.Entities
{
    public class Massage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<EmployeeMassage> EmployeesThatPerformThis { get; set; } = new List<EmployeeMassage>();

    }
}
