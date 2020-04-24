using MassageParlor.Context;
using MassageParlor.Entities;
using MassageParlor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Services
{
    public class MassageService : IMassageService, IDisposable
    {
        MassageParlorContext _massageParlorContext;

        public MassageService(MassageParlorContext massageParlorContext)
        {
            _massageParlorContext = massageParlorContext;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _massageParlorContext.Employees;//.Include(x => x.MassageServices).ThenInclude(y => y.Massage);
        }

        public IEnumerable<MasseuesViewModel> GetEmployeesForViewing()
        {
            IEnumerable<Employee> employees = GetEmployees();
            List<MasseuesViewModel> viewModels = new List<MasseuesViewModel>();

            foreach (var item in employees)
            {
               // List<MassagesViewModel> massages = new List<MassagesViewModel>();
               //
               // foreach (EmployeeMassage employeeMassage in item.MassageServices)
               // {
               //     MassagesViewModel massagesViewModel = new MassagesViewModel()
               //     {
               //         Name = employeeMassage.Massage.Name,
               //         Description = employeeMassage.Massage.Description
               //     };
               //     massages.Add(massagesViewModel);
               // }

                MasseuesViewModel masseues = new MasseuesViewModel()
                {
                    Name = $"{item.FirstName} {item.LastName}",
                    Description = item.Description,
                    StartDate = item.StartDate
                 //   MassagesProvided = massages
                };

                viewModels.Add(masseues);
            }

            return viewModels;
        }
    }
}
