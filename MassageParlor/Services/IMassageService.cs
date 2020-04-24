using MassageParlor.Entities;
using MassageParlor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Services
{
    public interface IMassageService
    {
        IEnumerable<Employee> GetEmployees();
        IEnumerable<MasseuesViewModel> GetEmployeesForViewing();
        IEnumerable<MassagesViewModel> GetMassages();
    }
}
