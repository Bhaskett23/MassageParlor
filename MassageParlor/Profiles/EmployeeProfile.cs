using AutoMapper;
using MassageParlor.Entities;
using MassageParlor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, MasseuesViewModel>()
                .ForMember( dto => dto.MassagesProvided, opt => opt.MapFrom(x => x.MassageServices.Select(z => z.Massage)));

            CreateMap<Massage, MassagesViewModel>();
        }
    }
}
