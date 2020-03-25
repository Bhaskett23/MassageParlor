using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Models
{
    public class MasseuesViewModel
    {
        public string Name { get; set; }

        public List<MassagesViewModel> MassagesProvided { get; set; }
    }
}
