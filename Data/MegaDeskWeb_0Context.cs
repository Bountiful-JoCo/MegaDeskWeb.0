using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb._0.Models;

namespace MegaDeskWeb._0.Models
{
    public class MegaDeskWeb_0Context : DbContext
    {
        public MegaDeskWeb_0Context (DbContextOptions<MegaDeskWeb_0Context> options)
            : base(options)
        {
        }
        public DbSet<MegaDeskWeb._0.Models.DeskQuote> DeskQuote { get; set; }

    }
}
