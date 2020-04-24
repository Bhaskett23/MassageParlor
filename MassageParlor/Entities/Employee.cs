using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

       // public ICollection<EmployeeMassage> MassageServices { get; set; } = new List<EmployeeMassage>();
    }
}
