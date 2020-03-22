using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Context
{
    public class MassageParlorContext : DbContext
    {
        public MassageParlorContext(DbContextOptions<MassageParlorContext> options) : base(options)
        {
        }


    }
}
