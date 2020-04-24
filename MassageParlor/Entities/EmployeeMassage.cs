using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Entities
{
    public class EmployeeMassage
    {
        [Key]
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public Guid MassageId { get; set; }

        [ForeignKey("MassageId")]
        public Massage Massage { get; set; }
    }
}
